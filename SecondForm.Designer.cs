namespace ShareLiveVar
{
    partial class SecondForm
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
            this.number = new System.Windows.Forms.Label();
            this.increment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(214, 106);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(83, 91);
            this.number.TabIndex = 0;
            this.number.Text = "0";
            // 
            // increment
            // 
            this.increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment.Location = new System.Drawing.Point(195, 281);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(115, 56);
            this.increment.TabIndex = 1;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 449);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.number);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button increment;
    }
}