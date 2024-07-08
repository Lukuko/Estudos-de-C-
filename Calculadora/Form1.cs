namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double numberOne;
        double numberTwo;
        int Op;
        public Calculadora()
        {
            InitializeComponent();
            this.Text = "Calculadora";
        }



        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text = "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Op = 1;

        }
        private void button14_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Op = 2;

        }
        private void button15_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Op = 3;

        }
        private void button16_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Op = 4;

        }
        private void button10_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Op = 5;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Op = 6;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            numberOne = Convert.ToDouble(textBox1.Text);
            double sqrtResult;
            if (textBox1.Text != "0")
            {
                sqrtResult = Math.Sqrt(numberOne);
                textBox1.Text = $"{sqrtResult}";
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            double negativeNumber;
            numberOne = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                negativeNumber = numberOne * -1;
                textBox1.Text = $"{negativeNumber}";
            }
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double result;

            numberTwo = Convert.ToDouble(textBox1.Text);
            switch (Op)
            {
                case 1:
                    result = (numberOne + numberTwo);

                    textBox1.Text = $"{result}";
                    break;
            }
        }

        }
    }

