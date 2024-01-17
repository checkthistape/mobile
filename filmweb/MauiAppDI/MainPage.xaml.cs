//using AndroidX.AppCompat.View.Menu;
using filmweb.Models;
using MauiAppDI.Helpers;
using MauiAppDI.ViewModel;
using System.Collections.ObjectModel;

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
		int all = ModelMockup.GetLastElement();

        ObservableCollection<Pages> pages = new ObservableCollection<Pages>();

        for (int i = 0; i < all; i++)
        {
           pages.Add( new Pages { PageId = i, YourProperty="qqqqq" });

        }
        DisplayMsg("Message", (pages[3].PageId).ToString());

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
		Console.WriteLine("yoyoyo");
		await Navigation.PushAsync(new DetailPage(), true);
	}

	async void NextPageMain(System.Object sender, System.EventArgs e)
	{
        await Navigation.PushAsync(new MainPage(), true);
    }

    async void DisplayMsg(string title, string message)
    {
        await DisplayAlert(title, message, "OK");
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

