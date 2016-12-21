using MvvmWpf.Abstract;
using MvvmWpf.Utils;
using System.Windows.Input;

namespace MvvmWpf.ViewModel
{
    public class SecondViewModel : BaseViewModel
    {
        private IContentChanger _contentChanger;

        public SecondViewModel(IContentChanger contentChanger)
        {
            _contentChanger = contentChanger;
        }

        public ICommand GoToFirstViewCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    _contentChanger.ChangeContent(this, new FirstViewModel(_contentChanger));
                });
            }
        }
    }
}
