using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// perform encapsulation

namespace Bedit
{
    class Tab : TabPage
    {
        public TextBox textBox;
        public string fileName;
        public TextBox lineNumberBox;
        public const int NUMBEROFLINESINTEXTBOX = 30;
        public int lineStartNumber = 1;

        //public int number;

        public Tab(TabControl tabControl, string tabName, string fileName) : base()//("new " + (tabControl.TabCount + 1))
        {
       //     this.SuspendLayout();//******remove this!******//
            this.Name = (tabName == null) ? NewTabName(tabControl) : tabName;
            this.Text = this.Name;
            this.fileName = (fileName == null) ? this.Text : fileName;
            //this.number = tabControl.TabCount + 1;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(4, 22);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(776, 487);
            this.UseVisualStyleBackColor = true;
            CreateContent();
            this.Controls.Add(lineNumberBox);
            this.Controls.Add(textBox);
        }

        private string NewTabName(TabControl tabControl)
        {
            int counter = 1;
            while (tabControl.TabPages.ContainsKey("new " + counter))
                counter++;
            return ("new " + counter);
        }

        private void CreateContent()
        {
            CreateLineNumberBox();
            CreateTextBox();
        }

        private void CreateLineNumberBox()
        {
            this.lineNumberBox = new TextBox();
            this.lineNumberBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lineNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineNumberBox.Enabled = false;
            this.lineNumberBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lineNumberBox.Location = new System.Drawing.Point(0, 0);
            this.lineNumberBox.Multiline = true;
            this.lineNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineNumberBox.Name = "lineNumberBox";
            this.lineNumberBox.Size = new System.Drawing.Size(48, 483);
            this.lineNumberBox.TabIndex = 0;
            this.lineNumberBox.Text = "1";
            this.lineNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            

        }

        private void CreateTextBox()
        {
            this.textBox = new TextBox();
            this.textBox.AcceptsTab = true;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Multiline = true;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(50, -2);
            this.textBox.Name = "textBox";// + number;
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(721, 484);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            this.textBox.WordWrap = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            //this.textBox.Select();

        }

        //public void caretRepositioned(int position)
        //{
        //    if (position == 10 && positionFlag == false)
        //    {
        //        positionFlag = true;
        //        MessageBox.Show("position is: " + position);
        //    }
        //}

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (NewLines(textBox.Text) + 1 > NUMBEROFLINESINTEXTBOX)
                this.textBox.ScrollBars = ScrollBars.Vertical;
            //lineNumberBox.Text = null;
            //lineStartNumber = 1;
            //int lineNum = NewLines(textBox.Text) + 1;
            //if (lineNum > NUMBEROFLINESINTEXTBOX)
            //{
            //    lineStartNumber = lineNum - NUMBEROFLINESINTEXTBOX + 1;
            //    this.textBox.ScrollBars = ScrollBars.Vertical;
            //}
            //for (int i = lineStartNumber; i < lineNum; i++)
            //    lineNumberBox.Text += (i + "\r\n");
            //    //lineNumberBox.AppendText("\r\n" + (i + 2));
            //lineNumberBox.Text += lineNum;
        }

        private int NewLines(string text)
        {
            int newLines = 0;
            foreach (char c in text)
            {
                if (c == '\n')
                    newLines++;
            }
            return newLines;
        }
    }
}
