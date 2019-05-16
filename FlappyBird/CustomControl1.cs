using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class CustomControl1 : System.Windows.Forms.Label
    {
        public CustomControl1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
