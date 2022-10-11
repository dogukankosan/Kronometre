using System;
using System.Windows.Forms;
namespace FormStudent
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private byte saat = default, dakika = default, saniye = default;
        void ButtonStart()
        {
            timer1.Start();
            Btn_Start.Enabled = false;
            Btn_Stop.Enabled = true;
            Btn_Reflesh.Enabled = true;
        }
        void ButtonStop()
        {
            timer1.Stop();
            Btn_Stop.Enabled = false;
            Btn_Start.Enabled = true;
        }
        void ButtonReflesh()
        {
            saat = default;
            dakika = default;
            saniye = default;
            lbl_Krotext.Text = "0";
            Btn_Start.Enabled = true;
            timer1.Stop();
            Btn_Stop.Enabled = false;
            Btn_Reflesh.Enabled = false;
        }
        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ButtonStart();
            else if (e.KeyCode == Keys.F3)
                ButtonStop();
            else if (e.KeyCode == Keys.F5)
                ButtonReflesh();
            else if(e.KeyCode==Keys.Escape)
                Application.Exit();
        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            ButtonStart();
        }
        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            ButtonStop();
        }
        private void Btn_Reflesh_Click(object sender, EventArgs e)
        {
            ButtonReflesh();
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Stop();
            Btn_Reflesh.Enabled = false;
            Btn_Stop.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                saniye = default;
                dakika++;
                if (dakika == 60)
                {
                    dakika = default;
                    saat++;
                    if (saat == 24)
                        saat = default;
                }
            }
            lbl_Krotext.Text = string.Concat(saat.ToString().PadLeft(2,'0'), ":", dakika.ToString().PadLeft(2, '0'), ":", saniye.ToString().PadLeft(2, '0'));
        }
    }
}