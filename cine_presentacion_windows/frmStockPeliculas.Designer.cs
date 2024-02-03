namespace cine_presentacion_windows
{
    partial class frmStockPeliculas
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
            this.GRABAR = new System.Windows.Forms.Button();
            this.txtCodigoPelicula = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtFechaUP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCodigoPelicula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStockP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockP)).BeginInit();
            this.SuspendLayout();
            // 
            // GRABAR
            // 
            this.GRABAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRABAR.Location = new System.Drawing.Point(158, 224);
            this.GRABAR.Name = "GRABAR";
            this.GRABAR.Size = new System.Drawing.Size(106, 28);
            this.GRABAR.TabIndex = 0;
            this.GRABAR.Text = "GRABAR";
            this.GRABAR.UseVisualStyleBackColor = true;
            this.GRABAR.Click += new System.EventHandler(this.GRABAR_Click);
            // 
            // txtCodigoPelicula
            // 
            this.txtCodigoPelicula.Location = new System.Drawing.Point(175, 34);
            this.txtCodigoPelicula.Name = "txtCodigoPelicula";
            this.txtCodigoPelicula.Size = new System.Drawing.Size(119, 20);
            this.txtCodigoPelicula.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(175, 65);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(119, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dtFechaUP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblCodigoPelicula);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtCodigoPelicula);
            this.groupBox1.Location = new System.Drawing.Point(127, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(373, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Estado Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtFechaUP
            // 
            this.dtFechaUP.Location = new System.Drawing.Point(204, 100);
            this.dtFechaUP.Name = "dtFechaUP";
            this.dtFechaUP.Size = new System.Drawing.Size(200, 20);
            this.dtFechaUP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha último pedido";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(27, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCodigoPelicula
            // 
            this.lblCodigoPelicula.AutoSize = true;
            this.lblCodigoPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPelicula.Location = new System.Drawing.Point(26, 34);
            this.lblCodigoPelicula.Name = "lblCodigoPelicula";
            this.lblCodigoPelicula.Size = new System.Drawing.Size(132, 20);
            this.lblCodigoPelicula.TabIndex = 3;
            this.lblCodigoPelicula.Text = "Código Pelicula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "STOCK PELICULAS";
            // 
            // dgvStockP
            // 
            this.dgvStockP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockP.Location = new System.Drawing.Point(127, 258);
            this.dgvStockP.Name = "dgvStockP";
            this.dgvStockP.Size = new System.Drawing.Size(529, 150);
            this.dgvStockP.TabIndex = 5;
            // 
            // frmStockPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStockP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GRABAR);
            this.Name = "frmStockPeliculas";
            this.Text = "frmStockPeliculas";
            this.Load += new System.EventHandler(this.frmStockPeliculas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GRABAR;
        private System.Windows.Forms.TextBox txtCodigoPelicula;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCodigoPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dtFechaUP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStockP;
    }
}