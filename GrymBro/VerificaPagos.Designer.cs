namespace GrymBro
{
    partial class VerificaPagos
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
            this.dataGridViewPagos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(263, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verifica los pagos realizados";
            // 
            // dataGridViewPagos
            // 
            this.dataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagos.Location = new System.Drawing.Point(147, 165);
            this.dataGridViewPagos.Name = "dataGridViewPagos";
            this.dataGridViewPagos.RowHeadersWidth = 51;
            this.dataGridViewPagos.RowTemplate.Height = 24;
            this.dataGridViewPagos.Size = new System.Drawing.Size(739, 350);
            this.dataGridViewPagos.TabIndex = 1;
            // 
            // VerificaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1075, 603);
            this.Controls.Add(this.dataGridViewPagos);
            this.Controls.Add(this.label1);
            this.Name = "VerificaPagos";
            this.Text = "VerificaPagos";
            this.Load += new System.EventHandler(this.VerificaPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPagos;
    }
}