
namespace Ex1
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
            this.btnclic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclic
            // 
            this.btnclic.Location = new System.Drawing.Point(29, 223);
            this.btnclic.Name = "btnclic";
            this.btnclic.Size = new System.Drawing.Size(213, 23);
            this.btnclic.TabIndex = 0;
            this.btnclic.Text = "Calcular Total de palavras";
            this.btnclic.UseVisualStyleBackColor = true;
            this.btnclic.Click += new System.EventHandler(this.btnclic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto";
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(71, 22);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(187, 23);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.BindingContextChanged += new System.EventHandler(this.currentText);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total de Palavras: ";
            // 
            // lbcont
            // 
            this.lbcont.AutoSize = true;
            this.lbcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcont.Location = new System.Drawing.Point(226, 112);
            this.lbcont.Name = "lbcont";
            this.lbcont.Size = new System.Drawing.Size(16, 17);
            this.lbcont.TabIndex = 4;
            this.lbcont.Text = "0";
            this.lbcont.BindingContextChanged += new System.EventHandler(this.contpalavra);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 258);
            this.Controls.Add(this.lbcont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbcont;
    }
}

