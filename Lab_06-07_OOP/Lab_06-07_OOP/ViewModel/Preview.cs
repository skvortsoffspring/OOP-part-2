using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab_06_07_OOP.Annotations;

namespace Lab_06_07_OOP.mvvm
{
    public class Preview : INotifyPropertyChanged
    {
        
        
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}