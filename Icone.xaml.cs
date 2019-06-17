    public partial class Icon : Label
    {
        public Icon()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.Android)
                FontFamily = "fa-solid-900.ttf#Font Awesome 5 Free Solid";

            if (Device.RuntimePlatform == Device.iOS)
                FontFamily = "Font Awesome 5 Free";

            if (Device.RuntimePlatform == Device.UWP)
                FontFamily = "Assets/fa-solid-900.ttf#Font Awesome 5 Free Solid";

        }
    }
