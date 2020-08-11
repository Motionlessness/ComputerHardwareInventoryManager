using ComputerHardwareInventoryManager.DB_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
                checkedListBox1.Items.Add(prod[i]);
                //checkedListBox1.Items.Add($"{prod[i].Manufacturer} {prod[i].Title} {prod[i].Description} Price: ${(double)prod[i].Price}");
            }
            
        }

        private void addbutt_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(); //makes a new add form page
            addForm.Tag = this;    //tags this form to the AddForm page
            addForm.Show();        //shows AddForm form to user
            Hide();             // hides current form

        }

        public void Form1_Load()
        {
            checkedListBox1.Items.Clear();
            for (int i = 0; i < HardwareDB.GetHardwareProducts().Count(); i++)
            {
                List<HardwareProduct> prod = HardwareDB.GetHardwareProducts();

                checkedListBox1.Items.Add(prod[i]);
            }
        }

        private void editbutt_Click(object sender, EventArgs e)
        {
            List<HardwareProduct> editProd = new List<HardwareProduct>();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                editProd.Add((HardwareProduct)checkedListBox1.CheckedItems[i]);
                AddForm editForm = new AddForm(editProd[i]);
                editForm.Tag = this;
                editForm.Show();
                Hide();
            }

        }

        private void deletebutt_Click(object sender, EventArgs e)
        {
            List<HardwareProduct> deleteProd = new List<HardwareProduct>();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                deleteProd.Add((HardwareProduct)checkedListBox1.CheckedItems[i]);
            }
            for (int i = 0; i < deleteProd.Count; i++)
            {
                HardwareDB.Delete(deleteProd[i].ProductId);
            }
            Form1_Load();
        }
    }
}
