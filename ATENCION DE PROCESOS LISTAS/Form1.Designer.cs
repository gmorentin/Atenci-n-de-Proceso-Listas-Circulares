namespace ATENCION_DE_PROCESOS_LISTAS
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
            this.btnComenzar = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.txtVacios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcesoPend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCiclosRest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProcesosAten = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(16, 11);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(100, 28);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(293, 11);
            this.txtReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(193, 530);
            this.txtReporte.TabIndex = 1;
            // 
            // txtVacios
            // 
            this.txtVacios.Location = new System.Drawing.Point(16, 78);
            this.txtVacios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVacios.Name = "txtVacios";
            this.txtVacios.Size = new System.Drawing.Size(132, 22);
            this.txtVacios.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ciclos Vacio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero Max Procesos";
            // 
            // txtNumeroMax
            // 
            this.txtNumeroMax.Location = new System.Drawing.Point(16, 146);
            this.txtNumeroMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroMax.Name = "txtNumeroMax";
            this.txtNumeroMax.Size = new System.Drawing.Size(132, 22);
            this.txtNumeroMax.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Procesos Pendientes";
            // 
            // txtProcesoPend
            // 
            this.txtProcesoPend.Location = new System.Drawing.Point(16, 218);
            this.txtProcesoPend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProcesoPend.Name = "txtProcesoPend";
            this.txtProcesoPend.Size = new System.Drawing.Size(132, 22);
            this.txtProcesoPend.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ciclos Restantes";
            // 
            // txtCiclosRest
            // 
            this.txtCiclosRest.Location = new System.Drawing.Point(16, 295);
            this.txtCiclosRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCiclosRest.Name = "txtCiclosRest";
            this.txtCiclosRest.Size = new System.Drawing.Size(132, 22);
            this.txtCiclosRest.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Procesos Atendidos";
            // 
            // txtProcesosAten
            // 
            this.txtProcesosAten.Location = new System.Drawing.Point(16, 375);
            this.txtProcesosAten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProcesosAten.Name = "txtProcesosAten";
            this.txtProcesosAten.Size = new System.Drawing.Size(132, 22);
            this.txtProcesosAten.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 556);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProcesosAten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCiclosRest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProcesoPend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVacios);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.btnComenzar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.TextBox txtVacios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProcesoPend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCiclosRest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcesosAten;
    }
}

