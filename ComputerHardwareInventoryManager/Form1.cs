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
            List<HardwareProduct> prod = HardwareDB.GetHardwareProducts();
            for (int i = 0; i < prod.Count(); i++)
            {
                
                checkedListBox1.Items.Add(prod[i]);
            }
            
        }

        private void addbutt_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm //makes a new add form page
            {
                Tag = this    //tags this form to the AddForm page
            };
            addForm.Show();        //shows AddForm form to user
            Hide();             // hides current form

        }

        public void Form1_Load()
        {
            checkedListBox1.Items.Clear();

            List<HardwareProduct> prod = HardwareDB.GetHardwareProducts();

            for (int i = 0; i < prod.Count(); i++)
            {
                checkedListBox1.Items.Add(prod[i]);
            }
        }

        private void editbutt_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                AddForm editForm = new AddForm((HardwareProduct)checkedListBox1.CheckedItems[i])
                {
                    Tag = this
                };
                editForm.Show();
                Hide();
            }

        }

        private void deletebutt_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                HardwareProduct h = (HardwareProduct)checkedListBox1.CheckedItems[i];
                HardwareDB.Delete(h.ProductId);
            }
            
            Form1_Load();
        }
    }
}
