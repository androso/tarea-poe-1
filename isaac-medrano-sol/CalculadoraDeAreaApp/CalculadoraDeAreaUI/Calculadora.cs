namespace CalculadoraDeAreaUI
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        public class Rectangulo
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public double CalcularArea()
            {
                return Base * Altura;
            }
            public double CalcularPerimetro()
            {
                return 2 * (Base + Altura);
            }
        }
        public class Heptagono
        {
            public double Lado { get; set; }
            public double CalcularArea()
            {
                double apotema = Lado / (2 * Math.Tan(Math.PI / 7));
                return (7 * Lado * apotema) / 2;
            }
            public double CalcularPerimetro()
            {
                return 7 * Lado;
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            try
            {
                //En caso de otro click, limpiar los labels de area y perimetro. 
                resultAreaLabel.Text = string.Empty;
                resultPerimetroLabel.Text = string.Empty;

                // Verificar si se ingresaron valores para el rectángulo
                if (!string.IsNullOrWhiteSpace(ladoAlturaTextBox.Text) &&
                    !string.IsNullOrWhiteSpace(baseRectTextBox.Text))
                {
                    double alturaRectangulo = double.Parse(ladoAlturaTextBox.Text);
                    double baseRectangulo = double.Parse(baseRectTextBox.Text);
                    Rectangulo rectangulo = new Rectangulo
                    {
                        Altura = alturaRectangulo,
                        Base = baseRectangulo
                    };
                    double areaRectangulo = rectangulo.CalcularArea();
                    double perimetroRectangulo = rectangulo.CalcularPerimetro();
                    resultAreaLabel.Text = $"El Área del rectángulo de base: {rectangulo.Base} y Altura: {rectangulo.Altura} es:\n {areaRectangulo.ToString()} unidades al cuadrado";
                    resultPerimetroLabel.Text = $"El Perímetro del rectángulo de base: {rectangulo.Base} y Altura: {rectangulo.Altura} es: {perimetroRectangulo.ToString()}";
                }

                // Verificar si se ingresó un valor para el heptágono
                if (!string.IsNullOrWhiteSpace(ladoTextBox.Text))
                {
                    double ladoHeptagono = double.Parse(ladoTextBox.Text);
                    Heptagono heptagono = new Heptagono
                    {
                        Lado = ladoHeptagono
                    };
                    double areaHeptagono = Math.Round(heptagono.CalcularArea(), 4);
                    double perimetroHeptagono = heptagono.CalcularPerimetro();
                    
                    resultAreaLabel.Text += $"El área del Heptágono de lado: {heptagono.Lado} es: {areaHeptagono.ToString()}";
                    resultPerimetroLabel.Text += $"El perímetro del Heptágono de lado: {heptagono.Lado} es: {perimetroHeptagono.ToString()}";
                    
                }

                // Manejar el caso en que no se ingresa nada
                if (string.IsNullOrWhiteSpace(ladoAlturaTextBox.Text) &&
                    string.IsNullOrWhiteSpace(baseRectTextBox.Text) &&
                    string.IsNullOrWhiteSpace(ladoTextBox.Text))
                {
                    MessageBox.Show("Por favor, ingrese al menos un valor para calcular.");
                }
                //Se limpian los textBox como medida si se quiere hacer otros calculos
                ladoTextBox.Text = string.Empty;
                baseRectTextBox.Text = string.Empty;
                ladoAlturaTextBox.Text = string.Empty;
            }
            catch (FormatException)
            {
                //si se ingresan valores errores igualmente seran borrados del textbox
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
                ladoTextBox.Text = string.Empty;
                baseRectTextBox.Text = string.Empty;
                ladoAlturaTextBox.Text = string.Empty;
            }

        }


        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

    }
}
