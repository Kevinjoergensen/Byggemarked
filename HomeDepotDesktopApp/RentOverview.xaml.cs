using HomeDepotWebApp.Models;
using System.Windows;
using System.Windows.Controls;
using HomeDepotWebApp.Storage;

namespace HomeDepotDesktopApp
{
    /// <summary>
    /// Interaction logic for RentOverview.xaml
    /// </summary>
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

        }
        private void mExit_Click(object sender, RoutedEventArgs e)
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
    }
}