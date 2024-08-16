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
            label2 = new Label();
            resultNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(379, 123);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Type a number";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(343, 166);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(181, 27);
            textBoxNumber.TabIndex = 1;
            // 
            // checkNumber
            // 
            checkNumber.BackColor = SystemColors.Highlight;
            checkNumber.Location = new Point(367, 235);
            checkNumber.Name = "checkNumber";
            checkNumber.Size = new Size(133, 29);
            checkNumber.TabIndex = 2;
            checkNumber.Text = "Check number";
            checkNumber.UseVisualStyleBackColor = false;
            checkNumber.Click += checkNumber_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 316);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // resultNumber
            // 
            resultNumber.AutoSize = true;
            resultNumber.Location = new Point(421, 290);
            resultNumber.Name = "resultNumber";
            resultNumber.Size = new Size(0, 20);
            resultNumber.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultNumber);
            Controls.Add(label2);
            Controls.Add(checkNumber);
            Controls.Add(textBoxNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Perfect Number";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumber;
        private Button checkNumber;
        private Label label2;
        private Label resultNumber;
    }
}
