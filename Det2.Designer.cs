namespace Álgebra
{
    partial class Det2
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
            this.a11 = new System.Windows.Forms.TextBox();
            this.a21 = new System.Windows.Forms.TextBox();
            this.a12 = new System.Windows.Forms.TextBox();
            this.a22 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.Resul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a11
            // 
            this.a11.Location = new System.Drawing.Point(120, 86);
            this.a11.Name = "a11";
            this.a11.Size = new System.Drawing.Size(44, 20);
            this.a11.TabIndex = 0;
            // 
            // a21
            // 
            this.a21.Location = new System.Drawing.Point(202, 86);
            this.a21.Name = "a21";
            this.a21.Size = new System.Drawing.Size(44, 20);
            this.a21.TabIndex = 1;
            // 
            // a12
            // 
            this.a12.Location = new System.Drawing.Point(120, 146);
            this.a12.Name = "a12";
            this.a12.Size = new System.Drawing.Size(44, 20);
            this.a12.TabIndex = 2;
            // 
            // a22
            // 
            this.a22.Location = new System.Drawing.Point(202, 146);
            this.a22.Name = "a22";
            this.a22.Size = new System.Drawing.Size(44, 20);
            this.a22.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese los Valores de su Matriz en los espacios de abajo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "La deerminante de la Matriz es: ";
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(48, 194);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(273, 23);
            this.Calcular.TabIndex = 6;
            this.Calcular.Text = "Calcular Determinante";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Resul
            // 
            this.Resul.AutoSize = true;
            this.Resul.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Resul.Location = new System.Drawing.Point(211, 237);
            this.Resul.Name = "Resul";
            this.Resul.Size = new System.Drawing.Size(0, 13);
            this.Resul.TabIndex = 7;
            // 
            // Det2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 318);
            this.Controls.Add(this.Resul);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a22);
            this.Controls.Add(this.a12);
            this.Controls.Add(this.a21);
            this.Controls.Add(this.a11);
            this.Name = "Det2";
            this.Text = "Det2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a11;
        private System.Windows.Forms.TextBox a21;
        private System.Windows.Forms.TextBox a12;
        private System.Windows.Forms.TextBox a22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label Resul;
    }
}