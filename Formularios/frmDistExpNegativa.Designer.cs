
namespace TP3_SIM.Formularios
{
    partial class frmDistExpNegativa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelParametros = new System.Windows.Forms.GroupBox();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblCantNumeros = new System.Windows.Forms.Label();
            this.txtBoxCantNumeros = new System.Windows.Forms.TextBox();
            this.lblLambda = new System.Windows.Forms.Label();
            this.txtBoxLambda = new System.Windows.Forms.TextBox();
            this.panelRadioButtons = new System.Windows.Forms.Panel();
            this.rdbLambda = new System.Windows.Forms.RadioButton();
            this.rdbMedia = new System.Windows.Forms.RadioButton();
            this.lblDeseoIngresar = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtBoxMedia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridNrosGenerados = new System.Windows.Forms.DataGridView();
            this.colIteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumerosGenerados = new System.Windows.Forms.Label();
            this.gridChiCuadrado = new System.Windows.Forms.DataGridView();
            this.Intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esperado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumatoriaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.chartExpNegativaFeFo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.panelParametros.SuspendLayout();
            this.panelRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNrosGenerados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpNegativaFeFo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParametros
            // 
            this.panelParametros.Controls.Add(this.lblIntervalos);
            this.panelParametros.Controls.Add(this.cmbIntervalos);
            this.panelParametros.Controls.Add(this.btnGenerar);
            this.panelParametros.Controls.Add(this.lblCantNumeros);
            this.panelParametros.Controls.Add(this.txtBoxCantNumeros);
            this.panelParametros.Controls.Add(this.lblLambda);
            this.panelParametros.Controls.Add(this.txtBoxLambda);
            this.panelParametros.Controls.Add(this.panelRadioButtons);
            this.panelParametros.Controls.Add(this.lblDeseoIngresar);
            this.panelParametros.Controls.Add(this.lblMedia);
            this.panelParametros.Controls.Add(this.txtBoxMedia);
            this.panelParametros.Location = new System.Drawing.Point(23, 70);
            this.panelParametros.Margin = new System.Windows.Forms.Padding(4);
            this.panelParametros.Name = "panelParametros";
            this.panelParametros.Padding = new System.Windows.Forms.Padding(4);
            this.panelParametros.Size = new System.Drawing.Size(465, 379);
            this.panelParametros.TabIndex = 0;
            this.panelParametros.TabStop = false;
            this.panelParametros.Text = "Parametros a Ingresar";
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(158, 250);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(122, 29);
            this.lblIntervalos.TabIndex = 73;
            this.lblIntervalos.Text = "Intervalos:";
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Location = new System.Drawing.Point(286, 247);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(121, 37);
            this.cmbIntervalos.TabIndex = 72;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(146, 290);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(168, 64);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.OnClickBtnGenerar);
            // 
            // lblCantNumeros
            // 
            this.lblCantNumeros.AutoSize = true;
            this.lblCantNumeros.Location = new System.Drawing.Point(28, 206);
            this.lblCantNumeros.Name = "lblCantNumeros";
            this.lblCantNumeros.Size = new System.Drawing.Size(255, 29);
            this.lblCantNumeros.TabIndex = 7;
            this.lblCantNumeros.Text = "Cantidad de numeros: ";
            // 
            // txtBoxCantNumeros
            // 
            this.txtBoxCantNumeros.Location = new System.Drawing.Point(289, 203);
            this.txtBoxCantNumeros.Name = "txtBoxCantNumeros";
            this.txtBoxCantNumeros.Size = new System.Drawing.Size(118, 34);
            this.txtBoxCantNumeros.TabIndex = 6;
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Location = new System.Drawing.Point(28, 158);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(112, 29);
            this.lblLambda.TabIndex = 5;
            this.lblLambda.Text = "Lambda: ";
            // 
            // txtBoxLambda
            // 
            this.txtBoxLambda.Enabled = false;
            this.txtBoxLambda.Location = new System.Drawing.Point(146, 153);
            this.txtBoxLambda.Name = "txtBoxLambda";
            this.txtBoxLambda.Size = new System.Drawing.Size(118, 34);
            this.txtBoxLambda.TabIndex = 4;
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.Controls.Add(this.rdbLambda);
            this.panelRadioButtons.Controls.Add(this.rdbMedia);
            this.panelRadioButtons.Location = new System.Drawing.Point(224, 54);
            this.panelRadioButtons.Name = "panelRadioButtons";
            this.panelRadioButtons.Size = new System.Drawing.Size(205, 29);
            this.panelRadioButtons.TabIndex = 3;
            // 
            // rdbLambda
            // 
            this.rdbLambda.AutoSize = true;
            this.rdbLambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLambda.Location = new System.Drawing.Point(93, 2);
            this.rdbLambda.Name = "rdbLambda";
            this.rdbLambda.Size = new System.Drawing.Size(103, 28);
            this.rdbLambda.TabIndex = 5;
            this.rdbLambda.Text = "Lambda";
            this.rdbLambda.UseVisualStyleBackColor = true;
            this.rdbLambda.CheckedChanged += new System.EventHandler(this.OnClickRdbLambda);
            // 
            // rdbMedia
            // 
            this.rdbMedia.AutoSize = true;
            this.rdbMedia.Checked = true;
            this.rdbMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedia.Location = new System.Drawing.Point(0, 1);
            this.rdbMedia.Name = "rdbMedia";
            this.rdbMedia.Size = new System.Drawing.Size(87, 28);
            this.rdbMedia.TabIndex = 4;
            this.rdbMedia.TabStop = true;
            this.rdbMedia.Text = "Media";
            this.rdbMedia.UseVisualStyleBackColor = true;
            this.rdbMedia.CheckedChanged += new System.EventHandler(this.OnClickRdbMedia);
            // 
            // lblDeseoIngresar
            // 
            this.lblDeseoIngresar.AutoSize = true;
            this.lblDeseoIngresar.Location = new System.Drawing.Point(28, 54);
            this.lblDeseoIngresar.Name = "lblDeseoIngresar";
            this.lblDeseoIngresar.Size = new System.Drawing.Size(190, 29);
            this.lblDeseoIngresar.TabIndex = 2;
            this.lblDeseoIngresar.Text = "Deseo ingresar: ";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(48, 108);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(92, 29);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "Media: ";
            // 
            // txtBoxMedia
            // 
            this.txtBoxMedia.Location = new System.Drawing.Point(146, 103);
            this.txtBoxMedia.Name = "txtBoxMedia";
            this.txtBoxMedia.Size = new System.Drawing.Size(118, 34);
            this.txtBoxMedia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = " Distribución Exponencial Negativa";
            // 
            // dataGridNrosGenerados
            // 
            this.dataGridNrosGenerados.AllowUserToAddRows = false;
            this.dataGridNrosGenerados.AllowUserToDeleteRows = false;
            this.dataGridNrosGenerados.AllowUserToResizeColumns = false;
            this.dataGridNrosGenerados.AllowUserToResizeRows = false;
            this.dataGridNrosGenerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNrosGenerados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIteracion,
            this.colNroGenerado});
            this.dataGridNrosGenerados.Location = new System.Drawing.Point(511, 100);
            this.dataGridNrosGenerados.Name = "dataGridNrosGenerados";
            this.dataGridNrosGenerados.ReadOnly = true;
            this.dataGridNrosGenerados.RowHeadersVisible = false;
            this.dataGridNrosGenerados.RowHeadersWidth = 72;
            this.dataGridNrosGenerados.RowTemplate.Height = 31;
            this.dataGridNrosGenerados.Size = new System.Drawing.Size(220, 349);
            this.dataGridNrosGenerados.TabIndex = 2;
            // 
            // colIteracion
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colIteracion.DefaultCellStyle = dataGridViewCellStyle1;
            this.colIteracion.HeaderText = "Iteración";
            this.colIteracion.MinimumWidth = 9;
            this.colIteracion.Name = "colIteracion";
            this.colIteracion.ReadOnly = true;
            this.colIteracion.Width = 75;
            // 
            // colNroGenerado
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNroGenerado.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNroGenerado.HeaderText = "Nros.Generados";
            this.colNroGenerado.MinimumWidth = 9;
            this.colNroGenerado.Name = "colNroGenerado";
            this.colNroGenerado.ReadOnly = true;
            this.colNroGenerado.Width = 125;
            // 
            // lblNumerosGenerados
            // 
            this.lblNumerosGenerados.AutoSize = true;
            this.lblNumerosGenerados.Location = new System.Drawing.Point(506, 68);
            this.lblNumerosGenerados.Name = "lblNumerosGenerados";
            this.lblNumerosGenerados.Size = new System.Drawing.Size(238, 29);
            this.lblNumerosGenerados.TabIndex = 8;
            this.lblNumerosGenerados.Text = "Numeros Generados";
            // 
            // gridChiCuadrado
            // 
            this.gridChiCuadrado.AllowUserToAddRows = false;
            this.gridChiCuadrado.AllowUserToDeleteRows = false;
            this.gridChiCuadrado.AllowUserToResizeColumns = false;
            this.gridChiCuadrado.AllowUserToResizeRows = false;
            this.gridChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChiCuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalo,
            this.Observado,
            this.Esperado,
            this.C,
            this.sumatoriaC});
            this.gridChiCuadrado.Location = new System.Drawing.Point(751, 100);
            this.gridChiCuadrado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridChiCuadrado.Name = "gridChiCuadrado";
            this.gridChiCuadrado.ReadOnly = true;
            this.gridChiCuadrado.RowHeadersVisible = false;
            this.gridChiCuadrado.RowHeadersWidth = 51;
            this.gridChiCuadrado.RowTemplate.Height = 24;
            this.gridChiCuadrado.ShowCellErrors = false;
            this.gridChiCuadrado.Size = new System.Drawing.Size(865, 349);
            this.gridChiCuadrado.TabIndex = 70;
            // 
            // Intervalo
            // 
            this.Intervalo.HeaderText = "Intervalo";
            this.Intervalo.MinimumWidth = 6;
            this.Intervalo.Name = "Intervalo";
            this.Intervalo.ReadOnly = true;
            this.Intervalo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Intervalo.Width = 300;
            // 
            // Observado
            // 
            this.Observado.HeaderText = "Observado (FO)";
            this.Observado.MinimumWidth = 6;
            this.Observado.Name = "Observado";
            this.Observado.ReadOnly = true;
            this.Observado.Width = 125;
            // 
            // Esperado
            // 
            this.Esperado.HeaderText = "Esperado (FE)";
            this.Esperado.MinimumWidth = 6;
            this.Esperado.Name = "Esperado";
            this.Esperado.ReadOnly = true;
            this.Esperado.Width = 125;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 175;
            // 
            // sumatoriaC
            // 
            this.sumatoriaC.HeaderText = "C (acum)";
            this.sumatoriaC.MinimumWidth = 6;
            this.sumatoriaC.Name = "sumatoriaC";
            this.sumatoriaC.ReadOnly = true;
            this.sumatoriaC.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tabla Chi-Cuadrado";
            // 
            // chartExpNegativaFeFo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartExpNegativaFeFo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartExpNegativaFeFo.Legends.Add(legend1);
            this.chartExpNegativaFeFo.Location = new System.Drawing.Point(12, 489);
            this.chartExpNegativaFeFo.Name = "chartExpNegativaFeFo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartExpNegativaFeFo.Series.Add(series1);
            this.chartExpNegativaFeFo.Size = new System.Drawing.Size(1604, 464);
            this.chartExpNegativaFeFo.TabIndex = 72;
            this.chartExpNegativaFeFo.Text = "chart1";
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Location = new System.Drawing.Point(18, 457);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(446, 29);
            this.lblGrafico.TabIndex = 73;
            this.lblGrafico.Text = "Grafico Frec.Esperada, Frec. Observada";
            // 
            // frmDistExpNegativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 963);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.chartExpNegativaFeFo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridChiCuadrado);
            this.Controls.Add(this.lblNumerosGenerados);
            this.Controls.Add(this.dataGridNrosGenerados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelParametros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "frmDistExpNegativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulación - Distribución Exponencial Negativa";
            this.panelParametros.ResumeLayout(false);
            this.panelParametros.PerformLayout();
            this.panelRadioButtons.ResumeLayout(false);
            this.panelRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNrosGenerados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpNegativaFeFo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox panelParametros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRadioButtons;
        private System.Windows.Forms.RadioButton rdbMedia;
        private System.Windows.Forms.Label lblDeseoIngresar;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtBoxMedia;
        private System.Windows.Forms.RadioButton rdbLambda;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.TextBox txtBoxLambda;
        private System.Windows.Forms.Label lblCantNumeros;
        private System.Windows.Forms.TextBox txtBoxCantNumeros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dataGridNrosGenerados;
        private System.Windows.Forms.Label lblNumerosGenerados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroGenerado;
        public System.Windows.Forms.DataGridView gridChiCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esperado;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumatoriaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpNegativaFeFo;
        private System.Windows.Forms.Label lblGrafico;
    }
}