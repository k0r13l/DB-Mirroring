

using System.Collections.Generic;

namespace ProyectoBasesDeDatos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.Listar = new System.Windows.Forms.ToolStripMenuItem();
            this.Insertar = new System.Windows.Forms.ToolStripMenuItem();
            this.Actualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxListar = new System.Windows.Forms.GroupBox();
            this.dataGridViewListar = new System.Windows.Forms.DataGridView();
            this.btnRefrescar_Listar = new System.Windows.Forms.Button();

            this.groupBoxInsertar = new System.Windows.Forms.GroupBox();
            this.btnInsertar_Insertar = new System.Windows.Forms.Button();
            this.lbCedula_Insertar = new System.Windows.Forms.Label();
            this.lbNombre_Insertar = new System.Windows.Forms.Label();
            this.lbApellido_Insertar = new System.Windows.Forms.Label();
            this.lbEdad_Insertar = new System.Windows.Forms.Label();
            this.lbSede_Insertar = new System.Windows.Forms.Label();
            this.inCedula_Insertar = new System.Windows.Forms.TextBox();
            this.inNombre_Insertar = new System.Windows.Forms.TextBox();
            this.inApellido_Insertar = new System.Windows.Forms.TextBox();
            this.inEdad_Insertar = new System.Windows.Forms.TextBox();
            this.comboSede_Insertar = new System.Windows.Forms.ComboBox();

            this.groupBoxActualizar = new System.Windows.Forms.GroupBox();
            this.btnActualizar_Actualizar = new System.Windows.Forms.Button();
            this.lbCedula_Actualizar = new System.Windows.Forms.Label();
            this.lbNombre_Actualizar = new System.Windows.Forms.Label();
            this.lbApellido_Actualizar = new System.Windows.Forms.Label();
            this.lbEdad_Actualizar = new System.Windows.Forms.Label();
            this.lbSede_Actualizar = new System.Windows.Forms.Label();
            this.inCedula_Actualizar = new System.Windows.Forms.TextBox();
            this.inNombre_Actualizar = new System.Windows.Forms.TextBox();
            this.inApellido_Actualizar = new System.Windows.Forms.TextBox();
            this.inEdad_Actualizar = new System.Windows.Forms.TextBox();
            this.comboSede_Actualizar = new System.Windows.Forms.ComboBox();
            this.comboEstudiantes_Actualizar = new System.Windows.Forms.ComboBox();
            this.lbEstudiante_Combo_Actualizar = new System.Windows.Forms.Label();

            this.groupBoxEliminar = new System.Windows.Forms.GroupBox();
            this.comboEstudiantes_Eliminar = new System.Windows.Forms.ComboBox();
            this.lbEstudiante_Combo_Eliminar = new System.Windows.Forms.Label();
            this.barraMenu.SuspendLayout();
            this.groupBoxListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).BeginInit();
            this.groupBoxInsertar.SuspendLayout();
            this.groupBoxActualizar.SuspendLayout();
            this.groupBoxEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraMenu
            // 
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Listar,
            this.Insertar,
            this.Actualizar,
            this.Eliminar});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(750, 24);
            this.barraMenu.TabIndex = 0;
            this.barraMenu.Text = "menuStrip1";
            this.barraMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barraMenu_ItemClicked);
            // 
            // Listar
            // 
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(47, 20);
            this.Listar.Text = "Listar";
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // Insertar
            // 
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(58, 20);
            this.Insertar.Text = "Insertar";
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(71, 20);
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(62, 20);
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // groupBoxListar
            // 
            this.groupBoxListar.Controls.Add(this.dataGridViewListar);
            this.groupBoxListar.Controls.Add(this.btnRefrescar_Listar);
            this.groupBoxListar.Enabled = false;
            this.groupBoxListar.Location = new System.Drawing.Point(0, 27);
            this.groupBoxListar.Name = "groupBoxListar";
            this.groupBoxListar.Size = new System.Drawing.Size(750, 300);
            this.groupBoxListar.TabIndex = 1;
            this.groupBoxListar.TabStop = false;
            this.groupBoxListar.Text = "Presione actualizar para obtener la información";
            this.groupBoxListar.Visible = false;
            // 
            // dataGridViewListar
            // 
            this.dataGridViewListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListar.Location = new System.Drawing.Point(18, 23);
            this.dataGridViewListar.Name = "dataGridViewListar";
            this.dataGridViewListar.RowTemplate.Height = 25;
            this.dataGridViewListar.Size = new System.Drawing.Size(726, 222);
            this.dataGridViewListar.TabIndex = 1;
            // 
            // btnRefrescar_Listar
            // 
            this.btnRefrescar_Listar.Location = new System.Drawing.Point(335, 265);
            this.btnRefrescar_Listar.Name = "btnRefrescar_Listar";
            this.btnRefrescar_Listar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar_Listar.TabIndex = 0;
            this.btnRefrescar_Listar.Text = "Refrescar";
            this.btnRefrescar_Listar.UseVisualStyleBackColor = true;
            this.btnRefrescar_Listar.Click += new System.EventHandler(this.btnRefrescar_Listar_Click);
            // 
            // groupBoxInsertar
            // 
            this.groupBoxInsertar.Controls.Add(this.btnInsertar_Insertar);
            this.groupBoxInsertar.Controls.Add(this.lbCedula_Insertar);
            this.groupBoxInsertar.Controls.Add(this.inCedula_Insertar);
            this.groupBoxInsertar.Controls.Add(this.lbNombre_Insertar);
            this.groupBoxInsertar.Controls.Add(this.inNombre_Insertar);
            this.groupBoxInsertar.Controls.Add(this.lbApellido_Insertar);
            this.groupBoxInsertar.Controls.Add(this.inApellido_Insertar);
            this.groupBoxInsertar.Controls.Add(this.lbEdad_Insertar);
            this.groupBoxInsertar.Controls.Add(this.inEdad_Insertar);
            this.groupBoxInsertar.Controls.Add(this.lbSede_Insertar);
            this.groupBoxInsertar.Controls.Add(this.comboSede_Insertar);
            this.groupBoxInsertar.Enabled = false;
            this.groupBoxInsertar.Location = new System.Drawing.Point(0, 27);
            this.groupBoxInsertar.Name = "groupBoxInsertar";
            this.groupBoxInsertar.Size = new System.Drawing.Size(750, 300);
            this.groupBoxInsertar.TabIndex = 1;
            this.groupBoxInsertar.TabStop = false;
            this.groupBoxInsertar.Text = "Inserte los datos del estudiante";
            this.groupBoxInsertar.Visible = false;
            // 
            // btnInsertar_Insertar
            // 
            this.btnInsertar_Insertar.Location = new System.Drawing.Point(329, 266);
            this.btnInsertar_Insertar.Name = "btnInsertar_Insertar";
            this.btnInsertar_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar_Insertar.TabIndex = 0;
            this.btnInsertar_Insertar.Text = "Insertar";
            this.btnInsertar_Insertar.UseVisualStyleBackColor = true;
            this.btnInsertar_Insertar.Click += new System.EventHandler(this.btnInsertar_Insertar_Click);
            // 
            // lbCedula
            // 
            this.lbCedula_Insertar.Location = new System.Drawing.Point(10, 30);
            this.lbCedula_Insertar.Name = "lbCedula";
            this.lbCedula_Insertar.Size = new System.Drawing.Size(75, 15);
            this.lbCedula_Insertar.TabIndex = 0;
            this.lbCedula_Insertar.Text = "Cédula";
            // 
            // inCedula
            // 
            this.inCedula_Insertar.Location = new System.Drawing.Point(10, 50);
            this.inCedula_Insertar.Name = "inCedula";
            this.inCedula_Insertar.Size = new System.Drawing.Size(75, 20);
            this.inCedula_Insertar.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre_Insertar.Location = new System.Drawing.Point(95, 30);
            this.lbNombre_Insertar.Name = "lbNombre";
            this.lbNombre_Insertar.Size = new System.Drawing.Size(75, 15);
            this.lbNombre_Insertar.TabIndex = 0;
            this.lbNombre_Insertar.Text = "Nombre";
            // 
            // inNombre
            // 
            this.inNombre_Insertar.Location = new System.Drawing.Point(95, 50);
            this.inNombre_Insertar.Name = "inNombre";
            this.inNombre_Insertar.Size = new System.Drawing.Size(75, 20);
            this.inNombre_Insertar.TabIndex = 0;
            // 
            // lbApellido
            // 
            this.lbApellido_Insertar.Location = new System.Drawing.Point(180, 30);
            this.lbApellido_Insertar.Name = "lbApellido";
            this.lbApellido_Insertar.Size = new System.Drawing.Size(75, 15);
            this.lbApellido_Insertar.TabIndex = 0;
            this.lbApellido_Insertar.Text = "Apellido";
            // 
            // inApellido
            // 
            this.inApellido_Insertar.Location = new System.Drawing.Point(180, 50);
            this.inApellido_Insertar.Name = "inApellido";
            this.inApellido_Insertar.Size = new System.Drawing.Size(75, 20);
            this.inApellido_Insertar.TabIndex = 0;
            // 
            // lbEdad
            // 
            this.lbEdad_Insertar.Location = new System.Drawing.Point(265, 30);
            this.lbEdad_Insertar.Name = "lbEdad";
            this.lbEdad_Insertar.Size = new System.Drawing.Size(75, 15);
            this.lbEdad_Insertar.TabIndex = 0;
            this.lbEdad_Insertar.Text = "Edad";
            // 
            // inEdad
            // 
            this.inEdad_Insertar.Location = new System.Drawing.Point(265, 50);
            this.inEdad_Insertar.Name = "inEdad";
            this.inEdad_Insertar.Size = new System.Drawing.Size(75, 20);
            this.inEdad_Insertar.TabIndex = 0;
            // 
            // lbSede
            // 
            this.lbSede_Insertar.Location = new System.Drawing.Point(350, 30);
            this.lbSede_Insertar.Name = "lbSede";
            this.lbSede_Insertar.Size = new System.Drawing.Size(75, 15);
            this.lbSede_Insertar.TabIndex = 0;
            this.lbSede_Insertar.Text = "Sede";
            // 
            // comboSede
            // 
            this.comboSede_Insertar.Location = new System.Drawing.Point(350, 50);
            this.comboSede_Insertar.Name = "comboSede";
            this.comboSede_Insertar.Size = new System.Drawing.Size(230, 20);
            this.comboSede_Insertar.TabIndex = 0;
            // 
            // groupBoxActualizar
            // 
            this.groupBoxActualizar.Controls.Add(this.btnActualizar_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.lbCedula_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.inCedula_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.lbNombre_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.inNombre_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.lbApellido_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.inApellido_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.lbEdad_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.inEdad_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.lbSede_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.comboSede_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.lbEstudiante_Combo_Actualizar);
            this.groupBoxActualizar.Controls.Add(this.comboEstudiantes_Actualizar);
            this.groupBoxActualizar.Enabled = false;
            this.groupBoxActualizar.Location = new System.Drawing.Point(0, 27);
            this.groupBoxActualizar.Name = "groupBoxActualizar";
            this.groupBoxActualizar.Size = new System.Drawing.Size(750, 300);
            this.groupBoxActualizar.TabIndex = 1;
            this.groupBoxActualizar.TabStop = false;
            this.groupBoxActualizar.Text = "Seleccione un estudiante del despegable para actualizarlo";
            this.groupBoxActualizar.Visible = false;
            // 
            // btnActualizar_Actualizar
            // 
            this.btnActualizar_Actualizar.Location = new System.Drawing.Point(329, 266);
            this.btnActualizar_Actualizar.Name = "btnActualizar_Actualizar";
            this.btnActualizar_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar_Actualizar.TabIndex = 0;
            this.btnActualizar_Actualizar.Text = "Actualizar";
            this.btnActualizar_Actualizar.UseVisualStyleBackColor = true;
            this.btnActualizar_Actualizar.Click += new System.EventHandler(this.btnActualizar_Actualizar_Click);
            /*---------------------------------------------------------*/
            // 
            // lbEstudiante_Combo_Actualizar
            // 
            this.lbEstudiante_Combo_Actualizar.Location = new System.Drawing.Point(10, 30);
            this.lbEstudiante_Combo_Actualizar.Name = "lbEstudiante_Combo_Actualizar";
            this.lbEstudiante_Combo_Actualizar.Size = new System.Drawing.Size(300, 15);
            this.lbEstudiante_Combo_Actualizar.TabIndex = 0;
            this.lbEstudiante_Combo_Actualizar.Text = "Buscar Estudiante por nombre";
            // 
            // comboEstudiantes_Actualizar
            // 
            this.comboEstudiantes_Actualizar.Location = new System.Drawing.Point(10, 50);
            this.comboEstudiantes_Actualizar.Name = "comboEstudiantes_Actualizar";
            this.comboEstudiantes_Actualizar.Size = new System.Drawing.Size(125, 20);
            this.comboEstudiantes_Actualizar.TabIndex = 0;
            this.comboEstudiantes_Actualizar.SelectedIndexChanged += new System.EventHandler(this.comboEstudiantes_Actualizar_Onchange);
            // 
            // lbCedula_Actualizar
            // 
            this.lbCedula_Actualizar.Location = new System.Drawing.Point(10, 110);
            this.lbCedula_Actualizar.Name = "lbCedula_Actualizar";
            this.lbCedula_Actualizar.Size = new System.Drawing.Size(75, 15);
            this.lbCedula_Actualizar.TabIndex = 0;
            this.lbCedula_Actualizar.Text = "Cédula";
            // 
            // inCedula_Actualizar
            // 
            this.inCedula_Actualizar.Location = new System.Drawing.Point(10, 130);
            this.inCedula_Actualizar.Name = "inCedula_Actualizar";
            this.inCedula_Actualizar.Size = new System.Drawing.Size(75, 20);
            this.inCedula_Actualizar.TabIndex = 0;
            // 
            // lbNombre_Actualizar
            // 
            this.lbNombre_Actualizar.Location = new System.Drawing.Point(95, 110);
            this.lbNombre_Actualizar.Name = "lbNombre_Actualizar";
            this.lbNombre_Actualizar.Size = new System.Drawing.Size(75, 15);
            this.lbNombre_Actualizar.TabIndex = 0;
            this.lbNombre_Actualizar.Text = "Nombre";
            // 
            // inNombre_Actualizar
            // 
            this.inNombre_Actualizar.Location = new System.Drawing.Point(95, 130);
            this.inNombre_Actualizar.Name = "inNombre_Actualizar";
            this.inNombre_Actualizar.Size = new System.Drawing.Size(75, 20);
            this.inNombre_Actualizar.TabIndex = 0;
            // 
            // lbApellido_Actualizar
            // 
            this.lbApellido_Actualizar.Location = new System.Drawing.Point(180, 110);
            this.lbApellido_Actualizar.Name = "lbApellido_Actualizar";
            this.lbApellido_Actualizar.Size = new System.Drawing.Size(75, 15);
            this.lbApellido_Actualizar.TabIndex = 0;
            this.lbApellido_Actualizar.Text = "Apellido";
            // 
            // inApellido_Actualizar
            // 
            this.inApellido_Actualizar.Location = new System.Drawing.Point(180, 130);
            this.inApellido_Actualizar.Name = "inApellido_Actualizar";
            this.inApellido_Actualizar.Size = new System.Drawing.Size(75, 20);
            this.inApellido_Actualizar.TabIndex = 0;
            // 
            // lbEdad_Actualizar
            // 
            this.lbEdad_Actualizar.Location = new System.Drawing.Point(265, 110);
            this.lbEdad_Actualizar.Name = "lbEdad_Actualizar";
            this.lbEdad_Actualizar.Size = new System.Drawing.Size(75, 15);
            this.lbEdad_Actualizar.TabIndex = 0;
            this.lbEdad_Actualizar.Text = "Edad";
            // 
            // inEdad_Actualizar
            // 
            this.inEdad_Actualizar.Location = new System.Drawing.Point(265, 130);
            this.inEdad_Actualizar.Name = "inEdad_Actualizar";
            this.inEdad_Actualizar.Size = new System.Drawing.Size(75, 20);
            this.inEdad_Actualizar.TabIndex = 0;
            // 
            // lbSede
            // 
            this.lbSede_Actualizar.Location = new System.Drawing.Point(350, 110);
            this.lbSede_Actualizar.Name = "lbSede_Actualizar";
            this.lbSede_Actualizar.Size = new System.Drawing.Size(75, 15);
            this.lbSede_Actualizar.TabIndex = 0;
            this.lbSede_Actualizar.Text = "Sede";
            // 
            // comboSede
            // 
            this.comboSede_Actualizar.Location = new System.Drawing.Point(350, 130);
            this.comboSede_Actualizar.Name = "comboSede_Actualizar";
            this.comboSede_Actualizar.Size = new System.Drawing.Size(230, 20);
            this.comboSede_Actualizar.TabIndex = 0;
            /*----------------------------------------------------------------------------*/
            // 
            // groupBoxEliminar
            // 
            this.groupBoxEliminar.Controls.Add(this.comboEstudiantes_Eliminar);
            this.groupBoxEliminar.Controls.Add(this.lbEstudiante_Combo_Eliminar);
            this.groupBoxEliminar.Enabled = false;
            this.groupBoxEliminar.Location = new System.Drawing.Point(0, 27);
            this.groupBoxEliminar.Name = "groupBoxEliminar";
            this.groupBoxEliminar.Size = new System.Drawing.Size(750, 300);
            this.groupBoxEliminar.TabIndex = 1;
            this.groupBoxEliminar.TabStop = false;
            this.groupBoxEliminar.Text = "Eliminar estudiante";
            this.groupBoxEliminar.Visible = false;
            // --------------------------------------
            // lbEstudiante_Combo_Eliminar
            // 
            this.lbEstudiante_Combo_Eliminar.Location = new System.Drawing.Point(10, 30);
            this.lbEstudiante_Combo_Eliminar.Name = "lbEstudiante_Combo_Eliminar";
            this.lbEstudiante_Combo_Eliminar.Size = new System.Drawing.Size(300, 15);
            this.lbEstudiante_Combo_Eliminar.TabIndex = 0;
            this.lbEstudiante_Combo_Eliminar.Text = "Eliminar Estudiante por nombre";
            // 
            // comboEstudiantes_Eliminar
            // 
            this.comboEstudiantes_Eliminar.Location = new System.Drawing.Point(10, 50);
            this.comboEstudiantes_Eliminar.Name = "comboEstudiantes_Eliminar";
            this.comboEstudiantes_Eliminar.Size = new System.Drawing.Size(125, 20);
            this.comboEstudiantes_Eliminar.TabIndex = 0;
            this.comboEstudiantes_Eliminar.SelectedIndexChanged += new System.EventHandler(this.comboEstudiantes_Eliminar_Onchange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 328);
            this.Controls.Add(this.groupBoxListar);
            this.Controls.Add(this.groupBoxInsertar);
            this.Controls.Add(this.groupBoxActualizar);
            this.Controls.Add(this.groupBoxEliminar);
            this.Controls.Add(this.barraMenu);
            this.MainMenuStrip = this.barraMenu;
            this.Name = "Form1";
            this.Text = "Proyecto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            this.groupBoxListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListar)).EndInit();
            this.groupBoxInsertar.ResumeLayout(false);
            this.groupBoxActualizar.ResumeLayout(false);
            this.groupBoxEliminar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem Listar;
        private System.Windows.Forms.ToolStripMenuItem Insertar;
        private System.Windows.Forms.ToolStripMenuItem Actualizar;
        private System.Windows.Forms.ToolStripMenuItem Eliminar;

        /* --- */
        private QueryManager QueryM;
        private List<Sede> listaSede;
        private List<Estudiante> listaEstudiantes;
        /* --- */

        private System.Windows.Forms.GroupBox groupBoxListar;
        private System.Windows.Forms.Button btnRefrescar_Listar;
        private System.Windows.Forms.DataGridView dataGridViewListar;

        private System.Windows.Forms.GroupBox groupBoxInsertar;
        private System.Windows.Forms.Button btnInsertar_Insertar;
        private System.Windows.Forms.Label lbCedula_Insertar;
        private System.Windows.Forms.Label lbNombre_Insertar;
        private System.Windows.Forms.Label lbApellido_Insertar;
        private System.Windows.Forms.Label lbEdad_Insertar;
        private System.Windows.Forms.Label lbSede_Insertar;
        private System.Windows.Forms.TextBox inCedula_Insertar;
        private System.Windows.Forms.TextBox inNombre_Insertar;
        private System.Windows.Forms.TextBox inApellido_Insertar;
        private System.Windows.Forms.TextBox inEdad_Insertar;
        private System.Windows.Forms.ComboBox comboSede_Insertar;

        private System.Windows.Forms.GroupBox groupBoxActualizar;
        private System.Windows.Forms.Button btnActualizar_Actualizar;
        private System.Windows.Forms.Label lbCedula_Actualizar;
        private System.Windows.Forms.Label lbNombre_Actualizar;
        private System.Windows.Forms.Label lbApellido_Actualizar;
        private System.Windows.Forms.Label lbEdad_Actualizar;
        private System.Windows.Forms.Label lbSede_Actualizar;
        private System.Windows.Forms.TextBox inCedula_Actualizar;
        private System.Windows.Forms.TextBox inNombre_Actualizar;
        private System.Windows.Forms.TextBox inApellido_Actualizar;
        private System.Windows.Forms.TextBox inEdad_Actualizar;
        private System.Windows.Forms.ComboBox comboSede_Actualizar;
        private System.Windows.Forms.ComboBox comboEstudiantes_Actualizar;
        private System.Windows.Forms.Label lbEstudiante_Combo_Actualizar;

        private System.Windows.Forms.GroupBox groupBoxEliminar;
        private System.Windows.Forms.ComboBox comboEstudiantes_Eliminar;
        private System.Windows.Forms.Label lbEstudiante_Combo_Eliminar;
    }
}

