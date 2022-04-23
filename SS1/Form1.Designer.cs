namespace SS1
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
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.labelEncender = new System.Windows.Forms.Label();
            this.labelDatos = new System.Windows.Forms.Label();
            this.labelAcelerar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAcelerar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAcelerar.Location = new System.Drawing.Point(341, 227);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(161, 41);
            this.buttonAcelerar.TabIndex = 0;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEncender.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEncender.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonEncender.Location = new System.Drawing.Point(74, 111);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(185, 57);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender Motor";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // labelEncender
            // 
            this.labelEncender.AutoSize = true;
            this.labelEncender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEncender.Location = new System.Drawing.Point(311, 133);
            this.labelEncender.Name = "labelEncender";
            this.labelEncender.Size = new System.Drawing.Size(0, 18);
            this.labelEncender.TabIndex = 3;
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDatos.Location = new System.Drawing.Point(57, 381);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(0, 18);
            this.labelDatos.TabIndex = 4;
            // 
            // labelAcelerar
            // 
            this.labelAcelerar.AutoSize = true;
            this.labelAcelerar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAcelerar.Location = new System.Drawing.Point(74, 43);
            this.labelAcelerar.Name = "labelAcelerar";
            this.labelAcelerar.Size = new System.Drawing.Size(0, 18);
            this.labelAcelerar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAcelerar);
            this.Controls.Add(this.labelDatos);
            this.Controls.Add(this.labelEncender);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttonAcelerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAcelerar;
        private Button buttonEncender;
        private Label labelEncender;
        private Label labelDatos;
        private Label labelAcelerar;
    }
}