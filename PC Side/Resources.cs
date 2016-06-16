using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC
{
    class Resources
    {
        public static Dictionary<string, Image> Images;

        public static void LoadResources()
        {
            Images = new Dictionary<string, Image>();
            Images.Add("close", Image.FromFile("closebutton.png"));
            Images.Add("edit", Image.FromFile("editbutton.png"));
            Images.Add("click", Image.FromFile("click.png"));
            Images.Add("key", Image.FromFile("key.png"));
        }
    }
}
