using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEfCoreApp
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();

                string Name;
                string Email;
                string Password;


                if (string.IsNullOrWhiteSpace(textName.Text))
                {
                    Name = "Default Name";
                }
                else
                {
                    Name = textName.Text;
                }

                if (string.IsNullOrWhiteSpace(textEmail.Text))
                {
                    Email = "Default Mail";
                }
                else
                {
                    Email = textEmail.Text;
                }
                if (string.IsNullOrWhiteSpace(textPassword.Text))
                {
                    Password = " ";
                }
                else
                {
                    Password = textPassword.Text;
                }

                var user = new User { Name = Name, Email = Email, Password = Password };

                db.Users.Add(user);
                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK; // sygnał dla Form1
            this.Close();
        }
    }
}
