using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using Calculator.Properties;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string[,] TypeMans;
        private int val;
        private bool clothesOrFootwhear = false;
        public Converter converter = new Converter();
        public Form1()
        {
            InitializeComponent();
            TypeMans = converter.GetArray("Male", clothesOrFootwhear);
            val = 0;
            UpdateData(val);
        }

        private void button_Click(object sender, EventArgs e)
        {

            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));
            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(59)))), ((int)(((byte)(82)))));

            var text = ((Button)sender).Text;
            TypeMans = converter.GetArray(text, clothesOrFootwhear);
            switch (text)
            {
                case "Male":
                    button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
                    if(clothesOrFootwhear) footwear.BackgroundImage = System.Drawing.Image.FromFile(@"../../img/Layer1.png");
                    break;
                case "Female":
                    button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
                    if (clothesOrFootwhear) footwear.BackgroundImage = System.Drawing.Image.FromFile(@"../../img/Layer3.png");
                    break;
                case "Boy":
                    button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
                    break;
                default:
                    button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(120)))));
                    break;
            }
            val = 0;
            UpdateData(val);

        }

        private void NextPreviousSize(object sender, EventArgs e)
        {
            var text = ((Label)sender).Name;
            switch (text)
            {
                case "Previous":
                    val--;
                    break;
                case "Next":
                    val++;
                    break;
            }
            if (val <= 0)
                val = 0;
            else if (val > (TypeMans.Length / TypeMans.GetLength(0) - 1))
                val = (TypeMans.Length / TypeMans.GetLength(0) - 1);
            UpdateData(val);
        }

        public void UpdateData(int value)
        {
            ouputBox.Text = TypeMans[0, value];
            label2.Text = TypeMans[1, value];
            label3.Text = TypeMans[2, value];
            label4.Text = TypeMans[3, value];
            if (clothesOrFootwhear)
            {
                int a = TypeMans.GetLength(0);
                sizeChest.Text = TypeMans[4, value];
                sizeWeist.Text = TypeMans[5, value];
                sizeHips.Text  = TypeMans[6, value];

            }
        }

        private void footwear_Click(object sender, EventArgs e)
        {

            if (clothesOrFootwhear)
            {
                clothesOrFootwhear = false;
                TypeMans = converter.GetArray("Male", clothesOrFootwhear);
                //ouputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                footwear.BackgroundImage = System.Drawing.Image.FromFile(@"../../img/Layer2.png");
                // visible labels
                sizeChest.Visible = false;
                sizeHips.Visible = false;
                sizeWeist.Visible = false;
                weist.Visible = false;
                chest.Visible = false;
                hips.Visible = false;
                button3.Visible = true;
                button4.Visible = true;
                UpdateData(val);
            }
            else
            {
                clothesOrFootwhear = true;
                TypeMans = converter.GetArray("Male", clothesOrFootwhear);
                //ouputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                footwear.BackgroundImage = System.Drawing.Image.FromFile(@"../../img/Layer1.png");
                // visible labels
                sizeChest.Visible = true;
                sizeHips.Visible = true;
                sizeWeist.Visible = true;
                weist.Visible = true;
                chest.Visible = true;
                hips.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                UpdateData(val);
            }
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
