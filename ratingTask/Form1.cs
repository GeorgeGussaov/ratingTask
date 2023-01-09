using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ratingTask
{
    public partial class FormMonthConverter : Form
    {
        public FormMonthConverter()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string monthNum = textBoxMonthNumber.Text;
            int intMonthNum = Convert.ToInt32(monthNum);
            if (intMonthNum > 12 || intMonthNum < 1)
            {
                listBoxInMonthDaysCnt.Items.Add("Выход за границы массива.");
                return;
            }
            int cntDays = 0;
            if (buttonOk.Enabled == true)
            {
                switch (monthNum)
                {
                    case "1": textBoxMonthName.Text = "Январь"; break;
                    case "2": textBoxMonthName.Text = "Февраль"; break;
                    case "3": textBoxMonthName.Text = "Март"; break;
                    case "4": textBoxMonthName.Text = "Апрель"; break;
                    case "5": textBoxMonthName.Text = "Май"; break;
                    case "6": textBoxMonthName.Text = "Июнь"; break;
                    case "7": textBoxMonthName.Text = "Июль"; break;
                    case "8": textBoxMonthName.Text = "Август"; break;
                    case "9": textBoxMonthName.Text = "Сентябрь"; break;
                    case "10": textBoxMonthName.Text = "Октябрь"; break;
                    case "11": textBoxMonthName.Text = "Ноябрь"; break;
                    case "12": textBoxMonthName.Text = "Декабрь"; break;
                }
                switch (monthNum)
                {
                    case "1":cntDays = 31; break;
                    case "2": cntDays = 28; break;
                    case "3": cntDays = 31; break;
                    case "4": cntDays = 30; break;
                    case "5": cntDays = 31; break;
                    case "6": cntDays = 30; break;
                    case "7": cntDays = 31; break;
                    case "8": cntDays = 31; break;
                    case "9": cntDays = 30; break;
                    case "10": cntDays = 31; break;
                    case "11": cntDays = 30; break;
                    case "12": cntDays = 31; break;
                }
                listBoxInMonthDaysCnt.Items.Add(textBoxMonthName.Text + " - " + cntDays);
            }
        }
    }
}
