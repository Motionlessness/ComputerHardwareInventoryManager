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

                checkedListBox1.Items.Add(prod[i]);
            }
            
        }

        private void addbutt_Click(object sender, EventArgs e)
        {
          
        }
    }
}
