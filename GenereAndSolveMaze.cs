using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace GenereMaze
{
    public partial class GenereAndSolveMaze : Form
    {
        public cell[,] Labirint;

        //рядки
        public int N = 10;
        //стовпці
        public int M = 10;

        private Int32 WidthY = 0;
        private Int32 WidthX = 0;
        private Int32 btn_clicks = 0;
        private Int32 p_Width;
        private Int32 p_Height;

        private bool inUse = false;
        private bool isActivated;
        private bool left = false;


        private Point[] StartEnd = new Point[2];


        private static Bitmap bmp;
        private static Graphics g;

        private delegate void dSolveMaze(Point Start);
        private delegate void dSetVisible();
        private delegate void dSetEnabling();



        public GenereAndSolveMaze(bool isActivated)
        {
            InitializeComponent();
            lb_N.Text = "N: " + this.N.ToString();
            lb_M.Text = "M: " + this.M.ToString();

            bmp = new Bitmap(pb_Draw.Width, pb_Draw.Height);
            g = Graphics.FromImage(bmp);

            p_Width = pb_Draw.Width;
            p_Height = pb_Draw.Height;

            this.isActivated = isActivated;
        }

        private void btn_genere_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            btn_clicks = 0;
            btn_solve.Enabled = false;
            left = false;
            StartEnd[0] = default(Point);
            StartEnd[1] = default(Point);

            Int32 SlideX = 0;
            Int32 SlideY = 0;

            inUse = false;

            Pen p = new Pen(Color.Black);


            WidthX = pb_Draw.Width / M;

            WidthY = pb_Draw.Height / N;
            if (WidthX < WidthY)
                WidthY = WidthX;
            else
                WidthX = WidthY;

            //---------------Drawing-----------------
            //Initialise square.
            for (int j = 0; j < M; j++)
            {
                // Draw top border
                g.DrawLine(p, SlideX, 0, SlideX + WidthX, 0);
                SlideX += WidthX;
            }

            SlideX = 0;
            for (int j = 0; j < N; j++)
            {
                // Draw left border
                g.DrawLine(p, 0, SlideX, 0, SlideX + WidthY);
                SlideX += WidthX;
            }

            SlideY = 0;
            SlideX = 0;
            Labirint = new cell[1, M];
            Random rand = new Random();
            Int32 res;
            Int32 k = 0;
            Int32 Used_K = 0;


            Init_Labirint(Labirint, M);

            Stopwatch stWtch = new Stopwatch();
            stWtch.Start();

            for (int i = 0; i < N; i++)
            {
                //Init sliding by X
                SlideX = 0;

                // If it's not a first row
                if (i != 0)
                {
                    //Clone last row to next row
                    for (int j = 0; j < M; j++)
                    {
                        if (Labirint[0, j].left && j != 0)
                            Labirint[0, j].left = false;
                        if (Labirint[0, j].right && j != M - 1)
                            Labirint[0, j].right = false;
                    }
                }

                // Init cells set
                // If cell without set(множество)
                // Init his own new set
                for (int j = 0; j < M; j++)
                    if (Labirint[0, j].value == 0)
                    {
                        Labirint[0, j].value = j + 1 + M * i;
                        Labirint[0, j].bottom = false;
                    }

                // Make right border between cells
                for (int j = 0; j < M - 1; j++)
                {
                    res = rand.Next(2);

                    if (res == 0)
                    {
                        // If   ====  two cells from one set ==> we must make border between them, and divide cell
                        // because we dont need cycle

                        if (Labirint[0, j].value == Labirint[0, j + 1].value)
                        {
                            Labirint[0, j].right = true;
                            Labirint[0, j + 1].left = true;

                            //---------------Drawing-----------------
                            //Draw right wall
                            g.DrawLine(p, SlideX + WidthY, SlideY, SlideX + WidthY, SlideY + WidthY);

                        }
                        // Else ====  Merge two sets to one set
                        else
                        {
                            Int32 tempVal = 0;
                            tempVal = Labirint[0, j + 1].value;
                            Labirint[0, j + 1].value = Labirint[0, j].value;
                            for (int q = 0; q < M; q++)
                                if (Labirint[0, q].value == tempVal)
                                    Labirint[0, q].value = Labirint[0, j].value;
                        }
                    }
                    else
                    {
                        // res == 1 (random)
                        // Make border between cells
                        Labirint[0, j].right = true;
                        Labirint[0, j + 1].left = true;

                        //---------------Drawing-----------------
                        //Draw right wall
                        g.DrawLine(p, SlideX + WidthY, SlideY, SlideX + WidthY, SlideY + WidthY);
                    }
                    SlideX += WidthX;
                }
                //---------------Drawing-----------------
                //Draw right wall for last cell 
                g.DrawLine(p, SlideX + WidthY, SlideY, SlideX + WidthY, SlideY + WidthY);
                SlideX = 0;

                // Make bottom border
                // Not for last cell
                if (i != N - 1)
                    for (int j = 0; j < M; j++)
                    {
                        res = rand.Next(2);

                        // k      - count of meeted cells
                        // Used_k - count of cells that have bottom border

                        // If we loop through new set
                        // init k and Used_k
                        if (j != 0)
                        {
                            if (Labirint[0, j].left && Labirint[0, j].value != Labirint[0, j - 1].value)
                            {
                                k = 0; Used_K = 0;
                            }
                        }
                        // for first cell. 
                        // Labirint[0, j].left && Labirint[0, j].value != Labirint[0, j - 1].value
                        // Did this else for avoiding OUTOFRANGE Exception
                        else
                        {
                            k = 0;
                            Used_K = 0;
                        }

                        k++;

                        if (res == 1)

                            //  k > Used_K            - we can add bottom border if we have at least one cell without bottom border in this cell

                            if (j == M - 1)
                            {
                                // for last cell. 
                                // Labirint[0, j].value == Labirint[0, j + 1].value
                                // Did this else for avoiding OUTOFRANGE Exception
                                if (k - 1 > Used_K)
                                {
                                    Labirint[0, j].bottom = true;
                                    Labirint[0, j].value = 0;
                                    Used_K++;

                                    //---------------Drawing-----------------
                                    //Draw bottom wall
                                    g.DrawLine(p, SlideX, SlideY + WidthY, SlideX + WidthX, SlideY + WidthY);

                                }
                            }
                            else
                                if (Labirint[0, j].value == Labirint[0, j + 1].value || k - 1 > Used_K)
                                {
                                    Labirint[0, j].bottom = true;
                                    Labirint[0, j].value = 0;
                                    Used_K++;

                                    //---------------Drawing-----------------
                                    //Draw bottom wall
                                    g.DrawLine(p, SlideX, SlideY + WidthY, SlideX + WidthX, SlideY + WidthY);

                                }
                        SlideX += WidthX;
                    }
                //Last cell, we need to end generating
                else
                {
                    SlideX = 0;

                    for (int j = 0; j < M - 1; j++)
                    {
                        // If cells are from different sets --> destroy wall
                        // and union sets
                        if (Labirint[0, j].value != Labirint[0, j + 1].value)
                        {
                            Labirint[0, j].right = false;
                            Labirint[0, j + 1].left = false;

                            //---------------Drawing-----------------
                            //Destroy right wall
                            g.DrawLine(new Pen(BackColor), SlideX + WidthY, SlideY, SlideX + WidthY, SlideY + WidthY);

                            //Union sets!!
                            Int32 tempVal = 0;
                            tempVal = Labirint[0, j + 1].value;
                            Labirint[0, j + 1].value = Labirint[0, j].value;
                            for (int q = 0; q < M; q++)
                                if (Labirint[0, q].value == tempVal)
                                    Labirint[0, q].value = Labirint[0, j].value;
                        }
                        //---------------Drawing-----------------
                        //Foreach cell draww bottom wall
                        g.DrawLine(p, SlideX, SlideY + WidthY, SlideX + WidthX, SlideY + WidthY);

                        SlideX += WidthX;
                    }
                    //---------------Drawing-----------------
                    // For last cell
                    g.DrawLine(p, SlideX, SlideY + WidthY, SlideX + WidthX, SlideY + WidthY);
                }

                SlideY += WidthX;
            }

            stWtch.Stop();

            lb_speed.Text = "Time of generating: " + stWtch.Elapsed.ToString();
            lb_memory.Text = "Memory used: " + GetObjectSize(Labirint).ToString() + " bytes";
            pb_Draw.Image = bmp;
        }

        private static void Init_Labirint(cell[,] Labirint, int M)
        {
            for (int j = 0; j < M; j++)
                Labirint[0, j] = new cell();

            Labirint[0, 0].left = true;
            Labirint[0, M - 1].right = true;


        }

        private void tb_N_ValueChanged(object sender, EventArgs e)
        {
            lb_N.Text = "N: " + tb_N.Value;
            this.N = tb_N.Value;
        }

        private void tb_M_ValueChanged(object sender, EventArgs e)
        {
            lb_M.Text = "M: " + tb_M.Value;
            this.M = tb_M.Value;
        }


        public static int GetObjectSize(object testObject)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            byte[] Array;
            bf.Serialize(ms, testObject);
            Array = ms.ToArray();
            return Array.Length;
        }

        private async void btn_solve_Click(object sender, EventArgs e)
        {
            Stopwatch stwtch = new Stopwatch();
            stwtch.Start();
            l_state.Visible = true;
            inUse = true;
            btn_solve.Enabled = false;
            btn_genere.Enabled = false;
            var t = SolveMaze(bmp, StartEnd[0], StartEnd[1]);


        }

        private void pb_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!inUse)
            {

                // if maze area
                if ((e.Y < WidthY * N) &&
                    (e.X < WidthX * M))
                {
                    //Clean all cells
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            if (bmp.GetPixel(WidthX * j + 1, WidthY * i + 1).ToArgb() == Color.Gray.ToArgb())
                                g.FillRectangle(new SolidBrush(this.BackColor), WidthX * j + 1, WidthY * i + 1, WidthX - 1, WidthY - 1);
                        }
                    }

                    //Mark current cell
                    g.FillRectangle(new SolidBrush(Color.Gray), e.X - e.X % WidthX + 1, e.Y - e.Y % WidthY + 1, WidthX - 1, WidthY - 1);
                    pb_Draw.Image = bmp;
                }
                // if we leave maze area
                else
                {
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            if (bmp.GetPixel(WidthX * j + 1, WidthY * i + 1).ToArgb() == Color.Gray.ToArgb())
                                g.FillRectangle(new SolidBrush(this.BackColor), WidthX * j + 1, WidthY * i + 1, WidthX - 1, WidthY - 1);
                        }
                    }

                    pb_Draw.Image = bmp;

                    return;
                }
            }
        }

        private void pb_Draw_Click(object sender, EventArgs e)
        {
            if (!inUse)
            {
                MouseEventArgs me = (MouseEventArgs)e;


                //Left
                if ((me.X < WidthX && me.Y < WidthY * N))
                {
                    //if it's cells is not used
                    if (bmp.GetPixel(0, me.Y - me.Y % WidthY + 1).ToArgb() == Color.Black.ToArgb())
                    {

                        //if we dont already have 2 open cells
                        if (btn_clicks != 2)
                        {
                            g.DrawLine(new Pen(BackColor), 0, me.Y - me.Y % WidthY,
                               0, me.Y - me.Y % WidthY + WidthY);
                            if (StartEnd[0] == default(Point))
                                StartEnd[0] = new Point(0, me.Y - me.Y % WidthY);
                            else if (StartEnd[1] == default(Point))
                                StartEnd[1] = new Point(0, me.Y - me.Y % WidthY);
                            else
                                StartEnd[btn_clicks] = new Point(0, me.Y - me.Y % WidthY);

                            btn_clicks++;
                        }
                    }
                    //if cell in use, deactivate this cell
                    else
                    {


                        g.DrawLine(new Pen(Color.Black), 0, me.Y - me.Y % WidthY,
                         0, me.Y - me.Y % WidthY + WidthY);
                        btn_clicks--;
                        for (int i = 0; i < StartEnd.Length; i++)
                        {
                            if (new Point(me.X - me.X % WidthY, me.Y - me.Y % WidthY) == StartEnd[i])
                            {

                                StartEnd[i] = default(Point);
                                break;
                            }
                        }


                    }
                }
                else
                    //top
                    if (me.Y < WidthY && me.X < WidthX * M)
                    {
                        if (bmp.GetPixel(me.X - me.X % WidthX + 1, 0).ToArgb() == Color.Black.ToArgb())
                        {
                            if (btn_clicks != 2)
                            {
                                g.DrawLine(new Pen(BackColor), me.X - me.X % WidthX, 0,
                                                               me.X - me.X % WidthX + WidthX, 0);

                                if (StartEnd[0] == default(Point))
                                    StartEnd[0] = new Point(me.X - me.X % WidthX, 0);
                                else if (StartEnd[1] == default(Point))
                                    StartEnd[1] = new Point(me.X - me.X % WidthX, 0);
                                else
                                    StartEnd[btn_clicks] = new Point(me.X - me.X % WidthX, 0);

                                btn_clicks++;
                            }

                        }
                        else
                        {
                            g.DrawLine(new Pen(Color.Black), me.X - me.X % WidthX, 0,
                                                             me.X - me.X % WidthX + WidthX, 0);



                            btn_clicks--;
                            for (int i = 0; i < StartEnd.Length; i++)
                            {
                                if (new Point(me.X - me.X % WidthY, me.Y - me.Y % WidthY) == StartEnd[i])
                                {

                                    StartEnd[i] = default(Point);
                                    break;
                                }
                            }
                        }

                    }
                    else
                        // Right
                        if (me.X > WidthX * (M - 1) && (me.X < WidthX * M) && me.Y < WidthY * N)
                        {
                            if (bmp.GetPixel(WidthX * M, me.Y + (WidthY - me.Y % WidthY) - 1).ToArgb() == Color.Black.ToArgb())
                            {
                                if (!left)
                                {
                                    left = true;

                                    if (btn_clicks != 2)
                                    {
                                        g.DrawLine(new Pen(BackColor), WidthX * M, me.Y - me.Y % WidthY,
                                                                       WidthX * M, me.Y - me.Y % WidthY + WidthY);

                                        if (StartEnd[0] == default(Point))
                                            StartEnd[0] = new Point(WidthX * M, me.Y - me.Y % WidthY);
                                        else if (StartEnd[1] == default(Point))
                                            StartEnd[1] = new Point(WidthX * M, me.Y - me.Y % WidthY);
                                        else
                                            StartEnd[btn_clicks] = new Point(WidthX * M, me.Y - me.Y % WidthY);



                                        btn_clicks++;
                                    }
                                }

                            }
                            else
                            {
                                g.DrawLine(new Pen(Color.Black), WidthX * M, me.Y - me.Y % WidthY,
                                                                 WidthX * M, me.Y - me.Y % WidthY + WidthY);

                                left = false;

                                btn_clicks--;

                                for (int i = 0; i < StartEnd.Length; i++)
                                {
                                    if (new Point(me.X - me.X % WidthY, me.Y - me.Y % WidthY) == StartEnd[i])
                                    {

                                        StartEnd[i] = default(Point);
                                        break;
                                    }
                                }
                            }


                        }
                        else
                            // Bottom
                            if (me.Y > WidthY * (N - 1) && (me.Y < WidthY * N) && me.X < WidthX * M)
                            {
                                if (bmp.GetPixel(me.X + (WidthX - me.X % WidthX) - 1, WidthY * N).ToArgb() == Color.Black.ToArgb())
                                {
                                    if (btn_clicks != 2)
                                    {
                                        g.DrawLine(new Pen(BackColor), me.X - me.X % WidthX, WidthY * N,
                                                                       me.X - me.X % WidthX + WidthY, WidthY * N);

                                        if (StartEnd[0] == default(Point))
                                            StartEnd[0] = new Point(me.X - me.X % WidthX, WidthY * (N - 1));
                                        else if (StartEnd[1] == default(Point))
                                            StartEnd[1] = new Point(me.X - me.X % WidthX, WidthY * (N - 1));
                                        else
                                            StartEnd[btn_clicks] = new Point(me.X - me.X % WidthX, WidthY * (N - 1));



                                        btn_clicks++;


                                    }

                                }
                                else
                                {
                                    g.DrawLine(new Pen(Color.Black), me.X - me.X % WidthX, WidthY * N,
                                                                     me.X - me.X % WidthX + WidthY, WidthY * N);
                                    btn_clicks--;

                                    for (int i = 0; i < StartEnd.Length; i++)
                                    {
                                        if (new Point(me.X - me.X % WidthY, me.Y - me.Y % WidthY) == StartEnd[i])
                                        {
                                            StartEnd[i] = default(Point);
                                            break;
                                        }

                                    }
                                }


                            }
                if (btn_clicks == 2)
                {
                    if (StartEnd[0].X > StartEnd[1].X)
                    {
                        var temp = StartEnd[1];
                        StartEnd[1] = StartEnd[0];
                        StartEnd[0] = temp;
                    }


                    btn_solve.Enabled = true;
                }
                else
                {
                    btn_solve.Enabled = false;
                }
                pb_Draw.Image = bmp;
            }

        }

        private async Task SolveMaze(Bitmap bmp, Point Start, Point End)
        {
            Stopwatch stwtch = new Stopwatch();
            stwtch.Start();
            try
            {

                await _SolveMaze(bmp, Start, End);

            }
            catch (ThreadInterruptedException) { }
            stwtch.Stop();

            label1.Text = "Time of solving: " + stwtch.Elapsed;
        }

        private async Task _SolveMaze(Bitmap p_bmp, Point Start, Point End)
        {
            await Task.Delay(5);
            {
                if (Start == End)
                {
                    if (this.l_state.InvokeRequired)
                    {
                        dSetVisible d = new dSetVisible(SetVisible);
                        this.Invoke(d, new object[] { });

                    }
                    else
                        this.l_state.Visible = false;

                    if (this.btn_solve.InvokeRequired)
                    {
                        dSetEnabling d = new dSetEnabling(delegate { btn_solve.Enabled = true; });
                        this.Invoke(d, new object[] { });
                    }
                    else
                        this.btn_solve.Enabled = true;

                    if (this.btn_genere.InvokeRequired)
                    {
                        dSetEnabling d = new dSetEnabling(delegate { btn_genere.Enabled = true; });
                        this.Invoke(d, new object[] { });
                    }
                    else
                        this.btn_genere.Enabled = true;

                    pb_Draw.Image = p_bmp;

                    throw new ThreadInterruptedException();

                    return;

                }



                {
                    Bitmap Solve_bmp = p_bmp.Clone(new Rectangle(0, 0, p_Width, p_Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    Graphics g = Graphics.FromImage(Solve_bmp);


                    //Move to bottom
                    if (Start.Y + 3 * WidthY / 2 <= pb_Draw.Height)
                        if (Solve_bmp.GetPixel(Start.X + WidthX / 2, Start.Y + WidthY).ToArgb() == BackColor.ToArgb() &&
                            Solve_bmp.GetPixel(Start.X + WidthX / 2, Start.Y + 3 * WidthY / 2).ToArgb() != Color.Gray.ToArgb()
                            )
                        {

                            g.FillRectangle(new SolidBrush(Color.Gray), Start.X + 1, Start.Y + 1, WidthX - 1, WidthY - 1);
                            pb_Draw.Image = Solve_bmp;
                            await _SolveMaze(Solve_bmp, new Point(Start.X, Start.Y + WidthY), End);


                        }
                    //Move to right
                    if (Start.X + 3 * WidthX / 2 < pb_Draw.Width)
                        if (Solve_bmp.GetPixel(Start.X + WidthX, Start.Y + WidthY / 2).ToArgb() == BackColor.ToArgb() &&
                            Solve_bmp.GetPixel(Start.X + 3 * WidthX / 2, Start.Y + WidthY / 2).ToArgb() != Color.Gray.ToArgb()
                            )
                        {

                            g.FillRectangle(new SolidBrush(Color.Gray), Start.X + 1, Start.Y + 1, WidthX - 1, WidthY - 1);
                            pb_Draw.Image = Solve_bmp;
                            await _SolveMaze(Solve_bmp, new Point(Start.X + WidthY, Start.Y), End);


                        }


                    //Move to left
                    if (Start.X - WidthX / 2 > 0)
                        if (Solve_bmp.GetPixel(Start.X, Start.Y + WidthY / 2).ToArgb() == BackColor.ToArgb() &&
                            Solve_bmp.GetPixel(Start.X - WidthX / 2, Start.Y + WidthY / 2).ToArgb() != Color.Gray.ToArgb()
                            )
                        {

                            g.FillRectangle(new SolidBrush(Color.Gray), Start.X + 1, Start.Y + 1, WidthX - 1, WidthY - 1);
                            pb_Draw.Image = Solve_bmp;
                            await _SolveMaze(Solve_bmp, new Point(Start.X - WidthX, Start.Y), End);


                        }

                    //Move to top
                    if (Start.Y - WidthY / 2 > 0)
                        if (Solve_bmp.GetPixel(Start.X + WidthX / 2, Start.Y).ToArgb() == BackColor.ToArgb() &&
                            Solve_bmp.GetPixel(Start.X + WidthX / 2, Start.Y - WidthY / 2).ToArgb() != Color.Gray.ToArgb()
                            )
                        {

                            g.FillRectangle(new SolidBrush(Color.Gray), Start.X + 1, Start.Y + 1, WidthX - 1, WidthY - 1);
                            pb_Draw.Image = Solve_bmp;
                            await _SolveMaze(Solve_bmp, new Point(Start.X, Start.Y - WidthY), End);


                        }

                }

            }
        }

        private void SetVisible()
        {
            l_state.Visible = false;
        }

        private void pb_Draw_MouseLeave(object sender, EventArgs e)
        {
            if (!inUse)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (bmp.GetPixel(WidthX * j + 1, WidthY * i + 1).ToArgb() == Color.Gray.ToArgb())
                            g.FillRectangle(new SolidBrush(this.BackColor), WidthX * j + 1, WidthY * i + 1, WidthX - 1, WidthY - 1);
                    }
                }
                pb_Draw.Image = bmp;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main newForm = new Main();
            newForm.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (isActivated)
            {
                btn_solve.Enabled = true;
            }
            else
            {
                btn_solve.Enabled = false;
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_Draw.Image = bmp;
            inUse = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
