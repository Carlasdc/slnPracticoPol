namespace WindowsPresentacion
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
            this.btnAfinar = new System.Windows.Forms.Button();
            this.btnAjedrez = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConejo = new System.Windows.Forms.Button();
            this.btnLoro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfinar
            // 
            this.btnAfinar.Location = new System.Drawing.Point(182, 47);
            this.btnAfinar.Name = "btnAfinar";
            this.btnAfinar.Size = new System.Drawing.Size(164, 23);
            this.btnAfinar.TabIndex = 0;
            this.btnAfinar.Text = "Afinar Instrumento";
            this.btnAfinar.UseVisualStyleBackColor = true;
            this.btnAfinar.Click += new System.EventHandler(this.btnAfinar_Click);
            // 
            // btnAjedrez
            // 
            this.btnAjedrez.Location = new System.Drawing.Point(182, 110);
            this.btnAjedrez.Name = "btnAjedrez";
            this.btnAjedrez.Size = new System.Drawing.Size(164, 23);
            this.btnAjedrez.TabIndex = 0;
            this.btnAjedrez.Text = "Iniciar Ajedrez";
            this.btnAjedrez.UseVisualStyleBackColor = true;
            this.btnAjedrez.Click += new System.EventHandler(this.btnAjedrez_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(182, 175);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(164, 23);
            this.btnMedico.TabIndex = 0;
            this.btnMedico.Text = "Iniciar Ej Medico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnAnimales
            // 
            this.btnAnimales.Location = new System.Drawing.Point(105, 292);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(66, 23);
            this.btnAnimales.TabIndex = 0;
            this.btnAnimales.Text = "Leon";
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ejercicio Animales";
            // 
            // btnConejo
            // 
            this.btnConejo.Location = new System.Drawing.Point(231, 292);
            this.btnConejo.Name = "btnConejo";
            this.btnConejo.Size = new System.Drawing.Size(75, 23);
            this.btnConejo.TabIndex = 2;
            this.btnConejo.Text = "Conejo";
            this.btnConejo.UseVisualStyleBackColor = true;
            this.btnConejo.Click += new System.EventHandler(this.btnConejo_Click);
            // 
            // btnLoro
            // 
            this.btnLoro.Location = new System.Drawing.Point(359, 292);
            this.btnLoro.Name = "btnLoro";
            this.btnLoro.Size = new System.Drawing.Size(75, 23);
            this.btnLoro.TabIndex = 3;
            this.btnLoro.Text = "Loro";
            this.btnLoro.UseVisualStyleBackColor = true;
            this.btnLoro.Click += new System.EventHandler(this.btnLoro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 380);
            this.Controls.Add(this.btnLoro);
            this.Controls.Add(this.btnConejo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnimales);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnAjedrez);
            this.Controls.Add(this.btnAfinar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAfinar;
        private Button btnAjedrez;
        private Button btnMedico;
        private Button btnAnimales;
        private Label label1;
        private Button btnConejo;
        private Button btnLoro;
    }
}