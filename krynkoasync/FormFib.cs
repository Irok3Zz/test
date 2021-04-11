using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace krynkofibonacci
{
    public partial class FormFib : Form
    {
        public FormFib()
        {
            InitializeComponent();
        }


        delegate void delfib();

        void fibonacci()
        {
            if (richTextBoxVivod.Text != null)
                richTextBoxVivod.Text = null;
            int sum = 0, one = 1, two = 1;
            while (Convert.ToInt32(textTo.Text) >= sum)
            {
                richTextBoxVivod.Text += sum + " ";
                one = two;
                two = sum;
                sum = one + two;
            }
            
        }

        void indicatorworks()
        {
            labelIndicator.Text = "Работаю";
        }
        void indicatorfin()
        {
            labelIndicator.Text = "Закончил";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            delfib del = fibonacci;
            richTextBoxVivod.Invoke(del);
           
        }

        #region Test buttons
        private void buttonTest1_Click(object sender, EventArgs e)
        {
            labelTest.Text = "1";
        }
        private void buttonTest2_Click(object sender, EventArgs e)
        {
            labelTest.Text = "2";
        }
        #endregion

        private void FormFib_Load(object sender, EventArgs e)
        {

        }
    }
}
