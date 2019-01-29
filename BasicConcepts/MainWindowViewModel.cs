using System.Windows.Input;

namespace BasicConcepts
{
    internal class MainWindowViewModel : ViewModelBase
    {
        // MVVM - Model View ViewModel = https://msdn.microsoft.com/en-us/magazine/dd419663.aspx
        // Interfaces = https://stackoverflow.com/a/384067
        // Base classes 
        // View binding = https://www.c-sharpcorner.com/blogs/databinding-in-wpf-part-i
        // Commands = https://www.codeproject.com/Articles/32101/Exploring-a-Model-View-ViewModel-Application-WPF-P

        private string _output;

        public MainWindowViewModel()
        {
            UpdateCommand = new UpdateCommand(this);
        }

        public string Input { get; set; }

        public ICommand UpdateCommand { get; set; }

        public string Output
        {
            get { return _output; }
            set
            {
                _output = value; 
                OnPropertyChanged();
            }
        }
    }
}
