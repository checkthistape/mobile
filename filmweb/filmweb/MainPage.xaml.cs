using Film = filmweb.Models.ModelMockup;

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
            filmList.ItemsSource = Film.GetContacts();
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
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}