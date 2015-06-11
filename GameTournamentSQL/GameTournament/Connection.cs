using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Connection
    {
        private SqlConnection myConnection;

        public SqlConnection MyConnection
        {
            get { return myConnection; }
            set { myConnection = value; }
        }
        public void getConn()
        {
           
        }
        public void setConn()
        {
            MyConnection = new SqlConnection("user id=username;" +
                                       "password=password;server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=GameTourny; " +
                                       "connection timeout=10");
        }
    }
}
