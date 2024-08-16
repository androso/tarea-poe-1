namespace CalculadoraDeAreaUI
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            alturaLadoLabel = new Label();
            baseLabel = new Label();
            alturaLadoTextBox = new TextBox();
            baseTextBox = new TextBox();
            calcularButton = new Button();
            resultadoLabel = new Label();
            tittleLabel = new Label();
            ladoAlturaLabel = new Label();
            baseRectLabel = new Label();
            resultAreaLabel = new Label();
            ladoAlturaTextBox = new TextBox();
            baseRectTextBox = new TextBox();
            resultButton = new Button();
            resultPerimetroLabel = new Label();
            ladoTextBox = new TextBox();
            ladoLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(111, 9);
            titleLabel.Margin = new Padding(5, 0, 5, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(680, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "CALCULADORA DE AREA Y PERIMETRO PARA RECTANGULO Y HEPTAGONO";
            // 
            // alturaLadoLabel
            // 
            alturaLadoLabel.AutoSize = true;
            alturaLadoLabel.Location = new Point(182, 71);
            alturaLadoLabel.Name = "alturaLadoLabel";
            alturaLadoLabel.Size = new Size(120, 25);
            alturaLadoLabel.TabIndex = 1;
            alturaLadoLabel.Text = "Altura/Lado: ";
            alturaLadoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // baseLabel
            // 
            baseLabel.AutoSize = true;
            baseLabel.Location = new Point(148, 140);
            baseLabel.Name = "baseLabel";
            baseLabel.Size = new Size(154, 25);
            baseLabel.TabIndex = 2;
            baseLabel.Text = "Base Rectangulo:";
            baseLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // alturaLadoTextBox
            // 
            alturaLadoTextBox.BorderStyle = BorderStyle.FixedSingle;
            alturaLadoTextBox.Location = new Point(322, 71);
            alturaLadoTextBox.Name = "alturaLadoTextBox";
            alturaLadoTextBox.PlaceholderText = "Ingrese el dato";
            alturaLadoTextBox.Size = new Size(243, 23);
            alturaLadoTextBox.TabIndex = 3;
            // 
            // baseTextBox
            // 
            baseTextBox.BorderStyle = BorderStyle.FixedSingle;
            baseTextBox.Location = new Point(322, 132);
            baseTextBox.Name = "baseTextBox";
            baseTextBox.PlaceholderText = "Ingrese el dato";
            baseTextBox.Size = new Size(243, 23);
            baseTextBox.TabIndex = 4;
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(0, 0);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(75, 23);
            calcularButton.TabIndex = 0;
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultadoLabel.Location = new Point(443, 251);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(0, 25);
            resultadoLabel.TabIndex = 6;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.Location = new Point(247, 9);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(339, 25);
            tittleLabel.TabIndex = 0;
            tittleLabel.Text = "CALCULADORA DE AREA Y PERIMETRO";
            // 
            // ladoAlturaLabel
            // 
            ladoAlturaLabel.AutoSize = true;
            ladoAlturaLabel.Location = new Point(202, 47);
            ladoAlturaLabel.Name = "ladoAlturaLabel";
            ladoAlturaLabel.Size = new Size(67, 25);
            ladoAlturaLabel.TabIndex = 1;
            ladoAlturaLabel.Text = "Altura:";
            // 
            // baseRectLabel
            // 
            baseRectLabel.AutoSize = true;
            baseRectLabel.Location = new Point(202, 99);
            baseRectLabel.Name = "baseRectLabel";
            baseRectLabel.Size = new Size(55, 25);
            baseRectLabel.TabIndex = 2;
            baseRectLabel.Text = "Base:";
            // 
            // resultAreaLabel
            // 
            resultAreaLabel.AutoSize = true;
            resultAreaLabel.Location = new Point(202, 256);
            resultAreaLabel.Name = "resultAreaLabel";
            resultAreaLabel.Size = new Size(0, 25);
            resultAreaLabel.TabIndex = 3;
            // 
            // ladoAlturaTextBox
            // 
            ladoAlturaTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            ladoAlturaTextBox.Location = new Point(323, 47);
            ladoAlturaTextBox.Name = "ladoAlturaTextBox";
            ladoAlturaTextBox.PlaceholderText = "Usar si es rectangulo ";
            ladoAlturaTextBox.Size = new Size(263, 29);
            ladoAlturaTextBox.TabIndex = 4;
            // 
            // baseRectTextBox
            // 
            baseRectTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            baseRectTextBox.Location = new Point(323, 99);
            baseRectTextBox.Name = "baseRectTextBox";
            baseRectTextBox.PlaceholderText = "Usar si es rectangulo ";
            baseRectTextBox.Size = new Size(263, 29);
            baseRectTextBox.TabIndex = 5;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(323, 195);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(263, 36);
            resultButton.TabIndex = 6;
            resultButton.Text = "Calcular";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // resultPerimetroLabel
            // 
            resultPerimetroLabel.AutoSize = true;
            resultPerimetroLabel.Location = new Point(202, 313);
            resultPerimetroLabel.Name = "resultPerimetroLabel";
            resultPerimetroLabel.Size = new Size(0, 25);
            resultPerimetroLabel.TabIndex = 7;
            // 
            // ladoTextBox
            // 
            ladoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            ladoTextBox.Location = new Point(323, 145);
            ladoTextBox.Name = "ladoTextBox";
            ladoTextBox.PlaceholderText = "Usar si es heptagono";
            ladoTextBox.Size = new Size(263, 29);
            ladoTextBox.TabIndex = 9;
            // 
            // ladoLabel
            // 
            ladoLabel.AutoSize = true;
            ladoLabel.Location = new Point(84, 153);
            ladoLabel.Name = "ladoLabel";
            ladoLabel.Size = new Size(185, 25);
            ladoLabel.TabIndex = 8;
            ladoLabel.Text = "Lado del heptagono:";
            // 
            // Calculadora
            // 
            ClientSize = new Size(791, 347);
            Controls.Add(ladoTextBox);
            Controls.Add(ladoLabel);
            Controls.Add(resultPerimetroLabel);
            Controls.Add(resultButton);
            Controls.Add(baseRectTextBox);
            Controls.Add(ladoAlturaTextBox);
            Controls.Add(resultAreaLabel);
            Controls.Add(baseRectLabel);
            Controls.Add(ladoAlturaLabel);
            Controls.Add(tittleLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label alturaLadoLabel;
        private Label baseLabel;
        private TextBox alturaLadoTextBox;
        private TextBox baseTextBox;
        private Button calcularButton;
        private Label resultadoLabel;
        private Label tittleLabel;
        private Label ladoAlturaLabel;
        private Label baseRectLabel;
        private Label resultAreaLabel;
        private TextBox ladoAlturaTextBox;
        private TextBox baseRectTextBox;
        private Button resultButton;
        private Label resultPerimetroLabel;
        private TextBox ladoTextBox;
        private Label ladoLabel;
    }
}
