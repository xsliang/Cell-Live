using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTest
{
    public partial class ViewForm : UserControl
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        public int column { get; set; }
        public List<Creature> lstCreature { get; set; }
        public int row { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (row != 0 && column != 0 && lstCreature != null && lstCreature.Count > 0)
            {
                Graphics dc = e.Graphics;
                dc.Clear(Color.WhiteSmoke);

                Pen pen = new Pen(Color.Black, 1);
                dc.DrawRectangle(pen, 1, 1, this.Width - 2, this.Height - 2);

                float eachWidth = (Width - 6) / row;
                float eachHeight = (Height - 6) / column;

                Pen rowLinePen = new Pen(Color.Black, 1);

                SolidBrush brushLive = new SolidBrush(Color.Black);

                SolidBrush brushDie = new SolidBrush(Color.White);
                foreach (var item in lstCreature)
                {
                    if (item.show == "1")
                    {
                        dc.FillRegion(brushLive, new Region(new RectangleF((item.row - 2) * eachWidth + eachWidth, (item.column - 2) * eachHeight + eachHeight, eachWidth, eachHeight)));
                    }
                    else
                    {
                        dc.DrawRectangle(rowLinePen, (item.row - 2) * eachWidth + eachWidth, (item.column - 2) * eachHeight + eachHeight, eachWidth, eachHeight);
                    }
                }
            }


        }
    }
}
