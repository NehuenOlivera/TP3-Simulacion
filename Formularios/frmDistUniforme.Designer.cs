
namespace TP3_SIM.Formularios
{
    partial class frmDistUniforme
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.gridDistUniforme = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.chartDistUniforme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.colRndUniforme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRndNormalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDistUniformePrueba = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.colIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistUniforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistUniformePrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribución Uniforme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Extremo Inferior (A):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Extremo Superior (B):";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(28, 55);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(130, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(28, 110);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(130, 20);
            this.txtB.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(28, 281);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(396, 47);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.onBtnGenerarClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad (n):";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(28, 166);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(130, 20);
            this.txtN.TabIndex = 2;
            // 
            // gridDistUniforme
            // 
            this.gridDistUniforme.AllowUserToAddRows = false;
            this.gridDistUniforme.AllowUserToDeleteRows = false;
            this.gridDistUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDistUniforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRndUniforme,
            this.colRndNormalizado});
            this.gridDistUniforme.Location = new System.Drawing.Point(28, 391);
            this.gridDistUniforme.Name = "gridDistUniforme";
            this.gridDistUniforme.ReadOnly = true;
            this.gridDistUniforme.Size = new System.Drawing.Size(396, 261);
            this.gridDistUniforme.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gráfico";
            // 
            // chartDistUniforme
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDistUniforme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDistUniforme.Legends.Add(legend1);
            this.chartDistUniforme.Location = new System.Drawing.Point(453, 36);
            this.chartDistUniforme.Name = "chartDistUniforme";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDistUniforme.Series.Add(series1);
            this.chartDistUniforme.Size = new System.Drawing.Size(764, 321);
            this.chartDistUniforme.TabIndex = 11;
            this.chartDistUniforme.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(25, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Intervalos:";
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Location = new System.Drawing.Point(28, 224);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(130, 21);
            this.cmbIntervalos.TabIndex = 13;
            // 
            // colRndUniforme
            // 
            this.colRndUniforme.Frozen = true;
            this.colRndUniforme.HeaderText = "Random (0-1)";
            this.colRndUniforme.Name = "colRndUniforme";
            this.colRndUniforme.ReadOnly = true;
            this.colRndUniforme.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRndUniforme.Width = 180;
            // 
            // colRndNormalizado
            // 
            this.colRndNormalizado.Frozen = true;
            this.colRndNormalizado.HeaderText = "Random Uniforme (A-B)";
            this.colRndNormalizado.Name = "colRndNormalizado";
            this.colRndNormalizado.ReadOnly = true;
            this.colRndNormalizado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colRndNormalizado.Width = 170;
            // 
            // gridDistUniformePrueba
            // 
            this.gridDistUniformePrueba.AllowUserToAddRows = false;
            this.gridDistUniformePrueba.AllowUserToDeleteRows = false;
            this.gridDistUniformePrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDistUniformePrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntervalo,
            this.colFrecObservada,
            this.colFrecEsperada,
            this.colC,
            this.colCAcum});
            this.gridDistUniformePrueba.Location = new System.Drawing.Point(453, 391);
            this.gridDistUniformePrueba.Name = "gridDistUniformePrueba";
            this.gridDistUniformePrueba.ReadOnly = true;
            this.gridDistUniformePrueba.Size = new System.Drawing.Size(764, 261);
            this.gridDistUniformePrueba.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prueba de Chi Cuadrado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(207, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Media:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(207, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Varianza:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(207, 55);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(15, 16);
            this.lblMedia.TabIndex = 18;
            this.lblMedia.Text = "0";
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarianza.Location = new System.Drawing.Point(207, 111);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(15, 16);
            this.lblVarianza.TabIndex = 19;
            this.lblVarianza.Text = "0";
            // 
            // colIntervalo
            // 
            this.colIntervalo.Frozen = true;
            this.colIntervalo.HeaderText = "Intervalo";
            this.colIntervalo.Name = "colIntervalo";
            this.colIntervalo.ReadOnly = true;
            this.colIntervalo.Width = 220;
            // 
            // colFrecObservada
            // 
            this.colFrecObservada.Frozen = true;
            this.colFrecObservada.HeaderText = "Frecuencia Observada";
            this.colFrecObservada.Name = "colFrecObservada";
            this.colFrecObservada.ReadOnly = true;
            this.colFrecObservada.Width = 145;
            // 
            // colFrecEsperada
            // 
            this.colFrecEsperada.Frozen = true;
            this.colFrecEsperada.HeaderText = "Frecuencia Esperada";
            this.colFrecEsperada.Name = "colFrecEsperada";
            this.colFrecEsperada.ReadOnly = true;
            this.colFrecEsperada.Width = 145;
            // 
            // colC
            // 
            this.colC.Frozen = true;
            this.colC.HeaderText = "C";
            this.colC.Name = "colC";
            this.colC.ReadOnly = true;
            this.colC.Width = 110;
            // 
            // colCAcum
            // 
            this.colCAcum.Frozen = true;
            this.colCAcum.HeaderText = "C Acumulada";
            this.colCAcum.Name = "colCAcum";
            this.colCAcum.ReadOnly = true;
            // 
            // frmDistUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 665);
            this.Controls.Add(this.lblVarianza);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridDistUniformePrueba);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartDistUniforme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridDistUniforme);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDistUniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulación - Distribución Uniforme";
            ((System.ComponentModel.ISupportInitialize)(this.gridDistUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistUniforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistUniformePrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.DataGridView gridDistUniforme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistUniforme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRndUniforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRndNormalizado;
        private System.Windows.Forms.DataGridView gridDistUniformePrueba;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCAcum;
    }
}