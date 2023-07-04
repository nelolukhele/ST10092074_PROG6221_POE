namespace RecipeApp
{
    partial class Form3
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
            this.btnadd = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtnuming = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsteps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblerror);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtsteps);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnuming);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 193);
            this.panel1.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(101, 157);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(137, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(144, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtnuming
            // 
            this.txtnuming.Location = new System.Drawing.Point(137, 55);
            this.txtnuming.Name = "txtnuming";
            this.txtnuming.Size = new System.Drawing.Size(144, 20);
            this.txtnuming.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recipe name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Ingredients";
            // 
            // txtsteps
            // 
            this.txtsteps.Location = new System.Drawing.Point(137, 91);
            this.txtsteps.Name = "txtsteps";
            this.txtsteps.Size = new System.Drawing.Size(144, 20);
            this.txtsteps.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Steps";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(20, 129);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 218);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnuming;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsteps;
        private System.Windows.Forms.Label lblerror;
    }
}