using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public Command.CountUpCommand CountUpCommand { get; private set; }
        public Command.CountDownCommand CountDownCommand { get; private set; }

        public int Count
        {
            get => model.Count;
            set
            {
                model.Count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
            }
        }

        private Model.Model model = new Model.Model();

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            CountUpCommand = new Command.CountUpCommand(this);
            CountDownCommand = new Command.CountDownCommand(this);
        }
    }
}
