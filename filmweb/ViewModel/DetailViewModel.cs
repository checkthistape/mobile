using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace filmweb.ViewModel;

    public partial class DetailViewModel : ObservableObject
    {
        IConnectivity connectivity;
        public DetailViewModel(IConnectivity connectivity)
        {
            this.connectivity = connectivity;
        }
    [RelayCommand]
    Task Back() => Shell.Current.GoToAsync("..");

    }

