namespace GrymBro
{
    partial class AgendarClase
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreClase = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarClase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(294, 63);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda tus clases";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtNombreClase
            // 
            this.txtNombreClase.Location = new System.Drawing.Point(272, 163);
            this.txtNombreClase.Name = "txtNombreClase";
            this.txtNombreClase.Size = new System.Drawing.Size(203, 22);
            this.txtNombreClase.TabIndex = 1;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(272, 212);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(203, 22);
            this.txtHorario.TabIndex = 2;
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.DisplayMember = "Value";
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(272, 270);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(146, 21);
            this.cmbInstructor.TabIndex = 3;
            this.cmbInstructor.ValueMember = "Key";
            this.cmbInstructor.SelectedIndexChanged += new System.EventHandler(this.cmbInstructor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(132, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de la clase";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Horario
            // 
            this.Horario.AutoSize = true;
            this.Horario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Horario.Location = new System.Drawing.Point(132, 218);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(52, 16);
            this.Horario.TabIndex = 5;
            this.Horario.Text = "Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(132, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Instructor";
            // 
            // btnGuardarClase
            // 
            this.btnGuardarClase.Location = new System.Drawing.Point(628, 372);
            this.btnGuardarClase.Name = "btnGuardarClase";
            this.btnGuardarClase.Size = new System.Drawing.Size(101, 41);
            this.btnGuardarClase.TabIndex = 7;
            this.btnGuardarClase.Text = "Agregar Clases";
            this.btnGuardarClase.UseVisualStyleBackColor = true;
            this.btnGuardarClase.Click += new System.EventHandler(this.btnGuardarClase_Click);
            // 
            // AgendarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarClase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Horario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbInstructor);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtNombreClase);
            this.Controls.Add(this.label1);
            this.Name = "AgendarClase";
            this.Text = "AgendarClase";
            this.Load += new System.EventHandler(this.AgendarClase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreClase;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Horario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarClase;
    }
}