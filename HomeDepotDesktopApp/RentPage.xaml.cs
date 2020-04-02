using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HomeDepotDesktopApp
{
    public partial class RentOverview : Page
    {
        private HomeDepotContext _context;
        private Rent currentRent;
        public RentOverview(Rent rent)
        {
            _context = new HomeDepotContext();
            InitializeComponent();
            currentRent = rent;
            id.Text = rent.Id.ToString();
            tool.Text = rent.RentTool.Name;
            pickup.Text = rent.PickUp;
            days.Text = rent.Days.ToString();
            combo.ItemsSource = Enum.GetValues(typeof(Status));
            combo.SelectedItem = rent.Status;

        }
        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Content = new NewC();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Content = new CostumerPage(currentRent.Customer);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (combo.Text.Equals("Reserveret"))
            {
                _context.Rents.Find(currentRent.Id).Status = Status.Reserveret;
            }
            else if (combo.Text.Equals("Udleveret"))
            {
                _context.Rents.Find(currentRent.Id).Status = Status.Udleveret;
            }
            else if (combo.Text.Equals("Tilbageleveret"))
            {
                _context.Rents.Find(currentRent.Id).Status = Status.Tilbageleveret;
            }
            _context.SaveChanges();
            this.NavigationService.Content = new CostumerPage(currentRent.Customer);
        }
    }
}