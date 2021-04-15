using System.ComponentModel;

namespace Lab_02_OOP
{
    partial class TreeOutput
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
            this.TreeOutputData = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // TreeOutputData
            // 
            this.TreeOutputData.Location = new System.Drawing.Point(0, -1);
            this.TreeOutputData.Name = "TreeOutputData";
            this.TreeOutputData.Size = new System.Drawing.Size(348, 451);
            this.TreeOutputData.TabIndex = 0;
            // 
            // TreeOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.TreeOutputData);
            this.Name = "TreeOutput";
            this.Text = "TreeOutput";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView TreeOutputData;

        #endregion
    }
}