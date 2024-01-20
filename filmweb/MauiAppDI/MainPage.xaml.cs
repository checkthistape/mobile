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
    int actualPage = 0;
    List<int> actualMaxs = new List<int>();

    public ObservableCollection<Pages> pages = new ObservableCollection<Pages>();


    public MainPage(MainViewModel vm)
    {
       
        List<filmweb.Models.Film> collectionL = new List<filmweb.Models.Film>();
        collectionL = Film.GetFilms();
        collectionL = new List<filmweb.Models.Film>(collectionL.Where(item => item.FilmId < maxPerPage));


        InitializeComponent();

        collectionView.ItemsSource = collectionL;

        int all = ModelMockup.GetLastElement();

        for (int i = 0; i <= (all + ((((all / 6) + 1) * 6) - all)); i += 6)
        {
            if (i != 0)
            {
                pages.Add(new Pages { PageId = actualPage });
            }

            actualPage++;


            actualMaxs.Add(i);

        }
        actualPage = 0;

        Device.BeginInvokeOnMainThread(() =>
        {
            pagesHor.ItemsSource = pages;

        });
       

        BindingContext = vm;
    }

    public MainPage(int n)
    {
        /*.~~~~~~~.Pages and navigation.~~~~~~~.*/
        int all = ModelMockup.GetLastElement();

        // Working auto pages quantity calculating (for example, if db contains 14 films, it should create 3 pages 
        for (int i = 0; i <= (all + ((((all / 6) + 1) * 6) - all)); i += 6)
        {
            if (i != 0)
            {
                pages.Add(new Pages { PageId = actualPage });
            }
            
            actualPage++;
            

            actualMaxs.Add(i);

        }


        actualPage = 0;
        /*.~~~~~~~.Pages and navigation.~~~~~~~.*/


        List<filmweb.Models.Film> collectionL = new List<filmweb.Models.Film>();
        collectionL = Film.GetFilms();

        if (n == 1)
        {
            collectionL = new List<filmweb.Models.Film>(collectionL.Where(item => item.FilmId < actualMaxs[n] && item.FilmId >= 0));
        }
        else
        {
            collectionL = new List<filmweb.Models.Film>(collectionL.Where(item => item.FilmId < actualMaxs[n] && item.FilmId >= actualMaxs[n - 1]));
        }
        

        

        InitializeComponent();

        collectionView.ItemsSource = collectionL;

        Device.BeginInvokeOnMainThread(() =>
        {
            pagesHor.ItemsSource = pages;

        });

        //DisplayMsg("Alert", "First element "+ actualMaxs[0].ToString());
        //DisplayMsg("Alert", "All: "+all);
    }

    public MainPage()
    {
        /*.~~~~~~~.Pages and navigation.~~~~~~~.*/
        int all = ModelMockup.GetLastElement();

        for (int i = 0; i <= (all + ((((all / 6) + 1) * 6) - all)); i += 6)
        {
            if (i != 0)
            {
                pages.Add(new Pages { PageId = actualPage });
            }

            actualPage++;


            actualMaxs.Add(i);

        }
        actualPage = 0;
        /*.~~~~~~~.Pages and navigation.~~~~~~~.*/


        List<filmweb.Models.Film> collectionL = new List<filmweb.Models.Film>();
        collectionL = Film.GetFilms();
        collectionL = new List<filmweb.Models.Film>(collectionL.Where(item => item.FilmId < maxPerPage ));



        InitializeComponent();

        collectionView.ItemsSource = collectionL;

        Device.BeginInvokeOnMainThread(() =>
        {
            pagesHor.ItemsSource = pages;

        });

    }


    async void NextPageNavigation(System.Object sender, System.EventArgs e)
    {
        if (sender is Frame frame)
        {
            string v = frame.AutomationId;
            var q = frame.BindingContext;


            DisplayMsg(v);
        }

        else if (sender is Image image)
        {
            ImageSource imgSource = image.Source;
            var id = image.AutomationId;
            //DisplayMsg("Command sent from image", "Image source is " + imgSource + " \nID is: " + id);

            await Navigation.PushAsync(new DetailPage(imgSource, id), true);
        }

    }

    async void NextPageMain(System.Object sender, System.EventArgs e)
    {
        if(sender is Label label)
        {
            var txt = label.Text;
            await Navigation.PushAsync(new MainPage(int.Parse(txt)), true);
            //DisplayMsg(sender.GetType().GetFields().ToString());
        }
        else if( sender is Label labell )
        {
            await Navigation.PushAsync(new MainPage(), true);
            DisplayMsg("Yo");
        }

         
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
        
    }
}