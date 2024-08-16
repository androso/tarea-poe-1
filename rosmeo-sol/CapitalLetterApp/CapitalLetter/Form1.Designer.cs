namespace CapitalLetter
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
            groupBox1 = new GroupBox();
            resultLabel = new Label();
            check = new Button();
            inputTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resultLabel);
            groupBox1.Controls.Add(check);
            groupBox1.Controls.Add(inputTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(121, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capital Letter";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(228, 205);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 3;
            // 
            // check
            // 
            check.Location = new Point(193, 157);
            check.Name = "check";
            check.Size = new Size(94, 29);
            check.TabIndex = 2;
            check.Text = "Check ";
            check.UseVisualStyleBackColor = true;
            
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(118, 105);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(279, 27);
            inputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 45);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Please type a sentence ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox inputTextBox;
        private Button check;
        private Label resultLabel;
    }
}
