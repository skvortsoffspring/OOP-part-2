namespace Lab_02_OOP
{
    public interface IAbstractFactory
    {
        IScoreA CreateVipScoreA();
        IScoreA CreateNormalScoreA();
        IScoreA CreateMinimalScoreA();

    }

    public interface IScoreA
    {
        void SetServices();
    }

    public class ScoreFactoryA : IAbstractFactory
    {
        public IScoreA CreateVipScoreA()
        {
            var vipScoreA = new VipScoreA();
            vipScoreA.SetServices();
            return vipScoreA;
        }
        public IScoreA CreateNormalScoreA()
        {
            var normalScoreA = new NormalScoreA();
            normalScoreA.SetServices();
            return normalScoreA;
        }
        public IScoreA CreateMinimalScoreA()
        {
            var minimalScoreA = new MinimalScoreA();
            minimalScoreA.SetServices();
            return minimalScoreA;
        }
    }
    

    public class VipScoreA : Score, IScoreA 
    {
        public void SetServices()
        {
            ConnectSms = true;
            ConnectBanking = true;
            TypeDeposit = TypeDeposit.Indefinite;
        }
    }

    public class NormalScoreA : Score, IScoreA
    {
        public void SetServices()
        {
            ConnectSms = true;
            TypeDeposit = TypeDeposit.LongTerm;
        }
    }

    public class MinimalScoreA : Score, IScoreA
    {
        public void SetServices()
        {
            TypeDeposit = TypeDeposit.ShortTerm;
        }
    }
    
    public class Client
    {
        private IScoreA _scoreFactoryA;

        public IScoreA client(IAbstractFactory factory, string concrete)
        {
            switch (concrete)
            {
                case "full":
                    _scoreFactoryA = factory.CreateVipScoreA();
                    break;
                case "normal":
                    _scoreFactoryA = factory.CreateNormalScoreA();
                    break;
                case "minimal":
                    _scoreFactoryA = new MinimalScoreA();
                    break;
            }
           
            return _scoreFactoryA;
        }
        
    }
}