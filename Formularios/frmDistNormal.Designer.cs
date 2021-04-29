
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.gridNumDistNormal = new System.Windows.Forms.DataGridView();
            this.colRND1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRND2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridDistribucion = new System.Windows.Forms.DataGridView();
            this.colIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecObservadaNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProbEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecEsperadaNormal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridChi = new System.Windows.Forms.DataGridView();
            this.colDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMediaNormal = new System.Windows.Forms.TextBox();
            this.txtDesviacionNormal = new System.Windows.Forms.TextBox();
            this.txtCantNumNormal = new System.Windows.Forms.TextBox();
            this.btnGenerarNormal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCantIntervalosNormal = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumDistNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribucion Normal";
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
            this.gridNumDistNormal.Location = new System.Drawing.Point(29, 360);
            this.gridNumDistNormal.Name = "gridNumDistNormal";
            this.gridNumDistNormal.ReadOnly = true;
            this.gridNumDistNormal.RowHeadersVisible = false;
            this.gridNumDistNormal.RowHeadersWidth = 51;
            this.gridNumDistNormal.RowTemplate.Height = 24;
            this.gridNumDistNormal.Size = new System.Drawing.Size(624, 367);
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
            // grafNormal
            // 
            chartArea1.Name = "ChartArea1";
            this.grafNormal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafNormal.Legends.Add(legend1);
            this.grafNormal.Location = new System.Drawing.Point(29, 772);
            this.grafNormal.Name = "grafNormal";
            this.grafNormal.Size = new System.Drawing.Size(1456, 342);
            this.grafNormal.TabIndex = 6;
            this.grafNormal.Text = "chart1";
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
            this.gridDistribucion.Location = new System.Drawing.Point(707, 55);
            this.gridDistribucion.Name = "gridDistribucion";
            this.gridDistribucion.ReadOnly = true;
            this.gridDistribucion.RowHeadersVisible = false;
            this.gridDistribucion.RowHeadersWidth = 51;
            this.gridDistribucion.RowTemplate.Height = 24;
            this.gridDistribucion.Size = new System.Drawing.Size(779, 320);
            this.gridDistribucion.TabIndex = 7;
            // 
            // colIntervalo
            // 
            this.colIntervalo.HeaderText = "Intervalo";
            this.colIntervalo.MinimumWidth = 6;
            this.colIntervalo.Name = "colIntervalo";
            this.colIntervalo.ReadOnly = true;
            this.colIntervalo.Width = 175;
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
            this.gridChi.Location = new System.Drawing.Point(707, 422);
            this.gridChi.Name = "gridChi";
            this.gridChi.ReadOnly = true;
            this.gridChi.RowHeadersVisible = false;
            this.gridChi.RowHeadersWidth = 51;
            this.gridChi.RowTemplate.Height = 24;
            this.gridChi.Size = new System.Drawing.Size(779, 303);
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
            this.label6.Location = new System.Drawing.Point(703, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prueba de Bondad - Chi Cuadrado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 38);
            this.label7.TabIndex = 10;
            this.label7.Text = "Distribucion Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Media (μ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desviacion (σ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de Numeros :";
            // 
            // txtMediaNormal
            // 
            this.txtMediaNormal.Location = new System.Drawing.Point(99, 43);
            this.txtMediaNormal.Name = "txtMediaNormal";
            this.txtMediaNormal.Size = new System.Drawing.Size(112, 26);
            this.txtMediaNormal.TabIndex = 4;
            // 
            // txtDesviacionNormal
            // 
            this.txtDesviacionNormal.Location = new System.Drawing.Point(134, 85);
            this.txtDesviacionNormal.Name = "txtDesviacionNormal";
            this.txtDesviacionNormal.Size = new System.Drawing.Size(112, 26);
            this.txtDesviacionNormal.TabIndex = 5;
            // 
            // txtCantNumNormal
            // 
            this.txtCantNumNormal.Location = new System.Drawing.Point(204, 127);
            this.txtCantNumNormal.Name = "txtCantNumNormal";
            this.txtCantNumNormal.Size = new System.Drawing.Size(112, 26);
            this.txtCantNumNormal.TabIndex = 6;
            // 
            // btnGenerarNormal
            // 
            this.btnGenerarNormal.Location = new System.Drawing.Point(460, 127);
            this.btnGenerarNormal.Name = "btnGenerarNormal";
            this.btnGenerarNormal.Size = new System.Drawing.Size(113, 65);
            this.btnGenerarNormal.TabIndex = 7;
            this.btnGenerarNormal.Text = "Generar";
            this.btnGenerarNormal.UseVisualStyleBackColor = true;
            this.btnGenerarNormal.Click += new System.EventHandler(this.OnClickGenerarNormal);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad de intervalos :";
            // 
            // cmbCantIntervalosNormal
            // 
            this.cmbCantIntervalosNormal.FormattingEnabled = true;
            this.cmbCantIntervalosNormal.Location = new System.Drawing.Point(204, 172);
            this.cmbCantIntervalosNormal.Name = "cmbCantIntervalosNormal";
            this.cmbCantIntervalosNormal.Size = new System.Drawing.Size(136, 28);
            this.cmbCantIntervalosNormal.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCantIntervalosNormal);
            this.groupBox1.Controls.Add(this.btnGenerarNormal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCantNumNormal);
            this.groupBox1.Controls.Add(this.txtMediaNormal);
            this.groupBox1.Controls.Add(this.txtDesviacionNormal);
            this.groupBox1.Location = new System.Drawing.Point(29, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 218);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros a Ingresar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Numeros Generados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 747);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Grafico";
            // 
            // frmDistNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1574, 875);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridChi);
            this.Controls.Add(this.gridDistribucion);
            this.Controls.Add(this.grafNormal);
            this.Controls.Add(this.gridNumDistNormal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmDistNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulación - Distribución Normal";
            ((System.ComponentModel.ISupportInitialize)(this.gridNumDistNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistribucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridNumDistNormal;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRND1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRND2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colN2;
        private System.Windows.Forms.DataGridView gridDistribucion;
        private System.Windows.Forms.DataGridView gridChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCAcum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMediaNormal;
        private System.Windows.Forms.TextBox txtDesviacionNormal;
        private System.Windows.Forms.TextBox txtCantNumNormal;
        private System.Windows.Forms.Button btnGenerarNormal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCantIntervalosNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecObservadaNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProbEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecEsperadaNormal;
    }
}