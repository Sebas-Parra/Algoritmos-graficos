namespace DrawLies2
{
    partial class FrmFiguraRelleno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiguraRelleno));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.Font = new System.Drawing.Font("MV Boli", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(155, 231);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Clear";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDibujar.Font = new System.Drawing.Font("MV Boli", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(53, 231);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 37);
            this.btnDibujar.TabIndex = 42;
            this.btnDibujar.Text = "Draw";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picCanvas.Location = new System.Drawing.Point(276, 108);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(524, 467);
            this.picCanvas.TabIndex = 41;
            this.picCanvas.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(321, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 37);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Figura regular";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(406, 367);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 26);
            this.lblArea.TabIndex = 39;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.Location = new System.Drawing.Point(74, 135);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(69, 26);
            this.lblSide.TabIndex = 38;
            this.lblSide.Text = "Lados";
            // 
            // txtLado
            // 
            this.txtLado.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado.Location = new System.Drawing.Point(79, 164);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 30);
            this.txtLado.TabIndex = 37;
            this.txtLado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 100);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // FrmFiguraRelleno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 637);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFiguraRelleno";
            this.Text = "FrmFiguraRelleno";
            this.Load += new System.EventHandler(this.FrmFiguraRelleno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}