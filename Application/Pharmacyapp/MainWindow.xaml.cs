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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pharmacy_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public PharmacyDBEntities _Context = new PharmacyDBEntities();


        public MainWindow()
        {
            InitializeComponent();
        }

        public void Adduser_btn_Click(object sender, RoutedEventArgs e)
        {

            var pharmacy1 = new pharmacy()
            {

                name = Pharmacynamefld.Text,
                location = Pharmacylocationfld.Text,
            };
            _Context.pharmacies.Add(pharmacy1);
            _Context.SaveChanges();
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Close();
        }
    }
}
