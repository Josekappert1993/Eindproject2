using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindproject2
{
    class ado_net
    {
        public ado_net()
        {

        }

        public void runQueries(string email, string password, bool active, int numberOfAccount)
        {
            run1Query(email, password, active, numberOfAccount);
            run1000Querys(email, password, active, numberOfAccount);
            run100000Querys(email, password, active, numberOfAccount);
        }

        public void run1Query(string email, string password, bool active, int numberOfAccount)
        {

        }

        public void run1000Querys(string email, string password, bool active, int numberOfAccount)
        {

        }

        public void run100000Querys(string email, string password, bool active, int numberOfAccount)
        {

        }

        public void run1000000Querys(string email, string password, bool active, int numberOfAccount)
        {

        }
    }
}
