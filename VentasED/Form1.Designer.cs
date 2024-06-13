namespace VentasED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnProductosArreglo = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(44, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnProductosArreglo
            // 
            btnProductosArreglo.Location = new Point(219, 29);
            btnProductosArreglo.Name = "btnProductosArreglo";
            btnProductosArreglo.Size = new Size(275, 29);
            btnProductosArreglo.TabIndex = 1;
            btnProductosArreglo.Text = "Mostrar productos utilizando arreglos";
            btnProductosArreglo.UseVisualStyleBackColor = true;
            btnProductosArreglo.Click += btnProductosArreglo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProductosArreglo);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnProductosArreglo;
    }
}
