using System.Windows.Forms;

namespace Lab_02_OOP
{
    public interface IBuilder
    {
        void ConnectSms();
        void ConnectBanking();
        void NotConnectServices();
        void TypeDepositShort();
        void TypeDepositTerm();
        void TypeDepositIndefinite();

    }
    public class BuilderScore : IBuilder
    {
        private Score _score = new Score();

        public void Reset()
        {
            _score = new Score();
        }

        public void SetInitials(string first, string second, string patronymic)
        {
            _score.Owner.FirstName = first;
            _score.Owner.LastName = second;
            _score.Owner.Patronymic = patronymic;
        }

        public void SetPassport(string series, string numbers)
        {
            _score.Owner.SeriesPassport = series;
            _score.Owner.NumberPassport = numbers;
        }

        public void SetBalance(double balance)
        {
            _score.Balance = balance;
        }

        public void ConnectSms()
        {
            _score.ConnectSms = true;
        }

        public void ConnectBanking()
        {
            _score.ConnectBanking = true;
        }

        public void NotConnectServices()
        {
            _score.ConnectBanking = false;
            _score.ConnectSms = false;
        }

        public void TypeDepositShort()
        {
            _score.TypeDeposit = TypeDeposit.ShortTerm;
        }

        public void TypeDepositTerm()
        {
            _score.TypeDeposit = TypeDeposit.LongTerm;
        }

        public void TypeDepositIndefinite()
        {
            _score.TypeDeposit = TypeDeposit.Indefinite;
        }

        public Score GetScore()
        {
            var resultBuild = _score;
            Reset();
            return resultBuild;
        }
    }

    public class Director
    {
        public IBuilder Builder { get; set; }

        public void ChangeScore(string change)
        {
            switch (change)
            {
                case "minimal":
                    MinimalScoreServices();
                    break;
                case "normal":
                    ScoreNormalServices();
                    break;
                case "full":
                    ScoreVipServices();
                    break;
                default:
                    MessageBox.Show($"Неверный параметр ChangeScore: {change}");
                    break;
            }
        }
        
        private void ScoreNormalServices()
        {
            Builder.ConnectBanking();
            Builder.TypeDepositTerm();
        }
        
        private void ScoreVipServices()
        {
            Builder.ConnectBanking();
            Builder.ConnectSms();
            Builder.TypeDepositIndefinite();
        }

        private void MinimalScoreServices()
        {
            Builder.NotConnectServices();
            Builder.TypeDepositShort();
        }
    }
}