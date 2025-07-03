namespace DrawLies2
{
    partial class BresenhamFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BresenhamFrm));
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.txtYi = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.dataGridPuntos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(464, 136);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(454, 307);
            this.picCanvas.TabIndex = 6;
            this.picCanvas.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Y final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Y inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "X final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "X inicial";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(52, 152);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(148, 34);
            this.btnGraficar.TabIndex = 14;
            this.btnGraficar.Text = "Graficar Linea";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click_1);
            // 
            // txtYf
            // 
            this.txtYf.Location = new System.Drawing.Point(255, 107);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(100, 22);
            this.txtYf.TabIndex = 13;
            // 
            // txtYi
            // 
            this.txtYi.Location = new System.Drawing.Point(255, 43);
            this.txtYi.Name = "txtYi";
            this.txtYi.Size = new System.Drawing.Size(100, 22);
            this.txtYi.TabIndex = 12;
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(72, 105);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(100, 22);
            this.txtXf.TabIndex = 11;
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(72, 43);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 22);
            this.txtXi.TabIndex = 10;
            // 
            // dataGridPuntos
            // 
            this.dataGridPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPuntos.Location = new System.Drawing.Point(12, 219);
            this.dataGridPuntos.Name = "dataGridPuntos";
            this.dataGridPuntos.RowHeadersWidth = 51;
            this.dataGridPuntos.RowTemplate.Height = 24;
            this.dataGridPuntos.Size = new System.Drawing.Size(429, 359);
            this.dataGridPuntos.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "Algoritmo de Bresenham";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(228, 152);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 34);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BresenhamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 590);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridPuntos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.txtYf);
            this.Controls.Add(this.txtYi);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.picCanvas);
            this.Name = "BresenhamFrm";
            this.Text = "BresenhamFrm";
            this.Load += new System.EventHandler(this.BresenhamFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.TextBox txtYi;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.DataGridView dataGridPuntos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
    }
}