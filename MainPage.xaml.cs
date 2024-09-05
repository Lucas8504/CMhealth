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

            string result = GetMcResultMessaje(mch);
            DisplayAlert("Resultado",result, "Ok");

        }

        private string GetMcResultMessaje(double mch)
        {

            if (mch < UnderWeigthThreshold)
            {
                return "Estas con bajo peso";
            }
            if (mch < NormalWeigthThreshold)
            {
                return "Tu peso es normal";
            }
            if (mch < UnderWeigthThreshold)
            {
                return "Estas con sobre peso";
            }
            else
            {
                return "Tienes obesidad, consulta a tu medico";
            }

        }

    }

}
