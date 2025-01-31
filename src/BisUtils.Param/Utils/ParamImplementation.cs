﻿namespace BisUtils.Param.Utils;

using Core.Binarize;
using Core.Binarize.Implementation;
using Core.Extensions;
using Core.IO;
using FResults;
using Models;
using Options;

public interface IParamImplementation : IBinaryObject<ParamOptions>
{
    IParamFile ParamFile { get; set; }
    string Name { get; set; }
}

public class ParamImplementation : BinaryObject<ParamOptions>, IParamImplementation
{
    public IParamFile ParamFile { get; set; }
    public string Name { get => ParamFile.FileName; set => ParamFile.FileName = value; }

    protected ParamImplementation(IParamFile paramFile) => ParamFile = paramFile;

    protected ParamImplementation(string name, BisBinaryReader reader, ParamOptions options)
    {
        ParamFile = new ParamFile(name, reader, options);
        if (ParamFile.LastResult is { } result && result)
        {
            result.Throw();
        }
    }

    public override Result Binarize(BisBinaryWriter writer, ParamOptions options) =>
       LastResult = ParamFile.Binarize(writer, options);

    public sealed override Result Debinarize(BisBinaryReader reader, ParamOptions options) =>
        LastResult = ParamFile.Debinarize(reader, options);
}
