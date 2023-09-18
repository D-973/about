namespace about
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yyr = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABOUT";
            // 
            // yyr
            // 
            this.yyr.FormattingEnabled = true;
            this.yyr.Items.AddRange(new object[] {
            "So, about myself. I am a 19 year old college student at her 3rd semester in Klaba" +
                "t University.",
            "I have a preference for spicy food and doesn\'t really go well with sweet food, be" +
                "cause when i do eat such food i feel like puking it out",
            "When it comes to drinks, I love cookies and cream, although normally the cream pa" +
                "rt is too sweet, but the milk makes it up for it",
            "",
            "My hobbies include reading, watching and playing games. Although recently, it has" +
                " been far too busy and exhausting to do any of my hobbies.",
            "",
            "I am right now a student executive for the 2nd year students with my dear friend " +
                "Riana Keni.",
            "It has been busy definitely, but I think I am having fun.",
            "",
            "For this year, i think COA is my worst subject as i feel the knowledge coming and" +
                " going constantly without ever taking breaks",
            "",
            "I believe that is all.",
            "Thank You,",
            "\t\t\t\t\t\t\tSigned,",
            "\t\t\t\t\t\t\tYours Truly,",
            "\t\t\t\t\t\t\t",
            "\t\t\t\t\t\t\tDhea "});
            this.yyr.Location = new System.Drawing.Point(206, 71);
            this.yyr.Name = "yyr";
            this.yyr.Size = new System.Drawing.Size(481, 238);
            this.yyr.TabIndex = 3;
            // 
            // about
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 339);
            this.Controls.Add(this.yyr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "about";
            this.Text = "about";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ListBox yyr;
    }
}

