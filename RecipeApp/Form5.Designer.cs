namespace RecipeApp
{
    partial class Form5
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
            this.rtbdisplay = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.tbrnum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbrnum);
            this.panel1.Controls.Add(this.rtbdisplay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbldisplay);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 554);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rtbdisplay
            // 
            this.rtbdisplay.Location = new System.Drawing.Point(12, 59);
            this.rtbdisplay.Name = "rtbdisplay";
            this.rtbdisplay.Size = new System.Drawing.Size(403, 404);
            this.rtbdisplay.TabIndex = 6;
            this.rtbdisplay.Text = "";
            this.rtbdisplay.TextChanged += new System.EventHandler(this.rtbdisplay_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter a recipe number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Recipe";
            // 
            // lbldisplay
            // 
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.Location = new System.Drawing.Point(46, 43);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(0, 13);
            this.lbldisplay.TabIndex = 0;
            // 
            // tbrnum
            // 
            this.tbrnum.Location = new System.Drawing.Point(252, 486);
            this.tbrnum.Name = "tbrnum";
            this.tbrnum.Size = new System.Drawing.Size(100, 20);
            this.tbrnum.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 578);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbdisplay;
        private System.Windows.Forms.TextBox tbrnum;
        private System.Windows.Forms.Button button1;
    }
}