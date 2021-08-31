using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    class Connection
    {
        public Connection()
        {
            this.DefaultConnections = new string[2];
            this.DefaultConnections[0] = "Server=35.226.39.34; Database=Registro; User Id=sqlserver; Password=Kurama1727x.; Trusted_Connection=False; MultipleActiveResultSets=true;";
            this.DefaultConnections[1] = "server=35.224.126.31;database=Registro;uid=root;pwd=Kurama1727x.;";
        }

        protected string[] DefaultConnections { get; set; }
        protected SqlConnection SqlConnection { get; set; }

        protected  MySqlConnection MSqlConnection { get; set; }




        public SqlConnection OpenSQLS()
        {
            this.SqlConnection = new SqlConnection();
            this.SqlConnection.ConnectionString = this.DefaultConnections[0];
            this.SqlConnection.Open();
            return this.SqlConnection;
        }

        public MySqlConnection OpenMYSQL()
        {
            this.MSqlConnection = new MySqlConnection(this.DefaultConnections[1]);
            this.MSqlConnection.Open();
            return this.MSqlConnection;
        }

        public void Close()
        {
            try
            {
                this.SqlConnection.Close();
                this.MSqlConnection.Close();
                Console.WriteLine("Desconexión satisfactoria");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Información de error en Connection " + ex.ToString());
            }
        }
    }
}
