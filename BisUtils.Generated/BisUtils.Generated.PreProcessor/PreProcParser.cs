//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.10.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/developer/Desktop/BisUtils/BisUtils.Generated/BisUtils.Generated.PreProcessor\PreProcParser.g4 by ANTLR 4.10.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.CLSCompliant(false)]
public partial class PreProcParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		SHARP=1, CONCAT=2, CODE=3, DIRECTIVE_WHITESPACES=4, LSBracket=5, RSBracket=6, 
		LParenthesis=7, RParenthesis=8, Comma=9, UNDEFINE=10, DEFINE=11, INCLUDE=12, 
		IF=13, IFDEF=14, IFNDEF=15, ELSE=16, ENDIF=17, LINE=18, FILE=19, IDENTIFIER=20, 
		LITERAL_STRING=21, LITERAL_INT=22, LITERAL_FLOAT=23, NEW_LINE=24, DIRECITVE_NEW_LINE=25;
	public const int
		RULE_preprocessor = 0, RULE_text = 1, RULE_directive = 2, RULE_ifdefDirective = 3, 
		RULE_ifndefDirective = 4, RULE_elseDirective = 5, RULE_endIfDirective = 6, 
		RULE_preprocessor_expression = 7, RULE_preprocessor_macro = 8, RULE_newLineOrEOF = 9, 
		RULE_code = 10;
	public static readonly string[] ruleNames = {
		"preprocessor", "text", "directive", "ifdefDirective", "ifndefDirective", 
		"elseDirective", "endIfDirective", "preprocessor_expression", "preprocessor_macro", 
		"newLineOrEOF", "code"
	};

	private static readonly string[] _LiteralNames = {
		null, "'#'", "'##'", null, null, "'['", "']'", "'('", "')'", "','", "'undef'", 
		"'define'", "'include'", "'if'", "'ifdef'", "'ifndef'", "'else'", "'endif'", 
		"'__LINE__'", "'__FILE__'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SHARP", "CONCAT", "CODE", "DIRECTIVE_WHITESPACES", "LSBracket", 
		"RSBracket", "LParenthesis", "RParenthesis", "Comma", "UNDEFINE", "DEFINE", 
		"INCLUDE", "IF", "IFDEF", "IFNDEF", "ELSE", "ENDIF", "LINE", "FILE", "IDENTIFIER", 
		"LITERAL_STRING", "LITERAL_INT", "LITERAL_FLOAT", "NEW_LINE", "DIRECITVE_NEW_LINE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PreProcParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static PreProcParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public PreProcParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public PreProcParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class PreprocessorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(PreProcParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public TextContext[] text() {
			return GetRuleContexts<TextContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext text(int i) {
			return GetRuleContext<TextContext>(i);
		}
		public PreprocessorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_preprocessor; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterPreprocessor(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitPreprocessor(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPreprocessor(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PreprocessorContext preprocessor() {
		PreprocessorContext _localctx = new PreprocessorContext(Context, State);
		EnterRule(_localctx, 0, RULE_preprocessor);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==SHARP || _la==CODE) {
				{
				{
				State = 22;
				text();
				}
				}
				State = 27;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 28;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TextContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public CodeContext code() {
			return GetRuleContext<CodeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public DirectiveContext directive() {
			return GetRuleContext<DirectiveContext>(0);
		}
		public TextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_text; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterText(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitText(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitText(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TextContext text() {
		TextContext _localctx = new TextContext(Context, State);
		EnterRule(_localctx, 2, RULE_text);
		try {
			State = 32;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case CODE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 30;
				code();
				}
				break;
			case SHARP:
				EnterOuterAlt(_localctx, 2);
				{
				State = 31;
				directive();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DirectiveContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHARP() { return GetToken(PreProcParser.SHARP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INCLUDE() { return GetToken(PreProcParser.INCLUDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LITERAL_STRING() { return GetToken(PreProcParser.LITERAL_STRING, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NewLineOrEOFContext newLineOrEOF() {
			return GetRuleContext<NewLineOrEOFContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEFINE() { return GetToken(PreProcParser.DEFINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Preprocessor_macroContext preprocessor_macro() {
			return GetRuleContext<Preprocessor_macroContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Preprocessor_expressionContext preprocessor_expression() {
			return GetRuleContext<Preprocessor_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode UNDEFINE() { return GetToken(PreProcParser.UNDEFINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(PreProcParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public IfdefDirectiveContext ifdefDirective() {
			return GetRuleContext<IfdefDirectiveContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfndefDirectiveContext ifndefDirective() {
			return GetRuleContext<IfndefDirectiveContext>(0);
		}
		public DirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_directive; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDirective(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DirectiveContext directive() {
		DirectiveContext _localctx = new DirectiveContext(Context, State);
		EnterRule(_localctx, 4, RULE_directive);
		int _la;
		try {
			State = 52;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 34;
				Match(SHARP);
				State = 35;
				Match(INCLUDE);
				State = 36;
				Match(LITERAL_STRING);
				State = 37;
				newLineOrEOF();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 38;
				Match(SHARP);
				State = 39;
				Match(DEFINE);
				State = 40;
				preprocessor_macro();
				State = 42;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << IDENTIFIER) | (1L << LITERAL_INT) | (1L << LITERAL_FLOAT))) != 0)) {
					{
					State = 41;
					preprocessor_expression();
					}
				}

				State = 44;
				newLineOrEOF();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 46;
				Match(SHARP);
				State = 47;
				Match(UNDEFINE);
				State = 48;
				Match(IDENTIFIER);
				State = 49;
				newLineOrEOF();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 50;
				ifdefDirective();
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 51;
				ifndefDirective();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IfdefDirectiveContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHARP() { return GetToken(PreProcParser.SHARP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IFDEF() { return GetToken(PreProcParser.IFDEF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(PreProcParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NewLineOrEOFContext newLineOrEOF() {
			return GetRuleContext<NewLineOrEOFContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElseDirectiveContext elseDirective() {
			return GetRuleContext<ElseDirectiveContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EndIfDirectiveContext endIfDirective() {
			return GetRuleContext<EndIfDirectiveContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext[] text() {
			return GetRuleContexts<TextContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext text(int i) {
			return GetRuleContext<TextContext>(i);
		}
		public IfdefDirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifdefDirective; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterIfdefDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitIfdefDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIfdefDirective(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IfdefDirectiveContext ifdefDirective() {
		IfdefDirectiveContext _localctx = new IfdefDirectiveContext(Context, State);
		EnterRule(_localctx, 6, RULE_ifdefDirective);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 54;
			Match(SHARP);
			State = 55;
			Match(IFDEF);
			State = 56;
			Match(IDENTIFIER);
			State = 57;
			newLineOrEOF();
			State = 61;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 58;
					text();
					}
					} 
				}
				State = 63;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			State = 66;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
			case 1:
				{
				State = 64;
				elseDirective();
				}
				break;
			case 2:
				{
				State = 65;
				endIfDirective();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IfndefDirectiveContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHARP() { return GetToken(PreProcParser.SHARP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IFNDEF() { return GetToken(PreProcParser.IFNDEF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(PreProcParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NewLineOrEOFContext newLineOrEOF() {
			return GetRuleContext<NewLineOrEOFContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ElseDirectiveContext elseDirective() {
			return GetRuleContext<ElseDirectiveContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EndIfDirectiveContext endIfDirective() {
			return GetRuleContext<EndIfDirectiveContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext[] text() {
			return GetRuleContexts<TextContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext text(int i) {
			return GetRuleContext<TextContext>(i);
		}
		public IfndefDirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifndefDirective; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterIfndefDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitIfndefDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIfndefDirective(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IfndefDirectiveContext ifndefDirective() {
		IfndefDirectiveContext _localctx = new IfndefDirectiveContext(Context, State);
		EnterRule(_localctx, 8, RULE_ifndefDirective);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 68;
			Match(SHARP);
			State = 69;
			Match(IFNDEF);
			State = 70;
			Match(IDENTIFIER);
			State = 71;
			newLineOrEOF();
			State = 75;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 72;
					text();
					}
					} 
				}
				State = 77;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			}
			State = 80;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,7,Context) ) {
			case 1:
				{
				State = 78;
				elseDirective();
				}
				break;
			case 2:
				{
				State = 79;
				endIfDirective();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ElseDirectiveContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHARP() { return GetToken(PreProcParser.SHARP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE() { return GetToken(PreProcParser.ELSE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NewLineOrEOFContext newLineOrEOF() {
			return GetRuleContext<NewLineOrEOFContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public EndIfDirectiveContext endIfDirective() {
			return GetRuleContext<EndIfDirectiveContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext[] text() {
			return GetRuleContexts<TextContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TextContext text(int i) {
			return GetRuleContext<TextContext>(i);
		}
		public ElseDirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_elseDirective; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterElseDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitElseDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitElseDirective(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ElseDirectiveContext elseDirective() {
		ElseDirectiveContext _localctx = new ElseDirectiveContext(Context, State);
		EnterRule(_localctx, 10, RULE_elseDirective);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 82;
			Match(SHARP);
			State = 83;
			Match(ELSE);
			State = 84;
			newLineOrEOF();
			State = 88;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 85;
					text();
					}
					} 
				}
				State = 90;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,8,Context);
			}
			State = 91;
			endIfDirective();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EndIfDirectiveContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SHARP() { return GetToken(PreProcParser.SHARP, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ENDIF() { return GetToken(PreProcParser.ENDIF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public NewLineOrEOFContext newLineOrEOF() {
			return GetRuleContext<NewLineOrEOFContext>(0);
		}
		public EndIfDirectiveContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_endIfDirective; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterEndIfDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitEndIfDirective(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEndIfDirective(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EndIfDirectiveContext endIfDirective() {
		EndIfDirectiveContext _localctx = new EndIfDirectiveContext(Context, State);
		EnterRule(_localctx, 12, RULE_endIfDirective);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 93;
			Match(SHARP);
			State = 94;
			Match(ENDIF);
			State = 95;
			newLineOrEOF();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Preprocessor_expressionContext : ParserRuleContext {
		public Preprocessor_expressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_preprocessor_expression; } }
	 
		public Preprocessor_expressionContext() { }
		public virtual void CopyFrom(Preprocessor_expressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class PreprocessorMacroContext : Preprocessor_expressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public Preprocessor_macroContext preprocessor_macro() {
			return GetRuleContext<Preprocessor_macroContext>(0);
		}
		public PreprocessorMacroContext(Preprocessor_expressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterPreprocessorMacro(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitPreprocessorMacro(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPreprocessorMacro(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PreprocessorConstantContext : Preprocessor_expressionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LITERAL_FLOAT() { return GetToken(PreProcParser.LITERAL_FLOAT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LITERAL_INT() { return GetToken(PreProcParser.LITERAL_INT, 0); }
		public PreprocessorConstantContext(Preprocessor_expressionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterPreprocessorConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitPreprocessorConstant(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPreprocessorConstant(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Preprocessor_expressionContext preprocessor_expression() {
		Preprocessor_expressionContext _localctx = new Preprocessor_expressionContext(Context, State);
		EnterRule(_localctx, 14, RULE_preprocessor_expression);
		try {
			State = 100;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LITERAL_FLOAT:
				_localctx = new PreprocessorConstantContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 97;
				Match(LITERAL_FLOAT);
				}
				break;
			case LITERAL_INT:
				_localctx = new PreprocessorConstantContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 98;
				Match(LITERAL_INT);
				}
				break;
			case IDENTIFIER:
				_localctx = new PreprocessorMacroContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 99;
				preprocessor_macro();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Preprocessor_macroContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(PreProcParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LParenthesis() { return GetToken(PreProcParser.LParenthesis, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public Preprocessor_expressionContext preprocessor_expression() {
			return GetRuleContext<Preprocessor_expressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RParenthesis() { return GetToken(PreProcParser.RParenthesis, 0); }
		public Preprocessor_macroContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_preprocessor_macro; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterPreprocessor_macro(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitPreprocessor_macro(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPreprocessor_macro(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Preprocessor_macroContext preprocessor_macro() {
		Preprocessor_macroContext _localctx = new Preprocessor_macroContext(Context, State);
		EnterRule(_localctx, 16, RULE_preprocessor_macro);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 102;
			Match(IDENTIFIER);
			State = 107;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LParenthesis) {
				{
				State = 103;
				Match(LParenthesis);
				State = 104;
				preprocessor_expression();
				State = 105;
				Match(RParenthesis);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NewLineOrEOFContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEW_LINE() { return GetToken(PreProcParser.NEW_LINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(PreProcParser.Eof, 0); }
		public NewLineOrEOFContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_newLineOrEOF; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterNewLineOrEOF(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitNewLineOrEOF(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNewLineOrEOF(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NewLineOrEOFContext newLineOrEOF() {
		NewLineOrEOFContext _localctx = new NewLineOrEOFContext(Context, State);
		EnterRule(_localctx, 18, RULE_newLineOrEOF);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 109;
			_la = TokenStream.LA(1);
			if ( !(_la==Eof || _la==NEW_LINE) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class CodeContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] CODE() { return GetTokens(PreProcParser.CODE); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CODE(int i) {
			return GetToken(PreProcParser.CODE, i);
		}
		public CodeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_code; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.EnterCode(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPreProcParserListener typedListener = listener as IPreProcParserListener;
			if (typedListener != null) typedListener.ExitCode(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPreProcParserVisitor<TResult> typedVisitor = visitor as IPreProcParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCode(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public CodeContext code() {
		CodeContext _localctx = new CodeContext(Context, State);
		EnterRule(_localctx, 20, RULE_code);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 112;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 111;
					Match(CODE);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 114;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,11,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,25,117,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,2,10,7,10,1,0,5,0,24,8,0,10,0,12,0,27,9,0,1,0,1,0,
		1,1,1,1,3,1,33,8,1,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,3,2,43,8,2,1,2,1,2,
		1,2,1,2,1,2,1,2,1,2,1,2,3,2,53,8,2,1,3,1,3,1,3,1,3,1,3,5,3,60,8,3,10,3,
		12,3,63,9,3,1,3,1,3,3,3,67,8,3,1,4,1,4,1,4,1,4,1,4,5,4,74,8,4,10,4,12,
		4,77,9,4,1,4,1,4,3,4,81,8,4,1,5,1,5,1,5,1,5,5,5,87,8,5,10,5,12,5,90,9,
		5,1,5,1,5,1,6,1,6,1,6,1,6,1,7,1,7,1,7,3,7,101,8,7,1,8,1,8,1,8,1,8,1,8,
		3,8,108,8,8,1,9,1,9,1,10,4,10,113,8,10,11,10,12,10,114,1,10,0,0,11,0,2,
		4,6,8,10,12,14,16,18,20,0,1,1,1,24,24,121,0,25,1,0,0,0,2,32,1,0,0,0,4,
		52,1,0,0,0,6,54,1,0,0,0,8,68,1,0,0,0,10,82,1,0,0,0,12,93,1,0,0,0,14,100,
		1,0,0,0,16,102,1,0,0,0,18,109,1,0,0,0,20,112,1,0,0,0,22,24,3,2,1,0,23,
		22,1,0,0,0,24,27,1,0,0,0,25,23,1,0,0,0,25,26,1,0,0,0,26,28,1,0,0,0,27,
		25,1,0,0,0,28,29,5,0,0,1,29,1,1,0,0,0,30,33,3,20,10,0,31,33,3,4,2,0,32,
		30,1,0,0,0,32,31,1,0,0,0,33,3,1,0,0,0,34,35,5,1,0,0,35,36,5,12,0,0,36,
		37,5,21,0,0,37,53,3,18,9,0,38,39,5,1,0,0,39,40,5,11,0,0,40,42,3,16,8,0,
		41,43,3,14,7,0,42,41,1,0,0,0,42,43,1,0,0,0,43,44,1,0,0,0,44,45,3,18,9,
		0,45,53,1,0,0,0,46,47,5,1,0,0,47,48,5,10,0,0,48,49,5,20,0,0,49,53,3,18,
		9,0,50,53,3,6,3,0,51,53,3,8,4,0,52,34,1,0,0,0,52,38,1,0,0,0,52,46,1,0,
		0,0,52,50,1,0,0,0,52,51,1,0,0,0,53,5,1,0,0,0,54,55,5,1,0,0,55,56,5,14,
		0,0,56,57,5,20,0,0,57,61,3,18,9,0,58,60,3,2,1,0,59,58,1,0,0,0,60,63,1,
		0,0,0,61,59,1,0,0,0,61,62,1,0,0,0,62,66,1,0,0,0,63,61,1,0,0,0,64,67,3,
		10,5,0,65,67,3,12,6,0,66,64,1,0,0,0,66,65,1,0,0,0,67,7,1,0,0,0,68,69,5,
		1,0,0,69,70,5,15,0,0,70,71,5,20,0,0,71,75,3,18,9,0,72,74,3,2,1,0,73,72,
		1,0,0,0,74,77,1,0,0,0,75,73,1,0,0,0,75,76,1,0,0,0,76,80,1,0,0,0,77,75,
		1,0,0,0,78,81,3,10,5,0,79,81,3,12,6,0,80,78,1,0,0,0,80,79,1,0,0,0,81,9,
		1,0,0,0,82,83,5,1,0,0,83,84,5,16,0,0,84,88,3,18,9,0,85,87,3,2,1,0,86,85,
		1,0,0,0,87,90,1,0,0,0,88,86,1,0,0,0,88,89,1,0,0,0,89,91,1,0,0,0,90,88,
		1,0,0,0,91,92,3,12,6,0,92,11,1,0,0,0,93,94,5,1,0,0,94,95,5,17,0,0,95,96,
		3,18,9,0,96,13,1,0,0,0,97,101,5,23,0,0,98,101,5,22,0,0,99,101,3,16,8,0,
		100,97,1,0,0,0,100,98,1,0,0,0,100,99,1,0,0,0,101,15,1,0,0,0,102,107,5,
		20,0,0,103,104,5,7,0,0,104,105,3,14,7,0,105,106,5,8,0,0,106,108,1,0,0,
		0,107,103,1,0,0,0,107,108,1,0,0,0,108,17,1,0,0,0,109,110,7,0,0,0,110,19,
		1,0,0,0,111,113,5,3,0,0,112,111,1,0,0,0,113,114,1,0,0,0,114,112,1,0,0,
		0,114,115,1,0,0,0,115,21,1,0,0,0,12,25,32,42,52,61,66,75,80,88,100,107,
		114
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
