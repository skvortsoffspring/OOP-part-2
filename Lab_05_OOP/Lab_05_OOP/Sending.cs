using System;
using System.Windows.Forms;

namespace Lab_02_OOP
{
    public partial class Sending : Form
    {
        public Sending()
        {
            InitializeComponent();
        }

        public string MessageNormal
        {
            get => messageNormal.Text;
            set => messageNormal.Text = value;
        }

        public string MessageVip
        {
            get => messageVip.Text;
            set => messageVip.Text = value;
        }

        public string OutBox1
        {
            get => OutBox.Text;
            set => OutBox.Text = value;
        }

        private void разослатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.Scores.Count == 0) return;
            foreach (var score in Form1.Scores)
            {
                score.SendEmail();
            }
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            foreach (var score in Form1.Scores)
            {
                score.SendEmail();
                score.SendSms();
            }

            
        }
    }
}