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

namespace SistemaHospital.Modulos
{
    public partial class Clinica : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de Gestión de Pacientes";
        bool hasdetail = false;
        public Clinica()
        {
            InitializeComponent();
            loadClinic();
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
                    hasdetail = true;
                    byte[] img = dr[0] as byte[];
                    MemoryStream ms = new MemoryStream(img);

                    picLogo.Image = Image.FromStream(ms);
                    txtName.Text = dr[1].ToString();
                    txtPhone.Text = dr[2].ToString();
                    txtEmail.Text = dr[3].ToString();
                    txtAddress.Text = dr[4].ToString();
                    dtCreate.Text = dr[5].ToString();
                    dtCreate.Enabled = false;
                }
                else
                {
                    Clear();
                }
                dr.Close();
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                picLogo.Image.Save(ms, picLogo.Image.RawFormat);
                byte[] img = ms.ToArray();

                if (MessageBox.Show("¿Guardar detalles de la clínica?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {// now we create a function for execute querry only one line 
                    if (hasdetail)
                    {
                        cm = new SqlCommand("UPDATE tbClinic SET logo=@logo, name=@name, phone=@phone, email=@email, address=@address, createAt=@createAt", dbcon.connect());
                        cm.Parameters.AddWithValue("@logo", img);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cm.Parameters.AddWithValue("@email", txtEmail.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@createAt", dtCreate.Value);
                    }
                    else
                    {
                        cm = new SqlCommand("INSERT INTO tbClinic (logo, name, phone, email, address, createAt) VALUES (@logo, @name, @phone, @email, @address, @createAt)", dbcon.connect());
                        cm.Parameters.AddWithValue("@logo", img);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cm.Parameters.AddWithValue("@email", txtEmail.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@createAt", dtCreate.Value);

                    }
                    dbcon.open();// to open connection
                    cm.ExecuteNonQuery();
                    dbcon.close();// to close connection
                    MessageBox.Show("¡El detalle de la clínica se ha guardado con éxito!", "Guardar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            picLogo.Image = null;
            txtAddress.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtPhone.Clear();
            dtCreate.Value = DateTime.Now;
        }

        private void linkBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image (*.ico; *.png)|*ico.;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
