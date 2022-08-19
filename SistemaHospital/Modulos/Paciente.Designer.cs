namespace SistemaHospital.Modulos
{
    partial class Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGender = new MaterialSkin.Controls.MaterialComboBox();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPolicy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIllnesses = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtAllergies = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtMedications = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInsurence = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNote = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.linkBrowse = new System.Windows.Forms.LinkLabel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Foto*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre*";
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.AutoWordSelection = true;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(152, 211);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 36);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.UseTallSize = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Genero*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha N*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefono*";
            // 
            // cbGender
            // 
            this.cbGender.AutoResize = false;
            this.cbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbGender.Depth = 0;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbGender.DropDownHeight = 118;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.DropDownWidth = 121;
            this.cbGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.IntegralHeight = false;
            this.cbGender.ItemHeight = 29;
            this.cbGender.Items.AddRange(new object[] {
            "Maculino",
            "Femenino"});
            this.cbGender.Location = new System.Drawing.Point(152, 262);
            this.cbGender.MaxDropDownItems = 4;
            this.cbGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(287, 35);
            this.cbGender.StartIndex = 0;
            this.cbGender.TabIndex = 2;
            this.cbGender.UseTallSize = false;
            // 
            // dtDob
            // 
            this.dtDob.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDob.Location = new System.Drawing.Point(152, 315);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(287, 35);
            this.dtDob.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(152, 357);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(287, 36);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Text = "";
            this.txtPhone.TrailingIcon = null;
            this.txtPhone.UseTallSize = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Compañía de seguros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ploicy No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 566);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 27);
            this.label10.TabIndex = 1;
            this.label10.Text = "Enfermedades";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 661);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 27);
            this.label11.TabIndex = 1;
            this.label11.Text = "Alergias";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 756);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "Medicacion";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(152, 404);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(287, 36);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseTallSize = false;
            // 
            // txtPolicy
            // 
            this.txtPolicy.AnimateReadOnly = false;
            this.txtPolicy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPolicy.Depth = 0;
            this.txtPolicy.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPolicy.LeadingIcon = null;
            this.txtPolicy.Location = new System.Drawing.Point(152, 512);
            this.txtPolicy.MaxLength = 50;
            this.txtPolicy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPolicy.Multiline = false;
            this.txtPolicy.Name = "txtPolicy";
            this.txtPolicy.Size = new System.Drawing.Size(287, 36);
            this.txtPolicy.TabIndex = 7;
            this.txtPolicy.Text = "";
            this.txtPolicy.TrailingIcon = null;
            this.txtPolicy.UseTallSize = false;
            // 
            // txtIllnesses
            // 
            this.txtIllnesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIllnesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIllnesses.Depth = 0;
            this.txtIllnesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIllnesses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIllnesses.Location = new System.Drawing.Point(152, 566);
            this.txtIllnesses.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIllnesses.Name = "txtIllnesses";
            this.txtIllnesses.Size = new System.Drawing.Size(287, 88);
            this.txtIllnesses.TabIndex = 8;
            this.txtIllnesses.Text = "";
            // 
            // txtAllergies
            // 
            this.txtAllergies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAllergies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAllergies.Depth = 0;
            this.txtAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAllergies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAllergies.Hint = "Enter";
            this.txtAllergies.Location = new System.Drawing.Point(152, 661);
            this.txtAllergies.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(287, 88);
            this.txtAllergies.TabIndex = 9;
            this.txtAllergies.Text = "";
            // 
            // txtMedications
            // 
            this.txtMedications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMedications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedications.Depth = 0;
            this.txtMedications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMedications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMedications.Hint = "Insertar medicacion";
            this.txtMedications.Location = new System.Drawing.Point(152, 756);
            this.txtMedications.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMedications.Name = "txtMedications";
            this.txtMedications.Size = new System.Drawing.Size(287, 88);
            this.txtMedications.TabIndex = 10;
            this.txtMedications.Text = "";
            // 
            // dtCreate
            // 
            this.dtCreate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreate.Location = new System.Drawing.Point(152, 952);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(287, 35);
            this.dtCreate.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 957);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 27);
            this.label13.TabIndex = 10;
            this.label13.Text = "Creado en*";
            // 
            // txtInsurence
            // 
            this.txtInsurence.AnimateReadOnly = false;
            this.txtInsurence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInsurence.Depth = 0;
            this.txtInsurence.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInsurence.LeadingIcon = null;
            this.txtInsurence.Location = new System.Drawing.Point(152, 458);
            this.txtInsurence.MaxLength = 50;
            this.txtInsurence.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInsurence.Multiline = false;
            this.txtInsurence.Name = "txtInsurence";
            this.txtInsurence.Size = new System.Drawing.Size(287, 36);
            this.txtInsurence.TabIndex = 6;
            this.txtInsurence.Text = "";
            this.txtInsurence.TrailingIcon = null;
            this.txtInsurence.UseTallSize = false;
            // 
            // btnCancle
            // 
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Location = new System.Drawing.Point(283, 992);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 36);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "Cancelar";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(364, 992);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Depth = 0;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNote.Hint = "Enter Medications";
            this.txtNote.Location = new System.Drawing.Point(152, 850);
            this.txtNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(287, 88);
            this.txtNote.TabIndex = 11;
            this.txtNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 851);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Note";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(6, 1008);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(50, 27);
            this.lblPid.TabIndex = 10;
            this.lblPid.Text = "pId";
            this.lblPid.Visible = false;
            // 
            // linkBrowse
            // 
            this.linkBrowse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkBrowse.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkBrowse.LinkColor = System.Drawing.Color.Black;
            this.linkBrowse.Location = new System.Drawing.Point(148, 160);
            this.linkBrowse.Name = "linkBrowse";
            this.linkBrowse.Size = new System.Drawing.Size(116, 37);
            this.linkBrowse.TabIndex = 0;
            this.linkBrowse.TabStop = true;
            this.linkBrowse.Text = "Archivo";
            this.linkBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBrowse_LinkClicked);
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPhoto.Location = new System.Drawing.Point(152, 13);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(153, 139);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPhoto.TabIndex = 2;
            this.picPhoto.TabStop = false;
            // 
            // Paciente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1010);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 458);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.linkBrowse);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtCreate);
            this.Controls.Add(this.txtMedications);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.txtIllnesses);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtPolicy);
            this.Controls.Add(this.txtInsurence);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(508, 514);
            this.MinimumSize = new System.Drawing.Size(508, 514);
            this.Name = "Paciente";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dtDob;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtPolicy;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtIllnesses;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtAllergies;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtMedications;
        private System.Windows.Forms.DateTimePicker dtCreate;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialTextBox txtInsurence;
        private System.Windows.Forms.LinkLabel linkBrowse;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPid;
    }
}