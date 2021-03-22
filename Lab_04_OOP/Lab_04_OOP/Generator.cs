using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace Lab_02_OOP
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
        }

        private void GenBuilder_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(QuantityBuilder.Text, out result))
            {
                progressBarCreateObject.Minimum = 0;
                progressBarCreateObject.Maximum = result;
                progressBarCreateObject.Step = 1;
                var random = new Random();
                var arrSecond = new[]
                {
                    "Петров", "Иванов", "Сидоров", "Смирнов", "Кузнецов", "Попов", "Васильев", "Соколов", "Михайлов",
                    "Волков", "Карпов", "Никитин", "Рябов", "Тихонов", "Моисеев", "Горбачёв", "Авдеев", "Устинов",
                    "Данилов", "Морозов", "Новиков", "Костин", "Захаров", "Гуляев", "Савин", "Гришин", "Хохлов"
                };

                var arrFirst = new[]
                {
                    "Антон", "Иван", "Петр", "Алексей", "Дмитрий", "Олег", "Кирилл", "Максим", "Александр", "Василий"
                };

                var arrPatromonyc = new[]
                {
                    "Антонович", "Васильевич", "Петрович", "Алексеевич", "Дмитриевич", "Олегович", "Кириллович",
                    "Максимович", "Александрович", "Васильевич"
                };

                var seriesPassport = new[]
                {
                    "АВ", "ВМ", "НВ", "КН", "МР", "МС", "КВ", "РР", "SP", "DP"
                };

                var change = new[]
                {
                    "minimal", "normal", "full"
                };
                var builder = new BuilderScore();
                var director = new Director {Builder = builder};


                
                for (var i = 0; i < result; i++)
                {
                    progressBarCreateObject.PerformStep();                    
                    director.ChangeScore(change[random.Next(0, change.Length)]);
                    builder = (BuilderScore) director.Builder;
                    builder.SetBalance(random.Next(0, 10000));
                    
                    builder.SetPassport(seriesPassport[random.Next(0, seriesPassport.Length)],
                        random.Next(1000000, 9999999).ToString());
                    
                    builder.SetInitials(arrFirst[random.Next(0, arrFirst.Length)],
                        arrSecond[random.Next(0, arrSecond.Length)],
                        arrPatromonyc[random.Next(0, arrPatromonyc.Length)]);
                    
                    Form1.Scores.Add(builder.GetScore());
                }
            }
            else
            {
                MessageBox.Show(@"В этом поле моет быть только число!");
            }
        }

        private void GeneratorFactory_Click(object sender, EventArgs e)
        {

            int result;
            if (!int.TryParse(QuantityFactory.Text, out result)) return;
            var random = new Random();
            
            progressBarCreateObject.Minimum = 0;
            progressBarCreateObject.Maximum = result;
            progressBarCreateObject.Step = 1;
            
            var arrSecond = new[]
            {
                "Петров", "Иванов", "Сидоров", "Смирнов", "Кузнецов", "Попов", "Васильев", "Соколов", "Михайлов",
                "Волков", "Карпов", "Никитин", "Рябов", "Тихонов", "Моисеев", "Горбачёв", "Авдеев", "Устинов",
                "Данилов", "Морозов", "Новиков", "Костин", "Захаров", "Гуляев", "Савин", "Гришин", "Хохлов"
            };

            var arrFirst = new[]
            {
                "Антон", "Иван", "Петр", "Алексей", "Дмитрий", "Олег", "Кирилл", "Максим", "Александр", "Василий"
            };

            var arrPatromonyc = new[]
            {
                "Антонович", "Васильевич", "Петрович", "Алексеевич", "Дмитриевич", "Олегович", "Кириллович",
                "Максимович", "Александрович", "Васильевич"
            };

            var seriesPassport = new[]
            {
                "АВ", "ВМ", "НВ", "КН", "МР", "МС", "КВ", "РР", "SP", "DP"
            };

            var change = new[]
            {
                "minimal", "normal", "full"
            };


            var score = new Score();
            var client = new Client();

            for (int i = 0; i < result; i++)
            {
                progressBarCreateObject.PerformStep();  
                score = (Score) client.client(new ScoreFactoryA(), change[random.Next(0, change.Length)]);

                score.Owner.FirstName = arrFirst[random.Next(0, arrFirst.Length)];
                score.Owner.LastName = arrSecond[random.Next(0, arrSecond.Length)];
                score.Owner.Patronymic = arrPatromonyc[random.Next(0, arrPatromonyc.Length)];

                score.Owner.SeriesPassport = seriesPassport[random.Next(0, seriesPassport.Length)];
                score.Owner.NumberPassport = random.Next(1000000, 9999999).ToString();

                score.Balance = random.Next(0, 10000);
                score.Number = random.Next(1000000, 9999999);
                Form1.Scores.Add(score);
            }
        }
    }
}