using filmweb.Models;
using MauiAppDI.Helpers;
using MauiAppDI.ViewModel;

using Film = filmweb.Models.ModelMockup;

namespace MauiAppDI;

public partial class DetailPage : ContentPage
{
    ImageSource _imageSource;
    string _filmname;
    string _filmId;
    int _rating;

    List<filmweb.Models.Film> collectionL = new List<filmweb.Models.Film>();

    List<Stars> stars = new List<Stars>();

    public DetailPage(DetailViewModel vm)
	{
       // DisplayMsg("DetailPage(DetailViewModel vm)", "This message is being showed bcs you have add");
        InitializeComponent();
		BindingContext = vm;
	}

	public DetailPage()
	{
       // DisplayMsg("DetailPage()", "This message is being showed bcs you haven't add any parameters to it!");
        InitializeComponent();
    }

    //public DetailPage(ImageSource i, string filmname, string FilmId)
    //{
    //    _imageSource = i;
    //    _filmname= filmname;
    //    _filmId = FilmId;

    //    //DisplayMsg("DetailPage()", "This message is being showed bcs you have parameters such as image source and filmname");
    //    InitializeComponent();
    //}

    public DetailPage(ImageSource i, string FilmId)
    {
        collectionL = Film.GetFilms();

        _imageSource = i;
        _filmId = FilmId;
        _rating = collectionL[int.Parse(_filmId)].Rating;


        for(int j=6; j>0; j--)
        {
            if (j > (6-_rating))
            {
                stars.Add(new Stars { starImage = "star_gold.png" });
            }
            else
            {
                stars.Add(new Stars { starImage = "star.png" });
            }
        }
       
        InitializeComponent();

        



        Device.BeginInvokeOnMainThread(() =>
        {
            //textId.Text = _filmId;
            filmImage.Source = _imageSource;
            filmName.Text = bigFilmName.Text = collectionL[int.Parse(_filmId)].FilmName;
            rate.ItemsSource = stars;
           // bigFilmName.Text = collectionL[int.Parse(_filmId)].FilmName;

        });


    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    async void DisplayMsg(string title, string message)
    {
        await DisplayAlert(title, message, "OK");
    }

    public void starCounting()
    {
       

    }


    public class Stars
    {
        public ImageSource starImage { get; set; }

    }
}