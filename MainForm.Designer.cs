﻿namespace ShareLiveVar
{
    partial class MainForm
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
            this.increment = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.openSecondForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // increment
            // 
            this.increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment.Location = new System.Drawing.Point(183, 263);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(115, 56);
            this.increment.TabIndex = 3;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(202, 88);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(83, 91);
            this.number.TabIndex = 2;
            this.number.Text = "0";
            // 
            // openSecondForm
            // 
            this.openSecondForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSecondForm.Location = new System.Drawing.Point(98, 383);
            this.openSecondForm.Name = "openSecondForm";
            this.openSecondForm.Size = new System.Drawing.Size(299, 56);
            this.openSecondForm.TabIndex = 4;
            this.openSecondForm.Text = "Open SecondForm";
            this.openSecondForm.UseVisualStyleBackColor = true;
            this.openSecondForm.Click += new System.EventHandler(this.openSecondForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 469);
            this.Controls.Add(this.openSecondForm);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.number);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Button openSecondForm;
    }
}

