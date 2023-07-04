namespace RecipeApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbfg = new System.Windows.Forms.ComboBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbmeasuringunit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcalories = new System.Windows.Forms.TextBox();
            this.tbmquantity = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbfg);
            this.panel1.Controls.Add(this.lblerror);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.cbmeasuringunit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbcalories);
            this.panel1.Controls.Add(this.tbmquantity);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 379);
            this.panel1.TabIndex = 0;
            // 
            // tbfg
            // 
            this.tbfg.FormattingEnabled = true;
            this.tbfg.Items.AddRange(new object[] {
            "Fruit and vegetables.",
            "Starchy food.",
            "Dairy.",
            "Protein.",
            "Fat."});
            this.tbfg.Location = new System.Drawing.Point(208, 248);
            this.tbfg.Name = "tbfg";
            this.tbfg.Size = new System.Drawing.Size(192, 21);
            this.tbfg.TabIndex = 18;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(33, 299);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 17;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(233, 342);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(136, 23);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbmeasuringunit
            // 
            this.cbmeasuringunit.FormattingEnabled = true;
            this.cbmeasuringunit.Items.AddRange(new object[] {
            "Tea Spoon",
            "Table Spoon",
            "Cup"});
            this.cbmeasuringunit.Location = new System.Drawing.Point(208, 132);
            this.cbmeasuringunit.Name = "cbmeasuringunit";
            this.cbmeasuringunit.Size = new System.Drawing.Size(192, 21);
            this.cbmeasuringunit.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Food Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Calories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Measuring Unit Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Measuring Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingredient Name";
            // 
            // tbcalories
            // 
            this.tbcalories.Location = new System.Drawing.Point(208, 211);
            this.tbcalories.Name = "tbcalories";
            this.tbcalories.Size = new System.Drawing.Size(192, 20);
            this.tbcalories.TabIndex = 6;
            // 
            // tbmquantity
            // 
            this.tbmquantity.Location = new System.Drawing.Point(208, 173);
            this.tbmquantity.Name = "tbmquantity";
            this.tbmquantity.Size = new System.Drawing.Size(192, 20);
            this.tbmquantity.TabIndex = 3;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(208, 97);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(192, 20);
            this.tbname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Recipe";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 403);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcalories;
        private System.Windows.Forms.TextBox tbmquantity;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmeasuringunit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.ComboBox tbfg;
    }
}