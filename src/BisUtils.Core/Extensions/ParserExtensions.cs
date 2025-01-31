﻿namespace BisUtils.Core.Extensions;

using System.Text;
using FResults;
using Parsing;
using Parsing.Lexer;

public static class ParserExtensions
{
    public static Result ProcessAndParse<TAstNode, TLexer, TTypes, TPreProcessor>
    (
        this IBisParser<TAstNode, TLexer, TTypes, TPreProcessor> parser,
        out TAstNode? node,
        TLexer lexer,
        TPreProcessor? preprocessor = null
    ) where TLexer : BisLexer<TTypes> where TTypes : Enum where TPreProcessor : BisPreProcessorBase, new()
    {
        var builder = new StringBuilder();
        preprocessor ??= new TPreProcessor();
        preprocessor.EvaluateLexer(lexer, builder);
        lexer.ResetLexer(builder.ToString());
        return parser.Parse(out node, lexer);
    }
}
