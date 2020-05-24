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
    public partial class Det3 : Form
    {
        public Det3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b, c, d, eee, f, g, h, i = 0;
            Double res, temp1, temp2, temp3 = 0;
            a = Convert.ToDouble(aa.Text);
            b= Convert.ToDouble(bb.Text);
            c = Convert.ToDouble(cc.Text);
            d = Convert.ToDouble(dd.Text);
            eee= Convert.ToDouble(ee.Text);
            f= Convert.ToDouble(ff.Text);
            g= Convert.ToDouble(gg.Text);
            h= Convert.ToDouble(hh.Text);
            i= Convert.ToDouble(ii.Text);

            temp1 = a * ((eee * i) - (h * f));
            temp2 = -b * ((d * i) - (g * f));
            temp3 = c * ((d * h) - (g * eee));

            res = temp1 + temp2 + temp3;

            resu.Text = Convert.ToString(res);
        }

    }
}
