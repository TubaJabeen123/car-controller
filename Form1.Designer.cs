﻿namespace RemoteCar
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Commands = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Compile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(108, 121);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(258, 44);
            this.Input.TabIndex = 0;
            // 
            // Commands
            // 
            this.Commands.AutoSize = true;
            this.Commands.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commands.Location = new System.Drawing.Point(33, 61);
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(143, 31);
            this.Commands.TabIndex = 1;
            this.Commands.Text = "Commands";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(108, 297);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(258, 96);
            this.Output.TabIndex = 2;
            this.Output.Text = "";
            // 
            // Compile
            // 
            this.Compile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compile.Location = new System.Drawing.Point(147, 213);
            this.Compile.Name = "Compile";
            this.Compile.Size = new System.Drawing.Size(146, 47);
            this.Compile.TabIndex = 3;
            this.Compile.Text = "Compile";
            this.Compile.UseVisualStyleBackColor = true;
            this.Compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 465);
            this.Controls.Add(this.Compile);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Commands);
            this.Controls.Add(this.Input);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label Commands;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Compile;
    }
}

