﻿using System;
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
        Stack<Tab> activeTabStack = new Stack<Tab>();
        private PrintDocument printDocument = new PrintDocument();
        Image closeImage, closeImageAct;

        public Form1()
        {
            InitializeComponent();
            activeTab = CreateNewTab(tabControl, null, null);
            timer1.Start();
            activeTabStack.Push(activeTab);
        }

        private Tab CreateNewTab(TabControl tabControl, string tabName, string fileName)
        {
            Tab newTab = new Tab(tabControl, tabName, fileName);
            this.Text = newTab.fileName + " - bEdit";
            activeTab = newTab;
            listOfTabs.Add(newTab);
            tabControl.TabPages.Add(newTab);
            WindowMenuModifier(newTab);
            tabControl.SelectTab(newTab.Name);
            this.ActiveControl = newTab.textBox;
            return newTab;
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (listOfTabs.Count > 0)
            {
                activeTab = listOfTabs[tabControl.SelectedIndex];
                ActiveControl = activeTab.textBox;
                Text = activeTab.fileName + " - bEdit";
                tabControl.SelectTab(activeTab.Name);
                tabControl.SelectedTab = activeTab;
                readOnlyCheck.Checked = activeTab.textBox.ReadOnly;
                UpdateWindowMenuItemsChecks();
                tabControl.Invalidate();
                activeTabStack.Push(activeTab);
            }
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
                int tabNumber = IsFileOpen(openFileDialog.SafeFileName);
                if (tabNumber >= 0)
                {
                    TabSelect(tabNumber);
                }
                else
                {
                    activeTab = CreateNewTab(tabControl, openFileDialog.SafeFileName, openFileDialog.FileName);
                    activeTab.fileName = openFileDialog.FileName;
                    activeTab.textBox.Text = File.ReadAllText(openFileDialog.FileName);
                    activeTab.Name = openFileDialog.SafeFileName;
                }
            }
        }

        private int IsFileOpen(string fileName)
        {
            foreach (Tab tab in listOfTabs)
            {
                if (tab.Name == fileName)
                    return listOfTabs.IndexOf(tab);
            }
            return -1;
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
                activeTab.saved = true;
                tabControl.Invalidate();
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

                activeTab.saved = true;
                WindowMenuDisplay();
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

        // ***** more work on this later *****
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
            #region a simple single-use undo
            //// Determine if last operation can be undone in text box.   
            //if (activeTab.textBox.CanUndo == true)
            //{
            //    // Undo the last operation.
            //    activeTab.textBox.Undo();
            //    // Clear the undo buffer to prevent last action from being redone.
            //    activeTab.textBox.ClearUndo();
            //}
            //// Determine if last operation can be undone in text box.
            #endregion
            if (activeTab.undoStack.Count > 1)
            {
                // Save the caret location to put it back where it was.
                int caretLocation = activeTab.textBox.SelectionStart;
                // Undo the last change. The first pop takes out what textBox_TextChanged puts in when undo is performed.
                activeTab.redoStack.Push(activeTab.undoStack.Pop());
                activeTab.textBox.Text = activeTab.undoStack.Pop();
                // Put the caret back where it was. It moves to the last possible location if the saved location no longer exists.
                activeTab.textBox.SelectionStart = caretLocation;
            }
        }

        private void Menu_Redo(object sender, EventArgs e)
        {
            if (activeTab.redoStack.Count > 0)
            {
                // Save the caret location to put it back where it was.
                int caretLocation = activeTab.textBox.SelectionStart;
                // Redo the last change. The first pop pushes text back to undoStack and 2nd pop removes the push done by textChanged event.
                activeTab.undoStack.Push(activeTab.redoStack.Pop());
                activeTab.textBox.Text = activeTab.undoStack.Pop();
                // Put the caret back where it was. It moves to the last possible location if the saved location no longer exists.
                activeTab.textBox.SelectionStart = caretLocation;
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

        private void Menu_Font(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = activeTab.textBox.Font;
            fontDialog.ShowDialog();
            activeTab.textBox.Font = fontDialog.Font;
            //activeTab.lineNumberBox.Font = fontDialog.Font;
            activeTab.lineNumberBox.Font = new Font(fontDialog.Font.Name, fontDialog.Font.Size, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void Menu_StatusBar(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarCheck.Checked;
        }

        private void Menu_About(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void Menu_Close(object sender, EventArgs e)
        {
            if (activeTab.saved ||
                MessageBox.Show("Not saved. Proceed anyway?", "Usaved File Detected",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                listOfTabs.Remove(activeTab);
                tabControl.TabPages.Remove(activeTab);
                WindowMenuDisplay();
                if (listOfTabs.Count == 0)
                    activeTab = CreateNewTab(tabControl, null, null);
            }
        }

        private bool AllSaved(int begin, int end, Tab actTab = null)
        {
            for (int i = begin; i <= end; i++)
            {
                if (!listOfTabs[i].Equals(actTab) && !listOfTabs[i].saved)
                    return false;
            }
            return true;
        }

        private void Menu_CloseAll(object sender, EventArgs e)
        {
            if (AllSaved(0, listOfTabs.Count - 1) ||
                MessageBox.Show("Some files are not saved. Proceed anyway?", "Usaved File Detected",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                listOfTabs.Clear();
                tabControl.TabPages.Clear();
                WindowMenuDisplay();
                activeTab = CreateNewTab(tabControl, null, null);
            }
        }

        private void Menu_CloseAllButActive(object sender, EventArgs e)
        {
            if (AllSaved(0, listOfTabs.Count - 1, activeTab) ||
                MessageBox.Show("Some files are not saved. Proceed anyway?", "Usaved File Detected",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                for (int i = listOfTabs.Count - 1; i >= 0; i--)
                {
                    if (listOfTabs[i] != activeTab)
                    {
                        listOfTabs.Remove(listOfTabs[i]);
                        tabControl.TabPages.RemoveAt(i);
                    }
                }
                WindowMenuDisplay();
            }
        }

        private void Menu_CloseLeft(object sender, EventArgs e)
        {
            int indexOfActiveTab = listOfTabs.IndexOf(activeTab);
            if (AllSaved(0, indexOfActiveTab - 1) ||
                MessageBox.Show("Some files are not saved. Proceed anyway?", "Usaved File Detected",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                for (int i = indexOfActiveTab - 1; i >= 0; i--)
                {
                    listOfTabs.RemoveAt(i);
                    tabControl.TabPages.RemoveAt(i);
                }
                WindowMenuDisplay();
            }
        }

        private void Menu_CloseRight(object sender, EventArgs e)
        {
            int indexOfActiveTab = listOfTabs.IndexOf(activeTab);
            if (AllSaved(indexOfActiveTab + 1, listOfTabs.Count - 1) ||
                MessageBox.Show("Some files are not saved. Proceed anyway?", "Usaved File Detected",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                for (int i = listOfTabs.Count - 1; i > indexOfActiveTab; i--)
                {
                    listOfTabs.RemoveAt(i);
                    tabControl.TabPages.RemoveAt(i);
                }
                WindowMenuDisplay();
            }
        }

        private void Menu_SelectAll(object sender, EventArgs e)
        {
            activeTab.textBox.SelectAll();
        }

        private void Menu_ReadOnly(object sender, EventArgs e)
        {
            activeTab.textBox.ReadOnly = readOnlyCheck.Checked;
        }

        private void TabSelect(int index)
        {
            if (index < listOfTabs.Count && index >= 0)
                tabControl.SelectTab(index);
        }

        private void Menu_Tab1(object sender, EventArgs e)
        {
            TabSelect(0);
        }

        private void Menu_Tab2(object sender, EventArgs e)
        {
            TabSelect(1);
        }

        private void Menu_Tab3(object sender, EventArgs e)
        {
            TabSelect(2);
        }

        private void Menu_Tab4(object sender, EventArgs e)
        {
            TabSelect(3);
        }

        private void Menu_Tab5(object sender, EventArgs e)
        {
            TabSelect(4);
        }

        private void Menu_Tab6(object sender, EventArgs e)
        {
            TabSelect(5);
        }

        private void Menu_Tab7(object sender, EventArgs e)
        {
            TabSelect(6);
        }

        private void Menu_Tab8(object sender, EventArgs e)
        {
            TabSelect(7);
        }

        private void Menu_Tab9(object sender, EventArgs e)
        {
            TabSelect(8);
        }

        private void Menu_NextTab(object sender, EventArgs e)
        {
            TabSelect(listOfTabs.IndexOf(activeTab) + 1);
        }

        private void Menu_PreviousTab(object sender, EventArgs e)
        {
            TabSelect(listOfTabs.IndexOf(activeTab) - 1);
        }

        private void WindowMenuDisplay()
        {
            windowMenu.DropDownItems.Clear();
            foreach (Tab tab in listOfTabs)
                WindowMenuModifier(tab);
        }

        private void WindowMenuModifier(Tab tab)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            if (tab == activeTab)
            {
                item.Checked = true;
                item.CheckState = CheckState.Checked;
            }
            else
            {
                item.Checked = false;
                item.CheckState = CheckState.Unchecked;
            }
            item.CheckOnClick = true;
            item.Name = tab.Name;
            item.Size = new Size(156, 22);
            item.Text = listOfTabs.IndexOf(tab)+1 + ": " + tab.Text + "          ";
            item.Click += new EventHandler(Menu_WindowItems);
            windowMenu.DropDownItems.Add(item);
        }

        private void UpdateWindowMenuItemsChecks()
        {
            ToolStripMenuItem item = (ToolStripMenuItem)windowMenu.DropDownItems[listOfTabs.IndexOf(activeTab)];
            foreach (ToolStripMenuItem tabItem in windowMenu.DropDownItems)
            {
                if (tabItem != item)
                    tabItem.Checked = false;
                else
                    tabItem.Checked = true;
            }
        }

        private void Menu_WindowItems(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem) sender;
            item.Checked = true;
            TabSelect(windowMenu.DropDownItems.IndexOf(item));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size closeButtonSize = new Size(12, 12);
            closeImageAct = new Bitmap(bEdit.Properties.Resources.red_button, closeButtonSize);
            closeImage = new Bitmap(bEdit.Properties.Resources.gray_button, closeButtonSize);

            tabControl.Padding = new Point(30);
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = listOfTabs.Count - 1; i >= 0; i--)
            {
                Rectangle rect = tabControl.GetTabRect(i);
                Rectangle imageRect = new Rectangle(rect.Right - closeImage.Width - 5, rect.Top + (rect.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (imageRect.Contains(e.Location) && 
                    (listOfTabs[i].saved ||
                    MessageBox.Show("Not saved. Proceed anyway?", "Usaved File Detected",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes))
                {
                    activeTabStack.Pop();
                    while (activeTabStack.Count > 0 && !listOfTabs.Contains(activeTabStack.Peek()))
                        activeTabStack.Pop();
                    if (activeTabStack.Count > 0)
                        tabControl.SelectTab(listOfTabs.IndexOf(activeTabStack.Pop()));
                    listOfTabs.RemoveAt(i);
                    tabControl.TabPages.RemoveAt(i);
                    WindowMenuDisplay();
                    if (listOfTabs.Count == 0)
                    {
                        activeTab = CreateNewTab(tabControl, null, null);
                        activeTabStack.Push(activeTab);
                    }
                }
            }
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rect = tabControl.GetTabRect(e.Index);
            Rectangle imageRect = new Rectangle(rect.Right - closeImage.Width - 5, rect.Top + (rect.Height - closeImage.Height) / 2,
                closeImage.Width, closeImage.Height);

            if (!listOfTabs[e.Index].saved)
            {
                Brush tabBrush = Brushes.LightPink;
                e.Graphics.FillRectangle(tabBrush, rect);
            }

            Font font;
            Brush blackBrush = Brushes.Blue;
            Brush grayBrush = Brushes.Gray;
            StringFormat strF = new StringFormat(StringFormat.GenericDefault);

            if (activeTab == tabControl.TabPages[e.Index])
            {
                e.Graphics.DrawImage(closeImageAct, imageRect);
                font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, blackBrush, rect, strF);
            }
            else
            {
                e.Graphics.DrawImage(closeImage, imageRect);
                font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, grayBrush, rect, strF);
            }

        }
    }
}
