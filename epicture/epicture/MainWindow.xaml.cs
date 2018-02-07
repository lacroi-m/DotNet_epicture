using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FlickrNet;

namespace epicture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class SpellCheckExample : Page
    {
        public SpellCheckExample()
        {
            StackPanel myStackPanel = new StackPanel();

            //Create TextBox
            TextBox myTextBox = new TextBox();
            myTextBox.Width = 200;

            
            // Enable spellchecking on the TextBox.
            myTextBox.SpellCheck.IsEnabled = true;

            // Alternatively, the SetIsEnabled method could be used
            // to enable or disable spell checking like this:
            // SpellCheck.SetIsEnabled(myTextBox, true);

            myStackPanel.Children.Add(myTextBox);
            this.Content = myStackPanel;
        }
    }

    public partial class MainWindow : Window
    {
        const string apiKey = "1b83043f069825ebe46685c2a1ba4bc9";
        const string password = "ed73e0b97611e032";


        Flickr flickr = new Flickr(apiKey);
        public MainWindow()
        {

            //const string apiKey = "yourapikeygoeshere";

            //Flickr flickr = new Flickr(apiKey);


        }
        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {


            string searchTerm = "sexy";

            var options = new PhotoSearchOptions
            {
                Tags = searchTerm,
                PerPage = 10000,
                Page = 1
            };
            PhotoCollection photos = flickr.PhotosSearch(options);

            // Get TextBlock reference.
            var block = sender as TextBlock;
            // Set text.
            var line = 1;
            //list contenant les urls des images à charger (chercher en fcts des tags)
            List<string> url = new List<string>();

            TextBlock textBlock = new TextBlock();

            foreach (Photo photo in photos)
            {
                url.Add(photo.WebUrl);
                //appeler la fonction qui charge les images via l'url
                textBlock.Name = "yo";

                //du coup ça ça affiche le dernier url.
                block.Text = photo.WebUrl;
                line++;

                //s'occper des favoris

                //s'occuper de imgbur (sevag inc rush tmtc)
                //s'occuper de l'UX
            }
            /*block.Text = "This is some longer text in the TextBlock. " +
                "We see how it wraps in this example. " +
                "TextBlock is meant for longer text.";*/
        }

    }
};