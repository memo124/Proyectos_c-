namespace salario_empleado
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbruto = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtneto = new System.Windows.Forms.TextBox();
            this.rbg = new System.Windows.Forms.RadioButton();
            this.rgsg = new System.Windows.Forms.RadioButton();
            this.rbs = new System.Windows.Forms.RadioButton();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salario bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salario neto";
            // 
            // txtbruto
            // 
            this.txtbruto.Location = new System.Drawing.Point(175, 115);
            this.txtbruto.Name = "txtbruto";
            this.txtbruto.Size = new System.Drawing.Size(100, 20);
            this.txtbruto.TabIndex = 7;
            // 
            // txtdesc
            // 
            this.txtdesc.Enabled = false;
            this.txtdesc.Location = new System.Drawing.Point(175, 149);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(100, 20);
            this.txtdesc.TabIndex = 8;
            this.txtdesc.TextChanged += new System.EventHandler(this.txtdesc_TextChanged);
            // 
            // txtneto
            // 
            this.txtneto.Enabled = false;
            this.txtneto.Location = new System.Drawing.Point(175, 183);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(100, 20);
            this.txtneto.TabIndex = 9;
            // 
            // rbg
            // 
            this.rbg.AutoSize = true;
            this.rbg.Location = new System.Drawing.Point(331, 118);
            this.rbg.Name = "rbg";
            this.rbg.Size = new System.Drawing.Size(63, 17);
            this.rbg.TabIndex = 10;
            this.rbg.TabStop = true;
            this.rbg.Text = "Gerente";
            this.rbg.UseVisualStyleBackColor = true;
            // 
            // rgsg
            // 
            this.rgsg.AutoSize = true;
            this.rgsg.Location = new System.Drawing.Point(331, 151);
            this.rgsg.Name = "rgsg";
            this.rgsg.Size = new System.Drawing.Size(80, 17);
            this.rgsg.TabIndex = 11;
            this.rgsg.TabStop = true;
            this.rgsg.Text = "Subgerente";
            this.rgsg.UseVisualStyleBackColor = true;
            // 
            // rbs
            // 
            this.rbs.AutoSize = true;
            this.rbs.Location = new System.Drawing.Point(331, 183);
            this.rbs.Name = "rbs";
            this.rbs.Size = new System.Drawing.Size(73, 17);
            this.rbs.TabIndex = 12;
            this.rbs.TabStop = true;
            this.rbs.Text = "Secretaria";
            this.rbs.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(175, 244);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 322);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.rbs);
            this.Controls.Add(this.rgsg);
            this.Controls.Add(this.rbg);
            this.Controls.Add(this.txtneto);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtbruto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbruto;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtneto;
        private System.Windows.Forms.RadioButton rbg;
        private System.Windows.Forms.RadioButton rgsg;
        private System.Windows.Forms.RadioButton rbs;
        private System.Windows.Forms.Button btncalcular;
    }
}

