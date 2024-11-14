namespace DodawanieApp
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            var suma = Convert.ToDouble(PierwszaLiczba.Text) + Convert.ToDouble(DrugaLiczba.Text);
            Wynik.Text = "Wynik: " + suma;
        }
    }

}
