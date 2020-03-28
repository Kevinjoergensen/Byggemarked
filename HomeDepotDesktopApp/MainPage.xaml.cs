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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private HomeDepotContext _context;
        private List<Costumer> allCostumers;
        public MainPage()
        {
            InitializeComponent();
            _context = new HomeDepotContext();
            List<Tool> tools = _context.Tools.ToList<Tool>();
            allCostumers = _context.Costumers.ToList<Costumer>();
            filterCostumers();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Costumer c = (Costumer)ListBoxKunder.SelectedItem;
            
            this.NavigationService.Content = new CostumerPage(c);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            filterCostumers();
        }

        private void filterCostumers()
        {
            if (searchfield.Text.Length < 1)
            {
                this.DataContext = allCostumers;
            }
            else
            {
                List<Costumer> cust = new List<Costumer>();
                foreach (Costumer c in allCostumers)
                {

                    if (c.Name.ToLower().Contains(searchfield.Text.ToLower()))
                    {
                        cust.Add(c);
                    }
                    else if (c.Id.ToString().Contains(searchfield.Text.ToLower()))
                    {
                        cust.Add(c);
                    }
                    else if (c.Email.ToLower().Contains(searchfield.Text.ToLower()))
                    {
                        cust.Add(c);
                    }
                    else if (c.Username.ToLower().Contains(searchfield.Text.ToLower()))
                    {
                        cust.Add(c);
                    }

                }
                this.DataContext = cust;
            }
        }

    }
}
