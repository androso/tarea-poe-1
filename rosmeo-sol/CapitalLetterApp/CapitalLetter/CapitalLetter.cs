using System.Globalization;

namespace CapitalLetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            string inputSentence = inputTextBox.Text.Trim();

            if (string.IsNullOrEmpty(inputSentence))
            {
                MessageBox.Show("Por favor, introduce una oración.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (char c in inputSentence)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("La oración solo debe contener letras y espacios.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string resultSentence = textInfo.ToTitleCase(inputSentence.ToLower());

            
            resultLabel.Text = resultSentence;
            resultLabel.Visible = true;

            
            inputTextBox.Clear();
        }
    }
}
