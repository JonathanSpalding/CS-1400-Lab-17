namespace ShippingMethodLab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SameDay = new System.Windows.Forms.RadioButton();
            this.Express = new System.Windows.Forms.RadioButton();
            this.Standard = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Standard);
            this.groupBox1.Controls.Add(this.Express);
            this.groupBox1.Controls.Add(this.SameDay);
            this.groupBox1.Location = new System.Drawing.Point(37, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Method";
            // 
            // SameDay
            // 
            this.SameDay.AutoSize = true;
            this.SameDay.Location = new System.Drawing.Point(54, 78);
            this.SameDay.Name = "SameDay";
            this.SameDay.Size = new System.Drawing.Size(129, 29);
            this.SameDay.TabIndex = 0;
            this.SameDay.Text = "Same Day";
            this.SameDay.UseVisualStyleBackColor = true;
            this.SameDay.CheckedChanged += new System.EventHandler(this.SameDay_CheckedChanged);
            // 
            // Express
            // 
            this.Express.AutoSize = true;
            this.Express.Location = new System.Drawing.Point(54, 126);
            this.Express.Name = "Express";
            this.Express.Size = new System.Drawing.Size(108, 29);
            this.Express.TabIndex = 1;
            this.Express.Text = "Express";
            this.Express.UseVisualStyleBackColor = true;
            this.Express.CheckedChanged += new System.EventHandler(this.Express_CheckedChanged);
            // 
            // Standard
            // 
            this.Standard.AutoSize = true;
            this.Standard.Location = new System.Drawing.Point(54, 178);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(117, 29);
            this.Standard.TabIndex = 2;
            this.Standard.Text = "Standard";
            this.Standard.UseVisualStyleBackColor = true;
            this.Standard.CheckedChanged += new System.EventHandler(this.Standard_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 394);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Shipping Method";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton Express;
        private System.Windows.Forms.RadioButton Standard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SameDay;
    }
}

