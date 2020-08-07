using ComputerHardwareInventoryManager.DB_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerHardwareInventoryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < HardwareDB.GetHardwareProducts().Count(); i++)
            {
                List<HardwareProduct> prod = HardwareDB.GetHardwareProducts();

                checkedListBox1.Items.Add($"{prod[i].Manufacturer} {prod[i].Title} {prod[i].Description} Price: ${(double)prod[i].Price}");
            }
            
        }

        private void addbutt_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(); //makes a new add form page
            form.Tag = this;    //tags this form to the AddForm page
            form.Show();        //shows AddForm form to user
            Hide();             // hides current form

        }

        public void Form1_Load()
        {
            checkedListBox1.Items.Clear();
            for (int i = 0; i < HardwareDB.GetHardwareProducts().Count(); i++)
            {
                List<HardwareProduct> prod = HardwareDB.GetHardwareProducts();

                checkedListBox1.Items.Add(prod[i]);
            };
        }
    }
}
