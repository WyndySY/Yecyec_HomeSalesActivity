namespace Yecyec_HomeSalesActivity
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
            this.lblCodes = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.Btn_submit = new System.Windows.Forms.Button();
            this.Btn_print = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodes
            // 
            this.lblCodes.AutoSize = true;
            this.lblCodes.Location = new System.Drawing.Point(114, 74);
            this.lblCodes.Name = "lblCodes";
            this.lblCodes.Size = new System.Drawing.Size(214, 13);
            this.lblCodes.TabIndex = 0;
            this.lblCodes.Text = "Select: D - Danielle I E - Edward I F - Fatima";
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(114, 118);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(130, 13);
            this.lblInitial.TabIndex = 1;
            this.lblInitial.Text = " Enter Sales Person Initial:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(114, 153);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(82, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount of Sale:";
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(250, 115);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(158, 20);
            this.txtInitial.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(214, 146);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(158, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // Btn_submit
            // 
            this.Btn_submit.Location = new System.Drawing.Point(117, 214);
            this.Btn_submit.Name = "Btn_submit";
            this.Btn_submit.Size = new System.Drawing.Size(75, 31);
            this.Btn_submit.TabIndex = 5;
            this.Btn_submit.Text = "Submit";
            this.Btn_submit.UseVisualStyleBackColor = true;
            this.Btn_submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_print
            // 
            this.Btn_print.Location = new System.Drawing.Point(354, 214);
            this.Btn_print.Name = "Btn_print";
            this.Btn_print.Size = new System.Drawing.Size(75, 31);
            this.Btn_print.TabIndex = 6;
            this.Btn_print.Text = "Print";
            this.Btn_print.UseVisualStyleBackColor = true;
            this.Btn_print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.Location = new System.Drawing.Point(233, 214);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(75, 31);
            this.Btn_clear.TabIndex = 7;
            this.Btn_clear.Text = "Clear";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(114, 278);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(294, 80);
            this.lblOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_print);
            this.Controls.Add(this.Btn_submit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.lblCodes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodes;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button Btn_submit;
        private System.Windows.Forms.Button Btn_print;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Label lblOutput;
    }
}

