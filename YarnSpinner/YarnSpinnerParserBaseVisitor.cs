//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from YarnSpinnerParser.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IYarnSpinnerParserVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class YarnSpinnerParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IYarnSpinnerParserVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.dialogue"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDialogue([NotNull] YarnSpinnerParser.DialogueContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.node"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNode([NotNull] YarnSpinnerParser.NodeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.header"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitHeader([NotNull] YarnSpinnerParser.HeaderContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.header_title"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitHeader_title([NotNull] YarnSpinnerParser.Header_titleContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.header_tag"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitHeader_tag([NotNull] YarnSpinnerParser.Header_tagContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.header_line"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitHeader_line([NotNull] YarnSpinnerParser.Header_lineContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.body"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBody([NotNull] YarnSpinnerParser.BodyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStatement([NotNull] YarnSpinnerParser.StatementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.shortcut_statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShortcut_statement([NotNull] YarnSpinnerParser.Shortcut_statementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.shortcut"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShortcut([NotNull] YarnSpinnerParser.ShortcutContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.if_statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIf_statement([NotNull] YarnSpinnerParser.If_statementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.if_clause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIf_clause([NotNull] YarnSpinnerParser.If_clauseContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.else_if_clause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElse_if_clause([NotNull] YarnSpinnerParser.Else_if_clauseContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.else_clause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElse_clause([NotNull] YarnSpinnerParser.Else_clauseContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.set_statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSet_statement([NotNull] YarnSpinnerParser.Set_statementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.option_statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOption_statement([NotNull] YarnSpinnerParser.Option_statementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunction([NotNull] YarnSpinnerParser.FunctionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.function_statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunction_statement([NotNull] YarnSpinnerParser.Function_statementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.action_statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAction_statement([NotNull] YarnSpinnerParser.Action_statementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.line_statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLine_statement([NotNull] YarnSpinnerParser.Line_statementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.hashtag_block"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitHashtag_block([NotNull] YarnSpinnerParser.Hashtag_blockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.hashtag"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitHashtag([NotNull] YarnSpinnerParser.HashtagContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expParens</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpParens([NotNull] YarnSpinnerParser.ExpParensContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expMultDivMod</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpMultDivMod([NotNull] YarnSpinnerParser.ExpMultDivModContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expMultDivModEquals</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpMultDivModEquals([NotNull] YarnSpinnerParser.ExpMultDivModEqualsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expComparison</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpComparison([NotNull] YarnSpinnerParser.ExpComparisonContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expNegative</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpNegative([NotNull] YarnSpinnerParser.ExpNegativeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expAndOrXor</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpAndOrXor([NotNull] YarnSpinnerParser.ExpAndOrXorContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expPlusMinusEquals</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpPlusMinusEquals([NotNull] YarnSpinnerParser.ExpPlusMinusEqualsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expAddSub</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpAddSub([NotNull] YarnSpinnerParser.ExpAddSubContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expNot</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpNot([NotNull] YarnSpinnerParser.ExpNotContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expValue</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpValue([NotNull] YarnSpinnerParser.ExpValueContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expEquality</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpEquality([NotNull] YarnSpinnerParser.ExpEqualityContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>valueNumber</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValueNumber([NotNull] YarnSpinnerParser.ValueNumberContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>valueTrue</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValueTrue([NotNull] YarnSpinnerParser.ValueTrueContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>valueFalse</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValueFalse([NotNull] YarnSpinnerParser.ValueFalseContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>valueVar</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValueVar([NotNull] YarnSpinnerParser.ValueVarContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>valueString</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValueString([NotNull] YarnSpinnerParser.ValueStringContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>valueFunc</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValueFunc([NotNull] YarnSpinnerParser.ValueFuncContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>valueNull</c>
	/// labeled alternative in <see cref="YarnSpinnerParser.value"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValueNull([NotNull] YarnSpinnerParser.ValueNullContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="YarnSpinnerParser.variable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVariable([NotNull] YarnSpinnerParser.VariableContext context) { return VisitChildren(context); }
}