using System.Windows.Input;
using MusicTeacher.Views;
using Prism.Commands;
using Prism.Ioc;
using Unity;

namespace MusicTeacher.ViewModels
{
    public class StartWindowViewModel
    {
        private ICommand cordTransponseCommand;
        private ICommand cordPresenterCommand;
        private IUnityContainer unityContainer;

        public StartWindowViewModel(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public ICommand CordTransponseCommand => cordTransponseCommand ?? new DelegateCommand(CordTransponseCommandExecute, CordTransponseCanExecute);

        public ICommand CordPresenterCommand => cordPresenterCommand ?? new DelegateCommand(CordPresenterCommandExecute);


        private bool CordTransponseCanExecute()
        {
            return false;
        }


        private void CordPresenterCommandExecute()
        {
            unityContainer.Resolve<CordPresenter>().Show();
        }

        private void CordTransponseCommandExecute()
        {
            
        }
    }
}