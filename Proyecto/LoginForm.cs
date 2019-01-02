using System;
using System.Windows.Forms;



namespace Proyecto  
{
    public partial class LoginForm : Form
    {
        
        string userName = "";
        public string UserName
        {
            get { return userName; }
        }
        
        public LoginForm()
        {
            InitializeComponent();
           
            this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
            btnOK.Click += new EventHandler(btnOK_Click);
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            userName = tbUserName.Text.Trim();
            
            
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Seleccione un nombre de usuario de hasta 32 caracteres.");
                return;
                
            }

            this.FormClosing -= LoginForm_FormClosing;
            this.Close();
        }

        void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userName = "";
        }
    }
}

