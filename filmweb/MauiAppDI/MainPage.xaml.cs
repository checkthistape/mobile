//using AndroidX.AppCompat.View.Menu;
using filmweb.Models;
using MauiAppDI.Helpers;
using MauiAppDI.ViewModel;
using System.Collections.ObjectModel;
using System.Reflection;

namespace MauiAppDI;

using Film = filmweb.Models.ModelMockup;

public partial class MainPage : ContentPage
{
	int maxPerPage = 6;

    public ObservableCollection<Pages> pages = new ObservableCollection<Pages>();


    public MainPage(MainViewModel vm)
	{
        int all = ModelMockup.GetLastElement();

        //ObservableCollection<Pages> pages = new ObservableCollection<Pages>();




        for (int i = 0; i < all; i++)
        {
            pages.Add(new Pages { PageId = i, YourProperty = "qqqqq" });
        }

            //ObservableCollection<filmweb.Models.Film> collectionOb = new ObservableCollection<filmweb.Models.Film>();
            List<filmweb.Models.Film> collectionL = new List<filmweb.Models.Film>();
		collectionL = Film.GetFilms();
		collectionL = new List<filmweb.Models.Film>(collectionL.Where(item => item.FilmId < maxPerPage));

        //collectionView.ItemsSource = collectionL;
        //pagesHor.ItemsSource = pages;

        InitializeComponent();

		collectionView.ItemsSource = collectionL;
		pagesHor.ItemsSource = pages;
        //collectionView.ItemsSource = Film.GetFilms();
        BindingContext = vm;
	}

	public MainPage()
	{
        /*.~~~~~~~.Pages and navigation.~~~~~~~.*/
        int all = ModelMockup.GetLastElement();

        ObservableCollection<Pages> pages = new ObservableCollection<Pages>();

        for (int i = 0; i < all; i++)
        {
           pages.Add( new Pages { PageId = i, YourProperty="qqqqq" });

        }
        DisplayMsg("Message", (pages[3].PageId).ToString());
        /*.~~~~~~~.Pages and navigation.~~~~~~~.*/


        List<filmweb.Models.Film> collectionL = new List<filmweb.Models.Film>();
        collectionL = Film.GetFilms();
        collectionL = new List<filmweb.Models.Film>(collectionL.Where(item => item.FilmId > maxPerPage));

        //collectionView.ItemsSource = collectionL;
        //pagesHor.ItemsSource = pages;

        InitializeComponent();

        collectionView.ItemsSource = collectionL;
        pagesHor.ItemsSource = pages;

    }

    async void NextPageNavigation(System.Object sender, System.EventArgs e)
	{
        if(sender is Frame frame)
        {
            string v = frame.AutomationId;
            var q = frame.BindingContext;
            
            
            DisplayMsg(v);
        }

        else if(sender is Image image)
        {
            ImageSource imgSource = image.Source;
            var id = image.AutomationId;
            DisplayMsg("Command sent from image", "Image source is "+imgSource+" \nID is: "+id);

            await Navigation.PushAsync(new DetailPage(imgSource, id), true);
        }
        


        //var framee = (Frame)sender;
        //var item = (Film)framee.BindingContext;
        //var id = item.id;

        //string s = e.GetType().GetProperty("Text").GetValue(sender) as string;
        //DisplayMsg(s);
		
        //await Navigation.PushAsync(new DetailPage(), true);
    }

	async void NextPageMain(System.Object sender, System.EventArgs e)
	{
        await Navigation.PushAsync(new MainPage(), true);
    }

    async void DisplayMsg(string title, string message)
    {
        await DisplayAlert(title, message, "OK");
    }
    async void DisplayMsg(string message)
    {
        await DisplayAlert("Alert", message, "OK");
    }

    async void DisplayMsg(System.Object sender, System.EventArgs e)
    {
        await DisplayAlert("Alert", "Message", "OK");
    }

    

    public class Pages
    {
        public int PageId { get; set; }
        public string YourProperty { get; set; }
    }
}

