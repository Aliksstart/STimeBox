using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STimeBox
{
    public class MainView : Form
    {
        private void SetSizeWindow() {
            Size screenSize = Support.GetPrimaryScreenSize();
            if (!screenSize.IsEmpty) {
                Size = new Size(Support.CalcValuePercentFormMax(screenSize.Width, 20), Support.CalcValuePercentFormMax(screenSize.Height, 75));
            }
        }
        private void SetRightDownLocation() {
            Size screenSize = Support.GetPrimaryScreenSize();
            Location = new Point(screenSize.Width - Size.Width, screenSize.Height - Size.Height);
        }
        public MainView() {
            this.Load += MainView_Load;
            Text = "STimeBox";
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            SetSizeWindow();
            BackColor = Support.ConvertHexToColor("#2fed80");
        }

        private void MainView_Load(object? sender, EventArgs e)
        {
            SetRightDownLocation();
        }

        public void Redner() { }
    }
}
