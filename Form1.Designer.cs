namespace Álgebra
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.determinantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.determinantesToolStripMenuItem,
            this.inversasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // determinantesToolStripMenuItem
            // 
            this.determinantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem});
            this.determinantesToolStripMenuItem.Name = "determinantesToolStripMenuItem";
            this.determinantesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.determinantesToolStripMenuItem.Text = "Determinantes";
            // 
            // inversasToolStripMenuItem
            // 
            this.inversasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2ToolStripMenuItem1,
            this.x3ToolStripMenuItem1,
            this.x4ToolStripMenuItem1});
            this.inversasToolStripMenuItem.Name = "inversasToolStripMenuItem";
            this.inversasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.inversasToolStripMenuItem.Text = "Inversas";
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x2ToolStripMenuItem.Text = "2x2";
            this.x2ToolStripMenuItem.Click += new System.EventHandler(this.x2ToolStripMenuItem_Click);
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x3ToolStripMenuItem.Text = "3x3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.x4ToolStripMenuItem.Text = "4x4";
            this.x4ToolStripMenuItem.Click += new System.EventHandler(this.x4ToolStripMenuItem_Click);
            // 
            // x2ToolStripMenuItem1
            // 
            this.x2ToolStripMenuItem1.Name = "x2ToolStripMenuItem1";
            this.x2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.x2ToolStripMenuItem1.Text = "2x2";
            this.x2ToolStripMenuItem1.Click += new System.EventHandler(this.x2ToolStripMenuItem1_Click);
            // 
            // x3ToolStripMenuItem1
            // 
            this.x3ToolStripMenuItem1.Name = "x3ToolStripMenuItem1";
            this.x3ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.x3ToolStripMenuItem1.Text = "3x3";
            this.x3ToolStripMenuItem1.Click += new System.EventHandler(this.x3ToolStripMenuItem1_Click);
            // 
            // x4ToolStripMenuItem1
            // 
            this.x4ToolStripMenuItem1.Name = "x4ToolStripMenuItem1";
            this.x4ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.x4ToolStripMenuItem1.Text = "4x4";
            this.x4ToolStripMenuItem1.Click += new System.EventHandler(this.x4ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Álgebra Lineal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem determinantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem1;
    }
}

