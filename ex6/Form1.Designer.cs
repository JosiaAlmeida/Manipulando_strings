
namespace ex6
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
            this.lbresult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOcorrencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbresult.Location = new System.Drawing.Point(101, 129);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(20, 17);
            this.lbresult.TabIndex = 7;
            this.lbresult.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado:";
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(173, 76);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(195, 23);
            this.txtTexto.TabIndex = 5;
            this.txtTexto.BindingContextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Texto:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(173, 18);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(195, 23);
            this.txtPalavra.TabIndex = 9;
            this.txtPalavra.BindingContextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Palavra ";
            // 
            // btnOcorrencia
            // 
            this.btnOcorrencia.Location = new System.Drawing.Point(93, 167);
            this.btnOcorrencia.Name = "btnOcorrencia";
            this.btnOcorrencia.Size = new System.Drawing.Size(219, 34);
            this.btnOcorrencia.TabIndex = 10;
            this.btnOcorrencia.Text = "Ocorrencia";
            this.btnOcorrencia.UseVisualStyleBackColor = true;
            this.btnOcorrencia.Click += new System.EventHandler(this.btnOcorrencia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 213);
            this.Controls.Add(this.btnOcorrencia);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOcorrencia;
    }
}

