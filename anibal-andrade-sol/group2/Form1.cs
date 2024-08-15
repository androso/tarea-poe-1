namespace group2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Trackbar default value
            trackBar1.Value = 1;
            label3.Text = "Selected Value: 1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            label3.Text = "Selected Value: " + trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (double.TryParse(input, out double number))
            {
                int power = trackBar1.Value;
                double result = Math.Pow(number, power);
                label4.Text = $"Resultado: {number} elevado a {power} es {result}";
            } else
            {
                MessageBox.Show("Por favor ingresa un numero base válido."); 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
