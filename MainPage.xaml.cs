namespace WebViewTestingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Nastavíme prázdnou HTML stránku, aby WebView byl viditelný
            WebViewControl.Source = new HtmlWebViewSource
            {
                Html = "<html><body style='margin:0;padding:0;background-color:white;'></body></html>"
            };
        }

        private void OnNavigateClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UrlEntry.Text))
            {
                WebViewControl.Source = UrlEntry.Text;
            }
        }
    }
}
