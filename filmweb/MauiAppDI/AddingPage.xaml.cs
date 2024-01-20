using filmweb.Models;
using System.Collections.ObjectModel;

namespace MauiAppDI;

public partial class AddingPage : ContentPage
{
	public AddingPage()
	{
		InitializeComponent();
	}

	async public void AddItem(Object sender, EventArgs e)
	{


         //public ObservableCollection<filmweb.Models.Film> collectionL = new ObservableCollection<filmweb.Models.Film>();
		int all = ModelMockup.GetLastElement();
		Film item = new Film { filmid = all, filmname = filmNameEntry.Text, film_date = int.Parse(filmDateEntry.Text), filmImageURL = filmImageURLEntry.Text, film_rating = int.Parse(filmRatingEntry.Text) };
		ModelMockup.AddElementt(item);

        await Navigation.PushAsync(new MainPage(), true);
    }

	public void DateCheck(Object sender, EventArgs e)
	{

	}
}