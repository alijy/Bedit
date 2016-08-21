using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedit
{
    class Tab : TabPage
    {
        public TextBox textBox;
        public Label lineLabel;
        public string fileName;

        public Tab(TabControl tabControl) : base("new " + (tabControl.TabCount + 1))
        {
            this.SuspendLayout();
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tabPage" + tabControl.TabCount;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(776, 487);
            this.TabIndex = 0;
            //this.Text = "new 1";
            this.UseVisualStyleBackColor = true;
            CreateContent();
            this.Controls.Add(lineLabel);
            this.Controls.Add(textBox);

        }

        private void CreateContent()
        {
            CreateLineLabel();
            CreateTextBox();
        }

        private void CreateLineLabel()
        {
            this.lineLabel = new Label();
            this.lineLabel.BackColor = System.Drawing.Color.Lavender;
            this.lineLabel.Enabled = false;
            this.lineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lineLabel.Location = new System.Drawing.Point(-2, -2);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(46, 491);
            this.lineLabel.TabIndex = 2;
            this.lineLabel.Text = "1\r\n";
            this.lineLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        }

        private void CreateTextBox()
        {
            this.textBox = new TextBox();
            this.textBox.AcceptsTab = true;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Multiline = true;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(50, -2);
            this.textBox.Name = "textBox";
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(721, 484);
            this.textBox.TabIndex = 1;
            this.textBox.TabStop = false;
            //this.textBox.Text = "asasdads\nasdasd\n\n\nasdas\nasd\n\nasdas\nd\n";
            this.textBox.WordWrap = false;
            this.textBox.Select();
        }
    }
}
