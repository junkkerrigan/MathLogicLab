using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;

namespace ResolutionsMethod
{
    public partial class Form1 : Form
    {
        // {AvB, BvC}|=AvC
        public Form1()
        {
            InitializeComponent();
            TextBox Formula = new TextBox()
            {
                Size = new Size(300, 30),
                Location = new Point(200, 200),
            };
            Button Submit = new Button()
            {
                Size = new Size(50, 20),
                Location = new Point(Formula.Right + 15, Formula.Top + 5),
            };
            Submit.Click += (s, e) =>
            {
                var inputStream = new AntlrInputStream(Formula.Text);
                var lexer = new PropositionalLogicGrammarLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(lexer);
                var parser = new PropositionalLogicGrammarParser(commonTokenStream);
                var res = parser.statement();
                var ans = (new PropositionalVisitor()).Visit(res);
            };
            Controls.Add(Formula);
            Controls.Add(Submit);
        }
    }
}
