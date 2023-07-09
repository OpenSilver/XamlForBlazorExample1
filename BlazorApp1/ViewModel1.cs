using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorApp1
{
    public class ViewModel1 : INotifyPropertyChanged
    {
        public int _currentCount;
        public int CurrentCount
        {
            get => _currentCount;
            set
            {
                if (_currentCount == value) return;
                _currentCount = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string callerName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
        }
    }
}
