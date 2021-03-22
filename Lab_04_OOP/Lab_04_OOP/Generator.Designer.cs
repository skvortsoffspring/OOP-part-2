using System.ComponentModel;

namespace Lab_02_OOP
{
    partial class Generator
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
            this.QuantityBuilder = new System.Windows.Forms.TextBox();
            this.GenBuilder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GeneratorFactory = new System.Windows.Forms.Button();
            this.QuantityFactory = new System.Windows.Forms.TextBox();
            this.progressBarCreateObject = new System.Windows.Forms.ProgressBar();
            this.resultProgress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuantityBuilder
            // 
            this.QuantityBuilder.Location = new System.Drawing.Point(14, 16);
            this.QuantityBuilder.Name = "QuantityBuilder";
            this.QuantityBuilder.Size = new System.Drawing.Size(149, 20);
            this.QuantityBuilder.TabIndex = 0;
            // 
            // GenBuilder
            // 
            this.GenBuilder.Location = new System.Drawing.Point(14, 55);
            this.GenBuilder.Name = "GenBuilder";
            this.GenBuilder.Size = new System.Drawing.Size(101, 38);
            this.GenBuilder.TabIndex = 1;
            this.GenBuilder.Text = "Генерировать";
            this.GenBuilder.UseVisualStyleBackColor = true;
            this.GenBuilder.Click += new System.EventHandler(this.GenBuilder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenBuilder);
            this.groupBox1.Controls.Add(this.QuantityBuilder);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Строитель";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GeneratorFactory);
            this.groupBox2.Controls.Add(this.QuantityFactory);
            this.groupBox2.Location = new System.Drawing.Point(10, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 99);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фабрика";
            // 
            // GeneratorFactory
            // 
            this.GeneratorFactory.Location = new System.Drawing.Point(14, 55);
            this.GeneratorFactory.Name = "GeneratorFactory";
            this.GeneratorFactory.Size = new System.Drawing.Size(101, 38);
            this.GeneratorFactory.TabIndex = 1;
            this.GeneratorFactory.Text = "Генерировать";
            this.GeneratorFactory.UseVisualStyleBackColor = true;
            this.GeneratorFactory.Click += new System.EventHandler(this.GeneratorFactory_Click);
            // 
            // QuantityFactory
            // 
            this.QuantityFactory.Location = new System.Drawing.Point(14, 16);
            this.QuantityFactory.Name = "QuantityFactory";
            this.QuantityFactory.Size = new System.Drawing.Size(149, 20);
            this.QuantityFactory.TabIndex = 0;
            // 
            // progressBarCreateObject
            // 
            this.progressBarCreateObject.Location = new System.Drawing.Point(10, 263);
            this.progressBarCreateObject.Name = "progressBarCreateObject";
            this.progressBarCreateObject.Size = new System.Drawing.Size(176, 21);
            this.progressBarCreateObject.TabIndex = 4;
            // 
            // resultProgress
            // 
            this.resultProgress.Location = new System.Drawing.Point(10, 238);
            this.resultProgress.Name = "resultProgress";
            this.resultProgress.Size = new System.Drawing.Size(176, 25);
            this.resultProgress.TabIndex = 5;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 285);
            this.Controls.Add(this.resultProgress);
            this.Controls.Add(this.progressBarCreateObject);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Generator";
            this.Text = "Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label resultProgress;

        private System.Windows.Forms.ProgressBar progressBarCreateObject;

        private System.Windows.Forms.Button GeneratorFactory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox QuantityFactory;

        private System.Windows.Forms.Button GenBuilder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox QuantityBuilder;

        #endregion
    }
}