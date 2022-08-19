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
    public partial class Doctores : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de gestión de pacientes";
        public Doctores()
        {
            InitializeComponent();
            loadDoctor();
            cbGender.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Modulos.Doctor doctor = new Modulos.Doctor(this);
            doctor.ShowDialog();
        }

        #region method
        public void loadDoctor()
        {
            string sql = "";
            string gender = cbGender.Text;
            if (gender == "Genero (Todos)")
                sql = "SELECT d.id, name, gender, specialty, phone, email, datejoined, COUNT(distinct V.pid) AS Patient, count(V.did) AS visits FROM tbDoctors AS D LEFT JOIN tbVisits AS V ON D.id=V.did WHERE CONCAT(name, specialty)LIKE '%" + txtSearch.Text + "%' GROUP BY d.id, name, gender, specialty, phone, email, datejoined";
            else sql = "SELECT d.id, name, gender, specialty, phone, email, datejoined, COUNT(distinct V.pid) AS Patient, count(V.did) AS visits FROM tbDoctors AS D LEFT JOIN tbVisits AS V ON D.id=V.did WHERE CONCAT(name, specialty)LIKE '%" + txtSearch.Text + "%' and gender='" + gender + "' GROUP BY d.id, name, gender, specialty, phone, email, datejoined";
            try
            {
                int i = 0;
                dgvDoctor.Rows.Clear();
                cm = new SqlCommand(sql, dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // to add data to the datagridview from the database
                    dgvDoctor.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), DateTime.Parse(dr[6].ToString()).ToShortDateString(), dr[7].ToString(), dr[8].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion method

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDoctor.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                //to to sent doctor data to the module 
                Modulos.Doctor module = new Modulos.Doctor(this);
                module.loadDoctor(dgvDoctor.Rows[e.RowIndex].Cells[1].Value.ToString());
                module.ShowDialog();
            }
            else if (colName == "Delete") // if you want to delete the record to click the delete icon on the datagridview
            {
                try
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM tbDoctors WHERE id LIKE'" + dgvDoctor.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("¡El registro se ha eliminado con éxito!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDoctor();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }

        }
    }
}
