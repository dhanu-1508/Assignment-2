using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace RegisterAndLogin
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }
        int flag = 0;


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register successfully");
            flag = 1;
            if (flag == 1)
            {
                TabMenu tm = new TabMenu();
                tm.ShowDialog();

            }

        }
    }
}
