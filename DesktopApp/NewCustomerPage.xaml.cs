using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HomeDepotDesktopApp
{
    public partial class NewC : Page
    {
        private HomeDepotContext _context;

        public NewC()
        {
            _context = new HomeDepotContext();
            List<Tool> tools = _context.Tools.ToList<Tool>();
            List<Customer> costumers = _context.Customers.ToList<Customer>();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Customer nc = new Customer
            {
                Name = Navn.Text,
                Password = Password.Text,
                Username = Brugernavn.Text,
                Email = Email.Text,
                CustomerId = _context.Customers.Count() + 1
            };
            _context.Customers.Add(nc);
            _context.SaveChanges();
            this.NavigationService.Content = new MainPage();
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Content = new NewC();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Content = new MainPage();
        }

        public void GoBack()
        {
            this.NavigationService.Content = new MainPage();
        }
    }
}