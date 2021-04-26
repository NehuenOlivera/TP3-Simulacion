
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCantIntervalosNormal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerarNormal = new System.Windows.Forms.Button();
            this.txtCantNumNormal = new System.Windows.Forms.TextBox();
            this.txtDesviacionNormal = new System.Windows.Forms.TextBox();
            this.txtMediaNormal = new System.Windows.Forms.TextBox();
            this.gridNumDistNormal = new System.Windows.Forms.DataGridView();
            this.colRND1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRND2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafNomal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridDistribucion = new System.Windows.Forms.DataGridView();
            this.gridChi = new System.Windows.Forms.DataGridView();
            this.colDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.colIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecObservadaNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProbEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecEsperadaNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumDistNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafNomal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 47);
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
            this.panel1.Controls.Add(this.cmbCantIntervalosNormal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnGenerarNormal);
            this.panel1.Controls.Add(this.txtCantNumNormal);
            this.panel1.Controls.Add(this.txtDesviacionNormal);
            this.panel1.Controls.Add(this.txtMediaNormal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 149);
            this.panel1.TabIndex = 4;
            // 
            // cmbCantIntervalosNormal
            // 
            this.cmbCantIntervalosNormal.FormattingEnabled = true;
            this.cmbCantIntervalosNormal.Location = new System.Drawing.Point(178, 108);
            this.cmbCantIntervalosNormal.Name = "cmbCantIntervalosNormal";
            this.cmbCantIntervalosNormal.Size = new System.Drawing.Size(121, 24);
            this.cmbCantIntervalosNormal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad de intervalos :";
            // 
            // btnGenerarNormal
            // 
            this.btnGenerarNormal.Location = new System.Drawing.Point(407, 97);
            this.btnGenerarNormal.Name = "btnGenerarNormal";
            this.btnGenerarNormal.Size = new System.Drawing.Size(82, 35);
            this.btnGenerarNormal.TabIndex = 7;
            this.btnGenerarNormal.Text = "Generar";
            this.btnGenerarNormal.UseVisualStyleBackColor = true;
            this.btnGenerarNormal.Click += new System.EventHandler(this.OnClickGenerarNormal);
            // 
            // txtCantNumNormal
            // 
            this.txtCantNumNormal.Location = new System.Drawing.Point(245, 73);
            this.txtCantNumNormal.Name = "txtCantNumNormal";
            this.txtCantNumNormal.Size = new System.Drawing.Size(100, 22);
            this.txtCantNumNormal.TabIndex = 6;
            // 
            // txtDesviacionNormal
            // 
            this.txtDesviacionNormal.Location = new System.Drawing.Point(130, 39);
            this.txtDesviacionNormal.Name = "txtDesviacionNormal";
            this.txtDesviacionNormal.Size = new System.Drawing.Size(100, 22);
            this.txtDesviacionNormal.TabIndex = 5;
            // 
            // txtMediaNormal
            // 
            this.txtMediaNormal.Location = new System.Drawing.Point(99, 6);
            this.txtMediaNormal.Name = "txtMediaNormal";
            this.txtMediaNormal.Size = new System.Drawing.Size(100, 22);
            this.txtMediaNormal.TabIndex = 4;
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
            this.gridNumDistNormal.Location = new System.Drawing.Point(26, 255);
            this.gridNumDistNormal.Name = "gridNumDistNormal";
            this.gridNumDistNormal.ReadOnly = true;
            this.gridNumDistNormal.RowHeadersWidth = 51;
            this.gridNumDistNormal.RowTemplate.Height = 24;
            this.gridNumDistNormal.Size = new System.Drawing.Size(555, 441);
            this.gridNumDistNormal.TabIndex = 5;
            // 
            // colRND1
            // 
            this.colRND1.HeaderText = "RND1";
            this.colRND1.MinimumWidth = 6;
            this.colRND1.Name = "colRND1";
            this.colRND1.ReadOnly = true;
            this.colRND1.Width = 90;
            // 
            // colRND2
            // 
            this.colRND2.HeaderText = "RND2";
            this.colRND2.MinimumWidth = 6;
            this.colRND2.Name = "colRND2";
            this.colRND2.ReadOnly = true;
            this.colRND2.Width = 90;
            // 
            // colN1
            // 
            this.colN1.HeaderText = "N1";
            this.colN1.MinimumWidth = 6;
            this.colN1.Name = "colN1";
            this.colN1.ReadOnly = true;
            this.colN1.Width = 90;
            // 
            // colN2
            // 
            this.colN2.HeaderText = "N2";
            this.colN2.MinimumWidth = 6;
            this.colN2.Name = "colN2";
            this.colN2.ReadOnly = true;
            this.colN2.Width = 90;
            // 
            // grafNomal
            // 
            chartArea2.Name = "ChartArea1";
            this.grafNomal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafNomal.Legends.Add(legend2);
            this.grafNomal.Location = new System.Drawing.Point(26, 724);
            this.grafNomal.Name = "grafNomal";
            this.grafNomal.Size = new System.Drawing.Size(2176, 555);
            this.grafNomal.TabIndex = 6;
            this.grafNomal.Text = "chart1";
            // 
            // gridDistribucion
            // 
            this.gridDistribucion.AllowUserToAddRows = false;
            this.gridDistribucion.AllowUserToDeleteRows = false;
            this.gridDistribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDistribucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntervalo,
            this.colMarcaClase,
            this.colFrecObservadaNormal,
            this.colProbEsperada,
            this.colFrecEsperadaNormal});
            this.gridDistribucion.Location = new System.Drawing.Point(628, 67);
            this.gridDistribucion.Name = "gridDistribucion";
            this.gridDistribucion.ReadOnly = true;
            this.gridDistribucion.RowHeadersWidth = 51;
            this.gridDistribucion.RowTemplate.Height = 24;
            this.gridDistribucion.Size = new System.Drawing.Size(692, 328);
            this.gridDistribucion.TabIndex = 7;
            // 
            // gridChi
            // 
            this.gridChi.AllowUserToAddRows = false;
            this.gridChi.AllowUserToDeleteRows = false;
            this.gridChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesde,
            this.colHasta,
            this.colFrecObs,
            this.colFrecEsperada,
            this.colC,
            this.colCAcum});
            this.gridChi.Location = new System.Drawing.Point(628, 440);
            this.gridChi.Name = "gridChi";
            this.gridChi.ReadOnly = true;
            this.gridChi.RowHeadersWidth = 51;
            this.gridChi.RowTemplate.Height = 24;
            this.gridChi.Size = new System.Drawing.Size(692, 256);
            this.gridChi.TabIndex = 8;
            // 
            // colDesde
            // 
            this.colDesde.HeaderText = "Desde";
            this.colDesde.MinimumWidth = 6;
            this.colDesde.Name = "colDesde";
            this.colDesde.ReadOnly = true;
            this.colDesde.Width = 70;
            // 
            // colHasta
            // 
            this.colHasta.HeaderText = "Hasta";
            this.colHasta.MinimumWidth = 6;
            this.colHasta.Name = "colHasta";
            this.colHasta.ReadOnly = true;
            this.colHasta.Width = 70;
            // 
            // colFrecObs
            // 
            this.colFrecObs.HeaderText = "Frec Observada";
            this.colFrecObs.MinimumWidth = 6;
            this.colFrecObs.Name = "colFrecObs";
            this.colFrecObs.ReadOnly = true;
            this.colFrecObs.Width = 70;
            // 
            // colFrecEsperada
            // 
            this.colFrecEsperada.HeaderText = "Frec Esperada";
            this.colFrecEsperada.MinimumWidth = 6;
            this.colFrecEsperada.Name = "colFrecEsperada";
            this.colFrecEsperada.ReadOnly = true;
            this.colFrecEsperada.Width = 70;
            // 
            // colC
            // 
            this.colC.HeaderText = "C";
            this.colC.MinimumWidth = 6;
            this.colC.Name = "colC";
            this.colC.ReadOnly = true;
            this.colC.Width = 70;
            // 
            // colCAcum
            // 
            this.colCAcum.HeaderText = "C Acum";
            this.colCAcum.MinimumWidth = 6;
            this.colCAcum.Name = "colCAcum";
            this.colCAcum.ReadOnly = true;
            this.colCAcum.Width = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prueba de Bondad - Chi Cuadrado";
            // 
            // colIntervalo
            // 
            this.colIntervalo.HeaderText = "Intervalo";
            this.colIntervalo.MinimumWidth = 6;
            this.colIntervalo.Name = "colIntervalo";
            this.colIntervalo.ReadOnly = true;
            this.colIntervalo.Width = 70;
            // 
            // colMarcaClase
            // 
            this.colMarcaClase.HeaderText = "Marca de Clase";
            this.colMarcaClase.MinimumWidth = 6;
            this.colMarcaClase.Name = "colMarcaClase";
            this.colMarcaClase.ReadOnly = true;
            this.colMarcaClase.Width = 70;
            // 
            // colFrecObservadaNormal
            // 
            this.colFrecObservadaNormal.HeaderText = "Frec Observada";
            this.colFrecObservadaNormal.MinimumWidth = 6;
            this.colFrecObservadaNormal.Name = "colFrecObservadaNormal";
            this.colFrecObservadaNormal.ReadOnly = true;
            this.colFrecObservadaNormal.Width = 70;
            // 
            // colProbEsperada
            // 
            this.colProbEsperada.HeaderText = "Prob Esperada";
            this.colProbEsperada.MinimumWidth = 6;
            this.colProbEsperada.Name = "colProbEsperada";
            this.colProbEsperada.ReadOnly = true;
            this.colProbEsperada.Width = 70;
            // 
            // colFrecEsperadaNormal
            // 
            this.colFrecEsperadaNormal.HeaderText = "Frec Esperada";
            this.colFrecEsperadaNormal.MinimumWidth = 6;
            this.colFrecEsperadaNormal.Name = "colFrecEsperadaNormal";
            this.colFrecEsperadaNormal.ReadOnly = true;
            this.colFrecEsperadaNormal.Width = 70;
            // 
            // frmDistNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2245, 1325);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridChi);
            this.Controls.Add(this.gridDistribucion);
            this.Controls.Add(this.grafNomal);
            this.Controls.Add(this.gridNumDistNormal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDistNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulación - Distribución Normal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumDistNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafNomal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChi)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart grafNomal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRND1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRND2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN2;
        private System.Windows.Forms.ComboBox cmbCantIntervalosNormal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridDistribucion;
        private System.Windows.Forms.DataGridView gridChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCAcum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecObservadaNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProbEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecEsperadaNormal;
    }
}