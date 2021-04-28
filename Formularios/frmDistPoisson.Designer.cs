
namespace TP3_SIM.Formularios
{
    partial class frmDistPoisson
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
            this.txtCantNum = new System.Windows.Forms.MaskedTextBox();
            this.txtLambda = new System.Windows.Forms.NumericUpDown();
            this.gridPoisson = new System.Windows.Forms.DataGridView();
            this.Iteración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrosAleatoriosPoisson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarPoisson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaobservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadesperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaesperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoisson)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribución Poisson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Numeros a Generar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lambda (λ):";
            // 
            // txtCantNum
            // 
            this.txtCantNum.Location = new System.Drawing.Point(284, 30);
            this.txtCantNum.Mask = "99999";
            this.txtCantNum.Name = "txtCantNum";
            this.txtCantNum.Size = new System.Drawing.Size(100, 26);
            this.txtCantNum.TabIndex = 3;
            this.txtCantNum.ValidatingType = typeof(int);
            // 
            // txtLambda
            // 
            this.txtLambda.DecimalPlaces = 2;
            this.txtLambda.Location = new System.Drawing.Point(133, 70);
            this.txtLambda.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtLambda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(120, 26);
            this.txtLambda.TabIndex = 4;
            this.txtLambda.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // gridPoisson
            // 
            this.gridPoisson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPoisson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteración,
            this.nrosAleatoriosPoisson});
            this.gridPoisson.Location = new System.Drawing.Point(12, 237);
            this.gridPoisson.Name = "gridPoisson";
            this.gridPoisson.RowHeadersWidth = 62;
            this.gridPoisson.RowTemplate.Height = 28;
            this.gridPoisson.Size = new System.Drawing.Size(537, 358);
            this.gridPoisson.TabIndex = 5;
            // 
            // Iteración
            // 
            this.Iteración.HeaderText = "Iteración(i)";
            this.Iteración.MinimumWidth = 8;
            this.Iteración.Name = "Iteración";
            this.Iteración.Width = 150;
            // 
            // nrosAleatoriosPoisson
            // 
            this.nrosAleatoriosPoisson.HeaderText = "Nros Aleatorios Poisson (RND)";
            this.nrosAleatoriosPoisson.MinimumWidth = 8;
            this.nrosAleatoriosPoisson.Name = "nrosAleatoriosPoisson";
            this.nrosAleatoriosPoisson.Width = 150;
            // 
            // btnGenerarPoisson
            // 
            this.btnGenerarPoisson.Location = new System.Drawing.Point(407, 49);
            this.btnGenerarPoisson.Name = "btnGenerarPoisson";
            this.btnGenerarPoisson.Size = new System.Drawing.Size(120, 67);
            this.btnGenerarPoisson.TabIndex = 6;
            this.btnGenerarPoisson.Text = "Generar";
            this.btnGenerarPoisson.UseVisualStyleBackColor = true;
            this.btnGenerarPoisson.Click += new System.EventHandler(this.btnGenerarPoisson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGenerarPoisson);
            this.groupBox1.Controls.Add(this.txtCantNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLambda);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros a Ingresar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valor,
            this.frecuenciaobservada,
            this.probabilidadesperada,
            this.frecuenciaesperada});
            this.dataGridView1.Location = new System.Drawing.Point(644, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(713, 293);
            this.dataGridView1.TabIndex = 8;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 8;
            this.valor.Name = "valor";
            this.valor.Width = 150;
            // 
            // frecuenciaobservada
            // 
            this.frecuenciaobservada.HeaderText = "Frecuencia Observada";
            this.frecuenciaobservada.MinimumWidth = 8;
            this.frecuenciaobservada.Name = "frecuenciaobservada";
            this.frecuenciaobservada.Width = 150;
            // 
            // probabilidadesperada
            // 
            this.probabilidadesperada.HeaderText = "Probabilidad Esperada";
            this.probabilidadesperada.MinimumWidth = 8;
            this.probabilidadesperada.Name = "probabilidadesperada";
            this.probabilidadesperada.Width = 150;
            // 
            // frecuenciaesperada
            // 
            this.frecuenciaesperada.HeaderText = "Frecuencia Esperada";
            this.frecuenciaesperada.MinimumWidth = 8;
            this.frecuenciaesperada.Name = "frecuenciaesperada";
            this.frecuenciaesperada.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numeros Generados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Distribucion Poisson";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalo,
            this.FrecObs,
            this.FrecEsp,
            this.C,
            this.CAcum});
            this.dataGridView2.Location = new System.Drawing.Point(644, 410);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(876, 295);
            this.dataGridView2.TabIndex = 11;
            // 
            // Intervalo
            // 
            this.Intervalo.HeaderText = "Intervalo";
            this.Intervalo.MinimumWidth = 8;
            this.Intervalo.Name = "Intervalo";
            this.Intervalo.Width = 150;
            // 
            // FrecObs
            // 
            this.FrecObs.HeaderText = "Frecuencia Observada (FO)";
            this.FrecObs.MinimumWidth = 8;
            this.FrecObs.Name = "FrecObs";
            this.FrecObs.Width = 150;
            // 
            // FrecEsp
            // 
            this.FrecEsp.HeaderText = "Frecuencia Esperada (FE)";
            this.FrecEsp.MinimumWidth = 8;
            this.FrecEsp.Name = "FrecEsp";
            this.FrecEsp.Width = 150;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.MinimumWidth = 8;
            this.C.Name = "C";
            this.C.Width = 150;
            // 
            // CAcum
            // 
            this.CAcum.HeaderText = "C Acumulado";
            this.CAcum.MinimumWidth = 8;
            this.CAcum.Name = "CAcum";
            this.CAcum.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(644, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prueba de Bondad - Chi Cuadrado";
            // 
            // frmDistPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 1023);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridPoisson);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDistPoisson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulación - Distribución Poisson";
            this.Load += new System.EventHandler(this.frmDistPoisson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoisson)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCantNum;
        private System.Windows.Forms.NumericUpDown txtLambda;
        private System.Windows.Forms.DataGridView gridPoisson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteración;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrosAleatoriosPoisson;
        private System.Windows.Forms.Button btnGenerarPoisson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaobservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadesperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaesperada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAcum;
        private System.Windows.Forms.Label label6;
    }
}