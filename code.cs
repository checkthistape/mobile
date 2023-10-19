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

        // button
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

        }
        //.~~~~~~~.buttons for calculator.~~~~~~~.
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
        //.~~~~~~~.buttons for calculator.~~~~~~~.
        private void RetResult(object sender, EventArgs e)
        {
            string txt = entry.Text;
            txt = txt + "+";

        }
        private void DeleteLog(object sender, EventArgs e)
        {
            result2.Text = "";
        }
        private void Enter(object sender, EventArgs e)
        {

            char[] stream = new char[entry.Text.Length]; // space for a stream of values
            int[] ints = new int[15]; // space for numbers which depends on the size of input
            char[] ops = new char[ints.Length / 2]; // space for operations (+,-,...)
            int it = 0; // iterator
            string numb="";
            string numbNegative = "";

            int ii = 0; // iterator 2

            int k = 0; // iterator 3
            int iterator = 0; // iterator 4

            int result = 0; // result of calculations

            for(int i=0; i<entry.Text.Length; i++) { stream[i] = entry.Text[i]; } // getting values into char array "string" from string

            foreach (char c in stream)
            {
                
                if (c == '+') { if (ops[k] == '-') { ii = (Int32.Parse(numb)) * (-1); } else { ii = Int32.Parse(numb); } ops[k] = c;    ints[k] = ii; k++; numb = "";  } // if element in stream is +||-||- => add this element into the array ops[]
                else if (c=='-'||c=='-') { if (ops[k] == '-') { ii = (Int32.Parse(numb)) * (-1); } else if(numb!="") { ii = Int32.Parse(numb); } ops[k] = c; ints[k] = ii; k++; numb = ""; }
                else if(iterator==stream.Length-1) { numb += c; if (ops[k] == '-') { ii = Int32.Parse(numb)*(-1); } else { ii = Int32.Parse(numb); } ints[k] = ii; k++; numb = ""; }
                
                else { numb += c; }
                helloWorld.Text += ii + " ";

                resulttt.Text += " " + c.ToString();
                iterator++;
            }

            // generating log
            foreach (int j in ints){ result2.Text += j.ToString() + "."; }
            result2.Text += "|| ";
            foreach (char c in ops){ result2.Text += c + " " ; }

            if (ops.Length % 2!=0)
            {
                for (int q = 0; q < ops.Length; q++)
                {
                    
                    if (ops[it] == '+') { result += (ints[q] + ints[q + 1]); }
                    if (ops[it] == '-') { result += (ints[q] - ints[q + 1]); }
                    it++;
                    q = q + 1;

                }
            }

            /*if(ops.Length%2==0)
            {
                for (int q = 0; q < ops.Length; q++)
                {
                    
                    if (ops[q] == '+') { result += (ints[q] + ints[q + 1]); }
                    if (ops[q] == '-') { result += (ints[q] - ints[q + 1]); }


                }
            }*/
            
            entry.Text = result.ToString();
        }

    }
}
