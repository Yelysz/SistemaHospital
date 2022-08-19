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
    public partial class Doctor : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de Gestión de Pacientes";
        bool check = false;
        bool update = false;
        Pages.Doctores doctor;

        public Doctor(Pages.Doctores form)
        {
            InitializeComponent();
            doctor = form;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (update)
                    {
                        if (MessageBox.Show("¿Está seguro de que desea actualizar la información de este médico?", "Actualización de información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MemoryStream ms = new MemoryStream();
                            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            cm = new SqlCommand("UPDATE tbDoctors SET photo=@photo, name=@name, gender=@gender, specialty=@specialty, dob=@dob, phone=@phone, email=@email, datejoined=@dateJoined, note=@note WHERE id=" + lblDid.Text + "", dbcon.connect());
                            cm.Parameters.AddWithValue("@photo", img);
                            cm.Parameters.AddWithValue("@name", txtName.Text);
                            cm.Parameters.AddWithValue("@gender", cbGender.Text);
                            cm.Parameters.AddWithValue("@specialty", cbSepcialty.Text);
                            cm.Parameters.AddWithValue("@dob", dtDob.Value);
                            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                            cm.Parameters.AddWithValue("@email", txtEmail.Text);
                            cm.Parameters.AddWithValue("@dateJoined", dtJoinDate.Value);
                            cm.Parameters.AddWithValue("@note", txtNotes.Text);

                            dbcon.open();// to open connection
                            cm.ExecuteNonQuery();
                            dbcon.close();// to close connection
                            MessageBox.Show("¡La información de los médicos se ha actualizado con éxito!", title);
                            this.Dispose();

                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea registrar a este Doctor?", "Registro de Doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MemoryStream ms = new MemoryStream();
                            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            cm = new SqlCommand("INSERT INTO tbDoctors (photo, name, gender, specialty, dob, phone, email, dateJoined, note, createAt) VALUES ( @photo, @name, @gender, @specialty, @dob,@phone,@email,@dateJoined,@note,@createAt)", dbcon.connect());
                            cm.Parameters.AddWithValue("@photo", img);
                            cm.Parameters.AddWithValue("@name", txtName.Text);
                            cm.Parameters.AddWithValue("@gender", cbGender.Text);
                            cm.Parameters.AddWithValue("@specialty", cbSepcialty.Text);
                            cm.Parameters.AddWithValue("@dob", dtDob.Value);
                            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                            cm.Parameters.AddWithValue("@email", txtEmail.Text);
                            cm.Parameters.AddWithValue("@dateJoined", dtJoinDate.Value);
                            cm.Parameters.AddWithValue("@note", txtNotes.Text);
                            cm.Parameters.AddWithValue("@createAt", dtCreate.Value);


                            dbcon.open();// to open connection
                            cm.ExecuteNonQuery();
                            dbcon.close();// to close connection
                            MessageBox.Show("¡La información de los médicos se ha registrado correctamente!", title);
                            Clear();//to clear data field, after data inserted into the database

                            picPhoto.Focus();

                        }
                    }
                    doctor.loadDoctor();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region method
        public void Clear()
        {
            txtEmail.Clear();
            txtName.Clear();
            txtNotes.Clear();
            txtPhone.Clear();
            cbGender.SelectedIndex = 0;
            dtCreate.Value = DateTime.Now;
            dtDob.Value = DateTime.Now;
            dtJoinDate.Value = DateTime.Now;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Clear();
            update = false;
        }
        //to check data field and date of birth
        public void checkField()
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Required data Field!", "Warning");
                return; // return to the data field and form
            }

            if (checkAge(dtDob.Value) < 18)
            {
                MessageBox.Show("Doctor age is under 18!", "Warning");
                return;
            }
            check = true;
        }

        // to check the age and calculate for under 18
        private static int checkAge(DateTime dateofBirth)
        {
            int age = DateTime.Now.Year - dateofBirth.Year;
            if (DateTime.Now.DayOfYear < dateofBirth.DayOfYear)
                age = age - 1;
            return age;
        }

        public void loadDoctor(string dId)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbDoctors WHERE id=" + dId + "", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = dr[1] as byte[];
                    MemoryStream ms = new MemoryStream(img);
                    lblDid.Text = dId;
                    picPhoto.Image = Image.FromStream(ms);
                    txtName.Text = dr[2].ToString();
                    cbGender.Text = dr[3].ToString();
                    cbSepcialty.Text = dr[4].ToString();
                    dtDob.Text = dr[5].ToString();
                    txtPhone.Text = dr[6].ToString();
                    txtEmail.Text = dr[7].ToString();
                    dtJoinDate.Text = dr[8].ToString();
                    txtNotes.Text = dr[9].ToString();
                    dtCreate.Text = dr[10].ToString();
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

        public void View()
        {
            linkBrowse.Enabled = false;
            txtEmail.Enabled = false;
            txtName.Enabled = false;
            txtNotes.Enabled = false;
            txtPhone.Enabled = false;
            cbGender.Enabled = false;
            cbSepcialty.Enabled = false;
            dtDob.Enabled = false;
            dtJoinDate.Enabled = false;

            btnSave.Visible = false;
            btnCancle.Visible = false;
        }

        #endregion method

        private void Doctor_Load(object sender, EventArgs e)
        {

        }
    }
}
