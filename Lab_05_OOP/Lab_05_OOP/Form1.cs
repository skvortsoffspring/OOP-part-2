using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;
using Timer = System.Windows.Forms.Timer;

namespace Lab_02_OOP
{
    public partial class Form1 : Form
    {
        public static List<Score> Scores = new List<Score>();
        private bool IsSave = true;
        private static System.Timers.Timer aTimer;
        private Commands _commands = new Commands();
        public static Sending _sending;

        public Form1()
        {
            InitializeComponent();
            aTimer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += UpdateDateTime;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }       
        
        private void showData_Click(object sender, EventArgs e)
        {
            var decoratorClient = new DecoratorClient();
            decoratorClient.Show(new StandartOut());
        }
        private void AddData_Click(object sender, EventArgs e)
        {
            var sms = false;
            var banking = false;

            int.TryParse(numberScore.Text, out var numbScore);
            double.TryParse(balance.Text, out var balances);

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

            var score = new Score(
                firstName.Text,
                lastName.Text,
                patronymic.Text,
                seriesPass.Text,
                numbPass.Text,
                dateTimePicker1.Value,
                numbScore,
                typeDeposit,
                balances,
                dateTimePicker1.Value,
                sms,
                banking
            );

            var isSeries = score.Owner.IsValid(score);
            if (!isSeries)
            {
                MessageBox.Show(@"Неверная серия");
                return;
            }

            var results = new List<ValidationResult>();
            var context = new ValidationContext(score);
            if (!Validator.TryValidateObject(score, context, results, true))
            {
                var stringError = results.Aggregate("", (current, result) => current + result.ErrorMessage + "\n");

                MessageBox.Show(
                    stringError,
                    @"Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                Scores.Add(score);
                IsSave = false;
                UpdateQuantityObject();
                MessageBox.Show(@"Данные добавлены");
            }
        }

        private void KeyUpOnlyNumber(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void search_Click(object sender, EventArgs e)
        {
            var Founding = new Founding();
            Founding.Show();
        }

        private void aboutSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Developer: Skvortsoff \nVersion: for Lab3");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsSave)
            {
                var dialogResult = MessageBox.Show(
                    @"Сохранить данные?",
                    @"Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (dialogResult == DialogResult.Yes)
                    SaveAsToolStripMenuItem_Click(null, EventArgs.Empty);
                IsSave = true;
            }
            Application.Exit();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                @"Разработчик: Skvortsoff\nVersion: 1.01",
                @"Автор",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1
            );
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Scores.Count!=0)
            Scores.Clear();
            UpdateQuantityObject();
            MessageBox.Show(@"Список очищен!");
        }

        public void UpdateQuantityObject()
        {
            infoQuantityObject.Text = @"Количество объектов в программе: " + Scores.Count();
        }

        private void UpdateDateTime(Object source, ElapsedEventArgs e)
        {
            dateStatus.Text = @"Дата и время: " + DateTime.Now.ToString();
        }

        private void SortDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scores = (from score in Form1.Scores orderby score.DateOpened select score).ToList();
        }

        private void SortTypeDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scores = (from score in Form1.Scores orderby score.TypeDeposit select score).ToList();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _commands.Open();
            UpdateQuantityObject();
        }
        
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _commands.Save();
        }
        private void openIcon_ButtonClick(object sender, EventArgs e)
        {
            _commands.Open();
            UpdateQuantityObject();
        }

        private void saveIcon_Click(object sender, EventArgs e)
        {
            _commands.Save();
        }

        private void окноРассылкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sending = new Sending();
            _sending.Show();
        }

        private void ShowDataInTree_Click(object sender, EventArgs e)
        {
            DecoratorClient decoratorClient = new DecoratorClient();
            decoratorClient.Show(new OutAsTree(new StandartOut()));
        }
    }
}
