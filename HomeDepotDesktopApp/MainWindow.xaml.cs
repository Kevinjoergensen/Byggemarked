using HomeDepotWebApp.Models;
using HomeDepotWebApp.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace HomeDepotDesktopApp
{
    public partial class MainWindow : Window
    {
        private readonly HomeDepotContext _context;

        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new MainPage();
            _context = new HomeDepotContext();
            List<Customer> costumers = _context.Customers.ToList<Customer>();
            this.DataContext = costumers;
        }


    }
}
