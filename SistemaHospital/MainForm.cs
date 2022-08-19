using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SistemaHospital
{
    public partial class MainForm : MaterialForm
    {
        
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Restart();
        }



        // create a function any form to the panelChild on the mainform

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnPatient.Width;
            panelSlide.Left = btnPatient.Left;
            openChildForm(new Pages.Pacientes());
        }



        private void btnVisit_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnVisit.Width;
            panelSlide.Left = btnVisit.Left;
            openChildForm(new Pages.Visitas());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnDoctors.Width;
            panelSlide.Left = btnDoctors.Left;
            openChildForm(new Pages.Doctores());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnUsers.Width;
            panelSlide.Left = btnUsers.Left;
            openChildForm(new Pages.Usuarios());
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnClinic.Width;
            panelSlide.Left = btnClinic.Left;
            Modulos.Clinica module = new Modulos.Clinica();
            module.ShowDialog();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            panelSlide.Width = btnDash.Width;
            panelSlide.Left = btnDash.Left;
            openChildForm(new Pages.Tablero());

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDash.PerformClick();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
