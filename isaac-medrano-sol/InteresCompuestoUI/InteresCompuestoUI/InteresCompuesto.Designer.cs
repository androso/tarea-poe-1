namespace InteresCompuestoUI
{
    partial class InteresCompuesto
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
            label1 = new Label();
            capitalInicialLabel = new Label();
            interesLabel = new Label();
            capitalizacionLabel = new Label();
            añosLabel = new Label();
            calcularButton = new Button();
            resultadoLabel = new Label();
            capitalTexBox = new TextBox();
            interesTextBox = new TextBox();
            capitalizacionTextBox = new TextBox();
            añosTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(302, 25);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Interes Compuesto";
            // 
            // capitalInicialLabel
            // 
            capitalInicialLabel.AutoSize = true;
            capitalInicialLabel.Location = new Point(47, 50);
            capitalInicialLabel.Margin = new Padding(5, 0, 5, 0);
            capitalInicialLabel.Name = "capitalInicialLabel";
            capitalInicialLabel.Size = new Size(163, 25);
            capitalInicialLabel.TabIndex = 1;
            capitalInicialLabel.Text = "Capital Inicial (P): ";
            // 
            // interesLabel
            // 
            interesLabel.AutoSize = true;
            interesLabel.Location = new Point(47, 100);
            interesLabel.Margin = new Padding(5, 0, 5, 0);
            interesLabel.Name = "interesLabel";
            interesLabel.Size = new Size(216, 25);
            interesLabel.TabIndex = 2;
            interesLabel.Text = "Tasa de interes anual(r): ";
            // 
            // capitalizacionLabel
            // 
            capitalizacionLabel.AutoSize = true;
            capitalizacionLabel.Location = new Point(47, 148);
            capitalizacionLabel.Margin = new Padding(5, 0, 5, 0);
            capitalizacionLabel.Name = "capitalizacionLabel";
            capitalizacionLabel.Size = new Size(217, 25);
            capitalizacionLabel.TabIndex = 3;
            capitalizacionLabel.Text = "Capitalizacion Anual (n):";
            // 
            // añosLabel
            // 
            añosLabel.AutoSize = true;
            añosLabel.Location = new Point(47, 194);
            añosLabel.Margin = new Padding(5, 0, 5, 0);
            añosLabel.Name = "añosLabel";
            añosLabel.Size = new Size(170, 25);
            añosLabel.TabIndex = 4;
            añosLabel.Text = "Años a Calcular (t):";
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(47, 285);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(217, 42);
            calcularButton.TabIndex = 5;
            calcularButton.Text = "Calcular I. Compuesto";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultadoLabel.Location = new Point(282, 297);
            resultadoLabel.Margin = new Padding(5, 0, 5, 0);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(0, 21);
            resultadoLabel.TabIndex = 6;
            // 
            // capitalTexBox
            // 
            capitalTexBox.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            capitalTexBox.Location = new Point(272, 50);
            capitalTexBox.Name = "capitalTexBox";
            capitalTexBox.PlaceholderText = "la cantidad de dinero que se invierte";
            capitalTexBox.Size = new Size(338, 29);
            capitalTexBox.TabIndex = 7;
            // 
            // interesTextBox
            // 
            interesTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            interesTextBox.Location = new Point(272, 100);
            interesTextBox.Name = "interesTextBox";
            interesTextBox.PlaceholderText = "Ingrese un entero";
            interesTextBox.Size = new Size(338, 29);
            interesTextBox.TabIndex = 8;
            // 
            // capitalizacionTextBox
            // 
            capitalizacionTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            capitalizacionTextBox.Location = new Point(272, 148);
            capitalizacionTextBox.Name = "capitalizacionTextBox";
            capitalizacionTextBox.PlaceholderText = "Capitalizacion por año (mensualmente)";
            capitalizacionTextBox.Size = new Size(338, 29);
            capitalizacionTextBox.TabIndex = 9;
            // 
            // añosTextBox
            // 
            añosTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            añosTextBox.Location = new Point(272, 194);
            añosTextBox.Name = "añosTextBox";
            añosTextBox.PlaceholderText = "Cantidad de años";
            añosTextBox.Size = new Size(338, 29);
            añosTextBox.TabIndex = 10;
            // 
            // InteresCompuesto
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 381);
            Controls.Add(añosTextBox);
            Controls.Add(capitalizacionTextBox);
            Controls.Add(interesTextBox);
            Controls.Add(capitalTexBox);
            Controls.Add(resultadoLabel);
            Controls.Add(calcularButton);
            Controls.Add(añosLabel);
            Controls.Add(capitalizacionLabel);
            Controls.Add(interesLabel);
            Controls.Add(capitalInicialLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "InteresCompuesto";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label capitalInicialLabel;
        private Label interesLabel;
        private Label capitalizacionLabel;
        private Label añosLabel;
        private Button calcularButton;
        private Label resultadoLabel;
        private TextBox capitalTexBox;
        private TextBox interesTextBox;
        private TextBox capitalizacionTextBox;
        private TextBox añosTextBox;
    }
}
