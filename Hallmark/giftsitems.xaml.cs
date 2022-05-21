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
    public sealed partial class giftsitems : Page
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

        string myName,itemName,itemImage,itemDesc;
        public giftsitems()
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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            myName= e.Parameter as String;
            heading.Text = myName;
            fillItem(myName);
        }



        public void fillItem(String cat)
        {
            if (cat == "Birthday Gifts")
        {
            t1.Source = new BitmapImage(new Uri("ms-appx:///Assets/hello-kitty-memo-pad-set-with-pen-root-b12.jpg", UriKind.RelativeOrAbsolute));
            t2.Source = new BitmapImage(new Uri("ms-appx:///Assets/b2.jpg", UriKind.RelativeOrAbsolute));
            t3.Source = new BitmapImage(new Uri("ms-appx:///Assets/b3.jpg", UriKind.RelativeOrAbsolute));
            t4.Source = new BitmapImage(new Uri("ms-appx:///Assets/b4.jpg", UriKind.RelativeOrAbsolute));
            t5.Source = new BitmapImage(new Uri("ms-appx:///Assets/b5.jpg", UriKind.RelativeOrAbsolute));
            t6.Source = new BitmapImage(new Uri("ms-appx:///Assets/lolita-cheers-handpainted-wine-glass-root-4053097_1470_1.jpg", UriKind.RelativeOrAbsolute));
            t7.Source = new BitmapImage(new Uri("ms-appx:///Assets/coffee-cup-maxine-ornament-root-1hgo1008_1470_1.jpg", UriKind.RelativeOrAbsolute));
            t8.Source = new BitmapImage(new Uri("ms-appx:///Assets/light-your-way-every-day-friend-angel-figurine-ornament-root-19080_1470_1.jpg", UriKind.RelativeOrAbsolute));
            t9.Source = new BitmapImage(new Uri("ms-appx:///Assets/babys-first-birthday-ornament-root-1295qhx1199_1470_1.jpg", UriKind.RelativeOrAbsolute));
            t10.Source = new BitmapImage(new Uri("ms-appx:///Assets/milestone-birthday-ornament-root-1595qhx1054_1470_1.jpg", UriKind.RelativeOrAbsolute));
            
            }


            if (cat == "Wedding Gifts")
            {
                t1.Source = new BitmapImage(new Uri("ms-appx:///Assets/t1.jpg", UriKind.RelativeOrAbsolute));
                t2.Source = new BitmapImage(new Uri("ms-appx:///Assets/t2.jpg", UriKind.RelativeOrAbsolute));
                t3.Source = new BitmapImage(new Uri("ms-appx:///Assets/t3.jpg", UriKind.RelativeOrAbsolute));
                t4.Source = new BitmapImage(new Uri("ms-appx:///Assets/t4.jpg", UriKind.RelativeOrAbsolute));
                t5.Source = new BitmapImage(new Uri("ms-appx:///Assets/t5.jpg", UriKind.RelativeOrAbsolute));
                t6.Source = new BitmapImage(new Uri("ms-appx:///Assets/t6.jpg", UriKind.RelativeOrAbsolute));
                t7.Source = new BitmapImage(new Uri("ms-appx:///Assets/t7.jpg", UriKind.RelativeOrAbsolute));
                t8.Source = new BitmapImage(new Uri("ms-appx:///Assets/t8.jpg", UriKind.RelativeOrAbsolute));
                t9.Source = new BitmapImage(new Uri("ms-appx:///Assets/t9.jpg", UriKind.RelativeOrAbsolute));
                t10.Source = new BitmapImage(new Uri("ms-appx:///Assets/t10.jpg", UriKind.RelativeOrAbsolute));

            }


            if (cat == "Anniversary Gifts")
            {
                t1.Source = new BitmapImage(new Uri("ms-appx:///Assets/a1.jpg", UriKind.RelativeOrAbsolute));
                t2.Source = new BitmapImage(new Uri("ms-appx:///Assets/a2.jpg", UriKind.RelativeOrAbsolute));
                t3.Source = new BitmapImage(new Uri("ms-appx:///Assets/a3.jpg", UriKind.RelativeOrAbsolute));
                t4.Source = new BitmapImage(new Uri("ms-appx:///Assets/a4.jpg", UriKind.RelativeOrAbsolute));
                t5.Source = new BitmapImage(new Uri("ms-appx:///Assets/a5.jpg", UriKind.RelativeOrAbsolute));
                t6.Source = new BitmapImage(new Uri("ms-appx:///Assets/a6.jpg", UriKind.RelativeOrAbsolute));
                t7.Source = new BitmapImage(new Uri("ms-appx:///Assets/a7.jpg", UriKind.RelativeOrAbsolute));
                t8.Source = new BitmapImage(new Uri("ms-appx:///Assets/a8.jpg", UriKind.RelativeOrAbsolute));
                t9.Source = new BitmapImage(new Uri("ms-appx:///Assets/a9.jpg", UriKind.RelativeOrAbsolute));
                t10.Source = new BitmapImage(new Uri("ms-appx:///Assets/a10.jpg", UriKind.RelativeOrAbsolute));

            }
        
        
        
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

    

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(gifts),null);
        }

        private void t1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if(myName=="Birthday Gifts")
            {
                itemName = "Hello Kitty® Memo Pad Set With Pen";
                itemImage = "Assets/hello-kitty-memo-pad-set-with-pen-root-b12.jpg";
                itemDesc = "Price: $12.95" + Environment.NewLine + "" + Environment.NewLine + "Hello Kitty® fans will love this cute memo pad combination bundled with a pen." + Environment.NewLine + "" + Environment.NewLine + "1. Includes designed pen and stationery tower, wrapped with a ribbon." + Environment.NewLine + "2.Tower set has 3 pads: large pad has 100 sheets; medium pad has 100 sheets and top pad has 50 tabbed sheets." + Environment.NewLine + "3. 6.5 W x 6.5 H x 1.75 D";
            }
            if (myName == "Wedding Gifts")
            {
                itemName = "To Have and To Hold Musical Water Globe";
                itemImage = "Assets/t1.jpg";
                itemDesc = "Price: $35.99" + Environment.NewLine + "" + Environment.NewLine + "Though many eyes may be upon you, when you stand before the altar and wed the one you love, it seems you are the only ones there. Caught up in their moment of promise, the couple within this romantic 100mm water globe is a picture of matrimonial happiness" + Environment.NewLine + "" + Environment.NewLine + "1. Plays The Wedding March.               3. Resin, glass." + Environment.NewLine + "2. On globe: To Have and to Hold.";
            }
            if (myName == "Anniversary Gifts")
            {
                itemName = "50th Anniversary Wood Picture Frame";
                itemImage = "Assets/a1.jpg";
                itemDesc = "Price: $14.95" + Environment.NewLine + "" + Environment.NewLine + "Celebrate fifty years of life and love with this special anniversary frame, featuring a silver metal background accented by gold scrollwork and lettering. A classic gift for a milestone anniversary." + Environment.NewLine + "" + Environment.NewLine + "1. Metal and glass.                                          3. On frame: 50th Anniversary." + Environment.NewLine + "2. Easelback for tabletop display.                   4.Holds one 4x6 photo.";
            }
            String merge=itemName+"-"+itemImage+"+"+itemDesc;
            this.Frame.Navigate(typeof(ViewItem),merge );
      
        }

        private void t2_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
                if (myName == "Birthday Gifts")
                {
                    itemName = "Spider Man Connect & Play™ Puzzle";
                    itemImage = "Assets/b2.jpg";
                    itemDesc = "Price: $19.95" + Environment.NewLine + "" + Environment.NewLine + "Spider-Man is always protecting his friends from evil. Watch him save the day as you assemble this action-packed puzzle of Peter Parker weaving his web." + Environment.NewLine + "" + Environment.NewLine + "1. Paper puzzle pieces in metal case." + Environment.NewLine + "2.Connect & Play Puzzles include 36 puzzle pieces, coordinating play pieces and stands." + Environment.NewLine + "3. 7.125 W x 9.875 H x 3.5 D";
                }
                if (myName == "Wedding Gifts")
                {
                    itemName = "Promise Wedding Engagement Love Figurine & Wedding Cake Topper";
                    itemImage = "Assets/t2.jpg";
                    itemDesc = "Price: $36.00" + Environment.NewLine + "" + Environment.NewLine + "Hold dear the warm embrace you shared on your wedding day with this beautiful sculpture." + Environment.NewLine + "This piece, with its round base of carved roses, makes a beautiful centerpiece for your wedding cake." + Environment.NewLine + "" + Environment.NewLine + "1. Sentiment: Hold dear the promise of love." + Environment.NewLine + "2. Resin." + Environment.NewLine + "3. Dust with soft cloth or soft brush. Avoid water or cleaning solvents.";
                }
                if (myName == "Anniversary Gifts")
                {
                    itemName = "Memories Weathered Wood Picture Frame";
                    itemImage = "Assets/a2.jpg";
                    itemDesc = "Price: $12.00" + Environment.NewLine + "" + Environment.NewLine + "Distressed gray wood with an antique silver metal plaque frames a favorite photo with versatile style. Square shape provides a unique feature. Glare-resistant glass lens." + Environment.NewLine + "" + Environment.NewLine + "1. Wood and glass.                                                                              3. Easelback for tabletop display." + Environment.NewLine + "2. On frame: Some Moments stay in our hearts Forever.                   4. Holds one 4x6 photo.";
                }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void t3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Gifts")
            {
                itemName = "Star Wars FUNKO Pop! Captain Phasma Bobblehead";
                itemImage = "Assets/b3.jpg";
                itemDesc = "Price: $12.99" + Environment.NewLine + "" + Environment.NewLine + "From Star Wars: The Force Awakens comes Captain Phasma as a bobblehead clad in distinctive metallic armor for a far-out display piece." + Environment.NewLine + "" + Environment.NewLine + "1. Packaged in window box." + Environment.NewLine + "2. Not recommended for children under 5 years because of vinyl." + Environment.NewLine + "3. 2.5 W x 3.75 H x 2 D";
            }    
                if (myName == "Wedding Gifts")
                {
                    itemName = "Our Wedding Photo Holder Ornament";
                    itemImage = "Assets/t3.jpg";
                    itemDesc = "Price: $3.73" + Environment.NewLine + "" + Environment.NewLine + "Capture a beautiful milestone in the life of your loved one with this commemorative photo holder ornament. What a beautiful way to always remember the promise they made that very special day." + Environment.NewLine + "" + Environment.NewLine + "1. Christmas tree ornament.                               2. Photo holder." + Environment.NewLine + "3. Sticker included for personalization.             4. Plastic coated & Artist crafted.";
                }
                if (myName == "Anniversary Gifts")
                {
                    itemName = "Pearl Pendant Necklace in Sterling Silver";
                    itemImage = "Assets/a3.jpg";
                    itemDesc = "Price: $39.95" + Environment.NewLine + "" + Environment.NewLine + "This pearl pendant is nestled in an elongated sterling silver loop that gives it a modern look sure to accent your other sterling silver jewelry." + Environment.NewLine + "" + Environment.NewLine + "1. Sterling silver with white pearl and diamond accent." + Environment.NewLine + "2. Necklace: 18 L with 2 extender." + Environment.NewLine + "3. Product is packaged in a gift box featuring a Hallmark sentiment card.";
                }
        
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void t4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Gifts")
            {
                itemName = "1969 Dodge Coronet Super Bee Die Cast Metal Car";
                itemImage = "Assets/b4.jpg";
                itemDesc = "Price: $29.95" + Environment.NewLine + "" + Environment.NewLine + "Rev up your classic car collection with this 1969 Dodge Coronet Super Bee replica. Eye-catching red and intricate details make this muscle car a must-have." + Environment.NewLine + "" + Environment.NewLine + "1. 1:24 scale collectible & metallic car." + Environment.NewLine + "2. 8.5 W x 2.25 H x 3.25 D";
            }
            if (myName == "Wedding Gifts")
            {
                itemName = "The Best Is Yet to Come Script Picture Frame";
                itemImage = "Assets/t4.jpg";
                itemDesc = "Price: $36.00" + Environment.NewLine + "" + Environment.NewLine + "Painted gray wood and elegant scrollwork accent this pretty picture frame, an instant celebration of new beginnings and timeless love. Features an inspirational sentiment and glare-resistant glass." + Environment.NewLine + "" + Environment.NewLine + "1. Wood and glass." + Environment.NewLine + "2. Easelback for tabletop display." + Environment.NewLine + "3. Holds one 4x6 photo.";
            }
            if (myName == "Anniversary Gifts")
            {
                itemName = "Rose Quartz Beaded Heart Bracelet in Sterling Silver";
                itemImage = "Assets/a4.jpg";
                itemDesc = "Price: $44.95" + Environment.NewLine + "" + Environment.NewLine + "Adorn your wrist with this double-strand, sterling silver bracelet. Its rose quartz beads and cubic zirconia heart dangle add just the right amount of bling." + Environment.NewLine + "" + Environment.NewLine + "1. Sterling silver beaded bracelet." + Environment.NewLine + "2. Cubic zirconia charm and rose quartz beads." + Environment.NewLine + "3. 7.5 diameter.";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void t5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Gifts")
            {
                itemName = "1967 Chevrolet Camaro SS Die Cast Metal Car";
                itemImage = "Assets/b5.jpg";
                itemDesc = "Price: $29.95" + Environment.NewLine + "" + Environment.NewLine + "Your sports car enthusiast's motor will get all revved for this sleek, black 1967 Camaro SS die-cast metal car." + Environment.NewLine + "" + Environment.NewLine + "1. Artist crafted." + Environment.NewLine + "2. Die-cast metal." + Environment.NewLine + "3. 7.625 W x 3 H x 2 D";
            }
            if (myName == "Wedding Gifts")
            {
                itemName = "Mickey & Minnie Wedding Figurine";
                itemImage = "Assets/t5.jpg";
                itemDesc = "Price: $49.95" + Environment.NewLine + "" + Environment.NewLine + "This Mickey and Minnie wedding sculpture commemorates that special day." + Environment.NewLine + "The hand-painted figurine is perfect as a wedding gift." + Environment.NewLine + "" + Environment.NewLine + "1. Hand painted. Unique variations should be expected.." + Environment.NewLine + "2. Resin.";
            }
            if (myName == "Anniversary Gifts")
            {
                itemName = "Diamond Accent Stacked Double Heart Necklace in Sterling Silver";
                itemImage = "Assets/a5.jpg";
                itemDesc = "Price: $39.95" + Environment.NewLine + "" + Environment.NewLine + "Hearts speak the language of love. This double heart necklace in sterling silver is a beautiful gift for your true love. She will want to wear it every day to think of you." + Environment.NewLine + "" + Environment.NewLine + "1. Sterling silver with diamond accent." + Environment.NewLine + "2. Necklace: 18 L with 2 extender." + Environment.NewLine + "3. 7.5 diameter.";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void t6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Gifts")
            {
                itemName = "Cheers Handpainted Wine Glass Root";
                itemImage = "Assets/lolita-cheers-handpainted-wine-glass-root-4053097_1470_1.jpg";
                itemDesc = "Price: $26.95" + Environment.NewLine + "" + Environment.NewLine + "The perfect glass for any celebration with a simple hand-painted Cheers. Packaged in a signature box, with a special drink recipe on the base of the glass." + Environment.NewLine + "" + Environment.NewLine + "1. Hand wash only." + Environment.NewLine + "2. Recipe included." + Environment.NewLine + "3. Packaged in signature Lolita box.";
            }
            if (myName == "Wedding Gifts")
            {
                itemName = "Our Forever Wedding Picture Frame";
                itemImage = "Assets/t6.jpg";
                itemDesc = "Price: $18.95" + Environment.NewLine + "" + Environment.NewLine + "Capture that special day and put it on display in this porcelain frame." + Environment.NewLine + "It also makes a beautiful wedding gift." + Environment.NewLine + "" + Environment.NewLine + "1. On frame: Our forever is just beginning." + Environment.NewLine + "2. Porcelain." + Environment.NewLine + "3. Holds 4x6 photo.";
            }
            if (myName == "Anniversary Gifts")
            {
                itemName = "Three Hearts Necklace in Sterling Silver";
                itemImage = "Assets/a6.jpg";
                itemDesc = "Price: $39.95" + Environment.NewLine + "" + Environment.NewLine + "Your hearts are linked by love, just like this exquisite sterling silver pendant and its three intertwining hearts. It’s a beautiful symbol of the connection you share." + Environment.NewLine + "" + Environment.NewLine + "1. Created exclusively for Hallmark Gold Crown.         2. Sterling silver necklace: 18 L" + Environment.NewLine + "3. Sterling silver necklace and pendant.                         4. On card: Love connects us one heart at a time." + Environment.NewLine + "5. Pendant: 20x15mm";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void t7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Gifts")
            {
                itemName = "Coffee Cup Maxine Ornament";
                itemImage = "Assets/coffee-cup-maxine-ornament-root-1hgo1008_1470_1.jpg";
                itemDesc = "Price: $8.95" + Environment.NewLine + "" + Environment.NewLine + "Fans of Maxine—and coffee—will get a kick out of this replica coffee cup ornament." + Environment.NewLine + "" + Environment.NewLine + "1. On ornament: Caution: Hot and Bothered" + Environment.NewLine + "2. Christmas tree ornament." + Environment.NewLine + "3. Crafted from resin.";
            }
            if (myName == "Wedding Gifts")
            {
                itemName = "Embrace Memory Box";
                itemImage = "Assets/t7.jpg";
                itemDesc = "Price: $33.00" + Environment.NewLine + "" + Environment.NewLine + "This finely-crafted, hand-painted wood memory box is the perfect gift for safely storing special treasures such as notes, jewelry and mementos. Honor the love of your life with this keepsake piece depicting the special closeness you share." + Environment.NewLine + "" + Environment.NewLine + "1. Sentiment: In love's embrace                        2. Wood composite, resin." + Environment.NewLine + "3. Dust with soft cloth or soft brush.                4. Avoid water or cleaning solvents.";
            }
            if (myName == "Anniversary Gifts")
            {
                itemName = "Wishbone Necklace in Sterling Silver";
                itemImage = "Assets/a7.jpg";
                itemDesc = "Price: $39.95" + Environment.NewLine + "" + Environment.NewLine + "Let love be the center of your wishes with this sterling silver wishbone pendant and the tiny heart nestled in its middle. It is sure to tug at the heartstrings of the one you love." + Environment.NewLine + "" + Environment.NewLine + "1. Created exclusively for Hallmark Gold Crown.         2. Sterling silver necklace: 18 L" + Environment.NewLine + "3. 14K yellow gold plated heart pendant.                       4. On card: Love connects us one heart at a time." + Environment.NewLine + "5. Pendant: 20x14mm";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void t8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Gifts")
            {
                itemName = "Light Your Way Every Day Friend Angel Figurine Ornament";
                itemImage = "Assets/light-your-way-every-day-friend-angel-figurine-ornament-root-19080_1470_1.jpg";
                itemDesc = "Price: $14.95" + Environment.NewLine + "" + Environment.NewLine + "Friends are forever. Show her how much she means with this delicate angel ornament." + Environment.NewLine + "Intricate design, elegant embellishment and fine attention to detail make it as beautiful as it is thoughtful." + Environment.NewLine + "" + Environment.NewLine + "1. On ornament: Forever my friend" + Environment.NewLine + "2. Crafted from resin.";
            }
            if (myName == "Wedding Gifts")
            {
                itemName = "God's Love Ornament";
                itemImage = "Assets/t8.jpg";
                itemDesc = "Price: $17.95" + Environment.NewLine + "" + Environment.NewLine + "Share a comforting message with a friend or loved one when you give them this porcelain ornament with intertwining cross and gold heart. They're sure to feel God's love through your thoughtfulness." + Environment.NewLine + "" + Environment.NewLine + "1. Christmas tree ornament." + Environment.NewLine + "2. On ornament: God's love is always with you." + Environment.NewLine + "3. Porcelain & Artist crafted.";
            }
            if (myName == "Anniversary Gifts")
            {
                itemName = "Through The Years Wedding Anniversary Figurine";
                itemImage = "Assets/a8.jpg";
                itemDesc = "Price: $65.99" + Environment.NewLine + "" + Environment.NewLine + "The happiest couples are those that find new things to love about each other with each passing year. Celebrate any anniversary, whether a first or 60th with this piece showing a couple still in step with one another." + Environment.NewLine + "" + Environment.NewLine + "1. Bisque porcelain." + Environment.NewLine + "2. 5.5 H";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void t9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Gifts")
            {
                itemName = "Baby's First Birthday Ornament";
                itemImage = "Assets/babys-first-birthday-ornament-root-1295qhx1199_1470_1.jpg";
                itemDesc = "Price: $12.95" + Environment.NewLine + "" + Environment.NewLine + "Commemorate baby's first birthday with this adorable photo holder ornament." + Environment.NewLine + "Every year you and your little one will enjoy looking back on that super-fun day!" + Environment.NewLine + "" + Environment.NewLine + "1. Christmas tree ornament.                        2. Plastic." + Environment.NewLine + "3. Holds photo.                                            4. Personalize with stickers." + Environment.NewLine + "5. Artist crafted.                                           6. Plastic coated.";
            }
            if (myName == "Wedding Gifts")
            {
                itemName = "Wedding Photo Holder Ornament";
                itemImage = "Assets/t9.jpg";
                itemDesc = "Price: $17.95" + Environment.NewLine + "" + Environment.NewLine + "Capture a beautiful occasion in the life of two people with this ethereal photo holder ornament representing their best day ever!" + Environment.NewLine + "" + Environment.NewLine + "1. On ornament: 2016 BEST DAY EVER!" + Environment.NewLine + "2. Includes interchangeable stickers: The Happy Couple Our Wedding Date." + Environment.NewLine + "3. Porcelain.";
            }
            if (myName == "Anniversary Gifts")
            {
                itemName = "Geometric Wedding Guest Book and Pen Set";
                itemImage = "Assets/a9.jpg";
                itemDesc = "Price: $24.95" + Environment.NewLine + "" + Environment.NewLine + "Capture family and friends' signatures, addresses and congratulations for your big day in our elegant, simply designed guest book." + Environment.NewLine + "" + Environment.NewLine + "1. Includes pearlized metallic pen." + Environment.NewLine + "2. Features printed, designed endliners, dedication page and 48 lined pages for guest entries." + Environment.NewLine + "3. Guest book has debossed geometric pattern with pearlescent finish and gun metal hot foil lettering on cover.";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

        private void t10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (myName == "Birthday Gifts")
            {
                itemName = "Milestone Birthday Ornament";
                itemImage = "Assets/milestone-birthday-ornament-root-1595qhx1054_1470_1.jpg";
                itemDesc = "Price: $15.95" + Environment.NewLine + "" + Environment.NewLine + "Make that milestone birthday an occasion to remember with this birthday ornament." + Environment.NewLine + "Stickers included to personalize this celebratory event!" + Environment.NewLine + "" + Environment.NewLine + "1. Includes interchangeable stickers: 20, 30, 40, 50, 60, and 0, 1, 2, 3, 4, 5, 6, 7, 8." + Environment.NewLine + "2. Wood.";
            }
            if (myName == "Wedding Gifts")
            {
                itemName = "Wedding Cake Ornament";
                itemImage = "Assets/t10.jpg";
                itemDesc = "Price: $4.98" + Environment.NewLine + "" + Environment.NewLine + "Commemorate the year they dedicated their lives to each other with this white wedding cake ornament. This is the perfect wedding or Christmas gift for the newlyweds in your life." + Environment.NewLine + "" + Environment.NewLine + "1. Christmas tree ornament." + Environment.NewLine + "2. On ornament: 2015." + Environment.NewLine + "3. Porcelain with fabric ribbon & Artist crafted.";
            }
            if (myName == "Anniversary Gifts")
            {
                itemName = "Our Golden Anniversary Ceramic Plate";
                itemImage = "Assets/a10.jpg";
                itemDesc = "Price: $22.99" + Environment.NewLine + "" + Environment.NewLine + "Fifty years of marriage deserves a gift as special as the love it celebrates. This ceramic plate features a fleur-de-lis pattern, gold accents and a ribbon for wall hanging." + Environment.NewLine + "" + Environment.NewLine + "1. Ceramic." + Environment.NewLine + "2. On plate: 50th Our Golden Anniversary, Love begins in a moment, grows over time, and lasts for eternity.";
            }
            String merge = itemName + "-" + itemImage + "+" + itemDesc;
            this.Frame.Navigate(typeof(ViewItem), merge);
        }

    }
}
