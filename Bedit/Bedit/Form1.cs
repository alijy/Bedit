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
        Tab newTab;
        Tab activeTab;

        public Form1()
        {
            InitializeComponent();
            //Control firstTabPage = tabControl.GetControl(0);
            //firstTabPage.Text = "Heloo!";
           // tabPage1
            //TabPage tp = new Tab(tabControl);
            Tab newTab = new Tab(tabControl);
            listOfTabs.Add(newTab);
            tabControl.TabPages.Add(newTab);
            listOfTabs[0].textBox.Text = "hello!\r\n\r\n\r\nbye!";
            //this.ActiveControl = textBox;
            //textBox.SelectionStart = textBox.Text.Length;
            //this.ActiveControl = tabControl.TabPages[0];
            tabControl.SelectTab(1);
            this.ActiveControl = listOfTabs[0].textBox;
            listOfTabs[0].textBox.SelectionStart = listOfTabs[0].textBox.Text.Length;


        }

        // make two copies of this; one with a filename and one without
        // then for open file, use the former.
        private Tab CreateNewTab(TabControl tabControl)
        {
            Tab newTab = new Tab(tabControl);
            activeTab = newTab;
            listOfTabs.Add(newTab);
            tabControl.TabPages.Add(newTab);
            tabControl.SelectTab(newTab.Name);
            this.ActiveControl = newTab.textBox;
            newTab.textBox.SelectionStart = 0;
            return newTab;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Tab tab = CreateNewTab(tabControl);
                tab.fileName = openFileDialog.FileName;
                tab.textBox.Text = File.ReadAllText(openFileDialog.FileName);
                tab.Text = openFileDialog.SafeFileName;
                //tab.textBox.Text += "\r\n\r\n*** " + this.ActiveControl.ToString() + " ***";
                //this.Text = openFileDialog.FileName + " - bEdit";
                //filePath.Text = openFileDialog.FileName;
                //textBox.select ;//(something that shows cursor status)
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            this.Text = activeTab.fileName + " - bEdit";
        }
    }
}
