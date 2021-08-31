using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesDeDatos
{
    class QueryManager : Connection
    {
        public QueryManager()
        {
            this.QuerySQLSERVER = "";
            this.QueryMYSQL = "";
            this.ConnectionS = null;
        }

        public String QuerySQLSERVER { get; set; }
        public String QueryMYSQL { get; set; }
        public SqlConnection ConnectionS { get; set; }
        public MySqlConnection MySqlConnection { get; set; }
        public SqlCommand MsqlCommand { get; set; }
        public SqlDataReader MsqlDataReader { get; set; }

        public MySqlParameter[] MySqlParameter { get; set; }

        /* Se usa para replicar las bases de datos */
        public void Mirroring()
        {
            /* 
             * De SQL SERVER a MYSQL 
             * 
             * Agarra los insert de sql server
             */
            this.QuerySQLSERVER = "exec sp_replica_estudiante";
            List<Object> list = SendListQuery(0, 3);
            Estudiante tem;

            foreach (Object item in list)
            {
                tem = (Estudiante)item;
                SendQuery(1, 4, tem);
            }

            /*
             * Agarra los update de sql server
             */
            this.QuerySQLSERVER = "exec sp_replica_estudiante";
            list = SendListQuery(0, 4);
            
            foreach (Object item in list)
            {
                tem = (Estudiante)item;
                SendQuery(1, 6, tem);
            }


            /*
             * Agarra los delete de sql server
             */

            this.QuerySQLSERVER = "exec sp_replica_estudiante";
            list = SendListQuery(0, 5);

            foreach (Object item in list)
            {
                tem = (Estudiante)item;
                SendQuery(1, 8, tem);
            }

            /*------------------------------------*/

            /* 
             * De MYSQL SQL SERVER 
             */

            /*
             * Agarra los insert de mysql
             */

            this.QueryMYSQL = "sp_replica_estudiante";
            list.Clear();
            list = SendListQuery(1, 6);
            foreach (Object item in list)
            {
                tem = (Estudiante)item;
                SendQuery(0, 5, tem);
            }

            /*
             * Agarra los update de mysql
             */

            this.QueryMYSQL = "sp_replica_estudiante";
            list = SendListQuery(1, 7);

            foreach (Object item in list)
            {
                tem = (Estudiante)item;
                SendQuery(0, 7, tem);
            }

            /*
             * Agarra los delete de de mysql
             */
            this.QueryMYSQL = "sp_replica_estudiante";
            list = SendListQuery(1, 8);

            foreach (Object item in list)
            {
                tem = (Estudiante)item;
                SendQuery(0, 9, tem);
            }
        }

        /* Usado para los Select
         * 0 Para Estudiante
         * 1 Para Sede
         */
        public List<Object> SendListQuery(int server, int op)
        {
            List<Object> ObjectList = new List<object>();

            try
            {
                switch (server)
                {
                    case 0:
                        this.ConnectionS = base.OpenSQLS();
                        ObjectList = GenericSendListQuery(op);
                        break;
                    case 1:
                        this.MySqlConnection = base.OpenMYSQL();
                        this.QuerySQLSERVER = this.QueryMYSQL;
                        ObjectList = GenericSendListQuery(op);
                        break;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                this.QueryMYSQL = "";
                this.QuerySQLSERVER = "";
                
                if (this.SqlConnection != null)
                {
                    this.SqlConnection.Close();
                }

                if (this.ConnectionS != null)
                {
                    this.ConnectionS.Close();
                }
                
                if (this.MySqlConnection != null)
                {
                    this.MySqlConnection.Close();
                }
                
            }

            return ObjectList;
        }

        /* Usado para Insert, Update y Delete */
        public void SendQuery(int server, int op, Object obj)
        {
            try
            {
                switch (server)
                {
                    case 0:
                        this.ConnectionS = base.OpenSQLS();
                        GenericSendQuery(op, obj);
                        break;
                    case 1:
                        this.MySqlConnection = base.OpenMYSQL();
                        this.QuerySQLSERVER = this.QueryMYSQL;
                        GenericSendQuery(op, obj);
                        break;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                this.QueryMYSQL = "";
                this.QuerySQLSERVER = "";
                if (this.SqlConnection != null)
                {
                    this.SqlConnection.Close();
                }

                if (this.ConnectionS != null)
                {
                    this.ConnectionS.Close();
                }

                if (this.MySqlConnection != null)
                {
                    this.MySqlConnection.Close();
                }
            }
        }

        private List<Object> GenericSendListQuery(int op)
        {
            List<Object> ObjectList = new List<object>();
            Estudiante EstudianteTemp;
            try
            {
                switch (op)
                {
                    case 0:
                        
                        this.MsqlCommand = new SqlCommand(this.QuerySQLSERVER, this.ConnectionS);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        while (this.MsqlDataReader.Read())
                        {
                            EstudianteTemp = new Estudiante(
                                int.Parse(this.MsqlDataReader.GetValue(0).ToString()),
                                this.MsqlDataReader.GetValue(1).ToString(),
                                this.MsqlDataReader.GetValue(2).ToString(),
                                int.Parse(this.MsqlDataReader.GetValue(3).ToString()),
                                int.Parse(this.MsqlDataReader.GetValue(4).ToString()),
                                this.MsqlDataReader.GetValue(5).ToString());
                            ObjectList.Add(EstudianteTemp);
                        }
                        break;
                    case 1:
                        Sede SedeTemp;
                        this.MsqlCommand = new SqlCommand(this.QuerySQLSERVER, this.ConnectionS);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        while (this.MsqlDataReader.Read())
                        {
                            SedeTemp = new Sede(
                                int.Parse(this.MsqlDataReader.GetValue(0).ToString()),
                                this.MsqlDataReader.GetValue(1).ToString());
                            ObjectList.Add(SedeTemp);
                        }
                        break;
                    case 3: /* Para replica de sql server a mysql (DE INSERTAR)*/
                        try
                        {
                            this.MsqlCommand = new SqlCommand(/*this.QuerySQLSERVER*/"sp_replica_estudiante", this.ConnectionS);
                            this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                            this.MsqlCommand.Parameters.Clear();
                            this.MsqlCommand.Parameters.AddWithValue("param_ACCION", "IN");
                            this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                            while (this.MsqlDataReader.Read())
                            {
                                EstudianteTemp = new Estudiante(
                                    int.Parse(this.MsqlDataReader.GetValue(0).ToString()),
                                    this.MsqlDataReader.GetValue(1).ToString(),
                                    this.MsqlDataReader.GetValue(2).ToString(),
                                    int.Parse(this.MsqlDataReader.GetValue(3).ToString()),
                                    int.Parse(this.MsqlDataReader.GetValue(4).ToString()));
                                ObjectList.Add(EstudianteTemp);
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        break;
                    case 4: /* para sql server */
                        this.MsqlCommand = new SqlCommand("sp_replica_estudiante", this.ConnectionS);
                        this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        this.MsqlCommand.Parameters.Clear();
                        this.MsqlCommand.Parameters.AddWithValue("param_ACCION", "UP");
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        while (this.MsqlDataReader.Read())
                        {
                            EstudianteTemp = new Estudiante(
                                int.Parse(this.MsqlDataReader.GetValue(0).ToString()),
                                this.MsqlDataReader.GetValue(1).ToString(),
                                this.MsqlDataReader.GetValue(2).ToString(),
                                int.Parse(this.MsqlDataReader.GetValue(3).ToString()),
                                int.Parse(this.MsqlDataReader.GetValue(4).ToString()));
                            ObjectList.Add(EstudianteTemp);
                        }
                        //MessageBox.Show("Se listaron los update de sql server. Cantidad: " + ObjectList.Count);
                        break; 
                    case 5: /* para sql server */
                        this.MsqlCommand = new SqlCommand("sp_replica_estudiante", this.ConnectionS);
                        this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        this.MsqlCommand.Parameters.Clear();
                        this.MsqlCommand.Parameters.AddWithValue("param_ACCION", "DL");
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        while (this.MsqlDataReader.Read())
                        {
                            EstudianteTemp = new Estudiante(
                                int.Parse(this.MsqlDataReader.GetValue(0).ToString()),
                                this.MsqlDataReader.GetValue(1).ToString(),
                                this.MsqlDataReader.GetValue(2).ToString(),
                                int.Parse(this.MsqlDataReader.GetValue(3).ToString()),
                                int.Parse(this.MsqlDataReader.GetValue(4).ToString()));
                            ObjectList.Add(EstudianteTemp);
                        }
                        break; 
                    case 6: /* para mysql */
                        MySqlCommand command = new MySqlCommand("sp_replica_estudiante", this.MSqlConnection);

                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("param_ACCION", "IN");

                        MySqlDataReader mySqlDataReader = command.ExecuteReader();
                        
                        if (mySqlDataReader.HasRows)
                        {
                            while(mySqlDataReader.Read())
                            {
                                EstudianteTemp = new Estudiante(
                                    int.Parse(mySqlDataReader.GetValue(0).ToString()),
                                    mySqlDataReader.GetValue(1).ToString(),
                                    mySqlDataReader.GetValue(2).ToString(),
                                    int.Parse(mySqlDataReader.GetValue(3).ToString()),
                                    int.Parse(mySqlDataReader.GetValue(4).ToString()));
                                ObjectList.Add(EstudianteTemp);
                            }
                        }
                        
                        break; 
                    case 7: /* para mysql */
                        command = new MySqlCommand("sp_replica_estudiante", this.MSqlConnection);

                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("param_ACCION", "UP");

                        mySqlDataReader = command.ExecuteReader();

                        if (mySqlDataReader.HasRows)
                        {
                            while (mySqlDataReader.Read())
                            {
                                EstudianteTemp = new Estudiante(
                                    int.Parse(mySqlDataReader.GetValue(0).ToString()),
                                    mySqlDataReader.GetValue(1).ToString(),
                                    mySqlDataReader.GetValue(2).ToString(),
                                    int.Parse(mySqlDataReader.GetValue(3).ToString()),
                                    int.Parse(mySqlDataReader.GetValue(4).ToString()));
                                ObjectList.Add(EstudianteTemp);
                            }
                        }
                        break;
                    case 8: /* para mysql */
                        command = new MySqlCommand("sp_replica_estudiante", this.MSqlConnection);

                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("param_ACCION", "DL");

                        mySqlDataReader = command.ExecuteReader();

                        if (mySqlDataReader.HasRows)
                        {
                            while (mySqlDataReader.Read())
                            {
                                EstudianteTemp = new Estudiante(
                                    int.Parse(mySqlDataReader.GetValue(0).ToString()),
                                    mySqlDataReader.GetValue(1).ToString(),
                                    mySqlDataReader.GetValue(2).ToString(),
                                    int.Parse(mySqlDataReader.GetValue(3).ToString()),
                                    int.Parse(mySqlDataReader.GetValue(4).ToString()));
                                ObjectList.Add(EstudianteTemp);
                            }
                        }
                        break;
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine("Error en el método List de QueryManager. No se pudo realizar la consulta");
                Console.WriteLine("Codigo de error " + error);
            }
            finally
            {
                this.ConnectionS.Close();
                Console.WriteLine("Se cerroó la conexión con el servidor de bases de datos");
            }

            return ObjectList;
        }

        /*
         * 0 para MySql
         * Las demás para sql sever
         */
        private void GenericSendQuery(int op, Object objTemp)
        {
            try
            {
                Estudiante estudianteTemp;
                switch (op)
                {
                    case 0:
                        this.MsqlCommand = new SqlCommand(this.QuerySQLSERVER, this.ConnectionS);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        break;
                    case 1:         /*Insertar SQL SERVER*/
                        estudianteTemp = (Estudiante)objTemp;
                        this.MsqlCommand = new SqlCommand(this.QuerySQLSERVER, this.ConnectionS);
                        this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        this.MsqlCommand.Parameters.Clear();
                        this.MsqlCommand.Parameters.AddWithValue("@param_CEDULA", estudianteTemp.Cedula);
                        this.MsqlCommand.Parameters.AddWithValue("@param_NOMBRE", estudianteTemp.Nombre);
                        this.MsqlCommand.Parameters.AddWithValue("@param_APELLIDO", estudianteTemp.Apellidos);
                        this.MsqlCommand.Parameters.AddWithValue("@param_EDAD", estudianteTemp.Edad);
                        this.MsqlCommand.Parameters.AddWithValue("@param_ID_SEDE", estudianteTemp.IdSede);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        break;
                    case 2:         /*Actualizar SQL SERVER*/
                        estudianteTemp = (Estudiante)objTemp;
                        this.MsqlCommand = new SqlCommand(this.QuerySQLSERVER, this.ConnectionS);
                        this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        this.MsqlCommand.Parameters.Clear();
                        this.MsqlCommand.Parameters.AddWithValue("@param_CEDULA", estudianteTemp.Cedula);
                        this.MsqlCommand.Parameters.AddWithValue("@param_NOMBRE", estudianteTemp.Nombre);
                        this.MsqlCommand.Parameters.AddWithValue("@param_APELLIDO", estudianteTemp.Apellidos);
                        this.MsqlCommand.Parameters.AddWithValue("@param_EDAD", estudianteTemp.Edad);
                        this.MsqlCommand.Parameters.AddWithValue("@param_ID_SEDE", estudianteTemp.IdSede);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        break;
                    case 3:
                        this.MsqlCommand = new SqlCommand(this.QuerySQLSERVER, this.ConnectionS);
                        this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        this.MsqlCommand.Parameters.Clear();
                        this.MsqlCommand.Parameters.AddWithValue("@param_CEDULA", (int) objTemp);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        break;
                    case 4:/*insertar replica de sql server a mysql*/
                        estudianteTemp = (Estudiante)objTemp;
                        MySqlCommand command = new MySqlCommand("sp_insetar_estudiante2", this.MSqlConnection);
                       
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        
                        command.Parameters.AddWithValue("param_CEDULA", estudianteTemp.Cedula);
                        command.Parameters.AddWithValue("param_NOMBRE", estudianteTemp.Nombre);
                        command.Parameters.AddWithValue("param_APELLIDO", estudianteTemp.Apellidos);
                        command.Parameters.AddWithValue("param_EDAD", estudianteTemp.Edad);
                        command.Parameters.AddWithValue("param_ID_SEDE", estudianteTemp.IdSede);
                        
                        MySqlDataReader mySqlDataReader = command.ExecuteReader();
                        
                        MessageBox.Show("Ya pueden hacer el select en mysql");
                        break;
                    case 5:
                        estudianteTemp = (Estudiante)objTemp;
                        this.MsqlCommand = new SqlCommand("sp_insetar_estudiante2", this.ConnectionS);
                        this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        this.MsqlCommand.Parameters.Clear();
                        this.MsqlCommand.Parameters.AddWithValue("@param_CEDULA", estudianteTemp.Cedula);
                        this.MsqlCommand.Parameters.AddWithValue("@param_NOMBRE", estudianteTemp.Nombre);
                        this.MsqlCommand.Parameters.AddWithValue("@param_APELLIDO", estudianteTemp.Apellidos);
                        this.MsqlCommand.Parameters.AddWithValue("@param_EDAD", estudianteTemp.Edad);
                        this.MsqlCommand.Parameters.AddWithValue("@param_ID_SEDE", estudianteTemp.IdSede);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        break;
                    case 6: /* insertar los update de sql server en mysql*/
                        estudianteTemp = (Estudiante)objTemp;
                        command = new MySqlCommand("sp_actualizar_estudiante2", this.MSqlConnection);

                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("param_CEDULA", estudianteTemp.Cedula);
                        command.Parameters.AddWithValue("param_NOMBRE", estudianteTemp.Nombre);
                        command.Parameters.AddWithValue("param_APELLIDO", estudianteTemp.Apellidos);
                        command.Parameters.AddWithValue("param_EDAD", estudianteTemp.Edad);
                        command.Parameters.AddWithValue("param_ID_SEDE", estudianteTemp.IdSede);

                        mySqlDataReader = command.ExecuteReader();
                        MessageBox.Show("Ya se actualizó en mysql. Ya se puede comprobar");
                        break;
                    case 7: /* insertar los update de mysql en sql server*/
                        estudianteTemp = (Estudiante)objTemp;
                        this.MsqlCommand = new SqlCommand("sp_actualizar_estudiante2", this.ConnectionS);
                        this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        this.MsqlCommand.Parameters.Clear();
                        this.MsqlCommand.Parameters.AddWithValue("@param_CEDULA", estudianteTemp.Cedula);
                        this.MsqlCommand.Parameters.AddWithValue("@param_NOMBRE", estudianteTemp.Nombre);
                        this.MsqlCommand.Parameters.AddWithValue("@param_APELLIDO", estudianteTemp.Apellidos);
                        this.MsqlCommand.Parameters.AddWithValue("@param_EDAD", estudianteTemp.Edad);
                        this.MsqlCommand.Parameters.AddWithValue("@param_ID_SEDE", estudianteTemp.IdSede);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        break;
                    case 8: /* Pasar los delete de sql server a mysql */
                        estudianteTemp = (Estudiante)objTemp;
                        command = new MySqlCommand("sp_eliminar_estudiante", this.MSqlConnection);

                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("param_CEDULA", estudianteTemp.Cedula);
                        command.Parameters.AddWithValue("param_NOMBRE", estudianteTemp.Nombre);
                        command.Parameters.AddWithValue("param_APELLIDO", estudianteTemp.Apellidos);
                        command.Parameters.AddWithValue("param_EDAD", estudianteTemp.Edad);
                        command.Parameters.AddWithValue("param_ID_SEDE", estudianteTemp.IdSede);

                        mySqlDataReader = command.ExecuteReader();
                        MessageBox.Show("Ya se eliminó en mysql. Ya se puede comprobar");
                        break;
                    case 9:
                        estudianteTemp = (Estudiante)objTemp;
                        this.MsqlCommand = new SqlCommand("sp_eliminar_estudiante", this.ConnectionS);
                        this.MsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        this.MsqlCommand.Parameters.Clear();
                        this.MsqlCommand.Parameters.AddWithValue("@param_CEDULA", estudianteTemp.Cedula);
                        this.MsqlDataReader = this.MsqlCommand.ExecuteReader();
                        break;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                this.ConnectionS.Close();
                Console.WriteLine("Se cerroó la conexión con el servidor de bases de datos");
            }
        }
    }
}