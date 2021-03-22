using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Lab_02_OOP
{
    public partial class TableOutput : Form
    {
        public TableOutput()
        {
            InitializeComponent();
            Insert();
        }

        private void Insert()
        {
            foreach (var score in Form1.Scores)
            {
                dataGridView1.Rows.Add(
                    score.Owner.LastName,
                    score.Owner.FirstName,
                    score.Owner.Patronymic,
                    score.Owner.SeriesPassport,
                    score.Owner.NumberPassport,
                    score.DateOpened.ToString(CultureInfo.InvariantCulture),
                    score.Balance,
                    score.TypeDeposit,
                    score.ConnectSms,
                    score.ConnectBanking
                );

            }
        }
    }
}