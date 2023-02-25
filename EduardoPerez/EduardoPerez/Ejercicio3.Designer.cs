namespace EduardoPerez
{
    partial class Ejercicio3
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
            this.DatosListBox = new System.Windows.Forms.ListBox();
            this.CalculaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatosListBox
            // 
            this.DatosListBox.FormattingEnabled = true;
            this.DatosListBox.Location = new System.Drawing.Point(31, 68);
            this.DatosListBox.Name = "DatosListBox";
            this.DatosListBox.Size = new System.Drawing.Size(332, 459);
            this.DatosListBox.TabIndex = 0;
            // 
            // CalculaButton
            // 
            this.CalculaButton.Location = new System.Drawing.Point(151, 549);
            this.CalculaButton.Name = "CalculaButton";
            this.CalculaButton.Size = new System.Drawing.Size(75, 23);
            this.CalculaButton.TabIndex = 1;
            this.CalculaButton.Text = "Mostrar";
            this.CalculaButton.UseVisualStyleBackColor = true;
            this.CalculaButton.Click += new System.EventHandler(this.CalculaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Múltiplos";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculaButton);
            this.Controls.Add(this.DatosListBox);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DatosListBox;
        private System.Windows.Forms.Button CalculaButton;
        private System.Windows.Forms.Label label1;
    }
}