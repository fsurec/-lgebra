namespace Álgebra
{
    partial class Det3
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
            this.cc = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.TextBox();
            this.ee = new System.Windows.Forms.TextBox();
            this.ff = new System.Windows.Forms.TextBox();
            this.gg = new System.Windows.Forms.TextBox();
            this.hh = new System.Windows.Forms.TextBox();
            this.ii = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aa
            // 
            this.aa.Location = new System.Drawing.Point(88, 77);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(44, 20);
            this.aa.TabIndex = 0;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(244, 77);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(44, 20);
            this.cc.TabIndex = 1;
            // 
            // dd
            // 
            this.dd.Location = new System.Drawing.Point(88, 130);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(44, 20);
            this.dd.TabIndex = 2;
            // 
            // ee
            // 
            this.ee.Location = new System.Drawing.Point(168, 130);
            this.ee.Name = "ee";
            this.ee.Size = new System.Drawing.Size(44, 20);
            this.ee.TabIndex = 3;
            // 
            // ff
            // 
            this.ff.Location = new System.Drawing.Point(244, 130);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(44, 20);
            this.ff.TabIndex = 4;
            // 
            // gg
            // 
            this.gg.Location = new System.Drawing.Point(88, 187);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(44, 20);
            this.gg.TabIndex = 5;
            // 
            // hh
            // 
            this.hh.Location = new System.Drawing.Point(168, 187);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(44, 20);
            this.hh.TabIndex = 6;
            // 
            // ii
            // 
            this.ii.Location = new System.Drawing.Point(244, 187);
            this.ii.Name = "ii";
            this.ii.Size = new System.Drawing.Size(44, 20);
            this.ii.TabIndex = 7;
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(168, 77);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(44, 20);
            this.bb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rellene los Datos de la Matriz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "La determinante es : ";
            // 
            // resu
            // 
            this.resu.AutoSize = true;
            this.resu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resu.Location = new System.Drawing.Point(253, 334);
            this.resu.Name = "resu";
            this.resu.Size = new System.Drawing.Size(0, 13);
            this.resu.TabIndex = 23;
            // 
            // Det3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 383);
            this.Controls.Add(this.resu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.ii);
            this.Controls.Add(this.hh);
            this.Controls.Add(this.gg);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.ee);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.aa);
            this.Name = "Det3";
            this.Text = "Det3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aa;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.TextBox dd;
        private System.Windows.Forms.TextBox ee;
        private System.Windows.Forms.TextBox ff;
        private System.Windows.Forms.TextBox gg;
        private System.Windows.Forms.TextBox hh;
        private System.Windows.Forms.TextBox ii;
        private System.Windows.Forms.TextBox bb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resu;
    }
}