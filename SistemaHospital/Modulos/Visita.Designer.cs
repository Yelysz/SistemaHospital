namespace SistemaHospital.Modulos
{
    partial class Visita
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
            this.SuspendLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visita));
            this.txtReason = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDoctor = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeight = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTemp = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSystolic = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiastolic = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNote = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtCreate = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReason.Depth = 0;
            this.txtReason.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtReason.Location = new System.Drawing.Point(154, 25);
            this.txtReason.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(287, 88);
            this.txtReason.TabIndex = 32;
            this.txtReason.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Motivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Doctor*";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(154, 139);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(287, 35);
            this.dtDate.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "Fecha*";
            // 
            // cbDoctor
            // 
            this.cbDoctor.AutoResize = false;
            this.cbDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbDoctor.Depth = 0;
            this.cbDoctor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDoctor.DropDownHeight = 118;
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.DropDownWidth = 121;
            this.cbDoctor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.IntegralHeight = false;
            this.cbDoctor.ItemHeight = 29;
            this.cbDoctor.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbDoctor.Location = new System.Drawing.Point(154, 189);
            this.cbDoctor.MaxDropDownItems = 4;
            this.cbDoctor.MouseState = MaterialSkin.MouseState.OUT;
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(287, 35);
            this.cbDoctor.StartIndex = 0;
            this.cbDoctor.TabIndex = 37;
            this.cbDoctor.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "Peso*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 27);
            this.label2.TabIndex = 34;
            this.label2.Text = "Temperatura*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sistólica*";
            // 
            // txtWeight
            // 
            this.txtWeight.AnimateReadOnly = false;
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.Depth = 0;
            this.txtWeight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWeight.Hint = "0";
            this.txtWeight.LeadingIcon = null;
            this.txtWeight.Location = new System.Drawing.Point(154, 253);
            this.txtWeight.MaxLength = 50;
            this.txtWeight.MouseState = MaterialSkin.MouseState.OUT;
            this.txtWeight.Multiline = false;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(287, 36);
            this.txtWeight.TabIndex = 38;
            this.txtWeight.Text = "";
            this.txtWeight.TrailingIcon = null;
            this.txtWeight.UseTallSize = false;
            // 
            // txtTemp
            // 
            this.txtTemp.AnimateReadOnly = false;
            this.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemp.Depth = 0;
            this.txtTemp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTemp.Hint = "0";
            this.txtTemp.LeadingIcon = null;
            this.txtTemp.Location = new System.Drawing.Point(154, 309);
            this.txtTemp.MaxLength = 50;
            this.txtTemp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTemp.Multiline = false;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(287, 36);
            this.txtTemp.TabIndex = 38;
            this.txtTemp.Text = "";
            this.txtTemp.TrailingIcon = null;
            this.txtTemp.UseTallSize = false;
            // 
            // txtSystolic
            // 
            this.txtSystolic.AnimateReadOnly = false;
            this.txtSystolic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSystolic.Depth = 0;
            this.txtSystolic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSystolic.Hint = "0";
            this.txtSystolic.LeadingIcon = null;
            this.txtSystolic.Location = new System.Drawing.Point(154, 374);
            this.txtSystolic.MaxLength = 50;
            this.txtSystolic.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSystolic.Multiline = false;
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(287, 36);
            this.txtSystolic.TabIndex = 38;
            this.txtSystolic.Text = "";
            this.txtSystolic.TrailingIcon = null;
            this.txtSystolic.UseTallSize = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 27);
            this.label5.TabIndex = 34;
            this.label5.Text = "Diastólica*";
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.AnimateReadOnly = false;
            this.txtDiastolic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiastolic.Depth = 0;
            this.txtDiastolic.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiastolic.Hint = "0";
            this.txtDiastolic.LeadingIcon = null;
            this.txtDiastolic.Location = new System.Drawing.Point(154, 440);
            this.txtDiastolic.MaxLength = 50;
            this.txtDiastolic.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiastolic.Multiline = false;
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(287, 36);
            this.txtDiastolic.TabIndex = 38;
            this.txtDiastolic.Text = "";
            this.txtDiastolic.TrailingIcon = null;
            this.txtDiastolic.UseTallSize = false;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNote.Depth = 0;
            this.txtNote.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNote.Location = new System.Drawing.Point(154, 504);
            this.txtNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(287, 88);
            this.txtNote.TabIndex = 40;
            this.txtNote.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nota";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(366, 662);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(285, 662);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 627);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 27);
            this.label13.TabIndex = 41;
            this.label13.Text = "Creado en*";
            // 
            // dtCreate
            // 
            this.dtCreate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreate.Location = new System.Drawing.Point(154, 622);
            this.dtCreate.Name = "dtCreate";
            this.dtCreate.Size = new System.Drawing.Size(287, 35);
            this.dtCreate.TabIndex = 42;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(8, 695);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 27);
            this.lblId.TabIndex = 41;
            this.lblId.Text = "id";
            this.lblId.Visible = false;
            // 
            // visit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 740);
            this.ClientSize = new System.Drawing.Size(469, 404);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtCreate);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiastolic);
            this.Controls.Add(this.txtSystolic);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.cbDoctor);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(491, 460);
            this.Name = "visit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox txtReason;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialComboBox cbDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtWeight;
        private MaterialSkin.Controls.MaterialTextBox txtTemp;
        private MaterialSkin.Controls.MaterialTextBox txtSystolic;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtDiastolic;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtCreate;
        public System.Windows.Forms.Label lblId;
    }
}