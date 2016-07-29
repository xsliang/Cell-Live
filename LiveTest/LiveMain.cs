using LiveLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LiveTest
{
    public partial class LiveMain : Form
    {
        LiveBiz llogic = new LiveBiz();

        Color lineColor { get; set; }

        public LiveMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            llogic.row = Convert.ToInt32(numericUpDownMatrix.Value);
            llogic.column = Convert.ToInt32(numericUpDownMatrix.Value);

            llogic.InitCreature(Convert.ToInt32(numericUpDownBeginRatio.Value));

            timerSpeed.Interval = trackBar.Value * 10;

            llogic.CalcLiveStatus();

            viewForm1.row = llogic.row;
            viewForm1.column = llogic.column;
            viewForm1.lstCreature = llogic.lstCreature;
            viewForm1.lineColor = lineColor;
            viewForm1.Invalidate();
            timerSpeed.Start();
        }

        private void timerSpeed_Tick(object sender, EventArgs e)
        {
            llogic.CalcLiveStatus();

            viewForm1.lstCreature = llogic.lstCreature;
            viewForm1.Invalidate();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerSpeed.Stop();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            lineColor = colorDialog.Color;
        }
    }
}
