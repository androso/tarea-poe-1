using System.Windows.Forms;

namespace InteresCompuestoUI
{
    public partial class InteresCompuesto : Form
    {
        public InteresCompuesto()
        {
            InitializeComponent();
            //calcularButton.Click += new EventHandler(calcularButton_Click);
        }
        public class Interes
        {
            public double CapitalInicial { get; set; }
            public double TasaInteres { get; set; }
            public int CapitalizacionAnual { get; set; }
            public int Años { get; set; }

            public Interes(double capitalInicial, double tasaInteres, int capitalizacionAnual, int años)
            {
                CapitalInicial = capitalInicial;
                TasaInteres = tasaInteres / 100; // Convertir a decimal
                CapitalizacionAnual = capitalizacionAnual;
                Años = años;
            }
            public double CalcularMontoTotal()
            {
                return CapitalInicial * Math.Pow((1 + TasaInteres / CapitalizacionAnual), (CapitalizacionAnual * Años));
            }
        }
        private bool ValidarEntradas()
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(capitalTexBox.Text) ||
                string.IsNullOrWhiteSpace(interesTextBox.Text) ||
                string.IsNullOrWhiteSpace(capitalizacionTextBox.Text) ||
                string.IsNullOrWhiteSpace(añosTextBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que las entradas sean números válidos
            if (!double.TryParse(capitalTexBox.Text, out _) ||
                !double.TryParse(interesTextBox.Text, out _) ||
                !int.TryParse(capitalizacionTextBox.Text, out _) ||
                !int.TryParse(añosTextBox.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando entradas
                if (!ValidarEntradas())
                    return;
                double formCapitalInicial = Convert.ToDouble(capitalTexBox.Text);
                double formTasaInteres = Convert.ToDouble(interesTextBox.Text);
                int formCapitalizacion = Convert.ToInt32(capitalTexBox.Text);
                int formAños = Convert.ToInt32(añosTextBox.Text);


                Interes interesCompuesto = new Interes(formCapitalInicial, formTasaInteres, formCapitalizacion, formAños);
                double montoTotal = interesCompuesto.CalcularMontoTotal();

                resultadoLabel.Text = $"El monto total acumulado es: {montoTotal:C}";
                capitalTexBox.Text = string.Empty;
                interesTextBox.Text = string.Empty;
                capitalizacionTextBox.Text = string.Empty;
                añosTextBox.Text = string.Empty;
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capitalTexBox.Text = string.Empty;
                interesTextBox.Text = string.Empty;
                capitalizacionTextBox.Text = string.Empty;
                añosTextBox.Text = string.Empty;
            }
            catch (Exception ex) // Captura cualquier otra excepción
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capitalTexBox.Text = string.Empty;
                interesTextBox.Text = string.Empty;
                capitalizacionTextBox.Text = string.Empty;
                añosTextBox.Text = string.Empty;
            }
        }

    }
}
