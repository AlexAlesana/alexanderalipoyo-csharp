namespace alex_assign
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
            this.btnnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnum
            // 
            this.btnnum.Location = new System.Drawing.Point(12, 12);
            this.btnnum.Name = "btnnum";
            this.btnnum.Size = new System.Drawing.Size(177, 84);
            this.btnnum.TabIndex = 0;
            this.btnnum.Text = "0";
            this.btnnum.UseVisualStyleBackColor = true;
            this.btnnum.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 109);
            this.Controls.Add(this.btnnum);
            this.Name = "Form1";
            this.Text = "JUST CLICK";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnnum;

    }
}

