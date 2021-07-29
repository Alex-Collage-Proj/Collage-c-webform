
namespace OrlyProject001
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
            this.quantity = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.ListBox();
            this.Perprice = new System.Windows.Forms.Label();
            this.Counttotal = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.accept = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Ttotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(429, 49);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(75, 23);
            this.quantity.TabIndex = 0;
            this.quantity.Text = "Quantity";
            this.quantity.UseVisualStyleBackColor = true;
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(429, 78);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(75, 23);
            this.pay.TabIndex = 1;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(429, 107);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(75, 23);
            this.total.TabIndex = 2;
            this.total.Text = "Total";
            this.total.UseVisualStyleBackColor = true;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(75, 98);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(120, 95);
            this.type.TabIndex = 3;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // Perprice
            // 
            this.Perprice.AutoSize = true;
            this.Perprice.Location = new System.Drawing.Point(216, 60);
            this.Perprice.Name = "Perprice";
            this.Perprice.Size = new System.Drawing.Size(50, 13);
            this.Perprice.TabIndex = 4;
            this.Perprice.Text = "Per Price";
            this.Perprice.Click += new System.EventHandler(this.label1_Click);
            // 
            // Counttotal
            // 
            this.Counttotal.AutoSize = true;
            this.Counttotal.Location = new System.Drawing.Point(216, 104);
            this.Counttotal.Name = "Counttotal";
            this.Counttotal.Size = new System.Drawing.Size(87, 13);
            this.Counttotal.TabIndex = 5;
            this.Counttotal.Text = "Count Quty Total";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Tshort",
            "Shorts"});
            this.category.Location = new System.Drawing.Point(74, 51);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 21);
            this.category.TabIndex = 6;
            this.category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(75, 243);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 7;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(189, 243);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            // 
            // Ttotal
            // 
            this.Ttotal.AutoSize = true;
            this.Ttotal.Location = new System.Drawing.Point(332, 150);
            this.Ttotal.Name = "Ttotal";
            this.Ttotal.Size = new System.Drawing.Size(31, 13);
            this.Ttotal.TabIndex = 9;
            this.Ttotal.Text = "Total";
            this.Ttotal.Click += new System.EventHandler(this.Ttotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 287);
            this.Controls.Add(this.Ttotal);
            this.Controls.Add(this.close);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.category);
            this.Controls.Add(this.Counttotal);
            this.Controls.Add(this.Perprice);
            this.Controls.Add(this.type);
            this.Controls.Add(this.total);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.quantity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quantity;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.ListBox type;
        private System.Windows.Forms.Label Perprice;
        private System.Windows.Forms.Label Counttotal;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label Ttotal;
    }
}

