
namespace Client
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
            this.text = new System.Windows.Forms.Label();
            this.hw_id_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(67, 32);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(64, 13);
            this.text.TabIndex = 0;
            this.text.Text = "HardwareID";
            // 
            // hw_id_value
            // 
            this.hw_id_value.AutoSize = true;
            this.hw_id_value.Location = new System.Drawing.Point(155, 32);
            this.hw_id_value.Name = "hw_id_value";
            this.hw_id_value.Size = new System.Drawing.Size(35, 13);
            this.hw_id_value.TabIndex = 1;
            this.hw_id_value.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hw_id_value);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label hw_id_value;
    }
}

