namespace EduardoPerez
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
            this.CapitalTextBox = new System.Windows.Forms.TextBox();
            this.MesesListBox = new System.Windows.Forms.ListBox();
            this.MesComboBox = new System.Windows.Forms.ComboBox();
            this.InteresesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.TasaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes";
            // 
            // CapitalTextBox
            // 
            this.CapitalTextBox.Location = new System.Drawing.Point(195, 43);
            this.CapitalTextBox.Name = "CapitalTextBox";
            this.CapitalTextBox.Size = new System.Drawing.Size(103, 20);
            this.CapitalTextBox.TabIndex = 2;
            // 
            // MesesListBox
            // 
            this.MesesListBox.FormattingEnabled = true;
            this.MesesListBox.Location = new System.Drawing.Point(43, 265);
            this.MesesListBox.Name = "MesesListBox";
            this.MesesListBox.Size = new System.Drawing.Size(120, 173);
            this.MesesListBox.TabIndex = 3;
            // 
            // MesComboBox
            // 
            this.MesComboBox.FormattingEnabled = true;
            this.MesComboBox.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.MesComboBox.Location = new System.Drawing.Point(195, 112);
            this.MesComboBox.Name = "MesComboBox";
            this.MesComboBox.Size = new System.Drawing.Size(103, 21);
            this.MesComboBox.TabIndex = 4;
            // 
            // InteresesListBox
            // 
            this.InteresesListBox.FormattingEnabled = true;
            this.InteresesListBox.Location = new System.Drawing.Point(195, 265);
            this.InteresesListBox.Name = "InteresesListBox";
            this.InteresesListBox.Size = new System.Drawing.Size(134, 173);
            this.InteresesListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Meses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intereses";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(154, 150);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 8;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // TasaTextBox
            // 
            this.TasaTextBox.Enabled = false;
            this.TasaTextBox.Location = new System.Drawing.Point(195, 76);
            this.TasaTextBox.Name = "TasaTextBox";
            this.TasaTextBox.Size = new System.Drawing.Size(103, 20);
            this.TasaTextBox.TabIndex = 10;
            this.TasaTextBox.Text = "1.5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tasa de Interes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Resultado";
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(195, 191);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadoTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TasaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InteresesListBox);
            this.Controls.Add(this.MesComboBox);
            this.Controls.Add(this.MesesListBox);
            this.Controls.Add(this.CapitalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CapitalTextBox;
        private System.Windows.Forms.ListBox MesesListBox;
        private System.Windows.Forms.ComboBox MesComboBox;
        private System.Windows.Forms.ListBox InteresesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox TasaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResultadoTextBox;
    }
}

