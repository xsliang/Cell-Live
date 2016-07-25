using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTest
{
    public partial class Form1 : Form
    {
        int row = 0;
        int column = 0;

        const string LIVE = "1";

        const string DIED = "0";

        List<Creature> lstCreature = new List<Creature>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRow.Text) || string.IsNullOrEmpty(txtColumn.Text))
            {
                return;
            }
            else
            {
                row = Convert.ToInt32(txtRow.Text);
                column = Convert.ToInt32(txtColumn.Text);

                lstCreature = new List<Creature>();
                Random r = new Random(DateTime.Now.Second);
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Creature oCreature = new Creature();
                        oCreature.row = i;
                        oCreature.column = j;
                        double result = r.Next(0, 1000) * 0.1;
                        if (result < Convert.ToDouble(txtBeginRatio.Text))
                        {
                            oCreature.show = DIED;
                        }
                        else
                        {
                            oCreature.show = LIVE;
                        }

                        //test
                        //oCreature.show = DIED;
                        //test

                        lstCreature.Add(oCreature);
                    }
                }

                switch (cmbSpeed.Text)
                {
                    case "Fast":
                        timerSpeed.Interval = 100;
                        break;
                    case "Middle":
                        timerSpeed.Interval = 1000;
                        break;
                    case "Slow":
                        timerSpeed.Interval = 5000;
                        break;
                    default:
                        timerSpeed.Interval = 100;
                        cmbSpeed.Text = "Middle";
                        break;
                }
                viewForm1.row = row;
                viewForm1.column = column;
                viewForm1.lstCreature = lstCreature;
                this.Invalidate();
                timerSpeed.Start();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            viewForm1.row = row;
            viewForm1.column = column;
            viewForm1.lstCreature = lstCreature;
            viewForm1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerSpeed_Tick(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            List<string> lstShow = new List<string>();

            int[,] tempAry = new int[row, column];
            for (int i = 0; i < lstCreature.Count; i++)
            {
                tempAry[lstCreature[i].row, lstCreature[i].column] = Convert.ToInt32(lstCreature[i].show);
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    int threshold = 0;

                    if (j - 1 >= 0 && tempAry[i, j - 1] == Convert.ToInt32(LIVE))
                    {
                        threshold++;
                    }

                    if (i - 1 >= 0 && j - 1 >= 0 && tempAry[i - 1, j - 1] == Convert.ToInt32(LIVE))
                    {
                        threshold++;
                    }

                    if (i - 1 >= 0 && tempAry[i - 1, j] == Convert.ToInt32(LIVE))
                    {
                        threshold++;
                    }

                    if (i - 1 >= 0 && j + 1 < column && tempAry[i - 1, j + 1] == Convert.ToInt32(LIVE))
                    {
                        threshold++;
                    }

                    if (j + 1 < column && tempAry[i, j + 1] == Convert.ToInt32(LIVE))
                    {
                        threshold++;
                    }

                    if (i + 1 < row && j + 1 < column && tempAry[i + 1, j + 1] == Convert.ToInt32(LIVE))
                    {
                        threshold++;
                    }

                    if (i + 1 < row && tempAry[i + 1, j] == Convert.ToInt32(LIVE))
                    {
                        threshold++;
                    }

                    if (i + 1 < row && j - 1 >= 0 && tempAry[i + 1, j - 1] == Convert.ToInt32(LIVE))
                    {
                        threshold++;
                    }

                    if (tempAry[i, j] == Convert.ToInt32(DIED))
                    {
                        if (threshold == 3)
                        {
                            lstShow.Add(LIVE);
                        }
                        else
                        {
                            lstShow.Add(DIED);
                        }
                    }
                    else
                    {
                        if (threshold < 2 || threshold > 3)
                        {
                            lstShow.Add(DIED);
                        }
                        else
                        {
                            lstShow.Add(LIVE);
                        }
                    }
                }
            }

            for (int i = 0; i < lstCreature.Count; i++)
            {
                lstCreature[i].show = lstShow[i];
            }

            //viewForm1.ShowGrid(row, column, lstCreature);
            viewForm1.row = row;
            viewForm1.column = column;
            viewForm1.lstCreature = lstCreature;
            viewForm1.Invalidate();
        }

        private void OldMethod()
        {
            List<string> lstShow = new List<string>();

            for (int i = 0; i < lstCreature.Count; i++)
            {
                int threshold = 0;
                var item = lstCreature[i];

                if (lstCreature[i].row == 1 && lstCreature[i].column == 1)
                {

                    // right
                    if (lstCreature.Where(x => x.row == item.row
                        && x.column == item.column + 1
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                    // right down
                    if (lstCreature.Where(x => x.row == item.row + 1
                        && x.column == item.column + 1
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                    // down
                    if (lstCreature.Where(x => x.row == item.row + 1
                        && x.column == item.column
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                }
                else if (lstCreature[i].row == Convert.ToInt32(txtRow.Text) &&
                    lstCreature[i].column == Convert.ToInt32(txtColumn.Text))
                {
                    // top
                    if (lstCreature.Where(x => x.row == item.row - 1
                        && x.column == item.column
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                    // left top
                    if (lstCreature.Where(x => x.row == item.row - 1
                        && x.column == item.column - 1
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                    // left
                    if (lstCreature.Where(x => x.row == item.row
                        && x.column == item.column - 1
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }
                }
                else if (lstCreature[i].row == Convert.ToInt32(txtRow.Text) &&
                    lstCreature[i].column == 1)
                {
                    // top
                    if (lstCreature.Where(x => x.row == item.row - 1
                        && x.column == item.column
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                    // top right
                    if (lstCreature.Where(x => x.row == item.row - 1
                        && x.column == item.column + 1
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                    // right
                    if (lstCreature.Where(x => x.row == item.row
                        && x.column == item.column + 1
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }
                }
                else if (lstCreature[i].row == 1 &&
                    lstCreature[i].column == Convert.ToInt32(txtColumn.Text))
                {
                    // left
                    if (lstCreature.Where(x => x.row == item.row
                        && x.column == item.column - 1
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                    // left down
                    if (lstCreature.Where(x => x.row == item.row - 1
                        && x.column == item.column - 1
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }

                    // down
                    if (lstCreature.Where(x => x.row == item.row + 1
                        && x.column == item.column
                        && x.show == "1").Count() == 1)
                    {
                        threshold++;
                    }
                }
                else
                {
                    if (item.row != 1 && item.column != 1)
                    {
                        // left top
                        if (lstCreature.Where(x => x.row == item.row - 1
                            && x.column == item.column - 1
                            && x.show == "1").Count() == 1)
                        {
                            threshold++;
                        }
                    }


                    if (item.row != 1)
                    {
                        // top
                        if (lstCreature.Where(x => x.row == item.row - 1
                            && x.column == item.column
                            && x.show == "1").Count() == 1)
                        {
                            threshold++;
                        }


                    }

                    if (item.row != 1 && item.column != column)
                    {
                        // top right
                        if (lstCreature.Where(x => x.row == item.row - 1
                            && x.column == item.column + 1
                            && x.show == "1").Count() == 1)
                        {
                            threshold++;
                        }
                    }

                    if (item.column != column)
                    {
                        // right
                        if (lstCreature.Where(x => x.row == item.row
                            && x.column == item.column + 1
                            && x.show == "1").Count() == 1)
                        {
                            threshold++;
                        }
                    }

                    if (item.row != row && item.column != column)
                    {
                        // right down
                        if (lstCreature.Where(x => x.row == item.row + 1
                            && x.column == item.column + 1
                            && x.show == "1").Count() == 1)
                        {
                            threshold++;
                        }
                    }

                    if (item.row != row)
                    {
                        // down
                        if (lstCreature.Where(x => x.row == item.row + 1
                            && x.column == item.column
                            && x.show == "1").Count() == 1)
                        {
                            threshold++;
                        }
                    }

                    if (item.row != row && item.column != 1)
                    {
                        // left down
                        if (lstCreature.Where(x => x.row == item.row + 1
                            && x.column == item.column - 1
                            && x.show == "1").Count() == 1)
                        {
                            threshold++;
                        }
                    }

                    if (item.column != 1)
                    {
                        // left
                        if (lstCreature.Where(x => x.row == item.row
                            && x.column == item.column - 1
                            && x.show == "1").Count() == 1)
                        {
                            threshold++;
                        }
                    }
                }

                if (item.show == DIED)
                {
                    if (threshold == 3)
                    {
                        lstShow.Add(LIVE);
                    }
                    else
                    {
                        lstShow.Add(DIED);
                    }
                }
                else
                {
                    if (threshold < 2 || threshold > 3)
                    {
                        lstShow.Add(DIED);
                        //lstCreature[i].show = DIED;
                    }
                    else
                    {
                        lstShow.Add(LIVE);
                        //lstCreature[i].show = LIVE;
                    }
                }

            }

            for (int i = 0; i < lstCreature.Count; i++)
            {
                lstCreature[i].show = lstShow[i];
            }

            viewForm1.row = row;
            viewForm1.column = column;
            viewForm1.lstCreature = lstCreature;
            viewForm1.Invalidate();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerSpeed.Stop();
        }
    }
}
