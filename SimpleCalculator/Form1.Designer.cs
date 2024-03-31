namespace SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            buttonComma = new Button();
            buttonResult = new Button();
            buttonAddition = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            buttonSubtract = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            buttonDivision = new Button();
            buttonMultiply = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            display = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(32, 534);
            button1.Name = "button1";
            button1.Size = new Size(87, 79);
            button1.TabIndex = 0;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ClearButton;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(137, 534);
            button2.Name = "button2";
            button2.Size = new Size(87, 79);
            button2.TabIndex = 1;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Number0Button;
            // 
            // buttonComma
            // 
            buttonComma.BackColor = Color.Transparent;
            buttonComma.BackgroundImage = (Image)resources.GetObject("buttonComma.BackgroundImage");
            buttonComma.BackgroundImageLayout = ImageLayout.Stretch;
            buttonComma.FlatStyle = FlatStyle.Popup;
            buttonComma.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonComma.Location = new Point(242, 534);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(87, 79);
            buttonComma.TabIndex = 2;
            buttonComma.Text = ",";
            buttonComma.UseVisualStyleBackColor = false;
            buttonComma.Click += DotButton;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Transparent;
            buttonResult.BackgroundImage = (Image)resources.GetObject("buttonResult.BackgroundImage");
            buttonResult.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonResult.ForeColor = SystemColors.ButtonHighlight;
            buttonResult.Location = new Point(346, 534);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(87, 79);
            buttonResult.TabIndex = 3;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += ResultButton;
            // 
            // buttonAddition
            // 
            buttonAddition.BackColor = Color.Transparent;
            buttonAddition.BackgroundImage = (Image)resources.GetObject("buttonAddition.BackgroundImage");
            buttonAddition.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAddition.FlatStyle = FlatStyle.Popup;
            buttonAddition.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddition.Location = new Point(346, 437);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(87, 79);
            buttonAddition.TabIndex = 7;
            buttonAddition.Text = "+";
            buttonAddition.UseVisualStyleBackColor = false;
            buttonAddition.Click += PlusButton;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(242, 437);
            button6.Name = "button6";
            button6.Size = new Size(87, 79);
            button6.TabIndex = 6;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Number3Button;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(137, 437);
            button7.Name = "button7";
            button7.Size = new Size(87, 79);
            button7.TabIndex = 5;
            button7.Text = "2";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Number2Button;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(32, 437);
            button8.Name = "button8";
            button8.Size = new Size(87, 79);
            button8.TabIndex = 4;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Number1Button;
            // 
            // buttonSubtract
            // 
            buttonSubtract.BackColor = Color.Transparent;
            buttonSubtract.BackgroundImage = (Image)resources.GetObject("buttonSubtract.BackgroundImage");
            buttonSubtract.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSubtract.FlatStyle = FlatStyle.Popup;
            buttonSubtract.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSubtract.Location = new Point(346, 339);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(87, 79);
            buttonSubtract.TabIndex = 11;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = false;
            buttonSubtract.Click += SubtractButton;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(242, 339);
            button10.Name = "button10";
            button10.Size = new Size(87, 79);
            button10.TabIndex = 10;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            button10.Click += Number6Button;
            // 
            // button11
            // 
            button11.BackColor = Color.Transparent;
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            button11.FlatStyle = FlatStyle.Popup;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(137, 339);
            button11.Name = "button11";
            button11.Size = new Size(87, 79);
            button11.TabIndex = 9;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = false;
            button11.Click += Number5Button;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.BackgroundImage = (Image)resources.GetObject("button12.BackgroundImage");
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Location = new Point(32, 339);
            button12.Name = "button12";
            button12.Size = new Size(87, 79);
            button12.TabIndex = 8;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = false;
            button12.Click += Number4Button;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = Color.Transparent;
            buttonDivision.BackgroundImage = (Image)resources.GetObject("buttonDivision.BackgroundImage");
            buttonDivision.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDivision.FlatStyle = FlatStyle.Popup;
            buttonDivision.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDivision.Location = new Point(346, 147);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(87, 79);
            buttonDivision.TabIndex = 19;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += DivisionButton;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.Transparent;
            buttonMultiply.BackgroundImage = (Image)resources.GetObject("buttonMultiply.BackgroundImage");
            buttonMultiply.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMultiply.FlatStyle = FlatStyle.Popup;
            buttonMultiply.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMultiply.Location = new Point(346, 244);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(87, 79);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "x";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += MultipleButton;
            // 
            // button18
            // 
            button18.BackColor = Color.Transparent;
            button18.BackgroundImage = (Image)resources.GetObject("button18.BackgroundImage");
            button18.BackgroundImageLayout = ImageLayout.Stretch;
            button18.FlatStyle = FlatStyle.Popup;
            button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button18.ForeColor = SystemColors.ButtonHighlight;
            button18.Location = new Point(242, 244);
            button18.Name = "button18";
            button18.Size = new Size(87, 79);
            button18.TabIndex = 14;
            button18.Text = "9";
            button18.UseVisualStyleBackColor = false;
            button18.Click += Number9Button;
            // 
            // button19
            // 
            button19.BackColor = Color.Transparent;
            button19.BackgroundImage = (Image)resources.GetObject("button19.BackgroundImage");
            button19.BackgroundImageLayout = ImageLayout.Stretch;
            button19.FlatStyle = FlatStyle.Popup;
            button19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button19.ForeColor = SystemColors.ButtonHighlight;
            button19.Location = new Point(137, 244);
            button19.Name = "button19";
            button19.Size = new Size(87, 79);
            button19.TabIndex = 13;
            button19.Text = "8";
            button19.UseVisualStyleBackColor = false;
            button19.Click += Number8Button;
            // 
            // button20
            // 
            button20.BackColor = Color.Transparent;
            button20.BackgroundImage = (Image)resources.GetObject("button20.BackgroundImage");
            button20.BackgroundImageLayout = ImageLayout.Stretch;
            button20.FlatStyle = FlatStyle.Popup;
            button20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button20.ForeColor = SystemColors.ButtonHighlight;
            button20.Location = new Point(32, 244);
            button20.Name = "button20";
            button20.Size = new Size(87, 79);
            button20.TabIndex = 12;
            button20.Text = "7";
            button20.UseVisualStyleBackColor = false;
            button20.Click += Number7Button;
            // 
            // display
            // 
            display.BackColor = Color.DarkSeaGreen;
            display.BorderStyle = BorderStyle.FixedSingle;
            display.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            display.Location = new Point(30, 23);
            display.Multiline = true;
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(401, 92);
            display.TabIndex = 20;
            display.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(458, 640);
            Controls.Add(pictureBox1);
            Controls.Add(display);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMultiply);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(buttonSubtract);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(buttonAddition);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(buttonResult);
            Controls.Add(buttonComma);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator by Ivo Vaklinov";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button buttonComma;
        private Button buttonResult;
        private Button buttonAddition;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button buttonSubtract;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button buttonDivision;
        private Button buttonMultiply;
        private Button button18;
        private Button button19;
        private Button button20;
        private TextBox display;
        private PictureBox pictureBox1;
    }
}
