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
using System.Xml.Linq;

namespace SistemaHospital.Modulos
{
    public partial class Paciente : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        string title = "Sistema de Gestión de Pacientes";
        bool check = false;
        bool update = false;
        Pages.Pacientes patients;
        public Paciente(Pages.Pacientes form)
        {
            InitializeComponent();
            patients = form;
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

                            cm = new SqlCommand("UPDATE tbPatients SET photo=@photo, name=@name, gender=@gender, dob=@dob, phone=@phone, email=@email, insurance=@insurance, policy=@policy, illnesses=@illnesses, allergies=@allergies, medication=@medication, note=@note WHERE id=" + lblPid.Text + "", dbcon.connect());
                            cm.Parameters.AddWithValue("@photo", img);
                            cm.Parameters.AddWithValue("@name", txtName.Text);
                            cm.Parameters.AddWithValue("@gender", cbGender.Text);
                            cm.Parameters.AddWithValue("@dob", dtDob.Value);
                            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                            cm.Parameters.AddWithValue("@email", txtEmail.Text);
                            cm.Parameters.AddWithValue("@insurance", txtInsurence.Text);
                            cm.Parameters.AddWithValue("@policy", txtPolicy.Text);
                            cm.Parameters.AddWithValue("@illnesses", txtIllnesses.Text);
                            cm.Parameters.AddWithValue("@allergies", txtAllergies.Text);
                            cm.Parameters.AddWithValue("@medication", txtAllergies.Text);
                            cm.Parameters.AddWithValue("@note", txtNote.Text);

                            dbcon.open();// to open connection
                            cm.ExecuteNonQuery();
                            dbcon.close();// to close connection
                            MessageBox.Show("¡La información del paciente se actualizó con éxito!", title);
                            this.Dispose();

                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro de que desea registrar al paciente?", "Registro del paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MemoryStream ms = new MemoryStream();
                            picPhoto.Image.Save(ms, picPhoto.Image.RawFormat);
                            byte[] img = ms.ToArray();

                            cm = new SqlCommand("INSERT INTO tbPatients (photo, name, gender, dob, phone, email, insurance, policy, illnesses, allergies, medication, note, createAt) VALUES ( @photo, @name, @gender, @dob, @phone, @email, @insurance, @policy, @illnesses, @allergies, @medication, @note, @createAt)", dbcon.connect());
                            cm.Parameters.AddWithValue("@photo", img);
                            cm.Parameters.AddWithValue("@name", txtName.Text);
                            cm.Parameters.AddWithValue("@gender", cbGender.Text);
                            cm.Parameters.AddWithValue("@dob", dtDob.Value);
                            cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                            cm.Parameters.AddWithValue("@email", txtEmail.Text);
                            cm.Parameters.AddWithValue("@insurance", txtInsurence.Text);
                            cm.Parameters.AddWithValue("@policy", txtPolicy.Text);
                            cm.Parameters.AddWithValue("@illnesses", txtIllnesses.Text);
                            cm.Parameters.AddWithValue("@allergies", txtAllergies.Text);
                            cm.Parameters.AddWithValue("@medication", txtAllergies.Text);
                            cm.Parameters.AddWithValue("@note", txtNote.Text);
                            cm.Parameters.AddWithValue("@createAt", dtCreate.Value);


                            dbcon.open();// to open connection
                            cm.ExecuteNonQuery();
                            dbcon.close();// to close connection
                            MessageBox.Show("¡La información del paciente se ha registrado correctamente!", title);
                            Clear();//to clear data field, after data inserted into the database            

                        }
                    }
                    patients.loadPatients();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Clear();
            update = false;
        }

        #region method
        //to check data field and date of birth
        public void checkField()
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("¡Campo de datos requerido!", "Advertencia");
                return; // return to the data field and form
            }

            check = true;
        }

        public void Clear()
        {
            txtAllergies.Clear();
            txtEmail.Clear();
            txtIllnesses.Clear();
            txtInsurence.Clear();
            txtMedications.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtPolicy.Clear();
            cbGender.SelectedIndex = 0;
            
        }

        public void loadPatient(string Pid)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbPatients WHERE id=" + Pid + "", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = dr[1] as byte[];
                    MemoryStream ms = new MemoryStream(img);

                    lblPid.Text = Pid;
                    picPhoto.Image = Image.FromStream(ms);
                    txtName.Text = dr[2].ToString();
                    cbGender.Text = dr[3].ToString();
                    dtDob.Text = dr[4].ToString();
                    txtPhone.Text = dr[5].ToString();
                    txtEmail.Text = dr[6].ToString();
                    txtInsurence.Text = dr[7].ToString();
                    txtPolicy.Text = dr[8].ToString();
                    txtIllnesses.Text = dr[9].ToString();
                    txtAllergies.Text = dr[10].ToString();
                    txtMedications.Text = dr[11].ToString();
                    txtNote.Text = dr[12].ToString();
                    dtCreate.Text = dr[13].ToString();
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
            txtName.Enabled = false;
            cbGender.Enabled = false;
            dtDob.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtInsurence.Enabled = false;
            txtPolicy.Enabled = false;
            txtIllnesses.Enabled = false;
            txtAllergies.Enabled = false;
            txtMedications.Enabled = false;
            txtNote.Enabled = false;
            dtCreate.Enabled = false;
            btnCancle.Visible = false;
            btnSave.Visible = false;
        }



        #endregion method

        private void Paciente_Load(object sender, EventArgs e)
        {

        }
    }
}
