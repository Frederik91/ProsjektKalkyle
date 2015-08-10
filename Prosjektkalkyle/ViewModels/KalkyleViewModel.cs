using Prosjektkalkyle.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Prosjektkalkyle.ViewModels
{
    class KalkyleViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel;

        public KalkyleViewModel()
        {
            ProjectInfoCommand = new DelegateCommand(o => OpenProjectInfoWindow());
        }

        public void OpenProjectInfoWindow()
        {
            CurrentViewModel = new ProjectInfoViewModel();
        }

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                this.OnPropertyChanged("CurrentViewModel");
            }
        }


        public ICommand ProjectInfoCommand { get; private set; }

    }
}
