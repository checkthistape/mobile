using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;

using System.Collections.ObjectModel;
using System.ComponentModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
//using Org.Apache.Http.Conn;




namespace filmweb.ViewModel;

public partial class MainViewModel : ObservableObject
{
    //Monkey monkey;
    public MainViewModel()
    {
        //monkey = new Monkey { Name = "Mooch" };
    }

    
    

    [ObservableProperty]
    string text;

    //[RelayCommand]
    //void Add()
    //{
    //    if (string.IsNullOrEmpty(Text))
    //    {
    //        return;
    //    }
    //    Items.Add(Text);
    //    // add our item
    //    Text = string.Empty;

    //}
    //[RelayCommand]
    //void Delete(string s)
    //{
    //    DisplayAlert("Alert", "Deletition!", "OK");
    //    if(Items.Contains(s))
    //    { 
    //        Items.Remove(s);
    //    }
    //}

    [RelayCommand]
    async Task Tap(string s)
    {
       await DisplayAlert("Alert", "You have been alerted", "OK");
        await Shell.Current.GoToAsync(nameof(DetailPage));
    }

    private Task DisplayAlert(string v1, string v2, string v3)
    {
       throw new NotImplementedException();
    }

    [RelayCommand]
    Task Navigate() => Shell.Current.GoToAsync(nameof(DetailPage));
}

