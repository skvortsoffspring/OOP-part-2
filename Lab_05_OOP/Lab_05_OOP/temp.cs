// using System.ComponentModel;
//
// namespace Lab_02_OOP
// {
//     partial class Founding
//     {
//         /// <summary>
//         /// Required designer variable.
//         /// </summary>
//         private IContainer components = null;
//
//         /// <summary>
//         /// Clean up any resources being used.
//         /// </summary>
//         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//         protected override void Dispose(bool disposing)
//         {
//             if (disposing && (components != null))
//             {
//                 components.Dispose();
//             }
//
//             base.Dispose(disposing);
//         }
//
//         #region Windows Form Designer generated code
//
//         private void InitializeComponent()
// {
//     this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//     this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//     this.DateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//     this.TypeDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//     this.SaveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//     this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
//     this.seriesPassport = new System.Windows.Forms.ComboBox();
//     this.buttonFound = new System.Windows.Forms.Button();
//     this.fieldFound = new System.Windows.Forms.MaskedTextBox();
//     this.FoundForHB = new System.Windows.Forms.RadioButton();
//     this.FoondForPassport = new System.Windows.Forms.RadioButton();
//     this.FoundForName = new System.Windows.Forms.RadioButton();
//     this.treeOutSearch = new System.Windows.Forms.TreeView();
//     this.groupBox1 = new System.Windows.Forms.GroupBox();
//     this.foundBetterPosition = new System.Windows.Forms.RadioButton();
//     this.ButtonFoundSecond = new System.Windows.Forms.Button();
//     this.fieldTwoForFound = new System.Windows.Forms.MaskedTextBox();
//     this.radioRepeatLatter = new System.Windows.Forms.RadioButton();
//     this.radioEndingLastName = new System.Windows.Forms.RadioButton();
//     this.radioFirstLatter = new System.Windows.Forms.RadioButton();
//     this.buttonClearTree = new System.Windows.Forms.Button();
//     this.menuStrip1.SuspendLayout();
//     this.GroupBoxSearch.SuspendLayout();
//     this.groupBox1.SuspendLayout();
//     this.SuspendLayout();
//     // 
//     // menuStrip1
//     // 
//     this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.sortToolStripMenuItem, this.SaveResultToolStripMenuItem});
//     this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//     this.menuStrip1.Name = "menuStrip1";
//     this.menuStrip1.Size = new System.Drawing.Size(363, 24);
//     this.menuStrip1.TabIndex = 0;
//     // 
//     // sortToolStripMenuItem
//     // 
//     this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.DateToolStripMenuItem, this.TypeDepositToolStripMenuItem});
//     this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
//     this.sortToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
//     this.sortToolStripMenuItem.Text = "Сортировка";
//     // 
//     // DateToolStripMenuItem
//     // 
//     this.DateToolStripMenuItem.Name = "DateToolStripMenuItem";
//     this.DateToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
//     this.DateToolStripMenuItem.Text = "По дате";
//     this.DateToolStripMenuItem.Click += new System.EventHandler(this.DateToolStripMenuItem_Click);
//     // 
//     // TypeDepositToolStripMenuItem
//     // 
//     this.TypeDepositToolStripMenuItem.Name = "TypeDepositToolStripMenuItem";
//     this.TypeDepositToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
//     this.TypeDepositToolStripMenuItem.Text = "По типу вклада";
//     this.TypeDepositToolStripMenuItem.Click += new System.EventHandler(this.TypeDepositToolStripMenuItem_Click);
//     // 
//     // SaveResultToolStripMenuItem
//     // 
//     this.SaveResultToolStripMenuItem.Name = "SaveResultToolStripMenuItem";
//     this.SaveResultToolStripMenuItem.Size = new System.Drawing.Size(185, 20);
//     this.SaveResultToolStripMenuItem.Text = "Сохранить результаты поиска";
//     this.SaveResultToolStripMenuItem.Click += new System.EventHandler(this.SaveResultToolStripMenuItem_Click);
//     // 
//     // GroupBoxSearch
//     // 
//     this.GroupBoxSearch.Controls.Add(this.seriesPassport);
//     this.GroupBoxSearch.Controls.Add(this.buttonFound);
//     this.GroupBoxSearch.Controls.Add(this.fieldFound);
//     this.GroupBoxSearch.Controls.Add(this.FoundForHB);
//     this.GroupBoxSearch.Controls.Add(this.FoondForPassport);
//     this.GroupBoxSearch.Controls.Add(this.FoundForName);
//     this.GroupBoxSearch.Location = new System.Drawing.Point(16, 35);
//     this.GroupBoxSearch.Name = "GroupBoxSearch";
//     this.GroupBoxSearch.Size = new System.Drawing.Size(337, 135);
//     this.GroupBoxSearch.TabIndex = 1;
//     this.GroupBoxSearch.TabStop = false;
//     // 
//     // seriesPassport
//     // 
//     this.seriesPassport.FormattingEnabled = true;
//     this.seriesPassport.Items.AddRange(new object[] {"AB", "BM", "HB", "KH", "MP", "MC", "KB", "PP", "SP", "DP"});
//     this.seriesPassport.Location = new System.Drawing.Point(8, 98);
//     this.seriesPassport.Name = "seriesPassport";
//     this.seriesPassport.Size = new System.Drawing.Size(44, 21);
//     this.seriesPassport.TabIndex = 5;
//     this.seriesPassport.Visible = false;
//     // 
//     // buttonFound
//     // 
//     this.buttonFound.Location = new System.Drawing.Point(212, 73);
//     this.buttonFound.Name = "buttonFound";
//     this.buttonFound.Size = new System.Drawing.Size(119, 50);
//     this.buttonFound.TabIndex = 4;
//     this.buttonFound.Text = "ИСКАТЬ";
//     this.buttonFound.UseVisualStyleBackColor = true;
//     this.buttonFound.Click += new System.EventHandler(this.buttonFound_Click);
//     // 
//     // fieldFound
//     // 
//     this.fieldFound.Location = new System.Drawing.Point(58, 100);
//     this.fieldFound.Name = "fieldFound";
//     this.fieldFound.Size = new System.Drawing.Size(140, 20);
//     this.fieldFound.TabIndex = 3;
//     this.fieldFound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fieldFound_MaskInputKeyPress);
//     // 
//     // FoundForHB
//     // 
//     this.FoundForHB.Location = new System.Drawing.Point(14, 73);
//     this.FoundForHB.Name = "FoundForHB";
//     this.FoundForHB.Size = new System.Drawing.Size(175, 21);
//     this.FoundForHB.TabIndex = 2;
//     this.FoundForHB.TabStop = true;
//     this.FoundForHB.Text = "Поиск по дате рождения";
//     this.FoundForHB.UseVisualStyleBackColor = true;
//     this.FoundForHB.CheckedChanged += new System.EventHandler(this.FoundForOrder_CheckedChanged);
//     // 
//     // FoondForPassport
//     // 
//     this.FoondForPassport.Location = new System.Drawing.Point(14, 46);
//     this.FoondForPassport.Name = "FoondForPassport";
//     this.FoondForPassport.Size = new System.Drawing.Size(185, 21);
//     this.FoondForPassport.TabIndex = 1;
//     this.FoondForPassport.TabStop = true;
//     this.FoondForPassport.Text = "Поиск по паспортным данным";
//     this.FoondForPassport.UseVisualStyleBackColor = true;
//     this.FoondForPassport.CheckedChanged += new System.EventHandler(this.FoondForPassport_CheckedChanged);
//     // 
//     // FoundForName
//     // 
//     this.FoundForName.Location = new System.Drawing.Point(14, 19);
//     this.FoundForName.Name = "FoundForName";
//     this.FoundForName.Size = new System.Drawing.Size(142, 21);
//     this.FoundForName.TabIndex = 0;
//     this.FoundForName.TabStop = true;
//     this.FoundForName.Text = "Поиск по фамилии  ";
//     this.FoundForName.UseVisualStyleBackColor = true;
//     this.FoundForName.CheckedChanged += new System.EventHandler(this.FoundForName_CheckedChanged);
//     // 
//     // treeOutSearch
//     // 
//     this.treeOutSearch.LineColor = System.Drawing.Color.Empty;
//     this.treeOutSearch.Location = new System.Drawing.Point(0, 350);
//     this.treeOutSearch.Name = "treeOutSearch";
//     this.treeOutSearch.Size = new System.Drawing.Size(363, 162);
//     this.treeOutSearch.TabIndex = 2;
//     // 
//     // groupBox1
//     // 
//     this.groupBox1.Controls.Add(this.foundBetterPosition);
//     this.groupBox1.Controls.Add(this.ButtonFoundSecond);
//     this.groupBox1.Controls.Add(this.fieldTwoForFound);
//     this.groupBox1.Controls.Add(this.radioRepeatLatter);
//     this.groupBox1.Controls.Add(this.radioEndingLastName);
//     this.groupBox1.Controls.Add(this.radioFirstLatter);
//     this.groupBox1.Location = new System.Drawing.Point(16, 179);
//     this.groupBox1.Name = "groupBox1";
//     this.groupBox1.Size = new System.Drawing.Size(336, 165);
//     this.groupBox1.TabIndex = 3;
//     this.groupBox1.TabStop = false;
//     // 
//     // foundBetterPosition
//     // 
//     this.foundBetterPosition.Location = new System.Drawing.Point(14, 107);
//     this.foundBetterPosition.Name = "foundBetterPosition";
//     this.foundBetterPosition.Size = new System.Drawing.Size(191, 23);
//     this.foundBetterPosition.TabIndex = 6;
//     this.foundBetterPosition.TabStop = true;
//     this.foundBetterPosition.Text = "Поиск буквы в определенной позиции\r\n";
//     this.foundBetterPosition.UseVisualStyleBackColor = true;
//     this.foundBetterPosition.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
//     // 
//     // ButtonFoundSecond
//     // 
//     this.ButtonFoundSecond.Location = new System.Drawing.Point(211, 107);
//     this.ButtonFoundSecond.Name = "ButtonFoundSecond";
//     this.ButtonFoundSecond.Size = new System.Drawing.Size(119, 50);
//     this.ButtonFoundSecond.TabIndex = 5;
//     this.ButtonFoundSecond.Text = "ИСКАТЬ";
//     this.ButtonFoundSecond.UseVisualStyleBackColor = true;
//     this.ButtonFoundSecond.Click += new System.EventHandler(this.ButtonFoundSecond_Click);
//     // 
//     // fieldTwoForFound
//     // 
//     this.fieldTwoForFound.Location = new System.Drawing.Point(16, 136);
//     this.fieldTwoForFound.Name = "fieldTwoForFound";
//     this.fieldTwoForFound.Size = new System.Drawing.Size(140, 20);
//     this.fieldTwoForFound.TabIndex = 4;
//     this.fieldTwoForFound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fieldTwoForFound_MaskInputPressKey);
//     // 
//     // radioRepeatLatter
//     // 
//     this.radioRepeatLatter.Location = new System.Drawing.Point(12, 78);
//     this.radioRepeatLatter.Name = "radioRepeatLatter";
//     this.radioRepeatLatter.Size = new System.Drawing.Size(209, 23);
//     this.radioRepeatLatter.TabIndex = 2;
//     this.radioRepeatLatter.TabStop = true;
//     this.radioRepeatLatter.Text = "Поиск по длине слова";
//     this.radioRepeatLatter.UseVisualStyleBackColor = true;
//     this.radioRepeatLatter.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
//     // 
//     // radioEndingLastName
//     // 
//     this.radioEndingLastName.Location = new System.Drawing.Point(12, 49);
//     this.radioEndingLastName.Name = "radioEndingLastName";
//     this.radioEndingLastName.Size = new System.Drawing.Size(185, 23);
//     this.radioEndingLastName.TabIndex = 1;
//     this.radioEndingLastName.TabStop = true;
//     this.radioEndingLastName.Text = "Поик по окончанию фамилии";
//     this.radioEndingLastName.UseVisualStyleBackColor = true;
//     this.radioEndingLastName.CheckedChanged += new System.EventHandler(this.endingLastName_CheckedChanged);
//     // 
//     // radioFirstLatter
//     // 
//     this.radioFirstLatter.Location = new System.Drawing.Point(12, 20);
//     this.radioFirstLatter.Name = "radioFirstLatter";
//     this.radioFirstLatter.Size = new System.Drawing.Size(185, 23);
//     this.radioFirstLatter.TabIndex = 0;
//     this.radioFirstLatter.TabStop = true;
//     this.radioFirstLatter.Text = "Поик по первой букве";
//     this.radioFirstLatter.UseVisualStyleBackColor = true;
//     this.radioFirstLatter.CheckedChanged += new System.EventHandler(this.radioFirstLatter_CheckedChanged);
//     // 
//     // buttonClearTree
//     // 
//     this.buttonClearTree.Location = new System.Drawing.Point(301, 350);
//     this.buttonClearTree.Name = "buttonClearTree";
//     this.buttonClearTree.Size = new System.Drawing.Size(62, 30);
//     this.buttonClearTree.TabIndex = 4;
//     this.buttonClearTree.Text = "Очистить";
//     this.buttonClearTree.UseVisualStyleBackColor = true;
//     this.buttonClearTree.Click += new System.EventHandler(this.buttonClearTree_Click);
//     // 
//     // WindowSearch
//     // 
//
//     this.Controls.Add(this.buttonClearTree);
//     this.Controls.Add(this.groupBox1);
//     this.Controls.Add(this.treeOutSearch);
//     this.Controls.Add(this.GroupBoxSearch);
//     this.Controls.Add(this.menuStrip1);
//     this.MainMenuStrip = this.menuStrip1;
//     this.Name = "Founding";
//     this.menuStrip1.ResumeLayout(false);
//     this.menuStrip1.PerformLayout();
//     this.GroupBoxSearch.ResumeLayout(false);
//     this.GroupBoxSearch.PerformLayout();
//     this.groupBox1.ResumeLayout(false);
//     this.groupBox1.PerformLayout();
//     this.ResumeLayout(false);
//     this.PerformLayout();
// }
//
//         private System.Windows.Forms.RadioButton foundBetterPosition;
//
//         private System.Windows.Forms.Button buttonClearTree;
//         private System.Windows.Forms.Button ButtonFoundSecond;
//         private System.Windows.Forms.MaskedTextBox fieldTwoForFound;
//         private System.Windows.Forms.RadioButton radioEndingLastName;
//         private System.Windows.Forms.RadioButton radioRepeatLatter;
//
//         private System.Windows.Forms.RadioButton radioFirstLatter;
//
//         private System.Windows.Forms.GroupBox groupBox1;
//
//         private System.Windows.Forms.ComboBox seriesPassport;
//
//         private System.Windows.Forms.Button buttonFound;
//
//         private System.Windows.Forms.MaskedTextBox fieldFound;
//
//         private System.Windows.Forms.TreeView treeOutSearch;
//
//         private System.Windows.Forms.RadioButton FoundForName;
//         private System.Windows.Forms.GroupBox GroupBoxSearch;
//         private System.Windows.Forms.RadioButton FoondForPassport;
//         private System.Windows.Forms.RadioButton FoundForHB;
//
//         private System.Windows.Forms.ToolStripMenuItem DateToolStripMenuItem;
//
//         private System.Windows.Forms.ToolStripMenuItem SaveResultToolStripMenuItem;
//
//         private System.Windows.Forms.ToolStripMenuItem TypeDepositToolStripMenuItem;
//
//         private System.Windows.Forms.MenuStrip menuStrip1;
//         
//         private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
//
//         #endregion
//     }
// }