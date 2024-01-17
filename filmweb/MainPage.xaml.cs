using System.Collections.ObjectModel;
using Film = filmweb.Models.ModelMockup;

using filmweb.ViewModel;

///using CarouselItem = filmweb.Carousel.CarouselViewModel;

namespace filmweb
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        /**
         * 
         * Function initialises mainpage.xaml
         * @returns {void}
         * 
         **/
        public MainPage()
        {

            InitializeComponent();

            //MainPage = new CarouselViewDemo();

            //filmList.ItemsSource = Film.GetContacts();

            //ObservableCollection<String> collectionV = new ObservableCollection<string>();
            List<filmweb.Models.Film> collectionV = Film.GetFilms();

            //collectionV.Add(new Film { FilmId = 0, FilmName = "Pulp Fiction", ImageURL = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.themoviedb.org%2Ft%2Fp%2Foriginal%2FjlVOS4D6ledQGxGdL0EIte3TXfL.jpg&f=1&nofb=1&ipt=529dcb3f58baa034c5729ae3ea1a0c2b889b6eb0732d6afb0ea81f9e25fa845d&ipo=images" });
            collectionV = new List<filmweb.Models.Film>(collectionV.Where(item => item.FilmId < 2));

            collectionView.ItemsSource = collectionV;
            //collectionView.ItemsSource = Film.GetFilms();
        }

        /**
         * 
         * Function increases number in text by 1 after ever button click.
         * @param {object} sender
         * @returns {void}
         * 
         **/
        private void OnCounterClicked(object sender, EventArgs e)
        {
           
            //btnTest.Text = "hahaha";

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void Toast(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
        }

        async Task Tap(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
            await Shell.Current.GoToAsync(nameof(DetailPage));
        }
        

    }
}