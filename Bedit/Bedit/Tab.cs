using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Bedit
{
    /// <summary>
    /// An inherited class from 'TabPage' base class.
    /// It adds textboxes and other features to the TabPage class to provide a complete editing tab for the editor.
    /// </summary>
    class Tab : TabPage
    {
        private TabControl tabControl;
        public TextBox textBox;
        public string fileName;
        public TextBox lineNumberBox;
        public const int NUMBEROFLINESINTEXTBOX = 30;
        public int lineStartNumber = 1;
        public Stack<string> undoStack = new Stack<string>();
        public Stack<string> redoStack = new Stack<string>();
        public bool saved = true;

        /// <summary>
        /// Initializes a new instance of the Tab class and specifies the text for the tab.
        /// </summary>
        /// <param name="tabControl">The instance of TabControl class that the tab is being added to.</param>
        /// <param name="tabName">The name and text for the tab. It can be null in which case a numbered name will be generated for it.</param>
        /// <param name="fileName">The name of the opened file. It can be null in which case it is equal to tab name.</param>
        public Tab(TabControl tabControl, string tabName, string fileName) : base()
        {
            //this.SuspendLayout();
            this.tabControl = tabControl;
            this.Name = (tabName == null) ? NewTabName(tabControl) : tabName;
            this.Text = this.Name;
            this.fileName = (fileName == null) ? this.Text : fileName;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(4, 22);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(776, 487);
            this.UseVisualStyleBackColor = true;
            LoadContent();
            undoStack.Push("");
        }

        /// <summary>
        /// Generates a new and unique tab name in the form of 'new X'.
        /// </summary>
        /// <param name="tabControl">The instance of TabControl that the tab is being added to.</param>
        /// <returns></returns>
        private string NewTabName(TabControl tabControl)
        {
            int counter = 1;
            while (tabControl.TabPages.ContainsKey("new " + counter))
                counter++;
            return ("new " + counter);
        }

        /// <summary>
        /// Creates and adds the controls of the tab.
        /// </summary>
        private void LoadContent()
        {
            LoadLineNumberBox();
            LoadTextBox();
        }

        /// <summary>
        /// Creates and adds a textbox control to the tab for line numbers.
        /// </summary>
        private void LoadLineNumberBox()
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
            this.Controls.Add(lineNumberBox);
        }

        /// <summary>
        /// Creates and adds a textbox control for input text to the tab.
        /// </summary>
        private void LoadTextBox()
        {
            this.textBox = new TextBox();
            this.textBox.AcceptsTab = true;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Multiline = true;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(50, 0);
            this.textBox.Name = "textBox";
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(721, 483);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            this.textBox.WordWrap = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.Controls.Add(textBox);
        }

        /// <summary>
        /// Occurs when the text in the editable textbox of the tab changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.saved = false;
            tabControl.Invalidate();

            if (NumberOfNewLines(textBox.Text) + 1 > NUMBEROFLINESINTEXTBOX)
                this.textBox.ScrollBars = ScrollBars.Vertical;
            undoStack.Push(textBox.Text);
        }

        /// <summary>
        /// Returns the number of '\n' characters in a string.
        /// </summary>
        /// <param name="text">The input string.</param>
        /// <returns></returns>
        private int NumberOfNewLines(string text)
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
