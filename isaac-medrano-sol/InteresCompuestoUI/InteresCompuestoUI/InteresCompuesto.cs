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
            public int A�os { get; set; }

            public Interes(double capitalInicial, double tasaInteres, int capitalizacionAnual, int a�os)
            {
                CapitalInicial = capitalInicial;
                TasaInteres = tasaInteres / 100; // Convertir a decimal
                CapitalizacionAnual = capitalizacionAnual;
                A�os = a�os;
            }
            public double CalcularMontoTotal()
            {
                return CapitalInicial * Math.Pow((1 + TasaInteres / CapitalizacionAnual), (CapitalizacionAnual * A�os));
            }
        }
        private bool ValidarEntradas()
        {
            // Validar que los campos no est�n vac�os
            if (string.IsNullOrWhiteSpace(capitalTexBox.Text) ||
                string.IsNullOrWhiteSpace(interesTextBox.Text) ||
                string.IsNullOrWhiteSpace(capitalizacionTextBox.Text) ||
                string.IsNullOrWhiteSpace(a�osTextBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que las entradas sean n�meros v�lidos
            if (!double.TryParse(capitalTexBox.Text, out _) ||
                !double.TryParse(interesTextBox.Text, out _) ||
                !int.TryParse(capitalizacionTextBox.Text, out _) ||
                !int.TryParse(a�osTextBox.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese valores num�ricos v�lidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int formA�os = Convert.ToInt32(a�osTextBox.Text);


                Interes interesCompuesto = new Interes(formCapitalInicial, formTasaInteres, formCapitalizacion, formA�os);
                double montoTotal = interesCompuesto.CalcularMontoTotal();

                resultadoLabel.Text = $"El monto total acumulado es: {montoTotal:C}";
                capitalTexBox.Text = string.Empty;
                interesTextBox.Text = string.Empty;
                capitalizacionTextBox.Text = string.Empty;
                a�osTextBox.Text = string.Empty;
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores v�lidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capitalTexBox.Text = string.Empty;
                interesTextBox.Text = string.Empty;
                capitalizacionTextBox.Text = string.Empty;
                a�osTextBox.Text = string.Empty;
            }
            catch (Exception ex) // Captura cualquier otra excepci�n
            {
                MessageBox.Show($"Ocurri� un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capitalTexBox.Text = string.Empty;
                interesTextBox.Text = string.Empty;
                capitalizacionTextBox.Text = string.Empty;
                a�osTextBox.Text = string.Empty;
            }
        }

    }
}
