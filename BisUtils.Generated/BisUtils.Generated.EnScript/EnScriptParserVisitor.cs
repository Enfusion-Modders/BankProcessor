//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/ryannkelly/Desktop/BisUtils/BisUtils.Generated/BisUtils.Generated.EnScript/EnScriptParser.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace BisUtils.Generated.EnScript;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="EnScriptParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public interface IEnScriptParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.computationalStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComputationalStart([NotNull] EnScriptParser.ComputationalStartContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeDeclaration([NotNull] EnScriptParser.TypeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.globalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalDeclaration([NotNull] EnScriptParser.GlobalDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.globalInheritance"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGlobalInheritance([NotNull] EnScriptParser.GlobalInheritanceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumDeclaration([NotNull] EnScriptParser.EnumDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumBody([NotNull] EnScriptParser.EnumBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.enumMember"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumMember([NotNull] EnScriptParser.EnumMemberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclaration([NotNull] EnScriptParser.ClassDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassBody([NotNull] EnScriptParser.ClassBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.funcOrVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncOrVar([NotNull] EnScriptParser.FuncOrVarContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.funcVarOrDeconstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncVarOrDeconstructor([NotNull] EnScriptParser.FuncVarOrDeconstructorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] EnScriptParser.VariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.variableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarator([NotNull] EnScriptParser.VariableDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.undefinedVariableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUndefinedVariableDeclarator([NotNull] EnScriptParser.UndefinedVariableDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.definedVariableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefinedVariableDeclarator([NotNull] EnScriptParser.DefinedVariableDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclaration([NotNull] EnScriptParser.FunctionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.deconstructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeconstructorDeclaration([NotNull] EnScriptParser.DeconstructorDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionDeclarationParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclarationParameters([NotNull] EnScriptParser.FunctionDeclarationParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionDeclarationDefinedParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclarationDefinedParameter([NotNull] EnScriptParser.FunctionDeclarationDefinedParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionDeclarationUndefinedParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclarationUndefinedParameter([NotNull] EnScriptParser.FunctionDeclarationUndefinedParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionBody([NotNull] EnScriptParser.FunctionBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.encapsulatedFunctionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEncapsulatedFunctionBody([NotNull] EnScriptParser.EncapsulatedFunctionBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] EnScriptParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionCallParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallParameters([NotNull] EnScriptParser.FunctionCallParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionCallParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallParameter([NotNull] EnScriptParser.FunctionCallParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttribute([NotNull] EnScriptParser.AttributeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] EnScriptParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.primaryStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimaryStatement([NotNull] EnScriptParser.PrimaryStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.foreachStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeachStatement([NotNull] EnScriptParser.ForeachStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.foreachControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeachControl([NotNull] EnScriptParser.ForeachControlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] EnScriptParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.forControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForControl([NotNull] EnScriptParser.ForControlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] EnScriptParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseStatement([NotNull] EnScriptParser.ElseStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.objectCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitObjectCreation([NotNull] EnScriptParser.ObjectCreationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] EnScriptParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.threadStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThreadStatement([NotNull] EnScriptParser.ThreadStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.gotoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGotoStatement([NotNull] EnScriptParser.GotoStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.deleteStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeleteStatement([NotNull] EnScriptParser.DeleteStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.lambdaStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambdaStatement([NotNull] EnScriptParser.LambdaStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBreakStatement([NotNull] EnScriptParser.BreakStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContinueStatement([NotNull] EnScriptParser.ContinueStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] EnScriptParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchStatement([NotNull] EnScriptParser.SwitchStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.switchLabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchLabel([NotNull] EnScriptParser.SwitchLabelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.defaultSwitchLabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefaultSwitchLabel([NotNull] EnScriptParser.DefaultSwitchLabelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] EnScriptParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimaryExpression([NotNull] EnScriptParser.PrimaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.negatedExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNegatedExpression([NotNull] EnScriptParser.NegatedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.parenthesisedExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesisedExpression([NotNull] EnScriptParser.ParenthesisedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.arrayIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayIndex([NotNull] EnScriptParser.ArrayIndexContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.literalString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralString([NotNull] EnScriptParser.LiteralStringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.literalBoolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralBoolean([NotNull] EnScriptParser.LiteralBooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.literalNull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralNull([NotNull] EnScriptParser.LiteralNullContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.literalArray"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralArray([NotNull] EnScriptParser.LiteralArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.literalNumeric"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralNumeric([NotNull] EnScriptParser.LiteralNumericContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.literalFloat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralFloat([NotNull] EnScriptParser.LiteralFloatContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.literalInteger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteralInteger([NotNull] EnScriptParser.LiteralIntegerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] EnScriptParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.genericTypeDeclarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericTypeDeclarationList([NotNull] EnScriptParser.GenericTypeDeclarationListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.genericTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericTypeDeclaration([NotNull] EnScriptParser.GenericTypeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.genericTypedReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericTypedReference([NotNull] EnScriptParser.GenericTypedReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.typeReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeReference([NotNull] EnScriptParser.TypeReferenceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.typeModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeModifier([NotNull] EnScriptParser.TypeModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.sharedFuncOrVarModifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSharedFuncOrVarModifiers([NotNull] EnScriptParser.SharedFuncOrVarModifiersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.variableModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableModifier([NotNull] EnScriptParser.VariableModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="EnScriptParser.functionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionModifier([NotNull] EnScriptParser.FunctionModifierContext context);
}
