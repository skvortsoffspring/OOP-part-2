namespace Lab_06_07_OOP.ViewModel
{
    public class SingViewModel
    {
        private static ViewModel _instance;
        public static ViewModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ViewModel();
            }
            return _instance;
        }
    }
}