using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ARC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<Trigger> triggers;
        public static List<Watches> watches;
        public static List<Object> order;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
     class Trigger
    {
        public String name;
        public List<Function> functions;

       public Trigger(string name, List<Function> functions)
        {
            this.name = name;
            this.functions = functions;
        }

    }

     class Watches
    {
        public String name;
        public List<Function> functions;
        //public "screen"
        public Watches(string name, List<Function> functions /*,screen*/)
        {
            this.name = name;
            this.functions = functions;
        }

    }
}
