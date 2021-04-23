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



namespace RegisterAndLogin
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registeration registration = new Registeration();
            registration.ShowDialog();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

           string user, pass;
            int flag = 0;
            user = txtUsername.Text;
            pass = txtPassword.Text;
            if (user == "admin" && pass == "admin")
            {

                MessageBox.Show("Login successful");
                flag = 1;

                this.Hide();
            }
              if(flag == 1) 
                {
                    TabMenu tm = new TabMenu();
                    tm.ShowDialog();

                }
                

            
            else
            {
                MessageBox.Show("login inavlid");
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private class Form2
        {
            public Form2()
            {
            }

            internal void Show()
            {
                throw new NotImplementedException();
            }
        }
    }

   
    
}
