using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBuilder
{
    class CodeBuilder
    {
        protected const int INDENT_SIZE = 2;

        protected StringBuilder code = null;

        public CodeBuilder() {
            code = new StringBuilder();
        }

        public CodeBuilder(StringBuilder code) {
            this.code = code;
        }

        public ClassBuilder AddClass(string className) {
            StringBuilder currentCode = new StringBuilder(ToString());
            ClassBuilder classBuilder = new ClassBuilder(currentCode, className);
            return classBuilder;
        }

        public override string ToString() {
            return "";
        }
    }
}
