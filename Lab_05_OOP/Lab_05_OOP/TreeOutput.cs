using System.Windows.Forms;

namespace Lab_02_OOP
{
    public partial class TreeOutput : Form
    {
        public TreeOutput()
        {
            InitializeComponent();
            AddData();
        }

        public void AddData()
        {
            foreach (var score in Form1.Scores)
            {
                TreeNode node;
                node = TreeOutputData.Nodes.Add(score.Owner.LastName);
                node.Nodes.Add(score.Owner.FirstName);
                node.Nodes.Add(score.Owner.Patronymic);
                node.Nodes.Add(score.Owner.SeriesPassport + score.Owner.NumberPassport);
                node.Nodes.Add("Номер счёта: " + score.Number);
                node.Nodes.Add("Баланс: "+score.Balance);
            }
        }
    }
}