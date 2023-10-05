// using CoreImage;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public ICommand NewCommand { private set; get; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                Btn1.Text = $"Clicked {count} time";
            else
                Btn1.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(Btn1.Text);
        }
        private void Print(object sender, EventArgs e)
        {
            if(sender is Button btn) { entry.Text = entry.Text + btn.Text; }

            // entry.Text = entry.Text + ;

        }
        private void Backspace(object sender, EventArgs e)
        {
            entry.Text = entry.Text.Substring(0, entry.Text.Length - 1);
        }

        private void Plus(object sender, EventArgs e)
        {
            /*string Text = entry.Text;*/
            if (entry.Text != "") { entry.Text = entry.Text + "+"; }
          
           /* Btn2.Text = Text;*/
        }
        private void Minus(object sender, EventArgs e)
        {
            if (entry.Text != "") { entry.Text = entry.Text + "-"; }
        }
        private void RetResult(object sender, EventArgs e)
        {
            string txt = entry.Text;
            txt = txt + "+";

        }
        private void Enter(object sender, EventArgs e)
        {

            char[] stream = new char[entry.Text.Length];
            int[] ints = new int[8];
            char[] ops = new char[ints.Length / 2];

            string numb="";
            int ii = 0;

            int k = 0;
            int iterator = 0;

            int result = 0;
            for(int i=0; i<entry.Text.Length; i++) { stream[i] = entry.Text[i]; } // getting a char array "string" from string

            foreach (char c in stream)
            {
                
                if (c == '+' || c == '-' || c=='-') { ops[k] = c;   ii = Int32.Parse(numb); ints[k] = ii; k++; numb = "";  }
                else if(iterator==stream.Length-1) { numb += c; ii = Int32.Parse(numb); ints[k] = ii; k++; numb = ""; }
                else { numb += c; }


                resulttt.Text += " " + c.ToString();
                iterator++;
            }


            foreach (int j in ints)
            {
                result2.Text += j.ToString() + ".";
            }
            result2.Text += "|| ";

            foreach (char c in ops)
            {
                result2.Text += c + " " ;
            }
            for (int q=0; q<ops.Length; q++) { if (ops[q] == '+') { result += (ints[q] + ints[q + 1]); } }
            entry.Text = result.ToString();
        }

    }
}
