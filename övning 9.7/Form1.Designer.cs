namespace övning_9._7
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
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.lblNivå = new System.Windows.Forms.Label();
            this.tbxNivå = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(171, 114);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxUtdata.Size = new System.Drawing.Size(402, 280);
            this.tbxUtdata.TabIndex = 0;
            this.tbxUtdata.WordWrap = false;
            // 
            // lblNivå
            // 
            this.lblNivå.AutoSize = true;
            this.lblNivå.Location = new System.Drawing.Point(680, 130);
            this.lblNivå.Name = "lblNivå";
            this.lblNivå.Size = new System.Drawing.Size(29, 13);
            this.lblNivå.TabIndex = 1;
            this.lblNivå.Text = "Nivå";
            // 
            // tbxNivå
            // 
            this.tbxNivå.Location = new System.Drawing.Point(677, 156);
            this.tbxNivå.Name = "tbxNivå";
            this.tbxNivå.Size = new System.Drawing.Size(32, 20);
            this.tbxNivå.TabIndex = 2;
            this.tbxNivå.TextChanged += new System.EventHandler(this.tbxNivå_TextChanged);
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(677, 371);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(41, 23);
            this.btnVisa.TabIndex = 3;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.tbxNivå);
            this.Controls.Add(this.lblNivå);
            this.Controls.Add(this.tbxUtdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.Label lblNivå;
        private System.Windows.Forms.TextBox tbxNivå;
        private System.Windows.Forms.Button btnVisa;
    }
}

