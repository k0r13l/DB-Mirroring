using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBasesDeDatos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.QueryM == null)
            {
                this.QueryM = new QueryManager();
            }

            Thread t = new Thread(new ThreadStart(Mirroring));
            t.Start();
        }

        public static void Mirroring()
        {
            QueryManager QueryManagerT = new QueryManager();
            while (true)
            {
                QueryManagerT.Mirroring();
                Thread.Sleep(3000);
            }
        }

        private void barraMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Listar_Click(object sender, EventArgs e)
        {
            alternar(1);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            alternar(4);
            this.QueryM.QuerySQLSERVER = "exec sp_buscar_estudiantes";
            this.QueryM.QueryMYSQL = "";

            List<Object> listaObj;

            try
            {
                listaObj = this.QueryM.SendListQuery(0, 0);
            } catch (Exception error)
            {
                listaObj = this.QueryM.SendListQuery(1, 0);
            }

            this.listaEstudiantes = new List<Estudiante>();
            Estudiante estudianteT;
            this.comboEstudiantes_Eliminar.Items.Clear();
            foreach (Object item in listaObj)
            {
                estudianteT = (Estudiante)item;
                this.listaEstudiantes.Add(estudianteT);
                this.comboEstudiantes_Eliminar.Items.Add(estudianteT.Nombre + " " + estudianteT.Apellidos);
            }
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            alternar(2);
            this.QueryM.QuerySQLSERVER = "exec sp_buscar_sede";
            this.QueryM.QueryMYSQL = "";

            List<Object> listaObj;

            try
            {
                listaObj = this.QueryM.SendListQuery(0, 1);
            } catch (Exception error)
            {
                listaObj = this.QueryM.SendListQuery(1, 1);
            }

            this.listaSede = new List<Sede>();
            this.comboSede_Insertar.Items.Clear();
            Sede sedeTemp;
            foreach (Object item in listaObj)
            {
                sedeTemp = (Sede)item;
                listaSede.Add(sedeTemp);
                this.comboSede_Insertar.Items.Add(sedeTemp.NombreSede);
            }
             
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            alternar(3);
            this.QueryM.QuerySQLSERVER = "exec sp_buscar_estudiantes";
            this.QueryM.QueryMYSQL = "";

            List<Object> listaObj;

            try
            {
                listaObj = this.QueryM.SendListQuery(0, 0);
            }
            catch (Exception error)
            {
                listaObj = this.QueryM.SendListQuery(1, 0);
            }

            this.listaEstudiantes = new List<Estudiante>();
            Estudiante estudianteT;
            this.comboEstudiantes_Actualizar.Items.Clear();
            foreach (Object item in listaObj)
            {
                estudianteT = (Estudiante)item;
                this.listaEstudiantes.Add(estudianteT);
                this.comboEstudiantes_Actualizar.Items.Add(estudianteT.Nombre + " " + estudianteT.Apellidos);
            }
        }

        private void comboEstudiantes_Eliminar_Onchange(object sender, EventArgs e)
        {
            this.QueryM.QuerySQLSERVER = "sp_eliminar_estudiante";
            this.QueryM.QueryMYSQL = "";

            try
            {
                this.QueryM.SendQuery(0, 3, this.listaEstudiantes[this.comboEstudiantes_Eliminar.SelectedIndex].Cedula);
            } catch (Exception error)
            {
                this.QueryM.SendQuery(1, 3, this.listaEstudiantes[this.comboEstudiantes_Eliminar.SelectedIndex].Cedula);
            }

            this.QueryM.QuerySQLSERVER = "exec sp_buscar_estudiantes";
            this.QueryM.QueryMYSQL = "";

            List<Object> listaObj;

            try
            {
                listaObj = this.QueryM.SendListQuery(0, 0);
            }
            catch(Exception error)
            {
                listaObj = this.QueryM.SendListQuery(1, 0);
            }
            
            this.listaEstudiantes = new List<Estudiante>();
            Estudiante estudianteT;
            this.comboEstudiantes_Eliminar.Items.Clear();
            foreach (Object item in listaObj)
            {
                estudianteT = (Estudiante)item;
                this.listaEstudiantes.Add(estudianteT);
                this.comboEstudiantes_Eliminar.Items.Add(estudianteT.Nombre + " " + estudianteT.Apellidos);
            }
        }

        private void comboEstudiantes_Actualizar_Onchange(object sender, EventArgs e)
        {
            int cedula = this.listaEstudiantes[this.comboEstudiantes_Actualizar.SelectedIndex].Cedula;
            String nombre = this.listaEstudiantes[this.comboEstudiantes_Actualizar.SelectedIndex].Nombre;
            String apellido = this.listaEstudiantes[this.comboEstudiantes_Actualizar.SelectedIndex].Apellidos;
            int edad = this.listaEstudiantes[this.comboEstudiantes_Actualizar.SelectedIndex].Edad;
            String nombreSede = this.listaEstudiantes[this.comboEstudiantes_Actualizar.SelectedIndex].NombreSede;
            int i = 0;
            int index = 0;
            this.inCedula_Actualizar.Enabled = true;
            this.inCedula_Actualizar.Text = cedula.ToString();
            this.inCedula_Actualizar.Enabled = false;
            this.inNombre_Actualizar.Text = nombre;
            this.inApellido_Actualizar.Text = apellido;
            this.inEdad_Actualizar.Text = edad.ToString();
            /**/
            this.QueryM.QuerySQLSERVER = "exec sp_buscar_sede";
            this.QueryM.QueryMYSQL = "";

            List<Object> listaObj;

            try
            {
                listaObj = this.QueryM.SendListQuery(0, 1);
            }
            catch(Exception error)
            {
                listaObj = this.QueryM.SendListQuery(1, 1);
            }

            this.listaSede = new List<Sede>();
            Sede sedeTemp;
            this.comboSede_Actualizar.Items.Clear();
            foreach (Object item in listaObj)
            {
                sedeTemp = (Sede)item;
                listaSede.Add(sedeTemp);
                this.comboSede_Actualizar.Items.Add(sedeTemp.NombreSede);
                if (nombreSede == sedeTemp.NombreSede)
                {
                    index = i;
                }
                i++;
            }
            this.comboSede_Actualizar.SelectedIndex = index;
        }

        private void btnRefrescar_Listar_Click(object sender, EventArgs e)
        {
            this.QueryM.QuerySQLSERVER = "exec sp_buscar_estudiantes";
            try
            {
                this.dataGridViewListar.DataSource = this.QueryM.SendListQuery(0, 0);
            }
            catch(Exception error)
            {
                this.dataGridViewListar.DataSource = this.QueryM.SendListQuery(1, 0);
            }
        }

        private void btnActualizar_Actualizar_Click(object sender, EventArgs e)
        {
            this.QueryM.QuerySQLSERVER = "sp_actualizar_estudiante";
            this.QueryM.QueryMYSQL = "";
            int idSede = this.listaSede[this.comboSede_Actualizar.SelectedIndex].IdSede;

            Estudiante estudiante = new Estudiante(int.Parse(this.inCedula_Actualizar.Text.Trim()),
                                                    this.inNombre_Actualizar.Text.Trim(),
                                                    this.inApellido_Actualizar.Text.Trim(),
                                                    int.Parse(this.inEdad_Actualizar.Text.Trim()),
                                                    idSede);

            try
            {
                this.QueryM.SendQuery(0, 2, estudiante);
            }
            catch(Exception error)
            {
                this.QueryM.SendQuery(1, 2, estudiante);
            }

            this.QueryM.QuerySQLSERVER = "exec sp_buscar_estudiantes";
            this.QueryM.QueryMYSQL = "";

            List<Object> listaObj;

            try
            {
                listaObj = this.QueryM.SendListQuery(0, 0);
            }
            catch(Exception error)
            {
                listaObj = this.QueryM.SendListQuery(1, 0);
            }

            this.listaEstudiantes = new List<Estudiante>();
            Estudiante estudianteT;
            this.comboEstudiantes_Actualizar.Items.Clear();
            foreach (Object item in listaObj)
            {
                estudianteT = (Estudiante)item;
                this.listaEstudiantes.Add(estudianteT);
                this.comboEstudiantes_Actualizar.Items.Add(estudianteT.Nombre + " " + estudianteT.Apellidos);
            }
            this.comboSede_Actualizar.Items.Clear();
            this.comboSede_Actualizar.Text = " ";
            this.inCedula_Actualizar.Enabled = true;
            this.inCedula_Actualizar.Text = " ";
            this.inCedula_Actualizar.Enabled = false;
            this.inNombre_Actualizar.Text = " ";
            this.inApellido_Actualizar.Text = " ";
            this.inEdad_Actualizar.Text = " ";
        }

        private void btnInsertar_Insertar_Click(object sender, EventArgs e)
        {
            this.QueryM.QuerySQLSERVER = "sp_insetar_estudiante";
            this.QueryM.QueryMYSQL = "";
            int idSede = this.listaSede[this.comboSede_Insertar.SelectedIndex].IdSede;

            Estudiante estudiante = new Estudiante(int.Parse(this.inCedula_Insertar.Text.Trim()),
                                                    this.inNombre_Insertar.Text.Trim(),
                                                    this.inApellido_Insertar.Text.Trim(),
                                                    int.Parse(this.inEdad_Insertar.Text.Trim()),
                                                    idSede);
            try
            {
                this.QueryM.SendQuery(0, 1, estudiante);
            } 
            catch(Exception error)
            {
                this.QueryM.SendQuery(1, 1, estudiante);
            }

            this.comboSede_Insertar.Text = " ";
            this.inCedula_Insertar.Text = " ";
            this.inNombre_Insertar.Text = " ";
            this.inApellido_Insertar.Text = " ";
            this.inEdad_Insertar.Text = " ";
        }

        private void alternar(int encender)
        {
            this.groupBoxListar.Visible = false;
            this.groupBoxListar.Enabled = false;

            this.groupBoxInsertar.Visible = false;
            this.groupBoxInsertar.Enabled = false;

            this.groupBoxActualizar.Visible = false;
            this.groupBoxActualizar.Enabled = false;

            this.groupBoxEliminar.Visible = false;
            this.groupBoxEliminar.Enabled = false;

            switch (encender)
            {
                case 1:
                    this.groupBoxListar.Visible = true;
                    this.groupBoxListar.Enabled = true;
                    break;
                case 2:
                    this.groupBoxInsertar.Visible = true;
                    this.groupBoxInsertar.Enabled = true;
                    break;
                case 3:
                    this.groupBoxActualizar.Visible = true;
                    this.groupBoxActualizar.Enabled = true;
                    break;
                case 4:
                    this.groupBoxEliminar.Visible = true;
                    this.groupBoxEliminar.Enabled = true;
                    break;
            }
        }
    }
}
