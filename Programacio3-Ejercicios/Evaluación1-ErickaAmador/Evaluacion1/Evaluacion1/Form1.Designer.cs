namespace Evaluacion1
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
            this.VentasTextBox = new System.Windows.Forms.TextBox();
            this.VentasPromedioLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.NacimientoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.IngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.IngresoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SueldoTotalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VentasTextBox
            // 
            this.VentasTextBox.Location = new System.Drawing.Point(213, 126);
            this.VentasTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VentasTextBox.Name = "VentasTextBox";
            this.VentasTextBox.Size = new System.Drawing.Size(148, 25);
            this.VentasTextBox.TabIndex = 0;
            // 
            // VentasPromedioLabel
            // 
            this.VentasPromedioLabel.AutoSize = true;
            this.VentasPromedioLabel.Location = new System.Drawing.Point(57, 134);
            this.VentasPromedioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VentasPromedioLabel.Name = "VentasPromedioLabel";
            this.VentasPromedioLabel.Size = new System.Drawing.Size(133, 17);
            this.VentasPromedioLabel.TabIndex = 1;
            this.VentasPromedioLabel.Text = "Ventas Promedio: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de Ingreso: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calcular Salario Total De Un Empleado";
            // 
            // CalcularButton
            // 
            this.CalcularButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalcularButton.Location = new System.Drawing.Point(213, 236);
            this.CalcularButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(112, 31);
            this.CalcularButton.TabIndex = 7;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = false;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // NacimientoDateTimePicker1
            // 
            this.NacimientoDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NacimientoDateTimePicker1.Location = new System.Drawing.Point(213, 157);
            this.NacimientoDateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NacimientoDateTimePicker1.Name = "NacimientoDateTimePicker1";
            this.NacimientoDateTimePicker1.Size = new System.Drawing.Size(148, 25);
            this.NacimientoDateTimePicker1.TabIndex = 8;
            // 
            // IngresoDateTimePicker
            // 
            this.IngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IngresoDateTimePicker.Location = new System.Drawing.Point(213, 193);
            this.IngresoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IngresoDateTimePicker.Name = "IngresoDateTimePicker";
            this.IngresoDateTimePicker.Size = new System.Drawing.Size(148, 25);
            this.IngresoDateTimePicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edad:";
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(213, 284);
            this.EdadTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(148, 25);
            this.EdadTextBox.TabIndex = 11;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(37, 329);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(146, 17);
            this.Label.TabIndex = 12;
            this.Label.Text = "Años en la empresa:";
            // 
            // IngresoTextBox
            // 
            this.IngresoTextBox.Location = new System.Drawing.Point(213, 321);
            this.IngresoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IngresoTextBox.Name = "IngresoTextBox";
            this.IngresoTextBox.Size = new System.Drawing.Size(148, 25);
            this.IngresoTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sueldo Total:";
            // 
            // SueldoTotalTextBox
            // 
            this.SueldoTotalTextBox.Location = new System.Drawing.Point(213, 369);
            this.SueldoTotalTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SueldoTotalTextBox.Name = "SueldoTotalTextBox";
            this.SueldoTotalTextBox.Size = new System.Drawing.Size(148, 25);
            this.SueldoTotalTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Salario Base: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lps. 10,000.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(518, 426);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SueldoTotalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IngresoTextBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IngresoDateTimePicker);
            this.Controls.Add(this.NacimientoDateTimePicker1);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VentasPromedioLabel);
            this.Controls.Add(this.VentasTextBox);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VentasTextBox;
        private System.Windows.Forms.Label VentasPromedioLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.DateTimePicker NacimientoDateTimePicker1;
        private System.Windows.Forms.DateTimePicker IngresoDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox IngresoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SueldoTotalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

