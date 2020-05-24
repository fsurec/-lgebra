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
    public partial class g : Form
    {
        public g()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P = 0;
            A = Convert.ToDouble(a.Text);
            B = Convert.ToDouble(b.Text);
            C = Convert.ToDouble(c.Text);
            D = Convert.ToDouble(d.Text);
            E = Convert.ToDouble(ee.Text);
            F = Convert.ToDouble(f.Text);
            G = Convert.ToDouble(gg.Text);
            H = Convert.ToDouble(h.Text);
            I = Convert.ToDouble(i.Text);
            J = Convert.ToDouble(j.Text);
            K = Convert.ToDouble(k.Text);
            L = Convert.ToDouble(l.Text);
            M = Convert.ToDouble(m.Text);
            N = Convert.ToDouble(n.Text);
            O = Convert.ToDouble(o.Text);
            P = Convert.ToDouble(p.Text);

            Double ares, a1, a2, a3, bres, b1, b2, b3, cres, c1, c2, c3, dres, d1, d2, d3, total= 0;
            a1 = F * ((K * P) - (O * L));
            a2 = -G*((J * P) - (N * L));
            a3 = H* ((J * O) - (N * K));
            ares = a1 + a2 + a3;

            b1 = E * ((K * P) - (O * L));
            b2 = -G * ((I * P) - (M * L));
            b3 = H * ((I * O) - (M * K));
            bres = b1 + b2 + b3;

            c1 = E * ((J * P) - (N * L));
            c2 = -F * ((I * P) - (M * L));
            c3 = H * ((I * N) - (M * J));
            cres = c1 + c2 + c3;

            d1 = E * ((J * O) - (N - K));
            d2 = -F*((I * O) - (M * K));
            d3 = G*((I * N) - (M * J));
            dres = d1 + d2 + d3;

            total = ares - bres + cres - dres;
        }
    }
}
