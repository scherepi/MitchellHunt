namespace MitchellHunt
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
            this.INFO = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // INFO
            // 
            this.INFO.AutoSize = true;
            this.INFO.Font = new System.Drawing.Font("NSimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INFO.ForeColor = System.Drawing.Color.Red;
            this.INFO.Location = new System.Drawing.Point(25, 80);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(279, 20);
            this.INFO.TabIndex = 0;
            this.INFO.Text = "LOREM IPSUM DOLOR SIT AMET.";
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Font = new System.Drawing.Font("NSimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line2.ForeColor = System.Drawing.Color.Red;
            this.line2.Location = new System.Drawing.Point(25, 100);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(279, 20);
            this.line2.TabIndex = 1;
            this.line2.Text = "LOREM IPSUM DOLOR SIT AMET.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(330, 190);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.INFO);
            this.Name = "Form2";
            this.Text = "SECURE INFO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label INFO;
        private System.Windows.Forms.Label line2;
    }
}