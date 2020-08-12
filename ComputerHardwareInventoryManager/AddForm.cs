using ComputerHardwareInventoryManager.DB_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerHardwareInventoryManager
{
    public partial class AddForm : Form
    {
        Boolean editForm = false;
        HardwareProduct editProd = new HardwareProduct();

        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(HardwareProduct HP)
        {
            InitializeComponent();
           
            descriptionTxt.Text = HP.Description;
            manufacturerTxt.Text = HP.Manufacturer;
            priceTxt.Text = HP.Price.ToString("C2");
            titleTxt.Text = HP.Title;
            editProd.ProductId = HP.ProductId;
            
            editForm = true;
        }


        private void AddForm_Load(object sender, EventArgs e)
        {
            
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag; // set form1 to the Form1 class we tagged earlier
            form1.Show(); //Reopen original form
            Close(); //Close this form
        }

        private void subButt_Click(object sender, EventArgs e)
        {   
            HardwareProduct p = new HardwareProduct();
            p.Manufacturer = Convert.ToString(manufacturerTxt.Text);
            p.Title = Convert.ToString(titleTxt.Text);
            p.Description = Convert.ToString(descriptionTxt.Text);
            if (priceTxt.Text == "") { p.Price = -1; }
            else { p.Price = Convert.ToDecimal(priceTxt.Text); }
            if (!editForm) 
            { 
                HardwareDB.Insert(p);
            }else
            {
                p.ProductId = editProd.ProductId;
                HardwareDB.Update(p);
            }
            var form1 = (Form1)Tag; // set form1 to the Form1 class we tagged earlier
            form1.Form1_Load(); //refresh products list
            form1.Show();
            Close();
        }
    }
}
