﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SEExamen2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsConexion cn = new clsConexion();
        private void Form1_Load(object sender, EventArgs e)
        {
            cn.abrir();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCRUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCRUD.SelectedIndex == 1)
            {
                grpBoxInsertar.Visible = true;
                grpModificar.Visible = false;
                grpBoxDelete.Visible = false;
                txtCasada.Text = "NULL";
                loadDataI();             
            }else if (cmbCRUD.SelectedIndex==2)
            {
                grpModificar.Visible = true;
                grpBoxInsertar.Visible = false;
                grpBoxDelete.Visible = false;
                loadDataU();
            }else if (cmbCRUD.SelectedIndex==3)
            {
                grpBoxDelete.Visible = true;
                grpModificar.Visible = false;
                grpBoxInsertar.Visible = false;
                loadDataD();
            }
            cmbCRUD.SelectedIndex = 0;
        }

        public void loadDataI()
        {
            try
            {
                string cadena = "SELECT * FROM te_clientes WHERE estado=1;";
                cn.abrir();
                SqlCommand comm = new SqlCommand(cadena, cn.conectar);
                comm.ExecuteNonQuery();
                //SqlDataReader reader = comm.ExecuteReader();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dt);

                dgvInserciones.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los datos" + ex);
            }
            cn.cerrar();
        }

        public void loadDataU()
        {
            try
            {
                string cadena = "SELECT cli_codigo_cliente, cli_nombre1, cli_nombre2,cli_apellido1,cli_apellido2,cli_apellido_casada,cli_direccion,cli_telefono1,cli_fechaNacimiento,estado FROM te_clientes; ";
                cn.abrir();
                SqlCommand comm = new SqlCommand(cadena, cn.conectar);
                comm.ExecuteNonQuery();
                //SqlDataReader reader = comm.ExecuteReader();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dt);

                dgvModificar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los datos" + ex);
            }
            cn.cerrar();
        }

        public void loadDataD()
        {
            try
            {
                string cadena = "SELECT cli_codigo_cliente, cli_nombre1, cli_nombre2,cli_apellido1,cli_apellido2,cli_apellido_casada,cli_direccion,cli_telefono1,cli_fechaNacimiento,estado FROM te_clientes where estado=1; ";
                cn.abrir();
                SqlCommand comm = new SqlCommand(cadena, cn.conectar);
                comm.ExecuteNonQuery();
                //SqlDataReader reader = comm.ExecuteReader();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dt);

                dgvDelete.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los datos" + ex);
            }
            cn.cerrar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text!="" || txtSegundoNombre.Text != "" ||txtPrimerApellido.Text != "" ||txtSegundoApellido.Text != "" ||txtCasada.Text != "" ||txtDireccion.Text != "" ||txtTelefonoOne.Text != "" ||txtTelefonoTwo.Text != "" ||txtDpi.Text != "" ||txtEstado.Text != "")
            {
                string Fecha = dtpNacimiento.Value.ToString("MM/dd/yyyy");
                int stado = int.Parse(txtEstado.Text.ToString());
                try
                {

                    string Insertar = "EXEC SP_INSERTAR @i_cli_nombre1,@i_cli_nombre2,@i_cli_apellido1,@i_cli_apellido2,@i_cli_apellido_casada,@i_cli_direccion,@i_cli_telefono1,@i_cli_telefono2,@i_cli_identificacion,@i_cli_fechaNacimiento, @i_estado";
                    cn.abrir();
                    SqlCommand comm = new SqlCommand(Insertar, cn.conectar);
                    comm.Parameters.AddWithValue("@i_cli_nombre1", txtPrimerNombre.Text);
                    comm.Parameters.AddWithValue("@i_cli_nombre2", txtSegundoNombre.Text);
                    comm.Parameters.AddWithValue("@i_cli_apellido1", txtPrimerApellido.Text);
                    comm.Parameters.AddWithValue("@i_cli_apellido2", txtSegundoApellido.Text);
                    comm.Parameters.AddWithValue("@i_cli_apellido_casada", txtCasada.Text);
                    comm.Parameters.AddWithValue("@i_cli_direccion", txtDireccion.Text);
                    comm.Parameters.AddWithValue("@i_cli_telefono1", txtTelefonoOne.Text);
                    comm.Parameters.AddWithValue("@i_cli_telefono2", txtTelefonoTwo.Text);
                    comm.Parameters.AddWithValue("@i_cli_identificacion", txtDpi.Text);
                    comm.Parameters.AddWithValue("@i_cli_fechaNacimiento", Fecha);
                    comm.Parameters.AddWithValue("@i_estado", stado);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Datos Ingresados correctamente");
                }
                catch (Exception exc) { Console.WriteLine("Excepción Inserción en: " + exc); }
                loadDataI();
            }
        }

        private void rdbActivoI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivoI.Checked)
            {
                txtEstado.Text = "1";
            }else if (rdbInactivoI.Checked)
            {
                txtEstado.Text = "0";
            }
        }

        private void grpBoxInsertar_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelectCodeUpdate_Click(object sender, EventArgs e)
        {
            string codigoCliente = dgvModificar.CurrentRow.Cells[0].Value.ToString();
           // MessageBox.Show("Valor de codigo: " + codigoCliente);
            txtCodeModificar.Text = codigoCliente;
          
            txtCasadaU.Text = dgvModificar.CurrentRow.Cells[5].Value.ToString();
            txtDireccionU.Text = dgvModificar.CurrentRow.Cells[6].Value.ToString();
            string estado = dgvModificar.CurrentRow.Cells[9].Value.ToString();
            if (estado == "1")
            {
                rdbActivoU.Checked = true;
                rdbInactivoU.Checked = false;
            }
            else if (estado == "0")
            {
                rdbActivoU.Checked = false;
                rdbInactivoU.Checked = true;
            }
        }

        private void txtSearchU_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                string cadena = "SELECT cli_codigo_cliente, cli_nombre1, cli_nombre2,cli_apellido1,cli_apellido2,cli_apellido_casada,cli_direccion,cli_telefono1,cli_fechaNacimiento,estado FROM te_clientes WHERE cli_nombre1 like '" + txtSearchU.Text + "%';";
                cn.abrir();
                SqlCommand comm = new SqlCommand(cadena, cn.conectar);
                comm.ExecuteNonQuery();
                //SqlDataReader reader = comm.ExecuteReader();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dt);

                dgvModificar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los datos" + ex);

            }
            cn.cerrar();
        }

        private void rdbActivoU_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivoU.Checked)
            {
                txtEstadoU.Text = "1";
            }else if (rdbInactivoU.Checked)
            {
                txtEstadoU.Text = "0";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDireccionU.Text!="" || txtCasadaU.Text!="" || txtEstadoU.Text!="")
            {
                int stado = int.Parse(txtEstadoU.Text.ToString());
                int cliente = int.Parse(txtCodeModificar.Text.ToString());
                try
                {

                    string modificar = "EXEC SP_MODIFICAR @i_codigo,@w_cli_apellido_casada,@w_cli_direccion,@w_estado";
                    cn.abrir();
                    SqlCommand comm = new SqlCommand(modificar, cn.conectar);
                    comm.Parameters.AddWithValue("@i_codigo", cliente);
                    comm.Parameters.AddWithValue("@w_cli_apellido_casada", txtCasadaU.Text);
                    comm.Parameters.AddWithValue("@w_cli_direccion", txtDireccionU.Text);
                    comm.Parameters.AddWithValue("@w_estado", stado);
                    comm.ExecuteNonQuery();

                    MessageBox.Show("Datos Actualizados correctamente");
                }
                catch (Exception exc) { MessageBox.Show("Excepción actualizacion en: " + exc); }
            }
            
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox.Checked)
            {
                txtCasada.Text = "";
                txtCasada.Enabled = true;
            }else
            {
                txtCasada.Text = "NULL";
                txtCasada.Enabled = false;
            }
        }

        private void chkCasadaU_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCasadaU.Checked)
            {
                txtCasadaU.Enabled = true;
            }
            else
            {
                txtCasadaU.Enabled = false;
            }
        }

        private void txtSearchD_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string cadena = "SELECT cli_codigo_cliente, cli_nombre1, cli_nombre2,cli_apellido1,cli_apellido2,cli_apellido_casada,cli_direccion,cli_telefono1,cli_fechaNacimiento,estado FROM te_clientes where cli_nombre1 like '" + txtSearchD.Text + "%' and estado=1;";
                cn.abrir();
                SqlCommand comm = new SqlCommand(cadena, cn.conectar);
                comm.ExecuteNonQuery();
                //SqlDataReader reader = comm.ExecuteReader();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dt);

                dgvDelete.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los datos" + ex);

            }
            cn.cerrar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete","¿Estás seguro de eliminar el registro?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int cliente = int.Parse(txtCodeToD.Text.ToString());
                try
                {

                    string Insertar = "EXEC SP_BORRAR @codigo";
                    cn.abrir();
                    SqlCommand comm = new SqlCommand(Insertar, cn.conectar);
                    comm.Parameters.AddWithValue("@codigo", cliente);

                    comm.ExecuteNonQuery();

                    MessageBox.Show("Datos eliminados correctamente");
                }
                catch (Exception exc) { MessageBox.Show("Excepción eliminacion en: " + exc); }
            }
            else
            {

            }
        }

        private void btnSelectDCode_Click(object sender, EventArgs e)
        {
            string codigoCliente = dgvDelete.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("Valor de codigo: " + codigoCliente);
            txtCodeToD.Text = codigoCliente;
            txtPrimerNombreD.Text = dgvDelete.CurrentRow.Cells[1].Value.ToString();
            txtSegundoNombreD.Text = dgvDelete.CurrentRow.Cells[2].Value.ToString();
            txtPrimerApellidoD.Text = dgvDelete.CurrentRow.Cells[3].Value.ToString();
            txtSegundoApellidoD.Text = dgvDelete.CurrentRow.Cells[4].Value.ToString();
            txtDireccionD.Text = dgvDelete.CurrentRow.Cells[6].Value.ToString();
            string fechaNac = dgvDelete.CurrentRow.Cells[8].Value.ToString();
            dtpNacimientoD.Value = DateTime.Parse(fechaNac);            
            
        }
    }
}
