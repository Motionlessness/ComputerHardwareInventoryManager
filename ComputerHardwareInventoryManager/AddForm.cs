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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
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

            HardwareDB.Insert(p);
            var form1 = (Form1)Tag; // set form1 to the Form1 class we tagged earlier
            form1.Form1_Load(); //refresh products list
            form1.Show();
            Close();
        }
    }
}
