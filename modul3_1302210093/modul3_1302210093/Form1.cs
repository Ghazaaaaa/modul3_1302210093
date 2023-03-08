namespace modul3_1302210093
{
    public partial class Form1 : Form
    {
        int x = 0;
        string y = "";
        int angka1 = 0;
        int angka2 = 0;
        int keluar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txt.Text == "1")
            {
                txt.Text = "1";
            }
            else
            {
                txt.Text += "1";
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (txt.Text == "2")
            {
                txt.Text = "2";
            }
            else
            {
                txt.Text += "2";
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (txt.Text == "3")
            {
                txt.Text = "3";
            }
            else
            {
                txt.Text += "3";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txt.Text == "4")
            {
                txt.Text = "4";
            }
            else
            {
                txt.Text += "4";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (txt.Text == "5")
            {
                txt.Text = "5";
            }
            else
            {
                txt.Text += "5";
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (txt.Text == "6")
            {
                txt.Text = "6";
            }
            else
            {
                txt.Text += "6";
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (txt.Text == "7")
            {
                txt.Text = "7";
            }
            else
            {
                txt.Text += "7";
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (txt.Text == "8")
            {
                txt.Text = "8";
            }
            else
            {
                txt.Text += "8";
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (txt.Text == "9")
            {
                txt.Text = "9";
            }
            else
            {
                txt.Text += "9";
            }
        }
        
        private void button23_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "0";
            }
            else
            {
                txt.Text += "0";
            }
        }
      
        private void tambah_click(object sender, EventArgs e)
        {
            angka1 = int.Parse(button22.Text);
            txt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "1";
            }
            else
            {
                txt.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var arr = txt.Text.Split('+');
            var ans = 0;
            for(var i=0;i<arr.Length;i++) {
                ans += Convert.ToInt32(arr[i]);
            }
            txt.Text = ans.ToString();
        }
    }
}