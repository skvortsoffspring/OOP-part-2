using System.Resources;
using System.Windows.Forms;

namespace Lab_02_OOP
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
            this.lastName = new System.Windows.Forms.TextBox();
            this.Gro = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.seriesPass = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numbPass = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоТипуВкладаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноРассылкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ShowDataInTree = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.showData = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.term = new System.Windows.Forms.GroupBox();
            this.IndefiniteTerm = new System.Windows.Forms.RadioButton();
            this.longTerm = new System.Windows.Forms.RadioButton();
            this.shortTerm = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.numberScore = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoQuantityObject = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openIcon = new System.Windows.Forms.ToolStripSplitButton();
            this.saveIcon = new System.Windows.Forms.ToolStripButton();
            this.Gro.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.miniToolStrip.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.term.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(9, 19);
            this.lastName.MaxLength = 50;
            this.lastName.Name = "lastName";
            this.lastName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.lastName.Size = new System.Drawing.Size(168, 20);
            this.lastName.TabIndex = 2;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gro
            // 
            this.Gro.Controls.Add(this.groupBox7);
            this.Gro.Controls.Add(this.groupBox6);
            this.Gro.Controls.Add(this.groupBox4);
            this.Gro.Controls.Add(this.groupBox3);
            this.Gro.Controls.Add(this.groupBox2);
            this.Gro.Controls.Add(this.groupBox1);
            this.Gro.Location = new System.Drawing.Point(12, 66);
            this.Gro.Name = "Gro";
            this.Gro.Size = new System.Drawing.Size(602, 135);
            this.Gro.TabIndex = 3;
            this.Gro.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.seriesPass);
            this.groupBox7.Location = new System.Drawing.Point(236, 77);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(152, 52);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Серия паспорта";
            // 
            // seriesPass
            // 
            this.seriesPass.Location = new System.Drawing.Point(12, 19);
            this.seriesPass.MaxLength = 50;
            this.seriesPass.Name = "seriesPass";
            this.seriesPass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.seriesPass.Size = new System.Drawing.Size(128, 20);
            this.seriesPass.TabIndex = 4;
            this.seriesPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numbPass);
            this.groupBox6.Location = new System.Drawing.Point(394, 77);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 52);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Номер паспорта";
            // 
            // numbPass
            // 
            this.numbPass.Location = new System.Drawing.Point(12, 19);
            this.numbPass.MaxLength = 50;
            this.numbPass.Name = "numbPass";
            this.numbPass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.numbPass.Size = new System.Drawing.Size(165, 20);
            this.numbPass.TabIndex = 4;
            this.numbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(16, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 52);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Дата вклада";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.patronymic);
            this.groupBox3.Location = new System.Drawing.Point(394, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 52);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отчество";
            // 
            // patronymic
            // 
            this.patronymic.Location = new System.Drawing.Point(12, 19);
            this.patronymic.MaxLength = 50;
            this.patronymic.Name = "patronymic";
            this.patronymic.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.patronymic.Size = new System.Drawing.Size(165, 20);
            this.patronymic.TabIndex = 4;
            this.patronymic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.firstName);
            this.groupBox2.Location = new System.Drawing.Point(205, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Имя";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(9, 19);
            this.firstName.MaxLength = 50;
            this.firstName.Name = "firstName";
            this.firstName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.firstName.Size = new System.Drawing.Size(162, 20);
            this.firstName.TabIndex = 2;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фамилия";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.операцииToolStripMenuItem, this.aboutToolStripMenuItem});
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.Size = new System.Drawing.Size(161, 24);
            this.miniToolStrip.TabIndex = 5;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.openToolStripMenuItem, this.SaveAsToolStripMenuItem, this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.поискToolStripMenuItem, this.очиститьToolStripMenuItem, this.сортировкаПоДатеToolStripMenuItem, this.сортировкаПоТипуВкладаToolStripMenuItem, this.окноРассылкиToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.операцииToolStripMenuItem.Text = "Меню";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.search_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // сортировкаПоДатеToolStripMenuItem
            // 
            this.сортировкаПоДатеToolStripMenuItem.Name = "сортировкаПоДатеToolStripMenuItem";
            this.сортировкаПоДатеToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сортировкаПоДатеToolStripMenuItem.Text = "Сортировка по дате";
            this.сортировкаПоДатеToolStripMenuItem.Click += new System.EventHandler(this.SortDateToolStripMenuItem_Click);
            // 
            // сортировкаПоТипуВкладаToolStripMenuItem
            // 
            this.сортировкаПоТипуВкладаToolStripMenuItem.Name = "сортировкаПоТипуВкладаToolStripMenuItem";
            this.сортировкаПоТипуВкладаToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сортировкаПоТипуВкладаToolStripMenuItem.Text = "Сортировка по типу вклада";
            this.сортировкаПоТипуВкладаToolStripMenuItem.Click += new System.EventHandler(this.SortTypeDepositToolStripMenuItem_Click);
            // 
            // окноРассылкиToolStripMenuItem
            // 
            this.окноРассылкиToolStripMenuItem.Name = "окноРассылкиToolStripMenuItem";
            this.окноРассылкиToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.окноРассылкиToolStripMenuItem.Text = "Окно рассылки";
            this.окноРассылкиToolStripMenuItem.Click += new System.EventHandler(this.окноРассылкиToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "Автор";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ShowDataInTree);
            this.groupBox5.Controls.Add(this.SaveData);
            this.groupBox5.Controls.Add(this.showData);
            this.groupBox5.Controls.Add(this.search);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.term);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Location = new System.Drawing.Point(13, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(600, 217);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // ShowDataInTree
            // 
            this.ShowDataInTree.Location = new System.Drawing.Point(429, 102);
            this.ShowDataInTree.Name = "ShowDataInTree";
            this.ShowDataInTree.Size = new System.Drawing.Size(141, 31);
            this.ShowDataInTree.TabIndex = 13;
            this.ShowDataInTree.Text = "Дерево";
            this.ShowDataInTree.UseVisualStyleBackColor = true;
            this.ShowDataInTree.Click += new System.EventHandler(this.ShowDataInTree_Click);
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(429, 27);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(141, 31);
            this.SaveData.TabIndex = 0;
            this.SaveData.Text = "Добавить";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(429, 65);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(141, 31);
            this.showData.TabIndex = 1;
            this.showData.Text = "Таблица";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(429, 139);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(141, 31);
            this.search.TabIndex = 12;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(199, 177);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(188, 30);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "интернет банкинг";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(15, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 43);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "подключено оповещение SMS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.balance);
            this.groupBox10.Location = new System.Drawing.Point(15, 77);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(183, 52);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Баланс";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(12, 19);
            this.balance.MaxLength = 50;
            this.balance.Name = "balance";
            this.balance.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.balance.Size = new System.Drawing.Size(165, 20);
            this.balance.TabIndex = 4;
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // term
            // 
            this.term.Controls.Add(this.IndefiniteTerm);
            this.term.Controls.Add(this.longTerm);
            this.term.Controls.Add(this.shortTerm);
            this.term.Location = new System.Drawing.Point(209, 19);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(183, 131);
            this.term.TabIndex = 7;
            this.term.TabStop = false;
            // 
            // IndefiniteTerm
            // 
            this.IndefiniteTerm.Location = new System.Drawing.Point(20, 83);
            this.IndefiniteTerm.Name = "IndefiniteTerm";
            this.IndefiniteTerm.Size = new System.Drawing.Size(141, 24);
            this.IndefiniteTerm.TabIndex = 2;
            this.IndefiniteTerm.TabStop = true;
            this.IndefiniteTerm.Text = "бессрочный";
            this.IndefiniteTerm.UseVisualStyleBackColor = true;
            // 
            // longTerm
            // 
            this.longTerm.Location = new System.Drawing.Point(21, 53);
            this.longTerm.Name = "longTerm";
            this.longTerm.Size = new System.Drawing.Size(141, 24);
            this.longTerm.TabIndex = 1;
            this.longTerm.TabStop = true;
            this.longTerm.Text = "долгосрочный";
            this.longTerm.UseVisualStyleBackColor = true;
            // 
            // shortTerm
            // 
            this.shortTerm.Location = new System.Drawing.Point(20, 23);
            this.shortTerm.Name = "shortTerm";
            this.shortTerm.Size = new System.Drawing.Size(141, 24);
            this.shortTerm.TabIndex = 0;
            this.shortTerm.TabStop = true;
            this.shortTerm.Text = "короткосроный";
            this.shortTerm.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numberScore);
            this.groupBox8.Location = new System.Drawing.Point(15, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(183, 52);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Номер счета";
            // 
            // numberScore
            // 
            this.numberScore.Location = new System.Drawing.Point(9, 19);
            this.numberScore.MaxLength = 50;
            this.numberScore.Name = "numberScore";
            this.numberScore.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.numberScore.Size = new System.Drawing.Size(168, 20);
            this.numberScore.TabIndex = 2;
            this.numberScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.infoQuantityObject, this.dateStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(625, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoQuantityObject
            // 
            this.infoQuantityObject.Name = "infoQuantityObject";
            this.infoQuantityObject.Size = new System.Drawing.Size(88, 17);
            this.infoQuantityObject.Text = "Загрузите XML";
            // 
            // dateStatus
            // 
            this.dateStatus.Name = "dateStatus";
            this.dateStatus.Size = new System.Drawing.Size(32, 17);
            this.dateStatus.Text = "error";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.openIcon, this.saveIcon});
            this.toolStrip1.Location = new System.Drawing.Point(12, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(67, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openIcon
            // 
            this.openIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openIcon.Image = global::Lab_02_OOP.Properties.Resources._23ш4г;
            this.openIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openIcon.Name = "openIcon";
            this.openIcon.Size = new System.Drawing.Size(32, 22);
            this.openIcon.Text = "openIcon";
            this.openIcon.ToolTipText = "openIcon";
            this.openIcon.ButtonClick += new System.EventHandler(this.openIcon_ButtonClick);
            // 
            // saveIcon
            // 
            this.saveIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveIcon.Image = global::Lab_02_OOP.Properties.Resources._1046811;
            this.saveIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveIcon.Name = "saveIcon";
            this.saveIcon.Size = new System.Drawing.Size(23, 22);
            this.saveIcon.Text = "saveIcon";
            this.saveIcon.ToolTipText = "saveIcon";
            this.saveIcon.Click += new System.EventHandler(this.saveIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(625, 462);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Gro);
            this.Controls.Add(this.miniToolStrip);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Gro.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.term.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ShowDataInTree;

        private System.Windows.Forms.ToolStripMenuItem окноРассылкиToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton saveIcon;

        private System.Windows.Forms.ToolStripSplitButton openIcon;

        private System.Windows.Forms.ToolStrip toolStrip1;
        
        private System.Windows.Forms.ToolStripStatusLabel dateStatus;

        public System.Windows.Forms.ToolStripStatusLabel infoQuantityObject;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.ToolStripMenuItem сортировкаПоТипуВкладаToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem сортировкаПоДатеToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;

        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button showData;

        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox numbPass;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox seriesPass;

        private System.Windows.Forms.Button search;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;

        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.GroupBox groupBox10;

        private System.Windows.Forms.RadioButton shortTerm;
        private System.Windows.Forms.RadioButton longTerm;
        private System.Windows.Forms.RadioButton IndefiniteTerm;


        private System.Windows.Forms.TextBox numberScore;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox term;

        private System.Windows.Forms.GroupBox Gro;
        protected System.Windows.Forms.TextBox lastName;

        #endregion
    }
}