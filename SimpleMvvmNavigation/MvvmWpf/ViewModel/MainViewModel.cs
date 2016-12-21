using MvvmWpf.Abstract;
using MvvmWpf.Utils;
using System.Windows.Input;

namespace MvvmWpf.ViewModel
{
    public class MainViewModel : BaseViewModel, IContentChanger
    {
        private BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        public MainViewModel()
        {
            CurrentViewModel = new FirstViewModel(this);
        }

        public ICommand GoToFirstViewCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    CurrentViewModel = new FirstViewModel(this);
                });
            }
        }

        public ICommand GoToSecondViewCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    CurrentViewModel = new SecondViewModel(this);
                });
            }
        }

        public void ChangeContent(BaseViewModel sender, BaseViewModel newContent)
        {
            if (sender != CurrentViewModel)
                sender.Free();
            CurrentViewModel.Free();
            CurrentViewModel = newContent;
            newContent.DoWork();
        }
    }
}
