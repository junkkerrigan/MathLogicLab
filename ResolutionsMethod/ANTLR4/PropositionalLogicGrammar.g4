grammar PropositionalLogicGrammar;

/*
	Parser rules
*/

statement : LCURLYBRACKET (expression COMMA)* expression RCURLYBRACKET CONCLUSION result EOF;

result : expression;

expression 
	: LBRACKET expression RBRACKET #Parentheses
	| expression CONJUNCTION expression #Conjunction
	| expression DISJUNCTION expression #Disjunction
	| expression IMPLICATION expression #Implication
	| LITERAL_NEGATION #LiteralNegation
	| LITERAL #Literal
	| INVALID #Invalid
	;


/*
	Lexer rules
*/


COMMA : ',';
CONCLUSION : '|=';
CONJUNCTION : ('&'|'^');
DISJUNCTION : ('v'|'|');
IMPLICATION : '->';
LITERAL : LETTER;
LITERAL_NEGATION : NEGATION LETTER;
NEGATION : ('~'|'!'|'-');
LETTER : ('A'..'Z');
LBRACKET : '(';
RBRACKET : ')';
LCURLYBRACKET : '{';
RCURLYBRACKET : '}';
WHITESPACE : (' ' | '\t')+ -> skip;
INVALID : .;
