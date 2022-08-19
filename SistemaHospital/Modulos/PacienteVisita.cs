using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intercom.Core;


namespace SistemaHospital.Modulos
{
    public partial class PacienteVisita : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de gestión de pacientes";
        List<double> sysValues = new List<double>();
        List<double> diaValues = new List<double>();
        List<string> LblDate = new List<string>();
        List<double> weight = new List<double>();
        List<double> temp = new List<double>();

        Pages.Pacientes patients;
        public PacienteVisita(Pages.Pacientes patient)
        {
            InitializeComponent();
            patients = patient;
            doctorList();
            loadVisits();
            cbDoctor.SelectedIndex = 0;
            dtFrom.Value = DateTime.Now.AddDays(-30);

        }
        public void doctorList()
        {
            cbDoctor.Items.Add("Doctores (Todos)");
            cm = new SqlCommand("SELECT * FROM tbDoctors", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbDoctor.Items.Add(dr["name"]);
            }
            dbcon.close();
        }

        #region method
        public void loadVisits()
        {
            string sql = "";
            string doctor = cbDoctor.Text;
            if (doctor == "Doctores (Todos)")
                sql = "SELECT v.id, reason, date, pid, P.name, did, D.name, weight, temperature, systolic, diastolic FROM tbVisits AS V JOIN tbDoctors AS D ON v.did = d.id JOIN tbPatients AS P ON v.pid = p.id WHERE v.pid = '" + patients.pid + "' AND reason LIKE '%" + txtSearch.Text + "%' AND date BETWEEN '" + dtFrom.Value + "' AND '" + dtTo.Value + "'";
            else sql = "SELECT v.id, reason, date, pid, p.name, did, d.name, weight, temperature, systolic, diastolic FROM tbVisits AS V JOIN tbDoctors AS D ON v.did = d.id JOIN tbPatients AS P ON v.pid = p.id WHERE v.pid = '" + patients.pid + "' AND reason LIKE '%" + txtSearch.Text + "%'and d.name='" + doctor + "' AND date BETWEEN '" + dtFrom.Value + "' AND '" + dtTo.Value + "'";
            try
            {
                chartClear();
                int i = 0;
                dgvVisits.Rows.Clear();
                cm = new SqlCommand(sql, dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // to add data to the datagridview from the database
                    dgvVisits.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString());
                    sysValues.Add(double.Parse(dr[9].ToString()));
                    diaValues.Add(double.Parse(dr[10].ToString()));
                    LblDate.Add(DateTime.Parse(dr[2].ToString()).ToShortDateString());
                    weight.Add(double.Parse(dr[7].ToString()));
                    temp.Add(double.Parse(dr[8].ToString()));

                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
            LoadchartBlood();
            LoadchartWT();
        }

        #endregion method

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadVisits();
        }

        private void dgvVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvVisits.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                //to to sent doctor data to the module 
                Modulos.Visita module = new Modulos.Visita();
                module.loadVisits(dgvVisits.Rows[e.RowIndex].Cells[1].Value.ToString());
                module.ShowDialog();
            }
            else if (colName == "Patient")
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
            else if (colName == "Delete") // if you want to delete the record to click the delete icon on the datagridview
            {
                try
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE FROM tbVisits WHERE id LIKE'" + dgvVisits.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("¡El registro se ha eliminado con éxito!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadVisits();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
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

        private void Patient_visits_Load(object sender, EventArgs e)
        {
            LoadchartBlood();
            LoadchartWT();
        }

        public void LoadchartBlood()
        {
            chartBlood.Series.Clear();
            chartBlood.Series.Add(new LineSeries
            {
                Title = "Systolic",
                Values = new ChartValues<double>(sysValues),
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(193, 0, 55)),
                LineSmoothness = 1,
                //PointGeometry = null,
                PointGeometrySize = 8,
                PointForeground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(193, 0, 55))
            });
            chartBlood.Series.Add(new LineSeries
            {
                Title = "DiaStolic",
                Values = new ChartValues<double>(diaValues),
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 136, 0)),
                LineSmoothness = 1,
                PointGeometrySize = 8,
                PointForeground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 136, 0))
            });
            // chartBlood.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49));
            chartBlood.AxisX.Clear();
            chartBlood.AxisY.Clear();
            chartBlood.AxisX.Add(new Axis
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
            chartBlood.AxisY.Add(new Axis
            {
                Title = "Blood Pressure",
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 0.1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            }); ;
            chartBlood.LegendLocation = LiveCharts.LegendLocation.Top;
        }

        public void LoadchartWT()
        {
            chartWT.Series.Clear();
            chartWT.Series = new SeriesCollection
            {
                new LineSeries
                {
                   Title = "Weight",
                   Values = new ChartValues<double>(weight)
                },

                new LineSeries
                {
                 Title = "Tempature",
                 Values = new ChartValues<double>(temp),
                }
            };

            //chartWT.Series.Add(new LineSeries
            //{
            //    Title = "Weight",
            //    Values = new ChartValues<double>(weight),
            //    StrokeThickness = 2,
            //    //StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
            //    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(193, 0, 55)),
            //    //Fill = System.Windows.Media.Brushes.Red,
            //    LineSmoothness = 1,
            //    //PointGeometry = null,
            //    PointGeometrySize = 8,
            //    PointForeground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(193, 0, 55))
            //});
            //chartWT.Series.Add(new LineSeries
            //{
            //    Title = "Tempature",
            //    Values = new ChartValues<double>(temp),
            //    StrokeThickness = 2,
            //    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 136, 0)),
            //    //Fill = System.Windows.Media.Brushes.Orange,
            //    LineSmoothness = 1,
            //    PointGeometrySize = 8,
            //    PointForeground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 136, 0))
            //});
            //chartWT.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49));            
            chartWT.AxisY.Clear();
            chartWT.AxisX.Clear();

            chartWT.AxisX.Add(new Axis
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
            chartWT.AxisY.Add(new Axis
            {
                Title = "Tempature && Weight",
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 0.1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(4),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            }); ;
            chartWT.LegendLocation = LiveCharts.LegendLocation.Top;

        }

        public void chartClear()
        {
            sysValues.Clear();
            diaValues.Clear();
            weight.Clear();
            temp.Clear();
            LblDate.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Modulos.Visita module = new Modulos.Visita();
            module.lblId.Text = patients.pid;
            module.ShowDialog();
            loadVisits();
        }
    }
}
