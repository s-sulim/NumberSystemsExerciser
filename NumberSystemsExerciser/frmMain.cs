using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberSystemsExerciser
{
    public partial class frmMain : Form
    {
        private Random random;
        private int totalSeconds = 30;
        private int currentNum;
        private static string DIGITS = "0123456789ABCDEF";
        public frmMain()
        {
            InitializeComponent();
            random = new Random();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            cbRandSystem.SelectedIndex = 0;
            cbInputSystem.SelectedIndex = 2;
            btnCheck.Visible = false;
        }
        private void btnGenerateNumber_Click(object sender, EventArgs e)
        {
            tbEnteredNum.BackColor = Color.White;
            tbEnteredNum.Text = "";
            totalSeconds = 30;
            NowGueessing(true);
            int bs = 0;
            switch (cbRandSystem.SelectedIndex)
            {
                case 0:
                    bs = 2;
                    break;
                case 1:
                    bs = 8;
                    break;
                case 2:
                    bs = 10;
                    break;
                case 3:
                    bs = 16;
                    break;
            }
            currentNum = random.Next(0, 64);
            tbGeneratedNum.Text = Decimal2Base(currentNum, bs);
            tmrCountdown.Start();
        }
        private string Decimal2Base(int num, int Base)
        {
            if (Base < 2 || Base > 16)
                return "Invalid range";
            if (num == 0)
                return "0";
          
            string result = "";
            while (num > 0)
            {
                int digit = num % Base;
                result= DIGITS[digit] + result;
                num /= Base;
            }
            return result;
        }
        private int Base2Decimal(string num, int Base)
        {
            var chars = num.Reverse();
            int Dec = 0;
            int pow = 0;

            foreach (char digit in chars)
            {
                var val = DIGITS.IndexOf(digit);
                Dec += val * Convert.ToInt32((Math.Pow(Base, pow)));
                pow++;
            }
            return Dec;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (tmrCountdown.Enabled)
            {
                int bs = 0;
                switch (cbInputSystem.SelectedIndex)
                {
                    case 0:
                        bs = 2;
                        break;
                    case 1:
                        bs = 8;
                        break;
                    case 2:
                        bs = 10;
                        break;
                    case 3:
                        bs = 16;
                        break;
                }
                if (Base2Decimal(tbEnteredNum.Text, bs) == currentNum)
                {
                    NowGueessing(false);
                    tbEnteredNum.BackColor = Color.LightGreen;
                    tmrCountdown.Stop();
                    
                    totalSeconds = 30;
                }
                else
                {
                    tbEnteredNum.BackColor = Color.Red;
                }
            }
        }
  
        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            totalSeconds--;
            lbdSecondsCountdown.Text = totalSeconds.ToString();

            if (totalSeconds > 15)
            {
                lbdSecondsCountdown.ForeColor = Color.Green;
            }
            else if (totalSeconds > 10)
            {
                lbdSecondsCountdown.ForeColor = Color.Orange;
            }
            else 
            {
                lbdSecondsCountdown.ForeColor = Color.Red;
            }
            if (totalSeconds == 0)
            {
                NowGueessing(false);
                tmrCountdown.Stop();
                lbdSecondsCountdown.Text = 0.ToString();
                MessageBox.Show(this, "Time is up!", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbEnteredNum_TextChanged(object sender, EventArgs e)
        {
            if (tbEnteredNum.Text.Length > 0)
            {
                btnCheck.Visible = true;
            }
            else
            {
                btnCheck.Visible = false;
            }
        }
        private void NowGueessing(bool state)
        {
            btnGenerateNumber.Visible = !state;
            cbInputSystem.Enabled = !state;
            cbRandSystem.Enabled = !state;
        }
    }
}
