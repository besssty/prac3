namespace WinFormsApp1
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
            button1 = new Button();
            ProfessionBox = new TextBox();
            AgeBox = new TextBox();
            NameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            resultbox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 271);
            button1.Name = "button1";
            button1.Size = new Size(274, 41);
            button1.TabIndex = 0;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProfessionBox
            // 
            ProfessionBox.Location = new Point(55, 184);
            ProfessionBox.Name = "ProfessionBox";
            ProfessionBox.Size = new Size(164, 23);
            ProfessionBox.TabIndex = 1;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(55, 120);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(164, 23);
            AgeBox.TabIndex = 4;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(55, 46);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(164, 23);
            NameBox.TabIndex = 5;
            NameBox.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 19);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 6;
            label1.Text = "Імя";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 88);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 7;
            label2.Text = "Вік";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 156);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Професія";
            // 
            // resultbox
            // 
            resultbox.Location = new Point(313, 25);
            resultbox.Multiline = true;
            resultbox.Name = "resultbox";
            resultbox.Size = new Size(422, 287);
            resultbox.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(NameBox);
            groupBox1.Controls.Add(AgeBox);
            groupBox1.Controls.Add(ProfessionBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 229);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(757, 333);
            Controls.Add(groupBox1);
            Controls.Add(resultbox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Список";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox ProfessionBox;
        private TextBox AgeBox;
        private TextBox NameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox resultbox;
        private GroupBox groupBox1;
    }
}