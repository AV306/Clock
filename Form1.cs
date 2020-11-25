using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class ClockForm : Form
    {
        public ClockForm()
        {
            InitializeComponent();
        }

        DateTime StartTime; //um
        DateTime EndTime; //umm
        DateTime Clock; //this is a separate one for the clock function.
        TimeSpan Elapsed; //um well

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnclickable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wow, you actually managed to click it! I hope you didn't decompile the entire app to do it :P", "Wow!", MessageBoxButtons.OK, MessageBoxIcon.Error); //whee
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            EndTime = DateTime.Now;
            Elapsed = EndTime - StartTime;
            txtEnd.Text = EndTime.ToLongTimeString();
            txtElapsed.Text = Elapsed.Seconds.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //establish and print start time
            StartTime = DateTime.Now;
            txtStart.Text = StartTime.ToLongTimeString();
            txtEnd.Text = null;
            txtElapsed.Text = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock = DateTime.Now;
            textBox4.Text = Clock.ToLongTimeString();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = !(checkBox1.Checked);
        }
    }
}
