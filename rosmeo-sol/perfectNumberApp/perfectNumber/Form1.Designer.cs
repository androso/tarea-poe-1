namespace perfectNumber
{
    partial class Form1
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
            textBoxNumber = new TextBox();
            checkNumber = new Button();
            resultNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 77);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(282, 137);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(299, 27);
            textBoxNumber.TabIndex = 1;
            textBoxNumber.Text = "2";
            // 
            // checkNumber
            // 
            checkNumber.Location = new Point(369, 199);
            checkNumber.Name = "checkNumber";
            checkNumber.Size = new Size(94, 29);
            checkNumber.TabIndex = 2;
            checkNumber.Text = "check";
            checkNumber.UseVisualStyleBackColor = true;
            checkNumber.Click += checkNumber_Click;
            // 
            // resultNumber
            // 
            resultNumber.AutoSize = true;
            resultNumber.Location = new Point(405, 267);
            resultNumber.Name = "resultNumber";
            resultNumber.Size = new Size(0, 20);
            resultNumber.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultNumber);
            Controls.Add(checkNumber);
            Controls.Add(textBoxNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumber;
        private Button checkNumber;
        private Label resultNumber;
    }
}
