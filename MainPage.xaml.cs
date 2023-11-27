namespace Borsan_Alexandra_Lab7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Mangaiat de {count} ori";
            else
                CounterBtn.Text = $"Mangaiat de {count} ori";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}