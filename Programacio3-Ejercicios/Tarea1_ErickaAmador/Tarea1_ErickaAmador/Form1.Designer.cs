namespace Tarea1_ErickaAmador
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
            this.IngreseNumeroLabel = new System.Windows.Forms.Label();
            this.IngreseNumeroTextBox = new System.Windows.Forms.TextBox();
            this.ProcesarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IngreseNumeroLabel
            // 
            this.IngreseNumeroLabel.AutoSize = true;
            this.IngreseNumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseNumeroLabel.Location = new System.Drawing.Point(71, 105);
            this.IngreseNumeroLabel.Name = "IngreseNumeroLabel";
            this.IngreseNumeroLabel.Size = new System.Drawing.Size(114, 15);
            this.IngreseNumeroLabel.TabIndex = 0;
            this.IngreseNumeroLabel.Text = "Ingrese Número:";
            // 
            // IngreseNumeroTextBox
            // 
            this.IngreseNumeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseNumeroTextBox.Location = new System.Drawing.Point(193, 105);
            this.IngreseNumeroTextBox.Name = "IngreseNumeroTextBox";
            this.IngreseNumeroTextBox.Size = new System.Drawing.Size(100, 21);
            this.IngreseNumeroTextBox.TabIndex = 1;
            // 
            // ProcesarButton
            // 
            this.ProcesarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcesarButton.Location = new System.Drawing.Point(148, 163);
            this.ProcesarButton.Name = "ProcesarButton";
            this.ProcesarButton.Size = new System.Drawing.Size(87, 35);
            this.ProcesarButton.TabIndex = 2;
            this.ProcesarButton.Text = "Procesar";
            this.ProcesarButton.UseVisualStyleBackColor = true;
            this.ProcesarButton.Click += new System.EventHandler(this.ProcesarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar solo numeros enteros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(390, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcesarButton);
            this.Controls.Add(this.IngreseNumeroTextBox);
            this.Controls.Add(this.IngreseNumeroLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Tarea1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngreseNumeroLabel;
        private System.Windows.Forms.TextBox IngreseNumeroTextBox;
        private System.Windows.Forms.Button ProcesarButton;
        private System.Windows.Forms.Label label1;
    }
}

