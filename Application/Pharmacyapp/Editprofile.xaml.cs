using Pharmacy_App;
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
using System.Windows.Shapes;

namespace Pharmacyapp
{
    /// <summary>
    /// Interaction logic for Editprofile.xaml
    /// </summary>
    public partial class Editprofile : Window
    {
        public PharmacyDBEntities _Context = new PharmacyDBEntities();
        public void loadData()
        {
            // Get the last added pharmacy using LINQ and Entity Framework
            var lastPharmacy = _Context.pharmacies.OrderByDescending(p => p.id).FirstOrDefault();

            // Assign the pharmacy name to the label's content
            namelbl.Content = lastPharmacy.name;
            locationlbl.Content = lastPharmacy.location;
            txtUsername.Text = lastPharmacy.name;
            txtLocation.Text = lastPharmacy.location;
        }
        public Editprofile()
        {
            InitializeComponent();
            loadData();
        }

        private void Updateuser_btn_Click(object sender, RoutedEventArgs e)
        {
           
            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtLocation.Text) ) 
            {
                MessageBox.Show("You must put values");
            }
            else
            {
                namelbl.Content = txtUsername.Text;
                locationlbl.Content = txtLocation.Text;
                var lastPharmacy = _Context.pharmacies.OrderByDescending(p => p.id).FirstOrDefault();
                lastPharmacy.name=txtUsername.Text;
                lastPharmacy.location = txtLocation.Text;
                _Context.SaveChanges();
              
            }
           
        }

        private void Backnavbtn_Click(object sender, RoutedEventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            transactions.namelbl.Content = namelbl.Content;
            this.Close();
        }
    }
}
