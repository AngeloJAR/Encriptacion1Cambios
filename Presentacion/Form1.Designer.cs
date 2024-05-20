namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMostrarMensajeEncriptado = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de encriptacion \r\ny \r\ndesencriptacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(43, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtClave.Location = new System.Drawing.Point(151, 211);
            this.txtClave.MaxLength = 50;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(279, 32);
            this.txtClave.TabIndex = 2;
            this.txtClave.Text = "Ingrese su clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(32, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtMensaje.Location = new System.Drawing.Point(151, 284);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(279, 31);
            this.txtMensaje.TabIndex = 4;
            this.txtMensaje.Text = "Ingrese el mensaje";
            this.txtMensaje.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(146, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mensaje Encriptado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMostrarMensajeEncriptado
            // 
            this.txtMostrarMensajeEncriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtMostrarMensajeEncriptado.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarMensajeEncriptado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtMostrarMensajeEncriptado.Location = new System.Drawing.Point(48, 456);
            this.txtMostrarMensajeEncriptado.Multiline = true;
            this.txtMostrarMensajeEncriptado.Name = "txtMostrarMensajeEncriptado";
            this.txtMostrarMensajeEncriptado.Size = new System.Drawing.Size(382, 71);
            this.txtMostrarMensajeEncriptado.TabIndex = 8;
            this.txtMostrarMensajeEncriptado.Text = "Mensaje encriptado";
            this.txtMostrarMensajeEncriptado.TextChanged += new System.EventHandler(this.txtMostrarMensajeEncriptado_TextChanged);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.FlatAppearance.BorderSize = 0;
            this.btnEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEncriptar.Location = new System.Drawing.Point(37, 344);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(141, 57);
            this.btnEncriptar.TabIndex = 9;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.FlatAppearance.BorderSize = 0;
            this.btnDesencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesencriptar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDesencriptar.Location = new System.Drawing.Point(303, 344);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(127, 57);
            this.btnDesencriptar.TabIndex = 10;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(492, 582);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtMostrarMensajeEncriptado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Encriptacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMostrarMensajeEncriptado;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
    }
}

