grammar PropositionalLogicGrammar;

/*
	Parser rules
*/

statement : LCURLYBRACKET (expression COMMA)+ expression RCURLYBRACKET CONCLUSION result EOF;

result : expression;

expression 
	: LBRACKET expression RBRACKET #Parentheses
	| expression IMPLICATION expression #Implication
	| expression DISJUNCTION expression #Disjunction
	| expression CONJUNCTION expression #Conjunction
	| LITERAL_NEGATION #LiteralNegation
	| LITERAL #Literal
	| INVALID #Invalid
	;


/*
	Lexer rules
*/


COMMA : ',';
CONCLUSION : '|=';
CONJUNCTION : '&';
DISJUNCTION : 'v';
IMPLICATION : '->';
LITERAL : LETTER;
LITERAL_NEGATION : NEGATION LETTER;
NEGATION : '~';
LETTER : ('A'..'Z');
LBRACKET : '(';
RBRACKET : ')';
LCURLYBRACKET : '{';
RCURLYBRACKET : '}';
WHITESPACE : (' ' | '\t')+ -> skip;
INVALID : .;
