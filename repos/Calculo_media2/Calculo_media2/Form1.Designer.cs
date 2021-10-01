
namespace Calculo_media2
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
            this.btCalculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNota1 = new System.Windows.Forms.TextBox();
            this.tbNota2 = new System.Windows.Forms.TextBox();
            this.tbNota3 = new System.Windows.Forms.TextBox();
            this.tbMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCalculo
            // 
            this.btCalculo.Location = new System.Drawing.Point(3, 176);
            this.btCalculo.Name = "btCalculo";
            this.btCalculo.Size = new System.Drawing.Size(75, 23);
            this.btCalculo.TabIndex = 0;
            this.btCalculo.Text = "Media";
            this.btCalculo.UseVisualStyleBackColor = true;
            this.btCalculo.Click += new System.EventHandler(this.btCalculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 3:";
            // 
            // tbNota1
            // 
            this.tbNota1.Location = new System.Drawing.Point(119, 39);
            this.tbNota1.Name = "tbNota1";
            this.tbNota1.Size = new System.Drawing.Size(100, 23);
            this.tbNota1.TabIndex = 5;
            // 
            // tbNota2
            // 
            this.tbNota2.Location = new System.Drawing.Point(119, 72);
            this.tbNota2.Name = "tbNota2";
            this.tbNota2.Size = new System.Drawing.Size(100, 23);
            this.tbNota2.TabIndex = 6;
            // 
            // tbNota3
            // 
            this.tbNota3.Location = new System.Drawing.Point(119, 102);
            this.tbNota3.Name = "tbNota3";
            this.tbNota3.Size = new System.Drawing.Size(100, 23);
            this.tbNota3.TabIndex = 7;
            // 
            // tbMedia
            // 
            this.tbMedia.Location = new System.Drawing.Point(119, 131);
            this.tbMedia.Name = "tbMedia";
            this.tbMedia.Size = new System.Drawing.Size(100, 23);
            this.tbMedia.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Media:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(88, 177);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMedia);
            this.Controls.Add(this.tbNota3);
            this.Controls.Add(this.tbNota2);
            this.Controls.Add(this.tbNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalculo);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNota1;
        private System.Windows.Forms.TextBox tbNota2;
        private System.Windows.Forms.TextBox tbNota3;
        private System.Windows.Forms.TextBox tbMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button button1;
    }
}

