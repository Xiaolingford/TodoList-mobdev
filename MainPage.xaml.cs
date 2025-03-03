namespace Todo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTogglePasswordVisibility(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
            TogglePasswordButton.Text = PasswordEntry.IsPassword ? "👁" : "👁‍🗨";
        }

      
    }
}

