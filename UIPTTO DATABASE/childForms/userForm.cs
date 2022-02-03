using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIPTTO_DATABASE.childForms.popupForm;

namespace UIPTTO_DATABASE.childForms
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            addUserForm addUserForm = new addUserForm();
            addUserForm.ShowDialog(); 
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                dgvUser.Rows.Add(
                    new object[]
                    {
                        Faker.Name.FullName(),
                        Faker.Name.FullName()+"@gmail.com",
                        Faker.Company.Name(),
                        Faker.DateOfBirth.Next(),
                        Faker.Name.First()
                    });
            }
        }

        private void txtboxUserSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //click on the edit button and delete button here
        }
    }
}
