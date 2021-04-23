
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Iteración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrosAleatoriosPoisson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarPoisson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DISTRIBUCIÓN POISSON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Numeros a Generar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lambda (λ):";
            // 
            // txtCantNum
            // 
            this.txtCantNum.Location = new System.Drawing.Point(277, 125);
            this.txtCantNum.Mask = "99999";
            this.txtCantNum.Name = "txtCantNum";
            this.txtCantNum.Size = new System.Drawing.Size(100, 26);
            this.txtCantNum.TabIndex = 3;
            this.txtCantNum.ValidatingType = typeof(int);
            // 
            // txtLambda
            // 
            this.txtLambda.DecimalPlaces = 2;
            this.txtLambda.Location = new System.Drawing.Point(673, 128);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteración,
            this.nrosAleatoriosPoisson});
            this.dataGridView1.Location = new System.Drawing.Point(96, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(367, 150);
            this.dataGridView1.TabIndex = 5;
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
            this.btnGenerarPoisson.Location = new System.Drawing.Point(539, 241);
            this.btnGenerarPoisson.Name = "btnGenerarPoisson";
            this.btnGenerarPoisson.Size = new System.Drawing.Size(120, 67);
            this.btnGenerarPoisson.TabIndex = 6;
            this.btnGenerarPoisson.Text = "Generar";
            this.btnGenerarPoisson.UseVisualStyleBackColor = true;
            // 
            // frmDistPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnGenerarPoisson);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.txtCantNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDistPoisson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulación - Distribución Poisson";
            this.Load += new System.EventHandler(this.frmDistPoisson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCantNum;
        private System.Windows.Forms.NumericUpDown txtLambda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteración;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrosAleatoriosPoisson;
        private System.Windows.Forms.Button btnGenerarPoisson;
    }
}