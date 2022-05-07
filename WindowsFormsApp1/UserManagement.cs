using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();

            var q = dbcontext.Customers;

            dataGridView1.DataSource = q.ToList();

            txt_Phone.DataBindings.Add("Text", q.ToList(), "Phone");
            txt_Password.DataBindings.Add("Text", q.ToList(), "Password");
            txt_LastName.DataBindings.Add("Text", q.ToList(), "LastName");
            txt_FirstName.DataBindings.Add("Text", q.ToList(), "FirstName");
            txt_Email.DataBindings.Add("Text", q.ToList(), "Email");
            txt_Age.DataBindings.Add("Text", q.ToList(), "Age");
            txt_Address.DataBindings.Add("Text", q.ToList(), "Address");
            txt_Gender.DataBindings.Add("Text", q.ToList(), "Gender");
        }

        IGOEntities dbcontext = new IGOEntities();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var q = dbcontext.Customers.Where(n=>n.Phone = dataGridView1.SelectedRows[6])
        }
    }
}
