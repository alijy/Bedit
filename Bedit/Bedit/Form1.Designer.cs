namespace Bedit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMoreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllButToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToTheLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToTheRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.indentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseLineIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseLineIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.readOnlyCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tabMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thTabToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thTabToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thTabToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.thTabToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.thTabToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.nextTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.typeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lengthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lineLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lnLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu,
            this.viewMenu,
            this.windowMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.TabStop = true;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.saveMenu,
            this.saveAsMenu,
            this.closeMenu,
            this.closeAllMenu,
            this.closeMoreMenu,
            this.toolStripSeparator1,
            this.pageSetupMenu,
            this.printMenu,
            this.toolStripSeparator2,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenu.Size = new System.Drawing.Size(199, 22);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.Menu_New);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenu.Size = new System.Drawing.Size(199, 22);
            this.openMenu.Text = "Open...";
            this.openMenu.Click += new System.EventHandler(this.Menu_Open);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenu.Size = new System.Drawing.Size(199, 22);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.Menu_Save);
            // 
            // saveAsMenu
            // 
            this.saveAsMenu.Name = "saveAsMenu";
            this.saveAsMenu.Size = new System.Drawing.Size(199, 22);
            this.saveAsMenu.Text = "Save As...";
            this.saveAsMenu.Click += new System.EventHandler(this.Menu_SaveAs);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeMenu.Size = new System.Drawing.Size(199, 22);
            this.closeMenu.Text = "Close";
            this.closeMenu.Click += new System.EventHandler(this.Menu_Close);
            // 
            // closeAllMenu
            // 
            this.closeAllMenu.Name = "closeAllMenu";
            this.closeAllMenu.Size = new System.Drawing.Size(199, 22);
            this.closeAllMenu.Text = "Close All";
            this.closeAllMenu.Click += new System.EventHandler(this.Menu_CloseAll);
            // 
            // closeMoreMenu
            // 
            this.closeMoreMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllButToolStripMenuItem,
            this.closeAllToTheLeftToolStripMenuItem,
            this.closeAllToTheRightToolStripMenuItem});
            this.closeMoreMenu.Name = "closeMoreMenu";
            this.closeMoreMenu.Size = new System.Drawing.Size(199, 22);
            this.closeMoreMenu.Text = "Close More";
            // 
            // closeAllButToolStripMenuItem
            // 
            this.closeAllButToolStripMenuItem.Name = "closeAllButToolStripMenuItem";
            this.closeAllButToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.closeAllButToolStripMenuItem.Text = "Close All but Active Document";
            this.closeAllButToolStripMenuItem.Click += new System.EventHandler(this.Menu_CloseAllButActive);
            // 
            // closeAllToTheLeftToolStripMenuItem
            // 
            this.closeAllToTheLeftToolStripMenuItem.Name = "closeAllToTheLeftToolStripMenuItem";
            this.closeAllToTheLeftToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.closeAllToTheLeftToolStripMenuItem.Text = "Close All to the Left";
            this.closeAllToTheLeftToolStripMenuItem.Click += new System.EventHandler(this.Menu_CloseLeft);
            // 
            // closeAllToTheRightToolStripMenuItem
            // 
            this.closeAllToTheRightToolStripMenuItem.Name = "closeAllToTheRightToolStripMenuItem";
            this.closeAllToTheRightToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.closeAllToTheRightToolStripMenuItem.Text = "Close All to the Right";
            this.closeAllToTheRightToolStripMenuItem.Click += new System.EventHandler(this.Menu_CloseRight);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // pageSetupMenu
            // 
            this.pageSetupMenu.Name = "pageSetupMenu";
            this.pageSetupMenu.ShortcutKeyDisplayString = "";
            this.pageSetupMenu.Size = new System.Drawing.Size(199, 22);
            this.pageSetupMenu.Text = "Page Setup...                   ";
            this.pageSetupMenu.Click += new System.EventHandler(this.Menu_PageSetup);
            // 
            // printMenu
            // 
            this.printMenu.Name = "printMenu";
            this.printMenu.ShortcutKeyDisplayString = "";
            this.printMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printMenu.Size = new System.Drawing.Size(199, 22);
            this.printMenu.Text = "Print...";
            this.printMenu.Click += new System.EventHandler(this.Menu_Print);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(199, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.Menu_Exit);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenu,
            this.redoMenu,
            this.toolStripSeparator3,
            this.cutMenu,
            this.copyMenu,
            this.pasteMenu,
            this.deleteMenu,
            this.selectAllMenu,
            this.toolStripSeparator4,
            this.indentMenu,
            this.toolStripSeparator6,
            this.readOnlyCheck});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // undoMenu
            // 
            this.undoMenu.Name = "undoMenu";
            this.undoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenu.Size = new System.Drawing.Size(198, 22);
            this.undoMenu.Text = "Undo                  ";
            this.undoMenu.Click += new System.EventHandler(this.Menu_Undo);
            // 
            // redoMenu
            // 
            this.redoMenu.Name = "redoMenu";
            this.redoMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenu.Size = new System.Drawing.Size(198, 22);
            this.redoMenu.Text = "Redo";
            this.redoMenu.Click += new System.EventHandler(this.Menu_Redo);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // cutMenu
            // 
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenu.Size = new System.Drawing.Size(198, 22);
            this.cutMenu.Text = "Cut";
            this.cutMenu.Click += new System.EventHandler(this.Menu_Cut);
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenu.Size = new System.Drawing.Size(198, 22);
            this.copyMenu.Text = "Copy";
            this.copyMenu.Click += new System.EventHandler(this.Menu_Copy);
            // 
            // pasteMenu
            // 
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenu.Size = new System.Drawing.Size(198, 22);
            this.pasteMenu.Text = "Paste";
            this.pasteMenu.Click += new System.EventHandler(this.Menu_Paste);
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMenu.Size = new System.Drawing.Size(198, 22);
            this.deleteMenu.Text = "Delete";
            this.deleteMenu.Click += new System.EventHandler(this.Menu_Delete);
            // 
            // selectAllMenu
            // 
            this.selectAllMenu.Name = "selectAllMenu";
            this.selectAllMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenu.Size = new System.Drawing.Size(198, 22);
            this.selectAllMenu.Text = "Select All";
            this.selectAllMenu.Click += new System.EventHandler(this.Menu_SelectAll);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // indentMenu
            // 
            this.indentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseLineIndentToolStripMenuItem,
            this.decreaseLineIndentToolStripMenuItem});
            this.indentMenu.Enabled = false;
            this.indentMenu.Name = "indentMenu";
            this.indentMenu.Size = new System.Drawing.Size(198, 22);
            this.indentMenu.Text = "Indent";
            // 
            // increaseLineIndentToolStripMenuItem
            // 
            this.increaseLineIndentToolStripMenuItem.Name = "increaseLineIndentToolStripMenuItem";
            this.increaseLineIndentToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.increaseLineIndentToolStripMenuItem.Text = "Increase Line Indent";
            // 
            // decreaseLineIndentToolStripMenuItem
            // 
            this.decreaseLineIndentToolStripMenuItem.Name = "decreaseLineIndentToolStripMenuItem";
            this.decreaseLineIndentToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.decreaseLineIndentToolStripMenuItem.Text = "Decrease Line Indent";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(195, 6);
            // 
            // readOnlyCheck
            // 
            this.readOnlyCheck.CheckOnClick = true;
            this.readOnlyCheck.Name = "readOnlyCheck";
            this.readOnlyCheck.Size = new System.Drawing.Size(198, 22);
            this.readOnlyCheck.Text = "Set Read-Only";
            this.readOnlyCheck.Click += new System.EventHandler(this.Menu_ReadOnly);
            // 
            // formatMenu
            // 
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenu});
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(57, 20);
            this.formatMenu.Text = "Format";
            // 
            // fontMenu
            // 
            this.fontMenu.Name = "fontMenu";
            this.fontMenu.Size = new System.Drawing.Size(137, 22);
            this.fontMenu.Text = "Font...          ";
            this.fontMenu.Click += new System.EventHandler(this.Menu_Font);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarCheck,
            this.toolStripSeparator7,
            this.tabMenu});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "View";
            // 
            // statusBarCheck
            // 
            this.statusBarCheck.Checked = true;
            this.statusBarCheck.CheckOnClick = true;
            this.statusBarCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarCheck.Name = "statusBarCheck";
            this.statusBarCheck.Size = new System.Drawing.Size(156, 22);
            this.statusBarCheck.Text = "Status Bar          ";
            this.statusBarCheck.Click += new System.EventHandler(this.Menu_StatusBar);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(153, 6);
            // 
            // tabMenu
            // 
            this.tabMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stTabToolStripMenuItem,
            this.ndTabToolStripMenuItem,
            this.rdTabToolStripMenuItem,
            this.thTabToolStripMenuItem,
            this.thTabToolStripMenuItem1,
            this.thTabToolStripMenuItem2,
            this.thTabToolStripMenuItem3,
            this.thTabToolStripMenuItem4,
            this.thTabToolStripMenuItem5,
            this.toolStripSeparator8,
            this.nextTabToolStripMenuItem,
            this.previousTabToolStripMenuItem});
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(156, 22);
            this.tabMenu.Text = "Tab";
            // 
            // stTabToolStripMenuItem
            // 
            this.stTabToolStripMenuItem.Name = "stTabToolStripMenuItem";
            this.stTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.stTabToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.stTabToolStripMenuItem.Text = "1st Tab";
            this.stTabToolStripMenuItem.Click += new System.EventHandler(this.Menu_Tab1);
            // 
            // ndTabToolStripMenuItem
            // 
            this.ndTabToolStripMenuItem.Name = "ndTabToolStripMenuItem";
            this.ndTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.ndTabToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ndTabToolStripMenuItem.Text = "2nd Tab";
            this.ndTabToolStripMenuItem.Click += new System.EventHandler(this.Menu_Tab2);
            // 
            // rdTabToolStripMenuItem
            // 
            this.rdTabToolStripMenuItem.Name = "rdTabToolStripMenuItem";
            this.rdTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.rdTabToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.rdTabToolStripMenuItem.Text = "3rd Tab";
            this.rdTabToolStripMenuItem.Click += new System.EventHandler(this.Menu_Tab3);
            // 
            // thTabToolStripMenuItem
            // 
            this.thTabToolStripMenuItem.Name = "thTabToolStripMenuItem";
            this.thTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.thTabToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.thTabToolStripMenuItem.Text = "4th Tab";
            this.thTabToolStripMenuItem.Click += new System.EventHandler(this.Menu_Tab4);
            // 
            // thTabToolStripMenuItem1
            // 
            this.thTabToolStripMenuItem1.Name = "thTabToolStripMenuItem1";
            this.thTabToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.thTabToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.thTabToolStripMenuItem1.Text = "5th Tab";
            this.thTabToolStripMenuItem1.Click += new System.EventHandler(this.Menu_Tab5);
            // 
            // thTabToolStripMenuItem2
            // 
            this.thTabToolStripMenuItem2.Name = "thTabToolStripMenuItem2";
            this.thTabToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.thTabToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.thTabToolStripMenuItem2.Text = "6th Tab";
            this.thTabToolStripMenuItem2.Click += new System.EventHandler(this.Menu_Tab6);
            // 
            // thTabToolStripMenuItem3
            // 
            this.thTabToolStripMenuItem3.Name = "thTabToolStripMenuItem3";
            this.thTabToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.thTabToolStripMenuItem3.Size = new System.Drawing.Size(196, 22);
            this.thTabToolStripMenuItem3.Text = "7th Tab";
            this.thTabToolStripMenuItem3.Click += new System.EventHandler(this.Menu_Tab7);
            // 
            // thTabToolStripMenuItem4
            // 
            this.thTabToolStripMenuItem4.Name = "thTabToolStripMenuItem4";
            this.thTabToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.thTabToolStripMenuItem4.Size = new System.Drawing.Size(196, 22);
            this.thTabToolStripMenuItem4.Text = "8th Tab";
            this.thTabToolStripMenuItem4.Click += new System.EventHandler(this.Menu_Tab8);
            // 
            // thTabToolStripMenuItem5
            // 
            this.thTabToolStripMenuItem5.Name = "thTabToolStripMenuItem5";
            this.thTabToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.thTabToolStripMenuItem5.Size = new System.Drawing.Size(196, 22);
            this.thTabToolStripMenuItem5.Text = "9th Tab";
            this.thTabToolStripMenuItem5.Click += new System.EventHandler(this.Menu_Tab9);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(193, 6);
            // 
            // nextTabToolStripMenuItem
            // 
            this.nextTabToolStripMenuItem.Name = "nextTabToolStripMenuItem";
            this.nextTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.nextTabToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nextTabToolStripMenuItem.Text = "Next Tab";
            this.nextTabToolStripMenuItem.Click += new System.EventHandler(this.Menu_NextTab);
            // 
            // previousTabToolStripMenuItem
            // 
            this.previousTabToolStripMenuItem.Name = "previousTabToolStripMenuItem";
            this.previousTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.previousTabToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.previousTabToolStripMenuItem.Text = "Previous Tab";
            this.previousTabToolStripMenuItem.Click += new System.EventHandler(this.Menu_PreviousTab);
            // 
            // windowMenu
            // 
            this.windowMenu.Name = "windowMenu";
            this.windowMenu.Size = new System.Drawing.Size(63, 20);
            this.windowMenu.Text = "Window";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpMenu,
            this.toolStripSeparator5,
            this.aboutBEditMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // viewHelpMenu
            // 
            this.viewHelpMenu.Enabled = false;
            this.viewHelpMenu.Name = "viewHelpMenu";
            this.viewHelpMenu.Size = new System.Drawing.Size(167, 22);
            this.viewHelpMenu.Text = "View Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // aboutBEditMenu
            // 
            this.aboutBEditMenu.Name = "aboutBEditMenu";
            this.aboutBEditMenu.Size = new System.Drawing.Size(167, 22);
            this.aboutBEditMenu.Text = "About bEdit          ";
            this.aboutBEditMenu.Click += new System.EventHandler(this.Menu_About);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeLabel,
            this.lengthLabel,
            this.lineLabel,
            this.lnLabel,
            this.colLabel,
            this.selLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = false;
            this.typeLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.typeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.typeLabel.Enabled = false;
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(200, 19);
            this.typeLabel.Text = "Normal text file";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = false;
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(90, 19);
            this.lengthLabel.Text = "Length : 0";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = false;
            this.lineLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lineLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(90, 19);
            this.lineLabel.Text = "Line : 1";
            this.lineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = false;
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(60, 19);
            this.lnLabel.Text = "Ln : 1";
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = false;
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(60, 19);
            this.colLabel.Text = "Col : 1";
            this.colLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selLabel
            // 
            this.selLabel.AutoSize = false;
            this.selLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.selLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.selLabel.Name = "selLabel";
            this.selLabel.Size = new System.Drawing.Size(90, 19);
            this.selLabel.Text = "Sel : 0 | 0";
            this.selLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 513);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "bEdit";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageSetupMenu;
        private System.Windows.Forms.ToolStripMenuItem printMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem undoMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fontMenu;
        private System.Windows.Forms.ToolStripMenuItem statusBarCheck;
        private System.Windows.Forms.ToolStripMenuItem viewHelpMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutBEditMenu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel typeLabel;
        private System.Windows.Forms.ToolStripStatusLabel lineLabel;
        private System.Windows.Forms.ToolStripStatusLabel selLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripStatusLabel lengthLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lnLabel;
        private System.Windows.Forms.ToolStripStatusLabel colLabel;
        private System.Windows.Forms.ToolStripMenuItem redoMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMoreMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllButToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToTheLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToTheRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenu;
        private System.Windows.Forms.ToolStripMenuItem indentMenu;
        private System.Windows.Forms.ToolStripMenuItem increaseLineIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseLineIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem readOnlyCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tabMenu;
        private System.Windows.Forms.ToolStripMenuItem stTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rdTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thTabToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thTabToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thTabToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem thTabToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem thTabToolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem nextTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowMenu;
    }
}

