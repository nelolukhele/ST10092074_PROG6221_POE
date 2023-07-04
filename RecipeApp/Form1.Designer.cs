namespace RecipeApp
{
    partial class Form1
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnscale = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btnscale);
            this.panel1.Controls.Add(this.btnshow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 284);
            this.panel1.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(147, 220);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(98, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(147, 191);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(98, 23);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset Recipe";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnscale
            // 
            this.btnscale.Location = new System.Drawing.Point(147, 162);
            this.btnscale.Name = "btnscale";
            this.btnscale.Size = new System.Drawing.Size(98, 23);
            this.btnscale.TabIndex = 3;
            this.btnscale.Text = "Scale Recipe";
            this.btnscale.UseVisualStyleBackColor = true;
            this.btnscale.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(147, 133);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(98, 23);
            this.btnshow.TabIndex = 2;
            this.btnshow.Text = "Show Recipe";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipe App";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(147, 104);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(98, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add Recipe";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 308);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnscale;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnexit;
    }
}