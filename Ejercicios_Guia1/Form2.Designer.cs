namespace Ejercicios_Guia1
{
    partial class Form2
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
            this.brecibido = new System.Windows.Forms.Label();
            this.btnregreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brecibido
            // 
            this.brecibido.AutoSize = true;
            this.brecibido.Location = new System.Drawing.Point(43, 26);
            this.brecibido.Name = "brecibido";
            this.brecibido.Size = new System.Drawing.Size(0, 13);
            this.brecibido.TabIndex = 0;
            // 
            // btnregreso
            // 
            this.btnregreso.Location = new System.Drawing.Point(12, 70);
            this.btnregreso.Name = "btnregreso";
            this.btnregreso.Size = new System.Drawing.Size(75, 23);
            this.btnregreso.TabIndex = 1;
            this.btnregreso.Text = "Regresar";
            this.btnregreso.UseVisualStyleBackColor = true;
            this.btnregreso.Click += new System.EventHandler(this.btnregreso_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregreso);
            this.Controls.Add(this.brecibido);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brecibido;
        private System.Windows.Forms.Button btnregreso;
    }
}