namespace Lab_02_OOP
{
    public interface IOutput
    {
        void Show();
    }

    public class StandartOut : IOutput
    {
        public void Show()
        {
            var table = new TableOutput();
            table.Show();
        }
    }
    
    public abstract class Decorator : IOutput
    {
        protected StandartOut StandartOut;
        
        public Decorator(StandartOut standartOut)
        {
            StandartOut = standartOut;
        }

        public void SetComponent(StandartOut standartOut)
        {
            StandartOut = standartOut;
        }
        
        public virtual void Show() { }
    }

    public class OutAsTree : Decorator
    {
        public OutAsTree(StandartOut standartOut) : base(standartOut)
        {
        }
        public override void Show()
        {
            var treeOutput = new TreeOutput();
            treeOutput.Show();
        }
    }
    
    public class DecoratorClient
    {
        public void Show(IOutput output)
        {
            output.Show();
        }
    }
}