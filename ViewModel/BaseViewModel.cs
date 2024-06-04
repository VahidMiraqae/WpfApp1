using System.ComponentModel;

namespace ViewModelProject
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //protected void OnPropertyChanged<T>(ref T obj, T value, [CallerMemberName] string propertyName = null)
        //{
        //    obj = value;
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
