using MvvmWpf.ViewModel;

namespace MvvmWpf.Abstract
{
    public interface IContentChanger
    {
        void ChangeContent(BaseViewModel sender, BaseViewModel newContent);
    }
}
