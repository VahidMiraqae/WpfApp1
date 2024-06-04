using ViewModelProject;

namespace ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public PartAViewModel PartA { get; set; }
        public PartBViewModel PartB { get; set; }
        public int Age { get; set; }
    }
}
