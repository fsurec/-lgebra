namespace Álgebra
{
    partial class Inv2
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
            this.aa = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resa = new System.Windows.Forms.Label();
            this.resc = new System.Windows.Forms.Label();
            this.resb = new System.Windows.Forms.Label();
            this.resd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aa
            // 
            this.aa.Location = new System.Drawing.Point(68, 75);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(52, 20);
            this.aa.TabIndex = 0;
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(164, 75);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(52, 20);
            this.bb.TabIndex = 1;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(68, 130);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(52, 20);
            this.cc.TabIndex = 2;
            // 
            // dd
            // 
            this.dd.Location = new System.Drawing.Point(164, 130);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(52, 20);
            this.dd.TabIndex = 3;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(68, 182);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(148, 23);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular Inversa";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inversa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese los datos de la Matriz";
            // 
            // resa
            // 
            this.resa.AutoSize = true;
            this.resa.Location = new System.Drawing.Point(336, 102);
            this.resa.Name = "resa";
            this.resa.Size = new System.Drawing.Size(35, 13);
            this.resa.TabIndex = 11;
            this.resa.Text = "label3";
            // 
            // resc
            // 
            this.resc.AutoSize = true;
            this.resc.Location = new System.Drawing.Point(414, 102);
            this.resc.Name = "resc";
            this.resc.Size = new System.Drawing.Size(35, 13);
            this.resc.TabIndex = 12;
            this.resc.Text = "label3";
            // 
            // resb
            // 
            this.resb.AutoSize = true;
            this.resb.Location = new System.Drawing.Point(336, 148);
            this.resb.Name = "resb";
            this.resb.Size = new System.Drawing.Size(35, 13);
            this.resb.TabIndex = 13;
            this.resb.Text = "label4";
            // 
            // resd
            // 
            this.resd.AutoSize = true;
            this.resd.Location = new System.Drawing.Point(414, 148);
            this.resd.Name = "resd";
            this.resd.Size = new System.Drawing.Size(35, 13);
            this.resd.TabIndex = 14;
            this.resd.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Determinante: ";
            // 
            // Dete
            // 
            this.Dete.AutoSize = true;
            this.Dete.Location = new System.Drawing.Point(437, 212);
            this.Dete.Name = "Dete";
            this.Dete.Size = new System.Drawing.Size(35, 13);
            this.Dete.TabIndex = 16;
            this.Dete.Text = "label4";
            // 
            // Inv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 271);
            this.Controls.Add(this.Dete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resd);
            this.Controls.Add(this.resb);
            this.Controls.Add(this.resc);
            this.Controls.Add(this.resa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.aa);
            this.Name = "Inv2";
            this.Text = "Inv2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aa;
        private System.Windows.Forms.TextBox bb;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resa;
        private System.Windows.Forms.Label resc;
        private System.Windows.Forms.Label resb;
        private System.Windows.Forms.Label resd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Dete;
    }
}