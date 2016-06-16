using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.triggers = new List<Trigger>();
            Program.watches = new List<Watches>();
            Program.order = new List<Object>();
            Resources.LoadResources();
        }

        private void populate()
        {
            for (int i = 0; i < Program.triggers.Count; i++)
            {
                Panel p = new Panel();
                p.Size = new Size(Triggers.Width - 20, 50);
                p.Location = new Point(10, i * 60 + 10);
                p.BackColor = Color.White;
                p.Name = "T" + i;

                p.DoubleClick += (sender, e) => {
                    Program.order.Add(Program.triggers[int.Parse(((Panel)sender).Name.Substring(1))]);
                    ShowTriggerFunctions(Program.triggers[i].name);
                };

                Triggers.Controls.Add(p);

                PictureBox edit = new PictureBox();
                edit.Size = new Size(20, 20);
                edit.Location = new Point(p.Width - 20, 0);
                edit.Image = Resources.Images["edit"];
                edit.SizeMode = PictureBoxSizeMode.Zoom;
                edit.BackColor = Color.Transparent;
                p.Controls.Add(edit);

                Label title = new Label();
                title.Text = Program.triggers[i].name;
                title.TextAlign = ContentAlignment.MiddleCenter;
                title.Location = new Point(p.Width / 2 - title.Width / 2, p.Height / 2 - title.Height / 2);
                p.Controls.Add(title);
            }
        }
        
        private void ShowTriggerFunctions(string name)
        {
                Panel p = new Panel();
                p.Size = new Size(splitContainer1.Panel2.Width - 20, 50);
                p.Location = new Point(10, Program.order.Count * 60 + 10);
                p.BackColor = Color.White;
                splitContainer1.Panel2.Controls.Add(p);
                PictureBox close = new PictureBox();
                close.Size = new Size(20, 20);
                close.Location = new Point(p.Width - 20, 0);
                close.Image = Resources.Images["close"];
                close.SizeMode = PictureBoxSizeMode.Zoom;
                close.BackColor = Color.Transparent;
                close.Click += (sender, e) => { };
                p.Controls.Add(close);

                Label title = new Label();
                title.Text = name;
                title.TextAlign = ContentAlignment.MiddleCenter;
                title.Location = new Point(p.Width / 2 - title.Width / 2, p.Height / 2 - title.Height / 2);
                p.Controls.Add(title);
            }


        private void createNew_Click(object sender, EventArgs e)
        {
            Trigger one = new Trigger("one", new List<Function>());
            Trigger two = new Trigger("twoo", new List<Function>());
            Program.triggers.Add(one);
            Program.triggers.Add(two);
            populate();
        }
    }
    
}
