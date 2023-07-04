namespace RecipeApp
{
    partial class Form7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbdisplay = new System.Windows.Forms.RichTextBox();
            this.tbrecipenum = new System.Windows.Forms.TextBox();
            this.btnscale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbscaleby = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbscaleby);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnscale);
            this.panel1.Controls.Add(this.tbrecipenum);
            this.panel1.Controls.Add(this.rtbdisplay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 370);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scale Recipe";
            // 
            // rtbdisplay
            // 
            this.rtbdisplay.Location = new System.Drawing.Point(24, 60);
            this.rtbdisplay.Name = "rtbdisplay";
            this.rtbdisplay.Size = new System.Drawing.Size(403, 179);
            this.rtbdisplay.TabIndex = 7;
            this.rtbdisplay.Text = "";
            this.rtbdisplay.TextChanged += new System.EventHandler(this.rtbdisplay_TextChanged);
            // 
            // tbrecipenum
            // 
            this.tbrecipenum.Location = new System.Drawing.Point(282, 258);
            this.tbrecipenum.Name = "tbrecipenum";
            this.tbrecipenum.Size = new System.Drawing.Size(100, 20);
            this.tbrecipenum.TabIndex = 8;
            // 
            // btnscale
            // 
            this.btnscale.Location = new System.Drawing.Point(282, 332);
            this.btnscale.Name = "btnscale";
            this.btnscale.Size = new System.Drawing.Size(100, 23);
            this.btnscale.TabIndex = 9;
            this.btnscale.Text = "Scale";
            this.btnscale.UseVisualStyleBackColor = true;
            this.btnscale.Click += new System.EventHandler(this.btnscale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number of Recipe";
            // 
            // cbscaleby
            // 
            this.cbscaleby.FormattingEnabled = true;
            this.cbscaleby.Items.AddRange(new object[] {
            "0.5",
            "2",
            "3"});
            this.cbscaleby.Location = new System.Drawing.Point(282, 294);
            this.cbscaleby.Name = "cbscaleby";
            this.cbscaleby.Size = new System.Drawing.Size(100, 21);
            this.cbscaleby.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Scale by";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 394);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnscale;
        private System.Windows.Forms.TextBox tbrecipenum;
        private System.Windows.Forms.RichTextBox rtbdisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbscaleby;
    }
}