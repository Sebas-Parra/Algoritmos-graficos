namespace DrawLies2
{
    partial class AnalizadorDiferencialDigitalFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalizadorDiferencialDigitalFrm));
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.txtYi = new System.Windows.Forms.TextBox();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.dataGridPuntos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(510, 137);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(454, 307);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(196, 34);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(100, 22);
            this.txtXi.TabIndex = 1;
            this.txtXi.TextChanged += new System.EventHandler(this.txtXi_TextChanged);
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(196, 96);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(100, 22);
            this.txtXf.TabIndex = 2;
            this.txtXf.TextChanged += new System.EventHandler(this.txtXf_TextChanged);
            // 
            // txtYi
            // 
            this.txtYi.Location = new System.Drawing.Point(196, 156);
            this.txtYi.Name = "txtYi";
            this.txtYi.Size = new System.Drawing.Size(100, 22);
            this.txtYi.TabIndex = 3;
            this.txtYi.TextChanged += new System.EventHandler(this.txtYi_TextChanged);
            // 
            // txtYf
            // 
            this.txtYf.Location = new System.Drawing.Point(196, 220);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(100, 22);
            this.txtYf.TabIndex = 4;
            this.txtYf.TextChanged += new System.EventHandler(this.txtYf_TextChanged);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(176, 248);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(140, 34);
            this.btnGraficar.TabIndex = 5;
            this.btnGraficar.Text = "Graficar Linea";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // dataGridPuntos
            // 
            this.dataGridPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPuntos.Location = new System.Drawing.Point(12, 288);
            this.dataGridPuntos.Name = "dataGridPuntos";
            this.dataGridPuntos.RowHeadersWidth = 51;
            this.dataGridPuntos.RowTemplate.Height = 24;
            this.dataGridPuntos.Size = new System.Drawing.Size(479, 379);
            this.dataGridPuntos.TabIndex = 10;
            this.dataGridPuntos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPuntos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "X inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "X final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Y inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Y final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Algoritmo Analizador Diferencial Digital";
            // 
            // AnalizadorDiferencialDigitalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPuntos);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.txtYf);
            this.Controls.Add(this.txtYi);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.picCanvas);
            this.Name = "AnalizadorDiferencialDigitalFrm";
            this.Text = "AnalizadorDiferencialDigitalFrm";
            this.Load += new System.EventHandler(this.AnalizadorDiferencialDigitalFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.TextBox txtYi;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataGridView dataGridPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}