// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Shaders.Ast.Xenko;
using SiliconStudio.Shaders.Ast;
using SiliconStudio.Shaders.Visitor;

namespace SiliconStudio.Xenko.Shaders.Parser.Mixins
{
    internal class ExpressionSimplifierVisitor : ShaderWalker
    {
        private readonly ExpressionEvaluator evaluator;

        public ExpressionSimplifierVisitor()
            : base(true, true)
        {
            evaluator = new ExpressionEvaluator();
        }

        public void Run(Shader shader)
        {
            Visit(shader);
        }

        public override void Visit(StatementList statementList)
        {
            for (int i = 0; i < statementList.Count; i++)
            {
                var statement = statementList[i];
                var ifStatement = statement as IfStatement;
                if (ifStatement != null)
                {
                    var result = evaluator.Evaluate(ifStatement.Condition);
                    if (result.HasErrors)
                    {
                        continue;
                    }
                    statementList[i] = result.Value == 1.0 ? ifStatement.Then : ifStatement.Else;
                    if (statementList[i] == null)
                    {
                        statementList.RemoveAt(i);
                    }
                    i--;
                }
            }

            base.Visit(statementList);
        }
    }
}