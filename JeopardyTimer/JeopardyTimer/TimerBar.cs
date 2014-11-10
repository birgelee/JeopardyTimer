using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyTimer
{
    public partial class TimerBar : Form
    {
        public TimerBar()
        {

            InitializeComponent();
            this.TopMost = true;
            this.Paint += paintBar;

        }

        public void paintBar(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (Program.timer.ElapsedMilliseconds > 5000)
            {
                if (Program.timer.IsRunning)
                {
                    Program.playSound(Properties.Resources.jtime);
                    Program.timer.Stop();
                }
            }
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), 0, 0, (int)(((double)Program.timer.ElapsedMilliseconds / 5000F) * Width), Height);
        }

    }
}
