using LiveTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveLogic
{
    public class LiveBiz
    {
        public int row { get; set; }
        public int column { get; set; }


        public List<Creature> lstCreature { get; set; }

        const string LIVE = "1";

        const string DIED = "0";

        public LiveBiz()
        {
            lstCreature = new List<Creature>();
        }

        public void InitCreature(int ratio)
        {
            lstCreature.Clear();

            Random r = new Random(DateTime.Now.Second);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Creature oCreature = new Creature();
                    oCreature.row = i;
                    oCreature.column = j;
                    double result = r.Next(0, 1000) * 0.1;
                    if (result < Convert.ToDouble(ratio))
                    {
                        oCreature.show = DIED;
                    }
                    else
                    {
                        oCreature.show = LIVE;
                    }

                    lstCreature.Add(oCreature);
                }
            }
        }

        public void CalcLiveStatus()
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
        }

        private void CalcLiveStatus_old()
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
                else if (lstCreature[i].row == row && lstCreature[i].column == column)
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
                else if (lstCreature[i].row == row && lstCreature[i].column == 1)
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
                else if (lstCreature[i].row == 1 && lstCreature[i].column == column)
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

            //viewForm1.row = row;
            //viewForm1.column = column;
            //viewForm1.lstCreature = lstCreature;
            //viewForm1.Invalidate();
        }
    }
}
