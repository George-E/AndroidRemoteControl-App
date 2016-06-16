namespace ARC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.createNew = new System.Windows.Forms.Button();
            this.Switches = new System.Windows.Forms.TabControl();
            this.Triggers = new System.Windows.Forms.TabPage();
            this.Watches = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Switches.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.createNew);
            this.splitContainer1.Panel1.Controls.Add(this.Switches);
            this.splitContainer1.Size = new System.Drawing.Size(634, 397);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 0;
            // 
            // createNew
            // 
            this.createNew.Location = new System.Drawing.Point(7, 370);
            this.createNew.Name = "createNew";
            this.createNew.Size = new System.Drawing.Size(197, 23);
            this.createNew.TabIndex = 1;
            this.createNew.Text = "Create new";
            this.createNew.UseVisualStyleBackColor = true;
            this.createNew.Click += new System.EventHandler(this.createNew_Click);
            // 
            // Switches
            // 
            this.Switches.AccessibleDescription = " ";
            this.Switches.Controls.Add(this.Triggers);
            this.Switches.Controls.Add(this.Watches);
            this.Switches.Location = new System.Drawing.Point(3, 12);
            this.Switches.Name = "Switches";
            this.Switches.SelectedIndex = 0;
            this.Switches.Size = new System.Drawing.Size(205, 352);
            this.Switches.TabIndex = 0;
            this.Switches.UseWaitCursor = true;
            // 
            // Triggers
            // 
            this.Triggers.Location = new System.Drawing.Point(4, 22);
            this.Triggers.Name = "Triggers";
            this.Triggers.Padding = new System.Windows.Forms.Padding(3);
            this.Triggers.Size = new System.Drawing.Size(197, 326);
            this.Triggers.TabIndex = 0;
            this.Triggers.Text = "Triggers";
            this.Triggers.UseVisualStyleBackColor = true;
            this.Triggers.UseWaitCursor = true;
            // 
            // Watches
            // 
            this.Watches.Location = new System.Drawing.Point(4, 22);
            this.Watches.Name = "Watches";
            this.Watches.Padding = new System.Windows.Forms.Padding(3);
            this.Watches.Size = new System.Drawing.Size(197, 326);
            this.Watches.TabIndex = 1;
            this.Watches.Text = "Watches";
            this.Watches.UseVisualStyleBackColor = true;
            this.Watches.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 397);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Switches.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl Switches;
        private System.Windows.Forms.TabPage Triggers;
        private System.Windows.Forms.TabPage Watches;
        private System.Windows.Forms.Button createNew;
    }
}

