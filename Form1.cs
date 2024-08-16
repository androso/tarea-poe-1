namespace perfectNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkNumber_Click(object sender, EventArgs e)
        {

            int number;
            if (int.TryParse(textBoxNumber.Text, out number))

                if (IsPerfectNumber(number))
                {
                    resultNumber.Text = $"{number} is a Perfect number";
                }
                else
                {
                    resultNumber.Text = $"{number} is not a perfect number";
                }
            else
            {
                resultNumber.Text = "Please enter a valid number";
            }

        }
        private bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number && number != 0;
        }
    }
}
