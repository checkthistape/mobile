using MauiAppDI.Helpers;
using MauiAppDI.ViewModel;

namespace MauiAppDI;

public partial class DetailPage : ContentPage
{
    ImageSource _imageSource;
    string _filmname;
    string _filmId;



	public DetailPage(DetailViewModel vm)
	{
        DisplayMsg("DetailPage(DetailViewModel vm)", "This message is being showed bcs you have add");
        InitializeComponent();
		BindingContext = vm;
	}

	public DetailPage()
	{
        DisplayMsg("DetailPage()", "This message is being showed bcs you haven't add any parameters to it!");
        InitializeComponent();
    }

    public DetailPage(ImageSource i, string filmname, string FilmId)
    {
        _imageSource = i;
        _filmname= filmname;
        _filmId = FilmId;

        DisplayMsg("DetailPage()", "This message is being showed bcs you have parameters such as image source and filmname");
        InitializeComponent();
    }

    public DetailPage(ImageSource i, string FilmId)
    {
        _imageSource = i;
        _filmId = FilmId;

        

        DisplayMsg("DetailPage()", "This message is being showed bcs you have parameters such as image source and filmname");
        InitializeComponent();

        Device.BeginInvokeOnMainThread(() =>
        {
            textId.Text = _filmId;
            filmImage.Source = _imageSource;
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

}