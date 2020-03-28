using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
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

namespace HomeDepotDesktopApp
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class NewC : Page
    {
        private HomeDepotContext _context;

        public NewC()
        {
            _context = new HomeDepotContext();
            List<Tool> tools = _context.Tools.ToList<Tool>();
            List<Costumer> costumers = _context.Costumers.ToList<Costumer>();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Costumer nc = new Costumer();
            nc.Name = Navn.Text;
            nc.Password = Password.Text;
            nc.Username = Brugernavn.Text;
            nc.Email = Email.Text;
            nc.Id = _context.Costumers.Count() + 1;
            _context.Costumers.Add(nc);
            _context.SaveChanges();
            this.NavigationService.Content = new MainPage();
        }

        private void mExit_Click(object sender, RoutedEventArgs e)
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
