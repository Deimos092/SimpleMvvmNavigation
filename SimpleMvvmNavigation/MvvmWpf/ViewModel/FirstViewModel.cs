using MvvmWpf.Abstract;

namespace MvvmWpf.ViewModel
{
    public class FirstViewModel : BaseViewModel
    {
        private IContentChanger _contentChanger;

        public FirstViewModel(IContentChanger contentChanger)
        {
            _contentChanger = contentChanger;
        }
    }
}
