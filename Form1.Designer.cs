
namespace GettingToKnowSourceControl
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
            this.DoubleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compLabel = new System.Windows.Forms.Label();
            this.getCompBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoubleBtn
            // 
            this.DoubleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleBtn.Location = new System.Drawing.Point(105, 199);
            this.DoubleBtn.Name = "DoubleBtn";
            this.DoubleBtn.Size = new System.Drawing.Size(195, 99);
            this.DoubleBtn.TabIndex = 0;
            this.DoubleBtn.Text = "Double Amount";
            this.DoubleBtn.UseVisualStyleBackColor = true;
            this.DoubleBtn.Click += new System.EventHandler(this.DoubleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click The Button to Double The Amount\r\n";
            // 
            // valueLabel
            // 
            this.valueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.valueLabel.Location = new System.Drawing.Point(95, 99);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(216, 29);
            this.valueLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click The Button To Get a Compliment\r\n";
            // 
            // compLabel
            // 
            this.compLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.compLabel.Location = new System.Drawing.Point(519, 99);
            this.compLabel.Name = "compLabel";
            this.compLabel.Size = new System.Drawing.Size(216, 29);
            this.compLabel.TabIndex = 4;
            // 
            // getCompBtn
            // 
            this.getCompBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCompBtn.Location = new System.Drawing.Point(528, 200);
            this.getCompBtn.Name = "getCompBtn";
            this.getCompBtn.Size = new System.Drawing.Size(195, 99);
            this.getCompBtn.TabIndex = 5;
            this.getCompBtn.Text = "Get a Compliment";
            this.getCompBtn.UseVisualStyleBackColor = true;
            this.getCompBtn.Click += new System.EventHandler(this.getCompBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 395);
            this.Controls.Add(this.getCompBtn);
            this.Controls.Add(this.compLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoubleBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoubleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label compLabel;
        private System.Windows.Forms.Button getCompBtn;
    }
}

