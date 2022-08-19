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
    public partial class Usuario : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de gestión de pacientes";
        bool check = false;
        bool update = false;
        Pages.Usuarios user;
        public Usuario(Pages.Usuarios form)
        {
            InitializeComponent();
            user = form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (update)
                    {
                        if (MessageBox.Show("¿Está seguro de que desea actualizar esta información de usuario?", "Actualización de información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MemoryStream ms = new MemoryStream();
                            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            cm = new SqlCommand("UPDATE tbUsers SET photo=@photo, name=@name, gender=@gender, phone=@phone, email=@email, notes=@notes WHERE id=" + lblUid.Text + "", dbcon.connect());
                            cm.Parameters.AddWithValue("@photo", img);
                            cm.Parameters.AddWithValue("@name", txtName.Text);
                            cm.Parameters.AddWithValue("@gender", cbGender.Text);
                            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                            cm.Parameters.AddWithValue("@email", txtEmail.Text);
                            cm.Parameters.AddWithValue("@notes", txtNote.Text);

                            dbcon.open();// to open connection
                            cm.ExecuteNonQuery();
                            dbcon.close();// to close connection
                            MessageBox.Show("¡La información de los usuarios se ha actualizado con éxito!", title);
                            this.Dispose();


                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea registrar a este Usuario?", "Registro de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MemoryStream ms = new MemoryStream();
                            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            cm = new SqlCommand("INSERT INTO tbUsers (photo, name, gender, phone, email, notes, createAt) VALUES ( @photo, @name, @gender, @phone, @email, @notes, @createAt)", dbcon.connect());
                            cm.Parameters.AddWithValue("@photo", img);
                            cm.Parameters.AddWithValue("@name", txtName.Text);
                            cm.Parameters.AddWithValue("@gender", cbGender.Text);
                            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                            cm.Parameters.AddWithValue("@email", txtEmail.Text);
                            cm.Parameters.AddWithValue("@notes", txtNote.Text);
                            cm.Parameters.AddWithValue("@createAt", dtCreate.Value);


                            dbcon.open();// to open connection
                            cm.ExecuteNonQuery();
                            dbcon.close();// to close connection
                            MessageBox.Show("¡La información del usuario se ha registrado correctamente!", title);
                            Clear();//to clear data field, after data inserted into the database                            
                            picPhoto.Focus();

                        }
                    }
                    user.loadUser();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            update = false;
        }
        #region method
        //to check data field and date of birth
        public void checkField()
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("¡Campo de datos requerido!", "Advertencia");
                return; // return to the data field and form
            }

            check = true;
        }

        public void Clear()
        {
            txtEmail.Clear();
            txtName.Clear();
            txtNote.Clear();
            txtPhone.Clear();

            cbGender.SelectedIndex = 0;
            dtCreate.Value = DateTime.Now;

        }

        private void linkBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image (*.jpg; *.png; *.gif)|*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        public void loadUsers(string Pid)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUsers WHERE id=" + Pid + "", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = dr[1] as byte[];
                    MemoryStream ms = new MemoryStream(img);

                    lblUid.Text = Pid;
                    picPhoto.Image = Image.FromStream(ms);
                    txtName.Text = dr[2].ToString();
                    cbGender.Text = dr[3].ToString();
                    txtPhone.Text = dr[4].ToString();
                    txtEmail.Text = dr[5].ToString();
                    txtNote.Text = dr[7].ToString();
                    dtCreate.Text = dr[8].ToString();
                    dtCreate.Enabled = false;
                    update = true;
                }
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }


        #endregion method

        private void Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
