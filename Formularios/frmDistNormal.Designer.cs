
namespace TP3_SIM.Formularios
{
    partial class frmDistNormal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMediaNormal = new System.Windows.Forms.TextBox();
            this.txtDesviacionNormal = new System.Windows.Forms.TextBox();
            this.txtCantNumNormal = new System.Windows.Forms.TextBox();
            this.btnGenerarNormal = new System.Windows.Forms.Button();
            this.gridNumDistNormal = new System.Windows.Forms.DataGridView();
            this.colRND1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRND2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumDistNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribucion Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Media (μ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desviacion (σ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Numeros a Generar :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerarNormal);
            this.panel1.Controls.Add(this.txtCantNumNormal);
            this.panel1.Controls.Add(this.txtDesviacionNormal);
            this.panel1.Controls.Add(this.txtMediaNormal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 113);
            this.panel1.TabIndex = 4;
            // 
            // txtMediaNormal
            // 
            this.txtMediaNormal.Location = new System.Drawing.Point(99, 6);
            this.txtMediaNormal.Name = "txtMediaNormal";
            this.txtMediaNormal.Size = new System.Drawing.Size(100, 22);
            this.txtMediaNormal.TabIndex = 4;
            // 
            // txtDesviacionNormal
            // 
            this.txtDesviacionNormal.Location = new System.Drawing.Point(130, 39);
            this.txtDesviacionNormal.Name = "txtDesviacionNormal";
            this.txtDesviacionNormal.Size = new System.Drawing.Size(100, 22);
            this.txtDesviacionNormal.TabIndex = 5;
            // 
            // txtCantNumNormal
            // 
            this.txtCantNumNormal.Location = new System.Drawing.Point(245, 73);
            this.txtCantNumNormal.Name = "txtCantNumNormal";
            this.txtCantNumNormal.Size = new System.Drawing.Size(100, 22);
            this.txtCantNumNormal.TabIndex = 6;
            // 
            // btnGenerarNormal
            // 
            this.btnGenerarNormal.Location = new System.Drawing.Point(415, 60);
            this.btnGenerarNormal.Name = "btnGenerarNormal";
            this.btnGenerarNormal.Size = new System.Drawing.Size(82, 35);
            this.btnGenerarNormal.TabIndex = 7;
            this.btnGenerarNormal.Text = "Generar";
            this.btnGenerarNormal.UseVisualStyleBackColor = true;
            this.btnGenerarNormal.Click += new System.EventHandler(this.OnClickGenerarNormal);
            // 
            // gridNumDistNormal
            // 
            this.gridNumDistNormal.AllowUserToAddRows = false;
            this.gridNumDistNormal.AllowUserToDeleteRows = false;
            this.gridNumDistNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNumDistNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRND1,
            this.colRND2,
            this.colN1,
            this.colN2});
            this.gridNumDistNormal.Location = new System.Drawing.Point(46, 227);
            this.gridNumDistNormal.Name = "gridNumDistNormal";
            this.gridNumDistNormal.ReadOnly = true;
            this.gridNumDistNormal.RowHeadersWidth = 51;
            this.gridNumDistNormal.RowTemplate.Height = 24;
            this.gridNumDistNormal.Size = new System.Drawing.Size(549, 441);
            this.gridNumDistNormal.TabIndex = 5;
            // 
            // colRND1
            // 
            this.colRND1.HeaderText = "RND1";
            this.colRND1.MinimumWidth = 6;
            this.colRND1.Name = "colRND1";
            this.colRND1.ReadOnly = true;
            this.colRND1.Width = 125;
            // 
            // colRND2
            // 
            this.colRND2.HeaderText = "RND2";
            this.colRND2.MinimumWidth = 6;
            this.colRND2.Name = "colRND2";
            this.colRND2.ReadOnly = true;
            this.colRND2.Width = 125;
            // 
            // colN1
            // 
            this.colN1.HeaderText = "N1";
            this.colN1.MinimumWidth = 6;
            this.colN1.Name = "colN1";
            this.colN1.ReadOnly = true;
            this.colN1.Width = 125;
            // 
            // colN2
            // 
            this.colN2.HeaderText = "N2";
            this.colN2.MinimumWidth = 6;
            this.colN2.Name = "colN2";
            this.colN2.ReadOnly = true;
            this.colN2.Width = 125;
            // 
            // frmDistNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.gridNumDistNormal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmDistNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulación - Distribución Normal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumDistNormal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerarNormal;
        private System.Windows.Forms.TextBox txtCantNumNormal;
        private System.Windows.Forms.TextBox txtDesviacionNormal;
        private System.Windows.Forms.TextBox txtMediaNormal;
        private System.Windows.Forms.DataGridView gridNumDistNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRND1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRND2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN2;
    }
}