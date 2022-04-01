using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KampusFSD1WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surName = txtSurname.Text;
            lstDetails.Items.Add(name + " - " + surName);
            MessageBox.Show("Kayıt Eklenmiştir.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            lstDetails.Items.Clear();
            ListBox.ClearListBox();
        }

        

        
    }



    
}
