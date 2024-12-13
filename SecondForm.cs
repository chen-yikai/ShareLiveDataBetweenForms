using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareLiveVar
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
            number.Text = ShareData.Count.ToString();
            ShareData.DataEvent += () => number.Text = ShareData.Count.ToString();
        }

        private void increment_Click(object sender, EventArgs e)
        {
            ShareData.Count++;
        }
    }
}
