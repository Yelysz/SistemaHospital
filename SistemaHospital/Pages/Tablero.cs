using Intercom.Core;
using LiveCharts.Wpf;
using LiveCharts;
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
    public partial class Tablero : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de gestión de pacientes";
        List<int> wPatient = new List<int>();
        List<int> mVisit = new List<int>();
        List<string> LblDate = new List<string>();
        List<string> LblDatem = new List<string>();

        public Tablero()
        {
            InitializeComponent();
            loadVisits();
            loadData();
            doctorList();
            cbDoctor.SelectedIndex = 0;
            loadChart();
            LoadchartWeakly();
            Loadchartmonthly();

        }

        public void doctorList()
        {
            cbDoctor.Items.Add("Doctor (All)");
            cm = new SqlCommand("SELECT * FROM tbDoctors", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbDoctor.Items.Add(dr["name"]);
            }
            dbcon.close();
        }

        public void loadChart()
        {
            try
            {
                cm = new SqlCommand("select count(*),createAt from tbPatients WHERE createAt > '" + DateTime.Now.AddDays(-28) + "' group by createAt", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    wPatient.Add(int.Parse(dr[0].ToString()));
                    LblDate.Add(DateTime.Parse(dr[1].ToString()).ToShortDateString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }



            try
            {
                cm = new SqlCommand("select count(*),date from tbVisits WHERE date > '" + DateTime.Now.AddDays(-28) + "' group by date", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    mVisit.Add(int.Parse(dr[0].ToString()));
                    LblDatem.Add(DateTime.Parse(dr[1].ToString()).ToShortDateString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }

        }
        public void loadVisits()
        {
            string sql = "";
            string doctor = cbDoctor.Text;
            if (doctor == "Doctor (All)")
                sql = "SELECT v.id, reason, date, pid, P.name, did, D.name, weight, temperature, systolic, diastolic FROM tbVisits AS V JOIN tbDoctors AS D ON v.did = d.id JOIN tbPatients AS P ON v.pid = p.id WHERE CONCAT(reason, p.name) LIKE '%" + txtSearch.Text + "%'AND date BETWEEN '" + dtFrom.Value + "' AND '" + dtTo.Value + "'";
            else sql = "SELECT v.id, reason, date, pid, p.name, did, d.name, weight, temperature, systolic, diastolic FROM tbVisits AS V JOIN tbDoctors AS D ON v.did = d.id JOIN tbPatients AS P ON v.pid = p.id WHERE CONCAT(reason,p.name) LIKE '%" + txtSearch.Text + "%'and d.name='" + doctor + "'" +
                    " AND date BETWEEN '" + dtFrom.Value + "' AND '" + dtTo.Value + "'";
            try
            {
                int i = 0;
                dgvVisits.Rows.Clear();
                cm = new SqlCommand(sql, dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // to add data to the datagridview from the database
                    dgvVisits.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()).ToShortDateString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        public void loadData()
        {
            lblPatients.Text = dbcon.ExtractData("select count(*) from tbPatients").ToString();
            lblDoctor.Text = dbcon.ExtractData("select count(*) from tbDoctors").ToString();
            lblUser.Text = dbcon.ExtractData("select count(*) from tbUsers").ToString();
            lblVisits.Text = dbcon.ExtractData("select count(*) from tbVisits").ToString();
            lblPatientTD.Text = dbcon.ExtractData("select count(*) from tbPatients WHERE createAt > '" + DateTime.Now.AddDays(-1) + "'").ToString();
            lblVisitTD.Text = dbcon.ExtractData("select count(*) from tbVisits WHERE createAt > '" + DateTime.Now.AddDays(-1) + "'").ToString();
            lblPatientTM.Text = dbcon.ExtractData("select count(*) from tbPatients WHERE createAt > '" + DateTime.Now.AddDays(-28) + "'").ToString();
            lblVisitTM.Text = dbcon.ExtractData("select count(*) from tbVisits WHERE createAt > '" + DateTime.Now.AddDays(-28) + "'").ToString();
        }

        public void LoadchartWeakly()
        {
            chartWeakly.Series.Clear();
            chartWeakly.Series.Add(new ColumnSeries
            {
                Title = "Patient",
                Values = new ChartValues<int>(wPatient),
                StrokeThickness = 2,
            });

            chartWeakly.AxisX.Clear();
            chartWeakly.AxisY.Clear();
            chartWeakly.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = LblDate,
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 0.1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
            chartWeakly.AxisY.Add(new Axis
            {
                Title = "Last 28 Days",
                Labels = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21" },
                LabelsRotation = 1,
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 0.1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
            chartWeakly.LegendLocation = LiveCharts.LegendLocation.Top;
        }

        public void Loadchartmonthly()
        {
            chartMonthly.Series.Clear();
            chartMonthly.Series.Add(new ColumnSeries
            {
                Title = "Visits",
                Values = new ChartValues<int>(mVisit),
                StrokeThickness = 1,

            });

            chartMonthly.AxisX.Clear();
            chartMonthly.AxisY.Clear();
            chartMonthly.AxisX.Add(new Axis
            {
                Title = "Date",
                Labels = LblDatem,
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 0.1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(2),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 200, 86))
                }
            });
            chartMonthly.AxisY.Add(new Axis
            {
                Title = "Last 28 Days",
                Labels = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21" },
                LabelsRotation = 1,
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 0.1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
            chartMonthly.LegendLocation = LiveCharts.LegendLocation.Top;
        }

        private void dgvVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvVisits.Columns[e.ColumnIndex].Name;
            if (colName == "Patient")
            {
                //to to sent doctor data to the module 
                Modulos.Paciente module = new Modulos.Paciente(new Pages.Pacientes());
                module.loadPatient(dgvVisits.Rows[e.RowIndex].Cells[4].Value.ToString());
                module.View();
                module.ShowDialog();
            }
            else if (colName == "Doctor")
            {
                //to to sent doctor data to the module 
                Modulos.Doctor module = new Modulos.Doctor(new Pages.Doctores());
                module.loadDoctor(dgvVisits.Rows[e.RowIndex].Cells[6].Value.ToString());
                module.View();
                module.ShowDialog();
            }
        }

        private void Tablero_Load(object sender, EventArgs e)
        {

        }
    }
}
