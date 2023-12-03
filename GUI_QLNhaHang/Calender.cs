using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLNhaHang;


namespace GUI_QLNhaHang
{
    public partial class Calender : Form
    {
        #region Peoperties
        private List<List<Button>> matrix;
        private List<string> dateOfWeek = new List<string>(){ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public static int dateButtonWidth = 56;
        public static int dateButtonHeight = 40;
        public static int margin = 5;

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        public Calender()
        {
            InitializeComponent();
            LoadMatrix();
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-margin, 0) };
            for (int i = 0; i < 6; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < 7; j++)
                {
                    Button btn = new Button() { Width = dateButtonWidth, Height = dateButtonHeight };
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width + margin, oldbtn.Location.Y);

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldbtn = btn;
                }
                oldbtn = new Button() { Width = 0, Height = 0, Location = new Point(-margin, oldbtn.Location.Y + dateButtonHeight) };
            }
            SetDefaultDate();
        }
        int DayOfMonth(DateTime date) 
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.DayOfYear % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0 )
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                default:
                    return 30;
            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());

                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.PeachPuff;
                }

                if (column >= 6)
                {
                    line++;
                }

                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        void SetDefaultDate()
        {
            dtpDate.Value = DateTime.Now;
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddMonths(1);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddMonths(-1);
        }
    }
}
