namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBlitz = new System.Windows.Forms.Button();
            this.buttonTanks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMario = new System.Windows.Forms.Button();
            this.buttonGTA = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.buttonBlitz);
            this.tabPage1.Controls.Add(this.buttonTanks);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.buttonMario);
            this.tabPage1.Controls.Add(this.buttonGTA);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Описание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 398);
            this.button2.TabIndex = 8;
            this.button2.Text = "Фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBlitz
            // 
            this.buttonBlitz.AccessibleDescription = "0";
            this.buttonBlitz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBlitz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBlitz.BackgroundImage")));
            this.buttonBlitz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBlitz.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBlitz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBlitz.Location = new System.Drawing.Point(3, 279);
            this.buttonBlitz.Name = "buttonBlitz";
            this.buttonBlitz.Size = new System.Drawing.Size(359, 125);
            this.buttonBlitz.TabIndex = 6;
            this.buttonBlitz.Tag = "WoT Blitz";
            this.buttonBlitz.UseVisualStyleBackColor = false;
            this.buttonBlitz.Click += new System.EventHandler(this.buttonTanks_Click);
            // 
            // buttonTanks
            // 
            this.buttonTanks.AccessibleDescription = "0";
            this.buttonTanks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTanks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTanks.BackgroundImage")));
            this.buttonTanks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTanks.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonTanks.Location = new System.Drawing.Point(457, 279);
            this.buttonTanks.Name = "buttonTanks";
            this.buttonTanks.Size = new System.Drawing.Size(329, 125);
            this.buttonTanks.TabIndex = 7;
            this.buttonTanks.Tag = "tanks";
            this.buttonTanks.UseVisualStyleBackColor = false;
            this.buttonTanks.Click += new System.EventHandler(this.buttonTanks_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "0";
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 136);
            this.button1.TabIndex = 0;
            this.button1.Tag = "pubg";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonTanks_Click);
            // 
            // buttonMario
            // 
            this.buttonMario.AccessibleDescription = "0";
            this.buttonMario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMario.BackgroundImage")));
            this.buttonMario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMario.Location = new System.Drawing.Point(457, 148);
            this.buttonMario.Name = "buttonMario";
            this.buttonMario.Size = new System.Drawing.Size(329, 125);
            this.buttonMario.TabIndex = 4;
            this.buttonMario.Tag = "Mario";
            this.buttonMario.UseVisualStyleBackColor = false;
            this.buttonMario.Click += new System.EventHandler(this.buttonTanks_Click);
            // 
            // buttonGTA
            // 
            this.buttonGTA.AccessibleDescription = "1990";
            this.buttonGTA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGTA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGTA.BackgroundImage")));
            this.buttonGTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.buttonGTA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGTA.Location = new System.Drawing.Point(457, 6);
            this.buttonGTA.Name = "buttonGTA";
            this.buttonGTA.Size = new System.Drawing.Size(329, 136);
            this.buttonGTA.TabIndex = 1;
            this.buttonGTA.Tag = "GTA V";
            this.buttonGTA.UseVisualStyleBackColor = false;
            this.buttonGTA.Click += new System.EventHandler(this.buttonTanks_Click);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "0";
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(0, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(362, 125);
            this.button3.TabIndex = 2;
            this.button3.Tag = "standoff2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonTanks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 438);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2страница";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Steam";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Описание игр";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonTanks;
        private System.Windows.Forms.Button buttonBlitz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMario;
        private System.Windows.Forms.Button buttonGTA;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
    }
}

