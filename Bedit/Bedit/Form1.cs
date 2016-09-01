using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedit
{
    public partial class Form1 : Form
    {
        List<Tab> listOfTabs = new List<Tab>();
        Tab activeTab;

        public Form1()
        {
            InitializeComponent();
            activeTab = CreateNewTab(tabControl, null, null);
            timer1.Start();
        }

        private Tab CreateNewTab(TabControl tabControl, string tabName, string fileName)
        {
            Tab newTab = new Tab(tabControl, tabName, fileName);
            this.Text = newTab.fileName + " - bEdit";
            activeTab = newTab;
            listOfTabs.Add(newTab);
            tabControl.TabPages.Add(newTab);
            tabControl.SelectTab(newTab.Name);
            this.ActiveControl = newTab.textBox;
            return newTab;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTab = CreateNewTab(tabControl, null, null);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                activeTab = CreateNewTab(tabControl, openFileDialog.SafeFileName, openFileDialog.FileName);
                activeTab.fileName = openFileDialog.FileName;
                activeTab.textBox.Text = File.ReadAllText(openFileDialog.FileName);
                activeTab.Name = openFileDialog.SafeFileName;
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            ;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            activeTab = listOfTabs[tabControl.SelectedIndex];//***** change this back to [tabControl.activeIndex] after removing Test tab
            this.ActiveControl = activeTab.textBox;
            this.Text = activeTab.fileName + " - bEdit";
            tabControl.SelectTab(activeTab.Name);
            tabControl.SelectedTab = activeTab;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int caretPosition = activeTab.textBox.SelectionStart;
            //activeTab.caretRepositioned(caretPosition);
            int line = NewLines(activeTab.textBox.Text.Substring(0, caretPosition)) + 1;
            lnLabel.Text = "Ln : " + line;
            int columnStart = activeTab.textBox.Text.Substring(0, caretPosition).LastIndexOf('\n');
            colLabel.Text = "Col : " + (caretPosition - columnStart);
            int selectedLines = (activeTab.textBox.SelectionLength > 0) ? NewLines(activeTab.textBox.SelectedText) + 1 : 0;
            selLabel.Text = "Sel : " + (activeTab.textBox.SelectionLength) + " | " + selectedLines;
            lengthLabel.Text = "Length : " + activeTab.textBox.Text.Length;
            int numberOfLines = NewLines(activeTab.textBox.Text) + 1;
            lineLabel.Text = "Line : " + (numberOfLines);
            if (numberOfLines <= Tab.NUMBEROFLINESINTEXTBOX)
            {
                activeTab.lineStartNumber = 1;
                DrawNumbers(1, numberOfLines);
            }
            else
            {
                if (line < activeTab.lineStartNumber)
                {
                    activeTab.lineStartNumber = line;
                    DrawNumbers(line, line + Tab.NUMBEROFLINESINTEXTBOX - 1);
                }
                else if (line > activeTab.lineStartNumber + Tab.NUMBEROFLINESINTEXTBOX - 1)
                {
                    activeTab.lineStartNumber = line - Tab.NUMBEROFLINESINTEXTBOX + 1;
                    DrawNumbers(activeTab.lineStartNumber, line);
                }
            }

            //if (line < activeTab.lineStartNumber)
            //{
            //    for (int i = line; i < line + Tab.NUMBEROFLINESINTEXTBOX; i++)
            //        activeTab.lineNumberBox.Text += (i + "\r\n");
            //    //activeTab.lineNumberBox.Text += lineNum;
            //}
        }

        private void DrawNumbers(int start, int end)
        {
            activeTab.lineNumberBox.Text = start.ToString();
            for (int i = start + 1; i <= end; i++)
                activeTab.lineNumberBox.Text += ("\r\n" + i);
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
