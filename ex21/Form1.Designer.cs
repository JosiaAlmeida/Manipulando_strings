
namespace ex21
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
            this.lbAlfa = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAlfa
            // 
            this.lbAlfa.AutoSize = true;
            this.lbAlfa.Location = new System.Drawing.Point(12, 9);
            this.lbAlfa.Name = "lbAlfa";
            this.lbAlfa.Size = new System.Drawing.Size(16, 13);
            this.lbAlfa.TabIndex = 0;
            this.lbAlfa.Text = "...";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(112, 328);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(166, 23);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Mostrar Alfabeto";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 363);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lbAlfa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAlfa;
        private System.Windows.Forms.Button btnClick;
    }
}

