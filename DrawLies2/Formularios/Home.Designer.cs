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
            this.TitleElipses = new System.Windows.Forms.GroupBox();
            this.btnBresenhamElipse = new System.Windows.Forms.Button();
            this.TitleScanline = new System.Windows.Forms.GroupBox();
            this.btnScanline = new System.Windows.Forms.Button();
            this.TitleCohenSutherland = new System.Windows.Forms.GroupBox();
            this.btnCohenSutherland = new System.Windows.Forms.Button();
            this.TitleSutherladnHodgman = new System.Windows.Forms.GroupBox();
            this.btnSutherlandHodgman = new System.Windows.Forms.Button();
            this.TitleBezier = new System.Windows.Forms.GroupBox();
            this.btnBezier = new System.Windows.Forms.Button();
            this.TitleBSplines = new System.Windows.Forms.GroupBox();
            this.btnBSplines = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.TitleDDA.SuspendLayout();
            this.TitleBresenham.SuspendLayout();
            this.TitleCirculos.SuspendLayout();
            this.TitleRelleno.SuspendLayout();
            this.TitleElipses.SuspendLayout();
            this.TitleScanline.SuspendLayout();
            this.TitleCohenSutherland.SuspendLayout();
            this.TitleSutherladnHodgman.SuspendLayout();
            this.TitleBezier.SuspendLayout();
            this.TitleBSplines.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleGeneral
            // 
            this.lblTitleGeneral.AutoSize = true;
            this.lblTitleGeneral.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblTitleGeneral.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGeneral.Location = new System.Drawing.Point(467, 41);
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
            this.TitleDDA.Location = new System.Drawing.Point(141, 216);
            this.TitleDDA.Name = "TitleDDA";
            this.TitleDDA.Size = new System.Drawing.Size(211, 100);
            this.TitleDDA.TabIndex = 12;
            this.TitleDDA.TabStop = false;
            this.TitleDDA.Text = "Algoritmo DDA";
            // 
            // TitleBresenham
            // 
            this.TitleBresenham.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleBresenham.Controls.Add(this.btnBresenham);
            this.TitleBresenham.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBresenham.Location = new System.Drawing.Point(141, 343);
            this.TitleBresenham.Name = "TitleBresenham";
            this.TitleBresenham.Size = new System.Drawing.Size(211, 103);
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
            this.TitleCirculos.Location = new System.Drawing.Point(141, 466);
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
            this.TitleRelleno.Location = new System.Drawing.Point(394, 216);
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
            // TitleElipses
            // 
            this.TitleElipses.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleElipses.Controls.Add(this.btnBresenhamElipse);
            this.TitleElipses.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleElipses.Location = new System.Drawing.Point(141, 598);
            this.TitleElipses.Name = "TitleElipses";
            this.TitleElipses.Size = new System.Drawing.Size(217, 100);
            this.TitleElipses.TabIndex = 15;
            this.TitleElipses.TabStop = false;
            this.TitleElipses.Text = "Bresenham para elipses";
            // 
            // btnBresenhamElipse
            // 
            this.btnBresenhamElipse.Location = new System.Drawing.Point(58, 55);
            this.btnBresenhamElipse.Name = "btnBresenhamElipse";
            this.btnBresenhamElipse.Size = new System.Drawing.Size(95, 35);
            this.btnBresenhamElipse.TabIndex = 5;
            this.btnBresenhamElipse.Text = "Acceder";
            this.btnBresenhamElipse.UseVisualStyleBackColor = true;
            this.btnBresenhamElipse.Click += new System.EventHandler(this.btnBresenhamElipse_Click);
            // 
            // TitleScanline
            // 
            this.TitleScanline.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleScanline.Controls.Add(this.btnScanline);
            this.TitleScanline.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleScanline.Location = new System.Drawing.Point(394, 504);
            this.TitleScanline.Name = "TitleScanline";
            this.TitleScanline.Size = new System.Drawing.Size(217, 100);
            this.TitleScanline.TabIndex = 16;
            this.TitleScanline.TabStop = false;
            this.TitleScanline.Text = "Scanline";
            // 
            // btnScanline
            // 
            this.btnScanline.Location = new System.Drawing.Point(60, 43);
            this.btnScanline.Name = "btnScanline";
            this.btnScanline.Size = new System.Drawing.Size(95, 35);
            this.btnScanline.TabIndex = 5;
            this.btnScanline.Text = "Acceder";
            this.btnScanline.UseVisualStyleBackColor = true;
            this.btnScanline.Click += new System.EventHandler(this.btnScanline_Click);
            // 
            // TitleCohenSutherland
            // 
            this.TitleCohenSutherland.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleCohenSutherland.Controls.Add(this.btnCohenSutherland);
            this.TitleCohenSutherland.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCohenSutherland.Location = new System.Drawing.Point(669, 216);
            this.TitleCohenSutherland.Name = "TitleCohenSutherland";
            this.TitleCohenSutherland.Size = new System.Drawing.Size(217, 100);
            this.TitleCohenSutherland.TabIndex = 17;
            this.TitleCohenSutherland.TabStop = false;
            this.TitleCohenSutherland.Text = "Cohen-Sutherland";
            this.TitleCohenSutherland.UseWaitCursor = true;
            // 
            // btnCohenSutherland
            // 
            this.btnCohenSutherland.Location = new System.Drawing.Point(60, 43);
            this.btnCohenSutherland.Name = "btnCohenSutherland";
            this.btnCohenSutherland.Size = new System.Drawing.Size(95, 35);
            this.btnCohenSutherland.TabIndex = 5;
            this.btnCohenSutherland.Text = "Acceder";
            this.btnCohenSutherland.UseVisualStyleBackColor = true;
            this.btnCohenSutherland.UseWaitCursor = true;
            this.btnCohenSutherland.Click += new System.EventHandler(this.btnCohenSutherland_Click);
            // 
            // TitleSutherladnHodgman
            // 
            this.TitleSutherladnHodgman.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleSutherladnHodgman.Controls.Add(this.btnSutherlandHodgman);
            this.TitleSutherladnHodgman.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSutherladnHodgman.Location = new System.Drawing.Point(669, 361);
            this.TitleSutherladnHodgman.Name = "TitleSutherladnHodgman";
            this.TitleSutherladnHodgman.Size = new System.Drawing.Size(217, 100);
            this.TitleSutherladnHodgman.TabIndex = 18;
            this.TitleSutherladnHodgman.TabStop = false;
            this.TitleSutherladnHodgman.Text = "Sutherland-Hodgman";
            this.TitleSutherladnHodgman.UseWaitCursor = true;
            // 
            // btnSutherlandHodgman
            // 
            this.btnSutherlandHodgman.Location = new System.Drawing.Point(60, 43);
            this.btnSutherlandHodgman.Name = "btnSutherlandHodgman";
            this.btnSutherlandHodgman.Size = new System.Drawing.Size(95, 35);
            this.btnSutherlandHodgman.TabIndex = 5;
            this.btnSutherlandHodgman.Text = "Acceder";
            this.btnSutherlandHodgman.UseVisualStyleBackColor = true;
            this.btnSutherlandHodgman.UseWaitCursor = true;
            this.btnSutherlandHodgman.Click += new System.EventHandler(this.btnSutherlandHodgman_Click);
            // 
            // TitleBezier
            // 
            this.TitleBezier.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleBezier.Controls.Add(this.btnBezier);
            this.TitleBezier.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBezier.Location = new System.Drawing.Point(930, 216);
            this.TitleBezier.Name = "TitleBezier";
            this.TitleBezier.Size = new System.Drawing.Size(217, 100);
            this.TitleBezier.TabIndex = 19;
            this.TitleBezier.TabStop = false;
            this.TitleBezier.Text = "Curvas de Bezier";
            this.TitleBezier.UseWaitCursor = true;
            // 
            // btnBezier
            // 
            this.btnBezier.Location = new System.Drawing.Point(60, 43);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(95, 35);
            this.btnBezier.TabIndex = 5;
            this.btnBezier.Text = "Acceder";
            this.btnBezier.UseVisualStyleBackColor = true;
            this.btnBezier.UseWaitCursor = true;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // TitleBSplines
            // 
            this.TitleBSplines.BackColor = System.Drawing.Color.LavenderBlush;
            this.TitleBSplines.Controls.Add(this.btnBSplines);
            this.TitleBSplines.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBSplines.Location = new System.Drawing.Point(930, 361);
            this.TitleBSplines.Name = "TitleBSplines";
            this.TitleBSplines.Size = new System.Drawing.Size(217, 100);
            this.TitleBSplines.TabIndex = 20;
            this.TitleBSplines.TabStop = false;
            this.TitleBSplines.Text = "B-Splines";
            this.TitleBSplines.UseWaitCursor = true;
            // 
            // btnBSplines
            // 
            this.btnBSplines.Location = new System.Drawing.Point(60, 43);
            this.btnBSplines.Name = "btnBSplines";
            this.btnBSplines.Size = new System.Drawing.Size(95, 35);
            this.btnBSplines.TabIndex = 5;
            this.btnBSplines.Text = "Acceder";
            this.btnBSplines.UseVisualStyleBackColor = true;
            this.btnBSplines.UseWaitCursor = true;
            this.btnBSplines.Click += new System.EventHandler(this.btnBSplines_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(163, 135);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(152, 62);
            this.lbl1.TabIndex = 21;
            this.lbl1.Text = "Algoritmos de \r\nlineas y curvas";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(663, 135);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(225, 62);
            this.lbl3.TabIndex = 22;
            this.lbl3.Text = "Algoritmos de recorte \r\ngeométrico";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(392, 135);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(219, 62);
            this.lbl2.TabIndex = 23;
            this.lbl2.Text = "Algoritmos de relleno \r\nde regiones";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl4.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(930, 135);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(217, 62);
            this.lbl4.TabIndex = 24;
            this.lbl4.Text = "Algoritmos de curvas \r\nparamétricas";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1289, 761);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.TitleBSplines);
            this.Controls.Add(this.TitleBezier);
            this.Controls.Add(this.TitleSutherladnHodgman);
            this.Controls.Add(this.TitleCohenSutherland);
            this.Controls.Add(this.TitleScanline);
            this.Controls.Add(this.TitleElipses);
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
            this.TitleElipses.ResumeLayout(false);
            this.TitleScanline.ResumeLayout(false);
            this.TitleCohenSutherland.ResumeLayout(false);
            this.TitleSutherladnHodgman.ResumeLayout(false);
            this.TitleBezier.ResumeLayout(false);
            this.TitleBSplines.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox TitleElipses;
        private System.Windows.Forms.Button btnBresenhamElipse;
        private System.Windows.Forms.GroupBox TitleScanline;
        private System.Windows.Forms.Button btnScanline;
        private System.Windows.Forms.GroupBox TitleCohenSutherland;
        private System.Windows.Forms.Button btnCohenSutherland;
        private System.Windows.Forms.GroupBox TitleSutherladnHodgman;
        private System.Windows.Forms.Button btnSutherlandHodgman;
        private System.Windows.Forms.GroupBox TitleBezier;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.GroupBox TitleBSplines;
        private System.Windows.Forms.Button btnBSplines;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
    }
}