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
            number.Text = ShareData.Count.ToString(); // 當form被建立時先顯示共享數字，不然會是0(我label的預設值)
            ShareData.DataEvent += () => number.Text = ShareData.Count.ToString(); // 註冊DataEvent事件，當DataEvent事件被觸發時，更新共享數字
        }

        private void increment_Click(object sender, EventArgs e)
        {
            ShareData.Count++;
        }
    }
}
