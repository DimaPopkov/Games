namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonF = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.maxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minText = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Shanr = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(12, 12);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(118, 79);
            this.buttonF.TabIndex = 0;
            this.buttonF.Text = "Фильтр";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(254, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(44, 151);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(99, 51);
            this.button0.TabIndex = 6;
            this.button0.Text = "button0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // maxText
            // 
            this.maxText.Location = new System.Drawing.Point(149, 12);
            this.maxText.Name = "maxText";
            this.maxText.Size = new System.Drawing.Size(114, 20);
            this.maxText.TabIndex = 7;
            this.maxText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Максимальная цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Минимальная цена";
            // 
            // minText
            // 
            this.minText.Location = new System.Drawing.Point(149, 42);
            this.minText.Name = "minText";
            this.minText.Size = new System.Drawing.Size(114, 20);
            this.minText.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(359, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 51);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(359, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 51);
            this.button7.TabIndex = 12;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Shanr
            // 
            this.Shanr.FormattingEnabled = true;
            this.Shanr.Items.AddRange(new object[] {
            "Shuter",
            "akade",
            "action",
            "butle royal"});
            this.Shanr.Location = new System.Drawing.Point(456, 31);
            this.Shanr.Name = "Shanr";
            this.Shanr.Size = new System.Drawing.Size(120, 94);
            this.Shanr.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Жанры";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Shanr);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonF);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckedListBox Shanr;
        private System.Windows.Forms.Label label3;
    }
}