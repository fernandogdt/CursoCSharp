
namespace Switch_case
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btProximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSemana
            // 
            this.cbSemana.FormattingEnabled = true;
            this.cbSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sabado"});
            this.cbSemana.Location = new System.Drawing.Point(47, 68);
            this.cbSemana.Name = "cbSemana";
            this.cbSemana.Size = new System.Drawing.Size(121, 23);
            this.cbSemana.TabIndex = 0;
            this.cbSemana.SelectedIndexChanged += new System.EventHandler(this.cbSemana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha um dia da semana";
            // 
            // btProximo
            // 
            this.btProximo.Location = new System.Drawing.Point(119, 163);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(75, 23);
            this.btProximo.TabIndex = 2;
            this.btProximo.Text = "Proximo Exemplo";
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 198);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSemana);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btProximo;
    }
}

