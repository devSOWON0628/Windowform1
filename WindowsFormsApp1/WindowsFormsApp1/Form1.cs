using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class 헬로우월드 : Form
    {
        public 헬로우월드()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요","지성아~",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
        }
    }
}
