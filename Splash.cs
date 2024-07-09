using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ANSv1
{
    public partial class Splash : MetroForm
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
