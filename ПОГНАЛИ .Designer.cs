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
            this.maxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minText = new System.Windows.Forms.TextBox();
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
            // Shanr
            // 
            this.Shanr.FormattingEnabled = true;
            this.Shanr.Items.AddRange(new object[] {
            "shooter",
            "akade",
            "action",
            "butle royal"});
            this.Shanr.Location = new System.Drawing.Point(456, 31);
            this.Shanr.Name = "Shanr";
            this.Shanr.Size = new System.Drawing.Size(120, 79);
            this.Shanr.TabIndex = 13;
            this.Shanr.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Shanr_ItemCheck);
            this.Shanr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Shanr_MouseClick);
            this.Shanr.SelectedIndexChanged += new System.EventHandler(this.button1_Click_1);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxText);
            this.Controls.Add(this.buttonF);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.TextBox maxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.CheckedListBox Shanr;
        private System.Windows.Forms.Label label3;
    }
}