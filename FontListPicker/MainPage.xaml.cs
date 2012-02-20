using System.Collections.Generic;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace FontListPicker
{
    public partial class MainPage : PhoneApplicationPage
    {
        private static readonly List<FontBinding> FontFamilies = new List<FontBinding>
                                                {
                                                    //Font set as BlendEmbeddedFont in properties
                                                    new FontBinding("/FontListPicker;Component/Fonts/Fonts.zip#Advert"),
                                                    //Font set as Content in properties
                                                    new FontBinding("AKKA.TTF#Akka"),
                                                    //Font set as Resource in properties
                                                    new FontBinding("/FontListPicker;Component/ALGER.TTF#Algerian"),
                                                    new FontBinding("Arial"),
                                                    new FontBinding("Arial Black"),
                                                    new FontBinding("Calibri"),
                                                    new FontBinding("Comic Sans MS"),
                                                    new FontBinding("Courier New"),
                                                    new FontBinding("Georgia"),
                                                    new FontBinding("Lucida Sans Unicode"),
                                                    new FontBinding("Portable User Interface"),
                                                    new FontBinding("Segoe WP"),
                                                    new FontBinding("Segoe WP Black"),
                                                    new FontBinding("Tahoma"),
                                                    new FontBinding("Times New Roman"),
                                                    new FontBinding("Trebuchet MS"),
                                                    new FontBinding("Verdana"),
                                                    new FontBinding("Webdings"),
                                                    new FontBinding("Wingdings")
                                                };

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void LstPickerSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count <= 0)
                return;

            var fontBinding = e.AddedItems[0] as FontBinding;
            if (fontBinding != null)
                textBox.FontFamily = fontBinding.Family;

            //This updates the font family in the text box
            textBox.Text = textBox.Text;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            //Bind the FontFamilies list from the code behind (here)
            //to the list picker declared in the XAML
            FontListPicker.ItemsSource = FontFamilies;
            textBox.Text = "Some text here to demonstrate the picker";
            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            //Release
            FontListPicker.ItemsSource = null;
            base.OnNavigatedFrom(e);
        }
    }
}