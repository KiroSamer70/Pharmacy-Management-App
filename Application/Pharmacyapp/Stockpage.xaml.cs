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
using System.Xml.Linq;

namespace Pharmacyapp
{
    /// <summary>
    /// Interaction logic for Stockpage.xaml
    /// </summary>
    public partial class Stockpage : Window
    {
        StockDBEntities _Context =new StockDBEntities();
        public medicine _SelectedMed;
        public Stockpage()
        {
            InitializeComponent();
            LoadMedicines();
        }
        private void MedicineList_SelectionChanged(object sender, EventArgs e)
        {

            _SelectedMed = (medicine)dataGridUsers.SelectedItem;


           txtMedname.Text = _SelectedMed.name;
            txtid.Text = _SelectedMed.id.ToString();
            txtSolded.Text = _SelectedMed.solded_amount.ToString();
            txtSales.Text = _SelectedMed.sales_price.ToString();
            txtExpire.Text = _SelectedMed.expiration_date.ToString();
        }
        private void LoadMedicines()
        {
            dataGridUsers.ItemsSource = _Context.medicines.ToList();
        }
        public void ClearInputs()
        {
            txtMedname.Clear();
            txtid.Clear();
            txtSolded.Clear();
            txtSales.Clear();
            txtExpire.Clear();
        }
     
        private void UpdateMedicineBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_SelectedMed == null)
            {
                MessageBox.Show("Select Medicine you want to update");
            }
            _SelectedMed.name = txtMedname.Text;
            _SelectedMed.id = int.Parse(txtid.Text);
            _SelectedMed.solded_amount = int.Parse(txtSolded.Text);
            _SelectedMed.sales_price = int.Parse(txtSales.Text);
            _SelectedMed.expiration_date = DateTime.Parse(txtExpire.Text);
            _Context.SaveChanges();
            LoadMedicines();
        }

        private void DeleteMedicineBtn_Click(object sender, RoutedEventArgs e)
        {
            _Context.medicines.Remove(_SelectedMed);
            _Context.SaveChanges();
            LoadMedicines();
            ClearInputs();
        }

        private void AddMedicineBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMedname.Text) || string.IsNullOrWhiteSpace(txtid.Text)
              || string.IsNullOrWhiteSpace(txtSolded.Text) || string.IsNullOrWhiteSpace(txtSales.Text)
              || string.IsNullOrWhiteSpace(txtExpire.Text))
            {
                MessageBox.Show("Please fill the required fields");
            }
            var Medicine = new medicine
            {
                name = txtMedname.Text,
                id = int.Parse(txtid.Text),
                solded_amount = int.Parse(txtSolded.Text),
                sales_price = int.Parse(txtSales.Text),
                expiration_date = DateTime.Parse(txtExpire.Text)
            };
            _Context.medicines.Add(Medicine);
            _Context.SaveChanges();
            LoadMedicines();
            ClearInputs();
        }

        private void BackNavBtn_Click(object sender, RoutedEventArgs e)
        {
           
                Transactions transactions = new Transactions();
                transactions.Show();
                this.Close();
            
        }
    }

       
    
}
