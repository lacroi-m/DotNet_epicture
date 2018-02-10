/*using System;
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
            //TextBox myTextBox = new TextBox();0
           // myTextBox.Width = 200;

            
            // Enable spellchecking on the TextBox.
         //   myTextBox.SpellCheck.IsEnabled = true;

            // Alternatively, the SetIsEnabled method could be used
            // to enable or disable spell checking like this:
            // SpellCheck.SetIsEnabled(myTextBox, true);

           // myStackPanel.Children.Add(myTextBox);
           // this.Content = myStackPanel;
        }
    }

    public partial class MainWindow : Window
    {
        string search;
        string str = "";
        List<string> url = new List<string>();
        int list = 0;
        const string apiKey = "1b83043f069825ebe46685c2a1ba4bc9";
        const string password = "ed73e0b97611e032";

        public class DisplayImage
        {
            public string Url { get; set; }
            public DisplayImage() { }
            public DisplayImage(string url)
            {
                this.Url = url;
            }   
        }



        public string contents;
        public string Contents
        {
            get { return contents; }
        }

        Flickr flickr = new Flickr(apiKey);
        public MainWindow()
        { 



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            search = MyTextBox.Text;
            var options = new PhotoSearchOptions
            {
                Tags = search,
                PerPage = 5,
                Page = 1
            };
            PhotoCollection photos = flickr.PhotosSearch(options);
           flickr.

            // Get TextBlock reference.
            var block = sender as TextBlock;
            // Set text.
            int line = 1;
            //list contenant les urls des images à charger (chercher en fcts des tags)

            TextBlock textBlock = new TextBlock();

            foreach (Photo photo in photos)
            {
                var Path = photo.WebUrl;
                var image = new Image();

                BitmapImage myBitmapImage = new BitmapImage();
                myBitmapImage.BeginInit();
                myBitmapImage.UriSource = new Uri(photo.WebUrl, UriKind.Absolute);
                myBitmapImage.EndInit();
                image.Source = myBitmapImage;
                url.Add(photo.WebUrl);
                //appeler la fonction qui charge les images via l'url
                textBlock.Name = "yo";
                //du coup ça ça affiche le dernier url.
                line++;
                // MyLabel.Content = MyTextBox.Text;
                contents = "https://farm" + photo.Farm + ".staticflickr.com/" + photo.Server + "/" + photo.PhotoId + "_" + photo.Secret + ".jpg";
                MyTextBox.Text = contents;
                
            }
        }

        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    
}; */




/*using System;
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
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using System.Collections.ObjectModel;
using FlickrNet;

namespace epicture
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string apiKey = "1b83043f069825ebe46685c2a1ba4bc9";
        const string password = "ed73e0b97611e032";     
        Flickr flickr = new Flickr(apiKey);



        public class ListBoxContent
        {
            public string Url { get; set; }
            //public Imgur.API.Models.Impl.GalleryImage Img { get; set; }

            public ListBoxContent() { }

            public ListBoxContent(string url)
            {
                this.Url = url;
            }
        }

        public Flickr client;
       // public ImgurClient client;
        public ObservableCollection<ListBoxContent> contents = new ObservableCollection<ListBoxContent>();

        public ObservableCollection<ListBoxContent> Contents
        {
            get { return contents; }
        }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            client = new Flickr(apiKey, password);
                     //client = new ImgurClient("3439bd12f69a542", "85c9a54a0dfadaac225726f5ffa7a70630b9af93");
        }

        private  async void onTextChangedSearch(object sender, TextChangedEventArgs e)
        {
            Contents.Clear();
            string search = ((TextBox)sender).Text;
            var options = new PhotoSearchOptions
            {
                Tags = search,
                PerPage = 5,
                Page = 1
            };

            PhotoCollection photos = flickr.PhotosSearch(options);
            // Set text.
            int line = 1;
            //list contenant les urls des images à charger (chercher en fcts des tags)


            foreach (Photo photo in photos)
            {
                var Path = photo.WebUrl;
                var image = new Image();                

                ListBoxContent content = new ListBoxContent();

                content.Url = "https://farm" + photo.Farm + ".staticflickr.com/" + photo.Server + "/" + photo.PhotoId + "_" + photo.Secret + ".jpg";
                // var enpoint = new GalleryEndpoint(client);
                //var images = await endpoint.SearchGalleryAdvancedAsync(null, null, search, null, null, null, Imgur.API.Enums.GallerySortOrder.Time);
                /*foreach (var image in images)
                {
                    if (image.GetType() != typeof(Imgur.API.Models.Impl.GalleryImage))
                        continue;
                    Imgur.API.Models.Impl.GalleryImage tmp = (Imgur.API.Models.Impl.GalleryImage)image;
                    ListBoxContent content = new ListBoxContent();
                    content.Url = tmp.Link;
                    content.Img = tmp;
                    Contents.Add(content);
                }
                line++;
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //var endpoint = new ImageEndpoint(client);
            //await endpoint.FavoriteImageAsync(((ListBoxContent)((Button)sender).DataContext).Img.Id);
        }
    }
}*/

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
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using System.Collections.ObjectModel;
using System.IO;
using System.Diagnostics;

namespace epicture
{
    public partial class MainWindow : Window
    {
        int f = 0;
        public class ListBoxContent
        {
            public string Url { get; set; }
            public Imgur.API.Models.Impl.GalleryImage Img { get; set; }

            public ListBoxContent() { }

            public ListBoxContent(string url, Imgur.API.Models.Impl.GalleryImage img)
            {
                this.Url = url;
                this.Img = img;
            }
        }

        public ImgurClient client;
        public ObservableCollection<ListBoxContent> contents = new ObservableCollection<ListBoxContent>();

        public ObservableCollection<ListBoxContent> Contents
        {
            get { return contents; }
        }


        public ObservableCollection<ListBoxContent> favoris = new ObservableCollection<ListBoxContent>();

        public ObservableCollection<ListBoxContent> Favoris
        {
            get { return favoris; }
        }

        string favpath;
        string swappath;
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            client = new ImgurClient("3439bd12f69a542", "85c9a54a0dfadaac225726f5ffa7a70630b9af93");

            favpath = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\Fav\", "FavList.txt");
            swappath = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\Fav\", "Swap.txt");
            if (!File.Exists(favpath))
            {
                File.Create(favpath);
            }
            else if (File.Exists(favpath))
            {
                    string line = null;
                    using (StreamReader reader = new StreamReader(favpath))
                    {
                    while ((line = reader.ReadLine()) != null)
                            {
                        ListBoxContent favoris = new ListBoxContent();
                        favoris.Url = line;
                                Favoris.Add(favoris);
                            }
                    reader.Close();
                    }
            }

            if (!File.Exists(swappath))
            {
                File.Create(swappath);
            }
            else if (File.Exists(swappath))
            {
                File.WriteAllText(swappath, string.Empty);
            }
        }

        private async void onTextChangedSearch(object sender, RoutedEventArgs e)
        {
            favoriteDisplay = false;
            string search = searching.Text;
            Contents.Clear();
            var endpoint = new GalleryEndpoint(client);
            Imgur.API.Enums.ImageFileType? Filetype = null;
            if (type.Text == "Jpg")
                Filetype = Imgur.API.Enums.ImageFileType.Jpg;
            else if (type.Text == "Png")
                Filetype = Imgur.API.Enums.ImageFileType.Png;
            else if (type.Text == "Gif")
                Filetype = Imgur.API.Enums.ImageFileType.Gif;
            else if (type.Text == "Anigif")
                Filetype = Imgur.API.Enums.ImageFileType.Anigif;
 
            Imgur.API.Enums.ImageSize? Fileformat = null;
            if (format.Text == "Small")
                Fileformat = Imgur.API.Enums.ImageSize.Small;
            else if (format.Text == "Medium")
                Fileformat = Imgur.API.Enums.ImageSize.Med;
            else if (format.Text == "Big")
                Fileformat = Imgur.API.Enums.ImageSize.Big;
            else if (format.Text == "Large")
                Fileformat = Imgur.API.Enums.ImageSize.Lrg;
            else if (format.Text == "Huge")
                Fileformat = Imgur.API.Enums.ImageSize.Huge;

            if (search == "")
                return;
            var gallerys = await endpoint.SearchGalleryAdvancedAsync(search, null, null, null, Filetype, Fileformat, Imgur.API.Enums.GallerySortOrder.Time);
            foreach (var gallery in gallerys)
            {
                if (gallery.GetType() != typeof(Imgur.API.Models.Impl.GalleryAlbum))
                {
                    Imgur.API.Models.Impl.GalleryImage tip = (Imgur.API.Models.Impl.GalleryImage)gallery;
                    ListBoxContent content = new ListBoxContent();
                    content.Url = tip.Link;
                    Contents.Add(content);
                    continue;
                }
                Imgur.API.Models.Impl.GalleryAlbum tmp = (Imgur.API.Models.Impl.GalleryAlbum)gallery;
                foreach (var image in tmp.Images)
                {
                    ListBoxContent content = new ListBoxContent();
                    content.Url = image.Link;
                    Contents.Add(content);
                }
            }
        }
        bool favoriteDisplay = false;
        private void Display_Favoris(object send , RoutedEventArgs e)
        {
            Contents.Clear();
            foreach(var favoris in Favoris)
            {
                Contents.Add(favoris);
            }
            favoriteDisplay = true;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Image img = ((StackPanel)((DockPanel)((Button)sender).Parent).Parent).Children.OfType<DockPanel>().First().Children.OfType<Image>().First();
            ListBoxContent favoris = new ListBoxContent();
            if (img.Source.ToString() != null)
            {
                favoris.Url = img.Source.ToString();

                using (var FavListTxt = new StreamWriter(favpath, true))
                {
                    FavListTxt.WriteLine(img.Source.ToString());
                    FavListTxt.Close();
                }
                int i = -1;
                if (favoriteDisplay == false)
                    Favoris.Add(favoris);
                foreach (var favorispars in Favoris)
                {
                    if (Contents[++i].Url == img.Source.ToString() && favoriteDisplay == false)
                    {
                        Contents.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Image img = ((StackPanel)((DockPanel)((Button)sender).Parent).Parent).Children.OfType<DockPanel>().First().Children.OfType<Image>().First();
            ListBoxContent locfavoris = new ListBoxContent();
            if (img.Source.ToString() != string.Empty)
            {
                int i = -1;
                foreach (var favoris in Favoris)
                {
                    if (Favoris[++i].Url == img.Source.ToString())
                    {
                        Favoris.RemoveAt(i);
                        Contents.RemoveAt(i);
                        //suprime le liens dans le fichié text (Fav/FavList.txt)
                            string line = null;
                            string line_to_delete = img.Source.ToString();
                        using (StreamReader reader = new StreamReader(favpath))
                        {
                            using (StreamWriter writer = new StreamWriter(swappath))
                            {
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (String.Compare(line, line_to_delete) == 0)
                                        continue;
                                    writer.WriteLine(line);
                                }
                                writer.Close();
                            }
                           reader.Close();
                        }
                        using (StreamReader readerswap = new StreamReader(swappath))
                        {
                            File.WriteAllText(favpath, string.Empty);
                            using (StreamWriter writterFav = new StreamWriter(favpath))
                            {
                                while ((line = readerswap.ReadLine()) != null)
                                {
                                    writterFav.WriteLine(line);
                                }
                            }

                        }
                        break;
                        }
                    }
                }
            }
        }
    }
