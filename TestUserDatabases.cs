using System;
using System.Windows.Forms;

namespace Eindproject2
{
    public partial class TestUserDatabases : Form
    {
        private string email;
        private string password;
        private int numberOfAccounts;
        public TestUserDatabases()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADO1Query_Click(object sender, EventArgs e)
        {
            this.email = Email.Text;
            this.password = PasswordTest.Text;
            this.numberOfAccounts = Int32.Parse(NumberOfAccounts.Value.ToString());
            ado_net ado = new ado_net(this.email, this.password, this.numberOfAccounts);
        }

        private void Entity1Query_Click(object sender, EventArgs e)
        {

        }
    }
}
