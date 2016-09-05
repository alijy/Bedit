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
using System.Drawing.Printing;

namespace Bedit
{
    public partial class Form1 : Form
    {
        List<Tab> listOfTabs = new List<Tab>();
        Tab activeTab;
        private PrintDocument printDocument = new PrintDocument();

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

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            ;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            activeTab = listOfTabs[tabControl.SelectedIndex];
            this.ActiveControl = activeTab.textBox;
            this.Text = activeTab.fileName + " - bEdit";
            tabControl.SelectTab(activeTab.Name);
            tabControl.SelectedTab = activeTab;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int caretPosition = activeTab.textBox.SelectionStart;
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

        private void Menu_New(object sender, EventArgs e)
        {
            activeTab = CreateNewTab(tabControl, null, null);
        }

        private void Menu_Open(object sender, EventArgs e)
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

        private void Menu_Save(object sender, EventArgs e)
        {
            if (activeTab.fileName == activeTab.Name)
            {
                Menu_SaveAs(null, null);
            }
            else
            {
                using(StreamWriter writer=new StreamWriter(activeTab.fileName))
                {
                    writer.Write(activeTab.textBox.Text);
                }

            }
        }

        private void Menu_SaveAs(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(activeTab.textBox.Text);
                }
                stream.Close();

                #region alternative to above code
                //using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                //{
                //    using (TextWriter tw = new StreamWriter(fs))
                //    {
                //        foreach (string line in activeTab.textBox.Text.Split(new string[] { "\n" }, StringSplitOptions.None))
                //        {
                //            tw.WriteLine(line);
                //        }
                //    }
                //}
                #endregion
                activeTab.fileName = saveFileDialog.FileName;
                this.Text = activeTab.fileName + " - bEdit";
                activeTab.Text = Path.GetFileName(saveFileDialog.FileName);
            }
        }

        private void Menu_PageSetup(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            //pageSetupDialog.PageSettings = new System.Drawing.Printing.PageSettings();
            //pageSetupDialog.PrinterSettings = 
            pageSetupDialog.Document = new System.Drawing.Printing.PrintDocument();
            pageSetupDialog.ShowDialog();
        }

        private void Menu_Print(object sender, EventArgs e)
        {
            printDocument.PrintPage += document_PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.AllowSelection = true;
            printDialog.AllowCurrentPage = true;
            printDialog.AllowSomePages = true;
            printDialog.AllowPrintToFile = true;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        // ***** work more on this later *****
        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Insert code to render the page here.
            // This code will be called when the control is drawn.

            // The following code will render a simple
            // message on the printed document.
            string text = "In document_PrintPage method.";
            Font printFont = new Font("Arial", 35, System.Drawing.FontStyle.Regular);

            // Draw the content.
            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 10, 10);
        }

        private void Menu_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Undo(object sender, EventArgs e)
        {
            // Determine if last operation can be undone in text box.   
            if (activeTab.textBox.CanUndo == true)
            {
                // Undo the last operation.
                activeTab.textBox.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                activeTab.textBox.ClearUndo();
            }
        }

        private void Menu_Cut(object sender, EventArgs e)
        {
            // Ensure that text is currently selected in the text box.   
            if (activeTab.textBox.SelectedText != "")
                // Cut the selected text in the control and paste it into the Clipboard.
                activeTab.textBox.Cut();

        }

        private void Menu_Copy(object sender, EventArgs e)
        {
            // Ensure that text is selected in the text box.   
            if (activeTab.textBox.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                activeTab.textBox.Copy();
        }

        private void Menu_Paste(object sender, EventArgs e)
        {
            // Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (activeTab.textBox.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        activeTab.textBox.SelectionStart = activeTab.textBox.SelectionStart + activeTab.textBox.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                activeTab.textBox.Paste();
            }
        }

        private void Menu_Delete(object sender, EventArgs e)
        {
            activeTab.textBox.SelectedText = "";
        }
    }
}
