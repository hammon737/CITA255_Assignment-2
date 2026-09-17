using System.Diagnostics;

namespace CITA255_Assignment_2
{
    public partial class MainPage : ContentPage
    {
        List<string> Food = new List<string>
        {
            "",
            "banana",
            "lemon",
            "lime",
            "grapes",
            "cherry",
            "blueberry",
            "blackberry",
            "strawberry",
            "rasberry"
        };
        List<double> prices = new List<double>
        {
            5,
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
            myFoodList.ItemsSource = Food;
            myPriceList.ItemsSource = prices;
        }

        private void testButtonClicked(object sender, EventArgs e)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total = total + price;
                Debug.WriteLine(price);
            }

            sum.Text = total.ToString();


        }
    }
}
