namespace _54_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number = 0;
        int money = 0;
        int T_25;
        int T_20;
        int T_5;
        int T_1;
        bool low = false;
        bool high = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "�s���I����";
            label1.Text = "�I�����B:";
            label2.Text = "�I���ﶵ:";
            label3.Text = "$25";
            label4.Text = "$20";
            label5.Text = "$5";
            label6.Text = "$1";
            r_1.Text = "�ּ̤ƶq�f��";
            r_2.Text = "�̦h���B�����f��";
            groupBox1.Text = "�I������";
            textBox1.Text = "41";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ���}XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void r_1_CheckedChanged(object sender, EventArgs e)
        {
            low = true;
        }

        private void r_2_CheckedChanged(object sender, EventArgs e)
        {
            high = true;
        }
        private void �I��CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            try
            {
                number = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("�п�J�����!");
                return;
            }

            if (low)
            {
                if (number / 25 == 0)
                {
                    textBox2.Text = (number / 25).ToString();
                    textBox3.Text = textBox4.Text = textBox5.Text = "";
                }
                else if (number / 20 == 0) 
                {
                    textBox3.Text = (number / 20).ToString();
                    textBox2.Text = textBox4.Text = textBox5.Text = "";
                }

                if (number < 50 || number <25) 
                {
                    textBox2.Text = "0";
                    textBox3.Text = (number / 20).ToString();
                    number -= number / 20 * 20;
                    textBox4.Text = (number / 5).ToString();
                    number -= number / 5 * 5;
                    textBox5.Text = (number / 1).ToString();
                    number -= number / 1;
                }
            }

            if (high)
            {
                textBox2.Text = (number / 25).ToString();
                number -= number / 25 * 25; 
                textBox3.Text = (number /20).ToString();
                number -= number / 20 * 20;
                textBox4.Text = (number / 5).ToString();
                number -= number / 5 * 5;
                textBox5.Text = (number / 1).ToString();
                number -= number / 1 ;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        } 
    }
}

