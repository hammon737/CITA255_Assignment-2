using System.Diagnostics;

namespace CITA255_Assignment_2
{
    public partial class MainPage : ContentPage
    {
        List<string> Games = new List<string>
        {
            "Genshin Impact",
            "Honkai Star Rail",
            "Twisted Wonderland",
            "Reverse 1999",
            "Fate: Grand Order",
            "Limbus Company",
            "Death Mark",
            "Dupery",
            "The Walking Dead",
            "Adventure Escape"
        };
        List<double> Hours = new List<double>
        {
            10,
            20,
            12,
            16,
            8,
            17,
            30,
            6,
            2,
            19
        };

        public MainPage()
        {
            InitializeComponent();
            myGameList.ItemsSource = Games;
            myHourList.ItemsSource = Hours;
        }

        private void testButtonClicked(object sender, EventArgs e)
        {
            double total = 0;

            foreach (double hour in Hours)
            {
                total = total + hour;
                Debug.WriteLine(hour);
            }

            sum.Text = total.ToString()+" hours";


        }
    }
}
