using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace ResolutionsMethod
{
    class PropositionalVisitor : PropositionalLogicGrammarBaseVisitor< List<Disjunct> >
    {
        public PropositionalVisitor() : base()
        {
        }

        public override List<Disjunct> VisitConjunction([NotNull] PropositionalLogicGrammarParser.ConjunctionContext context)
        {
            return base.VisitConjunction(context);
        }

        public override List<Disjunct> VisitDisjunction([NotNull] PropositionalLogicGrammarParser.DisjunctionContext context)
        {
            return base.VisitDisjunction(context);
        }

        public override List<Disjunct> VisitImplication([NotNull] PropositionalLogicGrammarParser.ImplicationContext context)
        {
            return base.VisitImplication(context);
        }

        public override List<Disjunct> VisitInvalid([NotNull] PropositionalLogicGrammarParser.InvalidContext context)
        {
            return base.VisitInvalid(context);
        }

        public override List<Disjunct> VisitLiteral([NotNull] PropositionalLogicGrammarParser.LiteralContext context)
        {
            Literal l;
            return base.VisitLiteral(context);
        }

        public override List<Disjunct> VisitParentheses([NotNull] PropositionalLogicGrammarParser.ParenthesesContext context)
        {
            return base.VisitParentheses(context);
        }

        public override List<Disjunct> VisitStatement([NotNull] PropositionalLogicGrammarParser.StatementContext context)
        {
            return base.VisitStatement(context);
        }

        private List<Disjunct> WalkLeft(PropositionalLogicGrammarParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<PropositionalLogicGrammarParser.ExpressionContext>(0));
        }

        private List<Disjunct> WalkRight(PropositionalLogicGrammarParser.ExpressionContext context)
        {
            return Visit(context.GetRuleContext<PropositionalLogicGrammarParser.ExpressionContext>(1));
        }
    }
}
