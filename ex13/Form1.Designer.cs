
namespace ex13
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.ltbResult = new System.Windows.Forms.ListBox();
            this.ltbRepit = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(111, 31);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(221, 20);
            this.txtEntrada.TabIndex = 1;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 139);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(55, 13);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Resultado";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(137, 310);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // ltbResult
            // 
            this.ltbResult.FormattingEnabled = true;
            this.ltbResult.Location = new System.Drawing.Point(12, 155);
            this.ltbResult.Name = "ltbResult";
            this.ltbResult.Size = new System.Drawing.Size(120, 95);
            this.ltbResult.TabIndex = 4;
            // 
            // ltbRepit
            // 
            this.ltbRepit.FormattingEnabled = true;
            this.ltbRepit.Location = new System.Drawing.Point(138, 155);
            this.ltbRepit.Name = "ltbRepit";
            this.ltbRepit.Size = new System.Drawing.Size(120, 95);
            this.ltbRepit.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vezes Repetidas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltbRepit);
            this.Controls.Add(this.ltbResult);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ListBox ltbResult;
        private System.Windows.Forms.ListBox ltbRepit;
        private System.Windows.Forms.Label label2;
    }
}

