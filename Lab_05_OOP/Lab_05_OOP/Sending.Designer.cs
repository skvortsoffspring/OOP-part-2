using System.ComponentModel;

namespace Lab_02_OOP
{
    public partial class Sending
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.messageNormal = new System.Windows.Forms.TextBox();
            this.messageVip = new System.Windows.Forms.TextBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageNormal
            // 
            this.messageNormal.AcceptsReturn = true;
            this.messageNormal.AcceptsTab = true;
            this.messageNormal.AllowDrop = true;
            this.messageNormal.Location = new System.Drawing.Point(9, 12);
            this.messageNormal.Name = "messageNormal";
            this.messageNormal.Size = new System.Drawing.Size(205, 20);
            this.messageNormal.TabIndex = 0;
            // 
            // messageVip
            // 
            this.messageVip.Location = new System.Drawing.Point(4, 12);
            this.messageVip.Name = "messageVip";
            this.messageVip.Size = new System.Drawing.Size(205, 20);
            this.messageVip.TabIndex = 1;
            // 
            // OutBox
            // 
            this.OutBox.Location = new System.Drawing.Point(14, 164);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutBox.Size = new System.Drawing.Size(218, 201);
            this.OutBox.TabIndex = 2;
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(14, 116);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(141, 32);
            this.SendMessage.TabIndex = 3;
            this.SendMessage.Text = "Сделать рассылку";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messageNormal);
            this.groupBox1.Location = new System.Drawing.Point(5, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сообщение для VIP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageVip);
            this.groupBox2.Location = new System.Drawing.Point(5, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сообщение для остальных";
            // 
            // Sending
            // 
            this.ClientSize = new System.Drawing.Size(233, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.OutBox);
            this.Name = "Sending";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Button SendMessage;

        private System.Windows.Forms.TextBox messageNormal;
        public System.Windows.Forms.TextBox messageVip;
        public System.Windows.Forms.TextBox OutBox;

        #endregion
        
    }
}