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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShareData.DataEvent += () => number.Text = ShareData.Count.ToString(); // 註冊DataEvent事件，當DataEvent事件被觸發時，更新共享數字
        }

        private void increment_Click(object sender, EventArgs e)
        {
            ShareData.Count++;
        }

        private void openSecondForm_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }

        private void resetNumber_Click(object sender, EventArgs e)
        {
            ShareData.Count = 0;
        }
    }
}
