using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Lab_02_OOP.Properties;

namespace Lab_02_OOP
{
    public partial class Form1 : Form
    {
        public static List<Score> Scores = new List<Score>();
    public Form1()
        {
            InitializeComponent();
            Scores = new List<Score>();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var date = ((MonthCalendar) sender).SelectionEnd;
            System.Console.Write(date);
        }

        private void showData_Click(object sender, EventArgs e)
        {

            var table = new TableOutput();
            table.Show();
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            if (CheckDataNotNull())
            {
                var sms = false;
                var banking = false;
                TypeDeposit typeDeposit;
                // check elements checkbox
                if (checkBox1.Checked)
                    sms = true;
                if (checkBox2.Checked)
                    banking = true;
                // value radioBox
                if (shortTerm.Checked)
                    typeDeposit = TypeDeposit.ShortTerm;
                else if (longTerm.Checked)
                    typeDeposit = TypeDeposit.LongTerm;
                else if (IndefiniteTerm.Checked)
                    typeDeposit = TypeDeposit.Indefinite;
                else
                    typeDeposit = TypeDeposit.NotSelect;
                
                Score score = new Score(
                    firstName.Text,
                    lastName.Text,
                    patronymic.Text,
                    seriesPass.Text,
                    numbPass.Text,
                    dateTimePicker1.Value,
                    Int32.Parse(numberScore.Text),
                    typeDeposit,
                    Double.Parse(balance.Text),
                    dateTimePicker1.Value,
                    sms,
                    banking
                );
                Scores.Add(score);
                MessageBox.Show(@"Данные добавлены");
                XmlSerializeWrapper.Serialize(Form1.Scores,"output.xml");
            }
            else
            {
                MessageBox.Show(@"Поля не могут быть пустыми");
            }
        }

        private bool CheckDataNotNull()
        {
            if (
                firstName.Text != "" &&
                lastName.Text != "" &&
                patronymic.Text != "" &&
                seriesPass.Text != "" &&
                numbPass.Text != "" &&
                numberScore.Text != "" &&
                balance.Text != ""
                )
                return true;
            else
            {
                return false;
            }
        }

        private void KeyUpNumberScore(object sender,  KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        
        private void RunGenerator_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator();
            generator.Show();
        }

        private void настройкиПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings settings = AppSettings.GetInstance();
            settings.DoSomething(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Scores.Count != 0)
            {
                Score score = new Score();
                score = Scores[0].DeepCopy();
                Scores.Add(score);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Scores.Count != 0)
            {
                Score score = new Score();
                score = Scores[0].ShallowCopy();
                Scores.Add(score);
            }
        }
    }
}