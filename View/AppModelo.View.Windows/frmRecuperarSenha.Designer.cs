namespace AppModelo.View.Windows
{
    partial class frmRecuperarSenha
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
            this.txtEmailRecuperarSenha = new System.Windows.Forms.TextBox();
            this.btnRecuperarSenha = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(114, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperar senha";
            // 
            // txtEmailRecuperarSenha
            // 
            this.txtEmailRecuperarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRecuperarSenha.Location = new System.Drawing.Point(88, 100);
            this.txtEmailRecuperarSenha.Name = "txtEmailRecuperarSenha";
            this.txtEmailRecuperarSenha.Size = new System.Drawing.Size(304, 26);
            this.txtEmailRecuperarSenha.TabIndex = 1;
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.BackColor = System.Drawing.Color.Silver;
            this.btnRecuperarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarSenha.Location = new System.Drawing.Point(88, 149);
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Size = new System.Drawing.Size(304, 32);
            this.btnRecuperarSenha.TabIndex = 2;
            this.btnRecuperarSenha.Text = "RECUPERAR ACESSO";
            this.btnRecuperarSenha.UseVisualStyleBackColor = false;
            this.btnRecuperarSenha.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(88, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(304, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(489, 250);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRecuperarSenha);
            this.Controls.Add(this.txtEmailRecuperarSenha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmRecuperarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailRecuperarSenha;
        private System.Windows.Forms.Button btnRecuperarSenha;
        private System.Windows.Forms.Button btnCancelar;
    }
}