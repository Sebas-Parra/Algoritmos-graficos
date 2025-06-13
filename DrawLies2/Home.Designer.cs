namespace DrawLies2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblTitleGeneral = new System.Windows.Forms.Label();
            this.btnAnalizadorDiferencial = new System.Windows.Forms.Button();
            this.btnRellenoFiguras = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TitleDDA = new System.Windows.Forms.GroupBox();
            this.TitleBresenham = new System.Windows.Forms.GroupBox();
            this.btnBresenham = new System.Windows.Forms.Button();
            this.TitleCirculos = new System.Windows.Forms.GroupBox();
            this.btnCircunferencia = new System.Windows.Forms.Button();
            this.TitleRelleno = new System.Windows.Forms.GroupBox();
            this.btnRelleno = new System.Windows.Forms.Button();
            this.TitleDDA.SuspendLayout();
            this.TitleBresenham.SuspendLayout();
            this.TitleCirculos.SuspendLayout();
            this.TitleRelleno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleGeneral
            // 
            this.lblTitleGeneral.AutoSize = true;
            this.lblTitleGeneral.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblTitleGeneral.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGeneral.Location = new System.Drawing.Point(323, 69);
            this.lblTitleGeneral.Name = "lblTitleGeneral";
            this.lblTitleGeneral.Size = new System.Drawing.Size(394, 37);
            this.lblTitleGeneral.TabIndex = 0;
            this.lblTitleGeneral.Text = "Algoritmos gráficos básicos";
            // 
            // btnAnalizadorDiferencial
            // 
            this.btnAnalizadorDiferencial.Location = new System.Drawing.Point(47, 43);
            this.btnAnalizadorDiferencial.Name = "btnAnalizadorDiferencial";
            this.btnAnalizadorDiferencial.Size = new System.Drawing.Size(95, 35);
            this.btnAnalizadorDiferencial.TabIndex = 5;
            this.btnAnalizadorDiferencial.Text = "Acceder";
            this.btnAnalizadorDiferencial.UseVisualStyleBackColor = true;
            this.btnAnalizadorDiferencial.Click += new System.EventHandler(this.btnAnalizadorDiferencial_Click);
            // 
            // btnRellenoFiguras
            // 
            this.btnRellenoFiguras.Location = new System.Drawing.Point(60, 194);
            this.btnRellenoFiguras.Name = "btnRellenoFiguras";
            this.btnRellenoFiguras.Size = new System.Drawing.Size(95, 29);
            this.btnRellenoFiguras.TabIndex = 9;
            this.btnRellenoFiguras.Text = "Acceder";
            this.btnRellenoFiguras.UseVisualStyleBackColor = true;
            this.btnRellenoFiguras.Click += new System.EventHandler(this.btnRellenoFiguras_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Demostración";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dibujar una figura \r\nregular y rellenarla";
            // 
            // TitleDDA
            // 
            this.TitleDDA.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleDDA.Controls.Add(this.btnAnalizadorDiferencial);
            this.TitleDDA.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDDA.Location = new System.Drawing.Point(35, 170);
            this.TitleDDA.Name = "TitleDDA";
            this.TitleDDA.Size = new System.Drawing.Size(200, 100);
            this.TitleDDA.TabIndex = 12;
            this.TitleDDA.TabStop = false;
            this.TitleDDA.Text = "Algoritmo DDA";
            this.TitleDDA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TitleBresenham
            // 
            this.TitleBresenham.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleBresenham.Controls.Add(this.btnBresenham);
            this.TitleBresenham.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBresenham.Location = new System.Drawing.Point(270, 170);
            this.TitleBresenham.Name = "TitleBresenham";
            this.TitleBresenham.Size = new System.Drawing.Size(217, 100);
            this.TitleBresenham.TabIndex = 13;
            this.TitleBresenham.TabStop = false;
            this.TitleBresenham.Text = "Algoritmo Bresenham";
            // 
            // btnBresenham
            // 
            this.btnBresenham.Location = new System.Drawing.Point(60, 43);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(95, 35);
            this.btnBresenham.TabIndex = 5;
            this.btnBresenham.Text = "Acceder";
            this.btnBresenham.UseVisualStyleBackColor = true;
            this.btnBresenham.Click += new System.EventHandler(this.btnBresenham_Click);
            // 
            // TitleCirculos
            // 
            this.TitleCirculos.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleCirculos.Controls.Add(this.btnCircunferencia);
            this.TitleCirculos.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCirculos.Location = new System.Drawing.Point(525, 170);
            this.TitleCirculos.Name = "TitleCirculos";
            this.TitleCirculos.Size = new System.Drawing.Size(217, 100);
            this.TitleCirculos.TabIndex = 14;
            this.TitleCirculos.TabStop = false;
            this.TitleCirculos.Text = "Bresenham para circunferencias";
            // 
            // btnCircunferencia
            // 
            this.btnCircunferencia.Location = new System.Drawing.Point(58, 55);
            this.btnCircunferencia.Name = "btnCircunferencia";
            this.btnCircunferencia.Size = new System.Drawing.Size(95, 35);
            this.btnCircunferencia.TabIndex = 5;
            this.btnCircunferencia.Text = "Acceder";
            this.btnCircunferencia.UseVisualStyleBackColor = true;
            this.btnCircunferencia.Click += new System.EventHandler(this.btnCircunferencia_Click);
            // 
            // TitleRelleno
            // 
            this.TitleRelleno.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleRelleno.Controls.Add(this.btnRelleno);
            this.TitleRelleno.Controls.Add(this.label6);
            this.TitleRelleno.Controls.Add(this.label7);
            this.TitleRelleno.Controls.Add(this.btnRellenoFiguras);
            this.TitleRelleno.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRelleno.Location = new System.Drawing.Point(770, 152);
            this.TitleRelleno.Name = "TitleRelleno";
            this.TitleRelleno.Size = new System.Drawing.Size(217, 258);
            this.TitleRelleno.TabIndex = 15;
            this.TitleRelleno.TabStop = false;
            this.TitleRelleno.Text = "Algoritmo de relleno de figuras";
            // 
            // btnRelleno
            // 
            this.btnRelleno.Location = new System.Drawing.Point(60, 97);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(95, 35);
            this.btnRelleno.TabIndex = 5;
            this.btnRelleno.Text = "Acceder";
            this.btnRelleno.UseVisualStyleBackColor = true;
            this.btnRelleno.Click += new System.EventHandler(this.btnRelleno_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 449);
            this.Controls.Add(this.TitleRelleno);
            this.Controls.Add(this.TitleCirculos);
            this.Controls.Add(this.TitleBresenham);
            this.Controls.Add(this.lblTitleGeneral);
            this.Controls.Add(this.TitleDDA);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.TitleDDA.ResumeLayout(false);
            this.TitleBresenham.ResumeLayout(false);
            this.TitleCirculos.ResumeLayout(false);
            this.TitleRelleno.ResumeLayout(false);
            this.TitleRelleno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleGeneral;
        private System.Windows.Forms.Button btnAnalizadorDiferencial;
        private System.Windows.Forms.Button btnRellenoFiguras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox TitleDDA;
        private System.Windows.Forms.GroupBox TitleBresenham;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.GroupBox TitleCirculos;
        private System.Windows.Forms.Button btnCircunferencia;
        private System.Windows.Forms.GroupBox TitleRelleno;
        private System.Windows.Forms.Button btnRelleno;
    }
}