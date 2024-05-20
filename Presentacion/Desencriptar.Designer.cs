namespace Presentacion
{
    partial class Desencriptar
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
            this.ClaveEncriptada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MensajeDesencriptado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClaveEncriptada
            // 
            this.ClaveEncriptada.Location = new System.Drawing.Point(522, 142);
            this.ClaveEncriptada.Name = "ClaveEncriptada";
            this.ClaveEncriptada.Size = new System.Drawing.Size(218, 22);
            this.ClaveEncriptada.TabIndex = 0;
            this.ClaveEncriptada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClaveEncriptada.TextChanged += new System.EventHandler(this.ClaveEncriptada_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la clave encriptada";
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(554, 404);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(166, 59);
            this.btnDesencriptar.TabIndex = 2;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desencriptacion de mensaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensaje Desencriptado";
            // 
            // MensajeDesencriptado
            // 
            this.MensajeDesencriptado.Location = new System.Drawing.Point(476, 233);
            this.MensajeDesencriptado.Multiline = true;
            this.MensajeDesencriptado.Name = "MensajeDesencriptado";
            this.MensajeDesencriptado.Size = new System.Drawing.Size(315, 150);
            this.MensajeDesencriptado.TabIndex = 5;
            this.MensajeDesencriptado.TextChanged += new System.EventHandler(this.MensajeDesencriptado_TextChanged);
            // 
            // Desencriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 730);
            this.Controls.Add(this.MensajeDesencriptado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClaveEncriptada);
            this.Name = "Desencriptar";
            this.Text = "Desencriptar";
            this.Load += new System.EventHandler(this.Desencriptar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClaveEncriptada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MensajeDesencriptado;
    }
}