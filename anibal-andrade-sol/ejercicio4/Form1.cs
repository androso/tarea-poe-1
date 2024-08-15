namespace ejercicio4
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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isVowel(e.KeyChar))
            {
                MessageBox.Show("You pressed a vowel: " + e.KeyChar);
            }
        }
        private bool isVowel(char c )
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
        }
    }
}
