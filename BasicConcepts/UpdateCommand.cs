using System;
using System.Windows.Input;

namespace BasicConcepts
{
    class UpdateCommand : ICommand
    {
        private readonly MainWindowViewModel _viewModel;

        public UpdateCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Output = _viewModel.Input;
        }

        public event EventHandler CanExecuteChanged;
    }
}
