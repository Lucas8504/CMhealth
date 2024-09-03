namespace CMhealth
{
    public partial class MainPage : ContentPage
    {

        const double UnderWeigthThreshold = 18.5;
        const double NormalWeigthThreshold = 24.9;
        const double OverWeigthThreshold = 29.9;
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var weigth = double.Parse(Weigth.Text);
            var heigth = double.Parse(Heigth.Text) / 100;

            var mch = weigth / (heigth * heigth);

            Mch.Text = mch.ToString("F2");

        }
    }

}
