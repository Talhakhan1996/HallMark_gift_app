using Hallmark.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Hallmark
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class cardsitems : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        string myName, itemName, itemImage, itemDesc;
        public cardsitems()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            myName= e.Parameter as String;
            heading2.Text =myName ;
            fillItem(myName);
        }


        public void fillItem(String cat)
        {
            if (cat == "Birthday Cards")
            {
                c1.Source = new BitmapImage(new Uri("ms-appx:///Assets/c1.png", UriKind.RelativeOrAbsolute));
                c2.Source = new BitmapImage(new Uri("ms-appx:///Assets/c2.png", UriKind.RelativeOrAbsolute));
                c3.Source = new BitmapImage(new Uri("ms-appx:///Assets/c3.png", UriKind.RelativeOrAbsolute));
                c4.Source = new BitmapImage(new Uri("ms-appx:///Assets/c4.png", UriKind.RelativeOrAbsolute));
                c5.Source = new BitmapImage(new Uri("ms-appx:///Assets/c5.png", UriKind.RelativeOrAbsolute));
                c6.Source = new BitmapImage(new Uri("ms-appx:///Assets/c6.png", UriKind.RelativeOrAbsolute));
                c7.Source = new BitmapImage(new Uri("ms-appx:///Assets/c7.png", UriKind.RelativeOrAbsolute));
                c82.Source = new BitmapImage(new Uri("ms-appx:///Assets/c82.PNG", UriKind.RelativeOrAbsolute));
                c9.Source = new BitmapImage(new Uri("ms-appx:///Assets/c9.png", UriKind.RelativeOrAbsolute));
                c10.Source = new BitmapImage(new Uri("ms-appx:///Assets/c10.png", UriKind.RelativeOrAbsolute));
            }

            if (cat == "Wedding Cards")
            {
                c1.Source = new BitmapImage(new Uri("ms-appx:///Assets/w1.png", UriKind.RelativeOrAbsolute));
                c2.Source = new BitmapImage(new Uri("ms-appx:///Assets/w2.png", UriKind.RelativeOrAbsolute));
                c3.Source = new BitmapImage(new Uri("ms-appx:///Assets/w3.png", UriKind.RelativeOrAbsolute));
                c4.Source = new BitmapImage(new Uri("ms-appx:///Assets/w4.png", UriKind.RelativeOrAbsolute));
                c5.Source = new BitmapImage(new Uri("ms-appx:///Assets/w5.png", UriKind.RelativeOrAbsolute));
                c6.Source = new BitmapImage(new Uri("ms-appx:///Assets/w6.png", UriKind.RelativeOrAbsolute));
                c7.Source = new BitmapImage(new Uri("ms-appx:///Assets/w7.png", UriKind.RelativeOrAbsolute));
                c82.Source = new BitmapImage(new Uri("ms-appx:///Assets/w8.png", UriKind.RelativeOrAbsolute));
                c9.Source = new BitmapImage(new Uri("ms-appx:///Assets/w9.png", UriKind.RelativeOrAbsolute));
                c10.Source = new BitmapImage(new Uri("ms-appx:///Assets/w10.png", UriKind.RelativeOrAbsolute));
            }

            if (cat == "Friendship Cards")
            {
                c1.Source = new BitmapImage(new Uri("ms-appx:///Assets/f1.png", UriKind.RelativeOrAbsolute));
                c2.Source = new BitmapImage(new Uri("ms-appx:///Assets/f2.png", UriKind.RelativeOrAbsolute));
                c3.Source = new BitmapImage(new Uri("ms-appx:///Assets/f3.png", UriKind.RelativeOrAbsolute));
                c4.Source = new BitmapImage(new Uri("ms-appx:///Assets/f4.png", UriKind.RelativeOrAbsolute));
                c5.Source = new BitmapImage(new Uri("ms-appx:///Assets/f5.png", UriKind.RelativeOrAbsolute));
                c6.Source = new BitmapImage(new Uri("ms-appx:///Assets/f6.png", UriKind.RelativeOrAbsolute));
                c7.Source = new BitmapImage(new Uri("ms-appx:///Assets/f7.png", UriKind.RelativeOrAbsolute));
                c82.Source = new BitmapImage(new Uri("ms-appx:///Assets/f8.png", UriKind.RelativeOrAbsolute));
                c9.Source = new BitmapImage(new Uri("ms-appx:///Assets/f9.png", UriKind.RelativeOrAbsolute));
                c10.Source = new BitmapImage(new Uri("ms-appx:///Assets/f10.png", UriKind.RelativeOrAbsolute));
            }
        }
        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    navigationHelper.OnNavigatedTo(e);
        //}

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion/// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cards),null);
        }

        private void c1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if(myName == "Birthday Cards")
            {
                itemName = "Frozen Elsa Birthday Let it Go Card";
                itemImage = "Assets/c1.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "Frozen's popularity is undeniable and Elsa's image on this card is sure to continue the frenzy for many birthdays to come!" + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5.75 W x 8.25 H";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "Mr. Right & Mr. Perfect Wedding Card";
                itemImage = "Assets/w1.png";
                itemDesc = "Price: $3.99" + Environment.NewLine + "" + Environment.NewLine + "Celebrate a beautiful new chapter for two wonderful grooms who make the perfect pair." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: What do you get / when / Mr. Right / and / Mr. Perfect / fall in / love?";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "Coffee Shop Chat Thank You Card";
                itemImage = "Assets/f1.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "Show your sincere regard with this warm, heartfelt expression of appreciation." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5.75 W x 8.25 H";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Thank You Birthday Card";
                itemImage = "Assets/c2.png";
                itemDesc = "Price: $6.99" + Environment.NewLine + "" + Environment.NewLine + "Thank you for everything / you do for me. / Thank you for seeing / whatever it is you see in me. / Thank you for being you / and being amazing. / And thank you, thank you, thank you / for making me this happy. Give thanks for all she does and who she is with this card's beautiful message and backdrop." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary.     2. Handwork." + Environment.NewLine + "3. 5.75 W x 8.25 H                                                                                     4. Extra postage required.";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "A Happy Ending for You Wedding Card";
                itemImage = "Assets/w2.png";
                itemDesc = "Price: $6.95" + Environment.NewLine + "" + Environment.NewLine + "Set against teal paper, layers of tulle and a bouquet of gems embellish a silhouette of a bride gazing up at her groom. An elegant wish for a wonderful future." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Extra postage required.";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "Military Time Thinking of You Card";
                itemImage = "Assets/f2.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "Brighten your active-duty soldier's day with a warm greeting from home, expressing an upbeat you're on my mind." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: I think of you at 0700 and 0917 and 1356 and 1501 and 2310...";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Big Questions Birthday Card";
                itemImage = "Assets/c3.png";
                itemDesc = "Price: $3.49" + Environment.NewLine + "" + Environment.NewLine + "Is this the birthday when you start asking yourself / life's big questions? Philosophy meets humor inside this birthday card from Hallmark's Shoebox collection." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "Laughter and Love Wedding Congratulations Card";
                itemImage = "Assets/w3.png";
                itemDesc = "Price: $4.99" + Environment.NewLine + "" + Environment.NewLine + "This wedding keepsake card comes with a wooden heart that can be removed and kept as a memory of your best day to date." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Extra postage required.";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "Marjolein Bastin Floral Friendship Card";
                itemImage = "Assets/f3.png";
                itemDesc = "Price: $1.99" + Environment.NewLine + "" + Environment.NewLine + "A beautiful bouquet greets its recipient on a card that lets someone special know you're thinking about them." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: Just a note / to keep in touch…";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Fireworks and Favorite Wishes Birthday Card";
                itemImage = "Assets/c4.png";
                itemDesc = "Price: $1.99" + Environment.NewLine + "" + Environment.NewLine + "Wish them a birthday celebration full of favorite wishes and fireworks." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: Happy Birthday";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "You Make My Life Complete Wedding Card";
                itemImage = "Assets/w4.png";
                itemDesc = "Price: $3.99" + Environment.NewLine + "" + Environment.NewLine + "He's the man of your dreams. Let him know how much you love him with this sweet card, a perfect show of expression for the day of your wedding." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Glitter, foiled & Ribbon attachement.";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "Floral Grateful For You Just Because Card";
                itemImage = "Assets/f4.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "This card is a feast for the eyes containing a meaningful message for the heart." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5.75 W x 8.25 H" + Environment.NewLine + "3. Embossed";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Real Deal Happy Birthday Card";
                itemImage = "Assets/c5.png";
                itemDesc = "Price: $1.99" + Environment.NewLine + "" + Environment.NewLine + "Let someone special in your life know that you're wishing them more than cake-and-presents happiness for their birthday with this thoughtful card from Hallmark." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: Happy Birthday";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "Dance Through Life with Happiness Wedding Card";
                itemImage = "Assets/w5.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "This whimsical design makes for the ideal wedding card, complete with charming anecdote for the ages." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Foiled.";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "A Beautiful and Unique Friend Marjolein Bastin Card";
                itemImage = "Assets/f5.png";
                itemDesc = "Price: $5.99" + Environment.NewLine + "" + Environment.NewLine + "Laser-cut paper and a ribbon provide an elegant setting for a beautiful watercolored butterfly by artist Marjolein Bastin paired with sweet words." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Die-cut with ribbon embellishment.";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Balloon Bouquet Birthday Card";
                itemImage = "Assets/c6.png";
                itemDesc = "Price: $1.99" + Environment.NewLine + "" + Environment.NewLine + "This cheerful bundle of balloons conveys best wishes for a special day." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: A Birthday Wish / for you";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "Pink Floral Bouquet Religious Wedding Card";
                itemImage = "Assets/w6.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "It's always a good idea to make room for Christ in your marriage, having His intervention in difficult and happy times. This card signifies the couple that prays together, stays together." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Foiled";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "What Every Woman Needs Friendship Card";
                itemImage = "Assets/f6.png";
                itemDesc = "Price: $5.99" + Environment.NewLine + "" + Environment.NewLine + "A miniature LBD (read; little black dress) brings stylish flair to pink and gold polka dots, a pretty precursor to the sweet celebration of friendship inside." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary.                     2. 5 W x 7 H" + Environment.NewLine + "3. Features fabric, sequins, ribbon and foil accents.                                                   4. Extra postage required.";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Snoopy Birthday Card";
                itemImage = "Assets/c7.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "Let Snoopy say it again and again with this cute card from Hallmark: Happy Birthday! Happy Birthday!" + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: A Birthday Wish.";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "A Day as Bright as Tomorrow Wedding Congratulations Card";
                itemImage = "Assets/w7.png";
                itemDesc = "Price: $5.99" + Environment.NewLine + "" + Environment.NewLine + "A card commonly neutral but now in bright blue, to celebrate a divine love and life full of rich experiences for the future, forever." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Flittered";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "Female Friendship Dots Just Because Card";
                itemImage = "Assets/f7.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "There aren't many things sweeter in life than having that best friend to laugh with, cry to and bare your soul—making this just because card that much more significant." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Foiled";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c8_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Flowerpot Chairs Birthday Card";
                itemImage = "Assets/c82.png";
                itemDesc = "Price: $1.99" + Environment.NewLine + "" + Environment.NewLine + "Fresh potted flowers relax on a chair on this thoughtful birthday card for a special friend." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: Birthday Wishes.";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "Tux and Dress Wedding Card";
                itemImage = "Assets/w8.png";
                itemDesc = "Price: $8.99" + Environment.NewLine + "" + Environment.NewLine + "Decked out in its finest wedding attire for the occasion, this card is sure to get an Aww! out of the bride to be as you wish her and her groom happiness in their new life together." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary.         2.Fabric, gems and emboss." + Environment.NewLine + "3. 5 W x 7 H                                                                                                   4. Extra postage required.";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "Flowers and Hugs Thinking of You Card";
                itemImage = "Assets/f8.png";
                itemDesc = "Price: $1.99" + Environment.NewLine + "" + Environment.NewLine + "This charming card attracts with a lovely bouquet of flowers and a bonus declaration of affection across the miles." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Sweet Blessings Floral and Leaves Birthday Card";
                itemImage = "Assets/c9.png";
                itemDesc = "Price: $3.49" + Environment.NewLine + "" + Environment.NewLine + "Celebrate the sweet blessings of life this year with a birthday card that counts the years of life in kindnesses and close friends." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 8.25 H";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "A Toast for Two Engagement Card";
                itemImage = "Assets/w9.png";
                itemDesc = "Price: $5.99" + Environment.NewLine + "" + Environment.NewLine + "Say Cheers to you! with this bright and bubbly card" + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Foiled.";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "Courageous, Strong, Faithful Military Thank You Card";
                itemImage = "Assets/f9.png";
                itemDesc = "Price: $2.99" + Environment.NewLine + "" + Environment.NewLine + "With a graceful image of a bald eagle in flight, inspire a member of our military and offer a heartfelt thank you for their unequaled service for our country." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Foiled";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void c10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Cards")
            {
                itemName = "Deseos Para la Quinceañera en Inglés";
                itemImage = "Assets/c10.png";
                itemDesc = "Price: $1.99" + Environment.NewLine + "" + Environment.NewLine + "A beautiful card for a beautiful Quinceañera. Filled with floral patterning and a heartfelt message for the birthday girl, this Hallmark VIDA card is the perfect way to honor such a momentous occasion." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H";
            }
            if (myName == "Wedding Cards")
            {
                itemName = "Pink & Orange Flowers Wedding Card";
                itemImage = "Assets/w10.png";
                itemDesc = "Price: $3.99" + Environment.NewLine + "" + Environment.NewLine + "Celebrate a sweet friendship that has blossomed into a beautiful love." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H" + Environment.NewLine + "3. Front Message: TWO / Falling / in love / BECOME ONE";
            }
            if (myName == "Friendship Cards")
            {
                itemName = "Fresh Flower Marjolein Bastin Friendship Card";
                itemImage = "Assets/f10.png";
                itemDesc = "Price: $3.99" + Environment.NewLine + "" + Environment.NewLine + "White tulips accented with soft pink tips along with a sweet message about friendship will perk up a friend's day." + Environment.NewLine + "" + Environment.NewLine + "1. Includes envelope and Gold Crown seal. Envelope color may vary." + Environment.NewLine + "2. 5 W x 7 H";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }
        
    }
}
