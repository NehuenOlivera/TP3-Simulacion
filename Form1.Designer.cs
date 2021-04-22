
namespace TP3_SIM
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDistUniforme = new System.Windows.Forms.Button();
            this.btnDistExpNegativa = new System.Windows.Forms.Button();
            this.btnDistNormal = new System.Windows.Forms.Button();
            this.btnDistPoisson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDistUniforme
            // 
            this.btnDistUniforme.Location = new System.Drawing.Point(12, 12);
            this.btnDistUniforme.Name = "btnDistUniforme";
            this.btnDistUniforme.Size = new System.Drawing.Size(266, 52);
            this.btnDistUniforme.TabIndex = 0;
            this.btnDistUniforme.Text = "Distribución Uniforme";
            this.btnDistUniforme.UseVisualStyleBackColor = true;
            this.btnDistUniforme.Click += new System.EventHandler(this.btnDistUniformeOnClick);
            // 
            // btnDistExpNegativa
            // 
            this.btnDistExpNegativa.Location = new System.Drawing.Point(12, 70);
            this.btnDistExpNegativa.Name = "btnDistExpNegativa";
            this.btnDistExpNegativa.Size = new System.Drawing.Size(266, 52);
            this.btnDistExpNegativa.TabIndex = 1;
            this.btnDistExpNegativa.Text = "Distribución Exponencial Negativa";
            this.btnDistExpNegativa.UseVisualStyleBackColor = true;
            this.btnDistExpNegativa.Click += new System.EventHandler(this.btnDistExpNegativaOnClick);
            // 
            // btnDistNormal
            // 
            this.btnDistNormal.Location = new System.Drawing.Point(12, 128);
            this.btnDistNormal.Name = "btnDistNormal";
            this.btnDistNormal.Size = new System.Drawing.Size(266, 52);
            this.btnDistNormal.TabIndex = 2;
            this.btnDistNormal.Text = "Distribución Normal";
            this.btnDistNormal.UseVisualStyleBackColor = true;
            this.btnDistNormal.Click += new System.EventHandler(this.btnDistNormalOnClick);
            // 
            // btnDistPoisson
            // 
            this.btnDistPoisson.Location = new System.Drawing.Point(12, 186);
            this.btnDistPoisson.Name = "btnDistPoisson";
            this.btnDistPoisson.Size = new System.Drawing.Size(266, 52);
            this.btnDistPoisson.TabIndex = 3;
            this.btnDistPoisson.Text = "Distribución Poisson";
            this.btnDistPoisson.UseVisualStyleBackColor = true;
            this.btnDistPoisson.Click += new System.EventHandler(this.btnDistPoissonOnClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 251);
            this.Controls.Add(this.btnDistPoisson);
            this.Controls.Add(this.btnDistNormal);
            this.Controls.Add(this.btnDistExpNegativa);
            this.Controls.Add(this.btnDistUniforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Simulación";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDistUniforme;
        private System.Windows.Forms.Button btnDistExpNegativa;
        private System.Windows.Forms.Button btnDistNormal;
        private System.Windows.Forms.Button btnDistPoisson;
    }
}

