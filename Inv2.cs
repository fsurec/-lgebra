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
    public partial class Inv2 : Form
    {
        public Inv2()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Double A, B, C, D, det, fraccion = 0;
            A = Convert.ToDouble(aa.Text);
            B = Convert.ToDouble(bb.Text);
            C = Convert.ToDouble(cc.Text);
            D = Convert.ToDouble(dd.Text);

            det = (A * D) - (C * B);

            fraccion = 1 / det;

            Double adja, adjb, adjc, adjd = 0;

            adja = D*fraccion;
            adjb = -B*fraccion;
            adjc = -C*fraccion;
            adjd = A*fraccion;

            resa.Text = adja.ToString();
            resb.Text = adjb.ToString();
            resc.Text = adjc.ToString();
            resd.Text = adjd.ToString();
            Dete.Text = det.ToString();

           
           

        }
    }
}
