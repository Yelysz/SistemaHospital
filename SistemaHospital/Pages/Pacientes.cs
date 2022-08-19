using Intercom.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHospital.Pages
{
    public partial class Pacientes : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de gestión de pacientes";
        public string pid;
        public Pacientes()
        {
            InitializeComponent();
            loadPatients();
            cbGender.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Modulos.Paciente module = new Modulos.Paciente(this);
            module.ShowDialog();
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPatients.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                //to to sent doctor data to the module 
                Modulos.Paciente module = new Modulos.Paciente(this);
                module.loadPatient(dgvPatients.Rows[e.RowIndex].Cells[1].Value.ToString());
                module.ShowDialog();
            }
            else if (colName == "Delete") // if you want to delete the record to click the delete icon on the datagridview
            {
                try
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM tbPatients WHERE id LIKE'" + dgvPatients.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("¡El registro se ha eliminado con éxito!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadPatients();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
        }

        #region method
        public void loadPatients()
        {
            string sql = "";
            string gender = cbGender.Text;
            if (gender == "Genero (Todos)")
                sql = "SELECT P.id, name, gender, phone, email, insurance, policy, COUNT(V.pid) visits FROM tbPatients AS P LEFT JOIN tbVisits AS V ON P.id=v.pid WHERE name LIKE '%" + txtSearch.Text + "%' GROUP BY p.id, name,gender, phone, email, insurance, policy";
            else sql = "SELECT P.id, name, gender, phone, email, insurance, policy, COUNT(V.pid) visits FROM tbPatients AS P LEFT JOIN tbVisits AS V ON P.id=v.pid WHERE name LIKE '%" + txtSearch.Text + "%'and gender='" + gender + "' GROUP BY p.id, name,gender, phone, email, insurance, policy";

            try
            {
                int i = 0;
                dgvPatients.Rows.Clear();
                cm = new SqlCommand(sql, dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // to add data to the datagridview from the database
                    dgvPatients.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion method

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPatients();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadPatients();
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            Modulos.Visita module = new Modulos.Visita();
            module.lblId.Text = pid;
            module.ShowDialog();
            loadPatients();
        }

        private void btnViewVisit_Click(object sender, EventArgs e)
        {
            Modulos.PacienteVisita module = new Modulos.PacienteVisita(this);
            module.ShowDialog();
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddVisit.Enabled = true;
            btnViewVisit.Enabled = true;
            pid = dgvPatients.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

