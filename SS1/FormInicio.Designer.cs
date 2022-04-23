namespace SS1
{
    partial class FormInicio
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
            this.comboBoxMarcas = new System.Windows.Forms.ComboBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMaxVel = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.buttonNewCar = new System.Windows.Forms.Button();
            this.labelMarcas = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMaxVel = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMarcas
            // 
            this.comboBoxMarcas.FormattingEnabled = true;
            this.comboBoxMarcas.Items.AddRange(new object[] {
            "Ford",
            "KIA",
            "Jeep",
            "BMW"});
            this.comboBoxMarcas.Location = new System.Drawing.Point(237, 60);
            this.comboBoxMarcas.Name = "comboBoxMarcas";
            this.comboBoxMarcas.Size = new System.Drawing.Size(175, 23);
            this.comboBoxMarcas.TabIndex = 0;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(241, 127);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 23);
            this.textBoxModelo.TabIndex = 1;
            // 
            // textBoxMaxVel
            // 
            this.textBoxMaxVel.Location = new System.Drawing.Point(241, 178);
            this.textBoxMaxVel.Name = "textBoxMaxVel";
            this.textBoxMaxVel.Size = new System.Drawing.Size(100, 23);
            this.textBoxMaxVel.TabIndex = 2;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(241, 231);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(100, 23);
            this.textBoxOwner.TabIndex = 3;
            // 
            // buttonNewCar
            // 
            this.buttonNewCar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonNewCar.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNewCar.Location = new System.Drawing.Point(320, 298);
            this.buttonNewCar.Name = "buttonNewCar";
            this.buttonNewCar.Size = new System.Drawing.Size(141, 42);
            this.buttonNewCar.TabIndex = 4;
            this.buttonNewCar.Text = "Crear";
            this.buttonNewCar.UseVisualStyleBackColor = false;
            this.buttonNewCar.Click += new System.EventHandler(this.buttonNewCar_Click);
            // 
            // labelMarcas
            // 
            this.labelMarcas.AutoSize = true;
            this.labelMarcas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMarcas.Location = new System.Drawing.Point(75, 60);
            this.labelMarcas.Name = "labelMarcas";
            this.labelMarcas.Size = new System.Drawing.Size(76, 23);
            this.labelMarcas.TabIndex = 5;
            this.labelMarcas.Text = "Marcas";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModelo.Location = new System.Drawing.Point(75, 127);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(79, 23);
            this.labelModelo.TabIndex = 6;
            this.labelModelo.Text = "Modelo";
            // 
            // labelMaxVel
            // 
            this.labelMaxVel.AutoSize = true;
            this.labelMaxVel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxVel.Location = new System.Drawing.Point(75, 186);
            this.labelMaxVel.Name = "labelMaxVel";
            this.labelMaxVel.Size = new System.Drawing.Size(84, 23);
            this.labelMaxVel.TabIndex = 7;
            this.labelMaxVel.Text = "Max Vel";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOwner.Location = new System.Drawing.Point(75, 239);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(114, 23);
            this.labelOwner.TabIndex = 8;
            this.labelOwner.Text = "Propietario";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelMaxVel);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarcas);
            this.Controls.Add(this.buttonNewCar);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.textBoxMaxVel);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.comboBoxMarcas);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxMarcas;
        private TextBox textBoxModelo;
        private TextBox textBoxMaxVel;
        private TextBox textBoxOwner;
        private Button buttonNewCar;
        private Label labelMarcas;
        private Label labelModelo;
        private Label labelMaxVel;
        private Label labelOwner;
    }
}