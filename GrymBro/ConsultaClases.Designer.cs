namespace GrymBro
{
    partial class ConsultaClases
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
            this.dataGridViewClases = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(258, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta tus clases";
            // 
            // dataGridViewClases
            // 
            this.dataGridViewClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClases.Location = new System.Drawing.Point(196, 161);
            this.dataGridViewClases.Name = "dataGridViewClases";
            this.dataGridViewClases.RowHeadersWidth = 51;
            this.dataGridViewClases.RowTemplate.Height = 24;
            this.dataGridViewClases.Size = new System.Drawing.Size(624, 355);
            this.dataGridViewClases.TabIndex = 1;
            // 
            // ConsultaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1029, 598);
            this.Controls.Add(this.dataGridViewClases);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaClases";
            this.Text = "ConsultaClases";
            this.Load += new System.EventHandler(this.ConsultaClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClases;
    }
}