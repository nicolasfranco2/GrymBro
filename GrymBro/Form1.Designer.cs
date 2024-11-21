namespace GrymBro
{
    partial class Consulta_matricula
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
            this.dataGridViewMiembros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(173, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta las matriculas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewMiembros
            // 
            this.dataGridViewMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMiembros.Location = new System.Drawing.Point(85, 110);
            this.dataGridViewMiembros.Name = "dataGridViewMiembros";
            this.dataGridViewMiembros.RowHeadersWidth = 51;
            this.dataGridViewMiembros.RowTemplate.Height = 24;
            this.dataGridViewMiembros.Size = new System.Drawing.Size(1006, 441);
            this.dataGridViewMiembros.TabIndex = 1;
            // 
            // Consulta_matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1169, 609);
            this.Controls.Add(this.dataGridViewMiembros);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_matricula";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMiembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMiembros;
    }
}