namespace CMhealth
{
    public partial class MainPage : ContentPage
    {
      

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
