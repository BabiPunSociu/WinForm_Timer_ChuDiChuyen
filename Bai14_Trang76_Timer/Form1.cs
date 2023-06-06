using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14_Trang76_Timer
{
    public partial class Form1 : Form
    {
        bool traiSangPhai; // traiSangPhai=true chuyển động sang phải, traiSangPhai=false chuyển động sang trái.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            traiSangPhai = true;
            tmrHenGio.Interval = 80;  // Chu kì gọi sự kiện tich bên dưới---Đơn vị: ms    (1s = 1000ms)
                                    // Mặc định là: 100ms
            tmrHenGio.Start();  // Để bắt đầu       Dừng lại: tmrHenGio.Stop();
        }

        private void tmrHenGio_Tick(object sender, EventArgs e)
        {
            // Tạo chuyển động trái -> phải và phải -> trái
            if (traiSangPhai)
            {
                if ((lblVTH.Left + lblVTH.Width) < this.Width)
                    lblVTH.Left = lblVTH.Left + 10;
                else
                    traiSangPhai = false;
            }
            else
            {
                if (lblVTH.Left > 0)
                    lblVTH.Left = lblVTH.Left - 10;
                else
                    traiSangPhai = true;
            }

            // Tạo chuyển động chỉ trái sang phải
            if ((lblTraiSangPhai.Left + lblTraiSangPhai.Width) < this.Width)
                lblTraiSangPhai.Left = lblTraiSangPhai.Left + 10;
            else
                lblTraiSangPhai.Left = 0;   // Đặt lại vị trí về bên trái
        }
    }
}
