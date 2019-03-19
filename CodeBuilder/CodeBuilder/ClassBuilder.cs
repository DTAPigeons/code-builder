using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBuilder
{
    class ClassBuilder: CodeBuilder
    {

        public ClassBuilder() {

        }

        public ClassBuilder(string className) {
            code = new StringBuilder();
            string indent = new string(' ', INDENT_SIZE);
            code.AppendLine(indent+"public class " + className+" {");
        }

        public ClassBuilder(StringBuilder code, string className) : base(code) {
            string indent = new string(' ', INDENT_SIZE);
            code.AppendLine(indent + "public class " + className + " {");
        }

        public ClassBuilder AddField(string fieldName,string fieldType,string privasy = "private") {
            string indent = new string(' ', INDENT_SIZE * 2);
            code.AppendLine(indent+" "+privasy+" "+fieldType+" "+fieldName+";");
            return this;
        }

        public override string ToString() {
            string indent = new string(' ', INDENT_SIZE);
            code.AppendLine(indent+"}");
            return code.ToString();
        }
    }
}
