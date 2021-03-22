using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_02_OOP
{
    
    public partial class Form1 : Form
    {
        public static List<Score> Scores = new List<Score>();
    public Form1()
        {
            InitializeComponent();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = ((MonthCalendar) sender).SelectionEnd;
            System.Console.Write(date);
        }

        private void showData_Click(object sender, EventArgs e)
        {

            TableOutput table = new TableOutput();
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
        
    }
}