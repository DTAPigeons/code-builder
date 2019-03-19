using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBuilder
{
    class ClassBuilder
    {

        protected const int INDENT_SIZE = 2;

        protected StringBuilder code = null;

        public ClassBuilder() {

        }

        public ClassBuilder(string className) {
            code = new StringBuilder();
            string indent = new string(' ', INDENT_SIZE);
            code.AppendLine(indent+"public class " + className+" {");
        }

        public ClassBuilder AddField(string fieldName,string fieldType,string privasy = "private") {
            string indent = new string(' ', INDENT_SIZE * 2);
            code.AppendLine(indent+" "+privasy+" "+fieldType+" "+fieldName);
            return this;
        }

        public override string ToString() {
            string indent = new string(' ', INDENT_SIZE);
            code.AppendLine(indent+"}");
            return code.ToString();
        }
    }
}
