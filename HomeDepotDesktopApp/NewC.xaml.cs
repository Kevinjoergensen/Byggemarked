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
    }
}
