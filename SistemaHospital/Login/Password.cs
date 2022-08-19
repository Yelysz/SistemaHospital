using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHospital.Login
{
    public partial class Password : MainForm
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de Gestión de Pacientes";
        public string email;

        public Password()
        {
            InitializeComponent();
            loadClinic();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtComNewPass.Text)
            {
                MessageBox.Show("La contraseña que ingresaste no coincide. Escriba la contraseña de esta cuenta en ambos cuadros de texto.", "Asistente para agregar usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    if (MessageBox.Show("¿Restablecer contraseña?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery("UPDATE tbUsers SET password = '" + txtNewPass.Text + "'WHERE email = '" + txtEmail.Text + "'");
                        MessageBox.Show("La contraseña se ha restablecido con éxito", "Restablecer contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
            Application.Restart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void loadClinic()
        {
            try
            {
                dbcon.open();
                cm = new SqlCommand("SELECT * FROM tbClinic", dbcon.connect());
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    byte[] img = dr[0] as byte[];
                    MemoryStream ms = new MemoryStream(img);
                    picLogo.Image = Image.FromStream(ms);
                    lblName.Text = dr[1].ToString().ToUpper();
                }
                dr.Close();
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }

        }
        private void ResetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

    }
}
