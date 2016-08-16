using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedit
{
    public partial class Form1 : Form
    {
        List<Tab> listOfTabs = new List<Tab>();

        public Form1()
        {
            InitializeComponent();
            //Control firstTabPage = tabControl.GetControl(0);
            //firstTabPage.Text = "Heloo!";
           // tabPage1
            //TabPage tp = new Tab(tabControl);
            Tab myTab = new Tab(tabControl);
            listOfTabs.Add(myTab);
            tabControl.TabPages.Add(myTab);
            listOfTabs[0].textBox.Text = "hello!\r\n\r\nbye!";
            textBox.Select();
        }
    }
}
