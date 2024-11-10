using Pharmacyapp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pharmacy_App
{
    /// <summary>
    /// Interaction logic for Transactions.xaml
    /// </summary>

    public partial class Transactions : Window
    {
        public PharmacyDBEntities _Context = new PharmacyDBEntities();
        public Transactions()
        {
            InitializeComponent();
            loadname();
        }


        public void loadname()
        {
            // Get the last added pharmacy using LINQ and Entity Framework
            var lastPharmacy = _Context.pharmacies.OrderByDescending(p => p.id).FirstOrDefault();

            // Assign the pharmacy name to the label's content
            namelbl.Content = lastPharmacy.name;
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            Editprofile editprofile = new Editprofile();
            editprofile.Show();
            this.Close();
        }

        private void Stockbtn_Click(object sender, RoutedEventArgs e)
        {
            Stockpage Stockpage = new Stockpage();  
            Stockpage.Show();
            this.Close();
        }

        private void Marketbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
