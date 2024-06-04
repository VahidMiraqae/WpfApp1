namespace ViewModelProject
{
    public class PartAViewModel : BaseViewModel
    {
        private string _userText;
        //public string UserText { get => _userText; set => OnPropertyChanged(ref _userText, value); }
        public string UserText
        {
            get
            {
                return _userText;
            }
            set
            {
                _userText = value;
                OnPropertyChanged("UserText");
            }
        }
    }
}
