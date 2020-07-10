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
            //ado.RunQueries();
            ado.run1Query(this.email, this.password, this.numberOfAccounts);
            ADOQuery1.Text = ado.querie;
            ado.run1000Querys(this.email, this.password, this.numberOfAccounts);
            ADOQuery1000.Text = ado.thousantQuerys;
            ado.run100000Querys(this.email, this.password, this.numberOfAccounts);
            ADOQuery100000.Text = ado.hunderdThousandQuerys;
            ado.run1000000Querys(this.email, this.password, this.numberOfAccounts);
            ADOQuery1000000.Text = ado.milionQuerys;
        }

        private void Entity1Query_Click(object sender, EventArgs e)
        {
            this.email = Email.Text;
            EntityFramework entity = new EntityFramework();
            entity.run1Query(this.email);
            EntityQuery1.Text = entity.oneQuerieEntity;
            entity.run1000Querys(this.email);
            EntityQuery1000.Text = entity.thousandQuerieEntity;
            entity.run100000Querys(this.email);
            EntityQuery100000.Text = entity.hunderdThousandQuerieEntity;
            entity.run1000000Querys(this.email);
            EntityQuery100000.Text = entity.milionQuerieEntity;
        }
    }
}
