using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Luna_Bay_Resort.Controls
{
    public partial class BookingUserControl : UserControl
    {
        public ObservableCollection<ListItem> ListItems { get; set; }

        public BookingUserControl()
        {
            InitializeComponent(); // Ensures XAML elements are recognized
            LoadBookingCards();
            LoadCheckInOutCards();

            // Initialize the collection and add items
            ListItems = new ObservableCollection<ListItem>
            {
                new ListItem { Text = "Reservation 1" },
                new ListItem { Text = "Reservation 2" },
                new ListItem { Text = "Reservation 3" }
            };

            // Bind the collection to the ListView
            ListViewRight.ItemsSource = ListItems;
        }

        private void LoadBookingCards()
        {
            var reservationCards = new List<Booking>
            {
                new Booking { ImageSource = new BitmapImage(new Uri(@"C:\Users\JAY\source\repos\Luna-Bay-Resort\Luna-Bay-Resort\Resources\addReservation.png")), ButtonText = "Add Reservation" },
                new Booking { ImageSource = new BitmapImage(new Uri(@"C:\Users\JAY\source\repos\Luna-Bay-Resort\Luna-Bay-Resort\Resources\editReservation.png")), ButtonText = "Edit Reservation" },
                new Booking { ImageSource = new BitmapImage(new Uri(@"C:\Users\JAY\source\repos\Luna-Bay-Resort\Luna-Bay-Resort\Resources\viewReservation.png")), ButtonText = "View Reservation" }
            };

            // Bind the list to the ItemsControl
            ReservationContainer.ItemsSource = reservationCards;
        }

        private void LoadCheckInOutCards()
        {
            var checkInOutCards = new List<Booking>
            {
                new Booking { ImageSource = new BitmapImage(new Uri(@"C:\Users\JAY\source\repos\Luna-Bay-Resort\Luna-Bay-Resort\Resources\check-in.png")), ButtonText = "Check In" },
                new Booking { ImageSource = new BitmapImage(new Uri(@"C:\Users\JAY\source\repos\Luna-Bay-Resort\Luna-Bay-Resort\Resources\check-out.png")), ButtonText = "Check Out" }
            };

            // Bind the list to the ItemsControl for Check In and Out
            CheckInOutContainer.ItemsSource = checkInOutCards;
        }
    }

    public class Booking
    {
        public BitmapImage ImageSource { get; set; }
        public string ButtonText { get; set; }
    }

    public class ListItem
    {
        public string Text { get; set; }
    }
}
