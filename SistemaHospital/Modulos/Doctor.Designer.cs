namespace SistemaHospital.Modulos
{
    partial class Doctor
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
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtJoinDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblDid = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSepcialty = new MaterialSkin.Controls.MaterialComboBox();
            this.linkBrowse = new System.Windows.Forms.LinkLabel();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDob
            // 
            this.dtDob.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDob.Location = new System.Drawing.Point(165, 415);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(287, 35);
            this.dtDob.TabIndex = 16;
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
            "Masculino",
            "Femenino"});
            this.cbGender.Location = new System.Drawing.Point(165, 303);
            this.cbGender.MaxDropDownItems = 4;
            this.cbGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(287, 35);
            this.cbGender.StartIndex = 0;
            this.cbGender.TabIndex = 14;
            this.cbGender.UseTallSize = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(165, 519);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(287, 36);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseTallSize = false;
            // 
            // txtPhone
            // 
            this.txtPhone.AnimateReadOnly = false;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Depth = 0;
            this.txtPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.LeadingIcon = null;
            this.txtPhone.Location = new System.Drawing.Point(165, 462);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(287, 36);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Text = "";
            this.txtPhone.TrailingIcon = null;
            this.txtPhone.UseTallSize = false;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(165, 245);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 36);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            this.txtName.UseTallSize = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha N*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Genero*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Foto*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Union*";
            // 
            // dtJoinDate
            // 
            this.dtJoinDate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtJoinDate.Location = new System.Drawing.Point(165, 576);
            this.dtJoinDate.Name = "dtJoinDate";
            this.dtJoinDate.Size = new System.Drawing.Size(287, 35);
            this.dtJoinDate.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 735);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Creado en*";
            // 
            // dtCreate
            // 
            this.dtCreate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreate.Location = new System.Drawing.Point(165, 732);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(287, 35);
            this.dtCreate.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 620);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nota";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Depth = 0;
            this.txtNotes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNotes.Location = new System.Drawing.Point(165, 623);
            this.txtNotes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(287, 88);
            this.txtNotes.TabIndex = 20;
            this.txtNotes.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(275, 764);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Location = new System.Drawing.Point(194, 764);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 36);
            this.btnCancle.TabIndex = 22;
            this.btnCancle.Text = "Cancelar";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lblDid
            // 
            this.lblDid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDid.AutoSize = true;
            this.lblDid.Location = new System.Drawing.Point(-464, 784);
            this.lblDid.Name = "lblDid";
            this.lblDid.Size = new System.Drawing.Size(50, 27);
            this.lblDid.TabIndex = 23;
            this.lblDid.Text = "did";
            this.lblDid.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 27);
            this.label10.TabIndex = 24;
            this.label10.Text = "Especialidad";
            // 
            // cbSepcialty
            // 
            this.cbSepcialty.AutoResize = false;
            this.cbSepcialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSepcialty.Depth = 0;
            this.cbSepcialty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSepcialty.DropDownHeight = 118;
            this.cbSepcialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSepcialty.DropDownWidth = 121;
            this.cbSepcialty.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSepcialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSepcialty.FormattingEnabled = true;
            this.cbSepcialty.IntegralHeight = false;
            this.cbSepcialty.ItemHeight = 29;
            this.cbSepcialty.Items.AddRange(new object[] {
            "General",
            "Allergists",
            "Dermatologists",
            "Infectious disease doctors",
            "Ophthalmologists",
            "Obstetrician/gynecologists",
            "Cardiologists",
            "Endocrinologists",
            "Gastroenterologists",
            "Nephrologists",
            "Urologists",
            "Pulmonologists",
            "Otolaryngologists",
            "Neurologists",
            "Psychiatrists",
            "Oncologists",
            "Radiologists",
            "Rheumatologists",
            "General surgeons",
            "Orthopedic surgeons",
            "Cardiac surgeons",
            "Anesthesiologists",
            "General",
            "Allergists",
            "Dermatologists",
            "Infectious disease doctors",
            "Ophthalmologists",
            "Obstetrician/gynecologists",
            "Cardiologists",
            "Endocrinologists",
            "Gastroenterologists",
            "Nephrologists",
            "Urologists",
            "Pulmonologists",
            "Otolaryngologists",
            "Neurologists",
            "Psychiatrists",
            "Oncologists",
            "Radiologists",
            "Rheumatologists",
            "General surgeons",
            "Orthopedic surgeons",
            "Cardiac surgeons",
            "Anesthesiologists",
            "Resultados de traducción",
            "General",
            "Alergólogos",
            "Dermatólogos",
            "Médicos de enfermedades infecciosas",
            "Oftalmólogos",
            "Obstetras/ginecólogos",
            "Cardiólogos",
            "Endocrinólogos",
            "Gastroenterólogos",
            "Nefrólogos",
            "Urólogos",
            "Neumólogos",
            "Otorrinolaringólogos",
            "Neurólogos",
            "Psiquiatras",
            "Oncólogos",
            "Radiólogos",
            "Reumatólogos",
            "Cirujanos generales",
            "Cirujanos ortopédicos",
            "Cirujanos cardiacos",
            "Anestesiólogos"});
            this.cbSepcialty.Location = new System.Drawing.Point(165, 359);
            this.cbSepcialty.MaxDropDownItems = 4;
            this.cbSepcialty.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSepcialty.Name = "cbSepcialty";
            this.cbSepcialty.Size = new System.Drawing.Size(287, 35);
            this.cbSepcialty.StartIndex = 0;
            this.cbSepcialty.TabIndex = 25;
            this.cbSepcialty.UseTallSize = false;
            // 
            // linkBrowse
            // 
            this.linkBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkBrowse.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkBrowse.LinkColor = System.Drawing.Color.Black;
            this.linkBrowse.Location = new System.Drawing.Point(161, 186);
            this.linkBrowse.Name = "linkBrowse";
            this.linkBrowse.Size = new System.Drawing.Size(116, 37);
            this.linkBrowse.TabIndex = 6;
            this.linkBrowse.TabStop = true;
            this.linkBrowse.Text = "Elegir Archivo";
            this.linkBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBrowse_LinkClicked);
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPhoto.Location = new System.Drawing.Point(165, 25);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(153, 139);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 15;
            this.picPhoto.TabStop = false;
            // 
            // Doctor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 800);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 464);
            this.Controls.Add(this.cbSepcialty);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtCreate);
            this.Controls.Add(this.dtJoinDate);
            this.Controls.Add(this.linkBrowse);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(491, 520);
            this.Name = "Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBrowse;
        private System.Windows.Forms.DateTimePicker dtDob;
        private MaterialSkin.Controls.MaterialComboBox cbGender;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtJoinDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtCreate;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblDid;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialComboBox cbSepcialty;
    }
}