using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC
{
    public class Function
    {
        public delegate void FunctionAction(Function function);

        public string name;
        public string tooltip;
        public Image img;
        public FunctionAction action;
        public FunctionAction edit;
        public Parameter[] param;

        public Function(string name, string tooltip, Image img, FunctionAction action, FunctionAction edit, Parameter[] param)
        {
            this.name = name;
            this.tooltip = tooltip;
            this.img = img;
            this.action = action;
            this.edit = edit;
            this.param = param;
        }

        public class Parameter
        {
            public enum ParamType
            {
                String, Int, Float, Char
            }

            public string name;
            public ParamType type;
            public object value;

            public Parameter(string name, ParamType type, object value)
            {
                this.name = name;
                this.type = type;
                this.value = value;
            }
        }
    }
}
