using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WithLib.Command
{
    public class CountUpCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private ViewModel.ViewModel vm;

        public CountUpCommand(ViewModel.ViewModel vm)
        {
            this.vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            vm.Count.Value++;
        }
    }
}
