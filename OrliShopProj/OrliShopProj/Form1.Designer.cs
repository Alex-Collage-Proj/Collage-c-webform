
namespace OrliShopProj
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
            this.Qnty = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.Tot = new System.Windows.Forms.Button();
            this.Disable = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Cat = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Totcalc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Qnty
            // 
            this.Qnty.Enabled = false;
            this.Qnty.Location = new System.Drawing.Point(332, 27);
            this.Qnty.Name = "Qnty";
            this.Qnty.Size = new System.Drawing.Size(75, 23);
            this.Qnty.TabIndex = 0;
            this.Qnty.Text = "כמות";
            this.Qnty.UseVisualStyleBackColor = true;
            this.Qnty.Click += new System.EventHandler(this.Qnty_Click);
            // 
            // Payment
            // 
            this.Payment.Enabled = false;
            this.Payment.Location = new System.Drawing.Point(332, 56);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(75, 23);
            this.Payment.TabIndex = 1;
            this.Payment.Text = "לתשלום";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // Tot
            // 
            this.Tot.Enabled = false;
            this.Tot.Location = new System.Drawing.Point(332, 85);
            this.Tot.Name = "Tot";
            this.Tot.Size = new System.Drawing.Size(75, 23);
            this.Tot.TabIndex = 2;
            this.Tot.Text = "סה\'\'כ";
            this.Tot.UseVisualStyleBackColor = true;
            this.Tot.Click += new System.EventHandler(this.Tot_Click);
            // 
            // Disable
            // 
            this.Disable.Enabled = false;
            this.Disable.Location = new System.Drawing.Point(139, 244);
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(75, 23);
            this.Disable.TabIndex = 3;
            this.Disable.Text = "בטל";
            this.Disable.UseVisualStyleBackColor = true;
            this.Disable.Click += new System.EventHandler(this.Disable_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(25, 244);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 4;
            this.Close.Text = "סגור";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Cat
            // 
            this.Cat.FormattingEnabled = true;
            this.Cat.Items.AddRange(new object[] {
            "חולצה",
            "מכנס",
            "נעלים",
            "חצאית"});
            this.Cat.Location = new System.Drawing.Point(25, 27);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(121, 21);
            this.Cat.TabIndex = 5;
            this.Cat.SelectedIndexChanged += new System.EventHandler(this.Cat_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "מחיר פריט";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(169, 37);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(35, 13);
            this.price.TabIndex = 8;
            this.price.Text = "מחיר:";
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "בחר קטגוריה רצויה:";
            // 
            // calc
            // 
            this.calc.AutoSize = true;
            this.calc.Location = new System.Drawing.Point(154, 95);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(91, 13);
            this.calc.TabIndex = 10;
            this.calc.Text = "חישוב לפי כמות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "חישוב כללי";
            // 
            // Totcalc
            // 
            this.Totcalc.AutoSize = true;
            this.Totcalc.Location = new System.Drawing.Point(290, 155);
            this.Totcalc.Name = "Totcalc";
            this.Totcalc.Size = new System.Drawing.Size(0, 13);
            this.Totcalc.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = ":יחידה";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Totcalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Disable);
            this.Controls.Add(this.Tot);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Qnty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Qnty;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button Tot;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox Cat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label calc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Totcalc;
        private System.Windows.Forms.Label label3;
    }
}

