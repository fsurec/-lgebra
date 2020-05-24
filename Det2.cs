using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Álgebra
{
    public partial class Det2 : Form
    {
        public Det2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Double res, temp1, temp2 = 0;

            temp1 = Convert.ToDouble(a11.Text) * Convert.ToDouble(a22.Text);
            temp2 = Convert.ToDouble(a12.Text) * Convert.ToDouble(a21.Text);

            res= temp1 - temp2;

            Resul.Text = res.ToString();
        }
    }
}
