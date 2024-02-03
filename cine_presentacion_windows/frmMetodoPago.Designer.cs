namespace cine_presentacion_windows
{
    partial class frmMetodoPago
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.txtxDetalles = new System.Windows.Forms.TextBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblFechaExpiracion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaExpiracion = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(143, 225);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(96, 33);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Location = new System.Drawing.Point(201, 19);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.Size = new System.Drawing.Size(237, 20);
            this.txtTipoPago.TabIndex = 1;
            // 
            // txtxDetalles
            // 
            this.txtxDetalles.Location = new System.Drawing.Point(201, 51);
            this.txtxDetalles.Multiline = true;
            this.txtxDetalles.Name = "txtxDetalles";
            this.txtxDetalles.Size = new System.Drawing.Size(237, 43);
            this.txtxDetalles.TabIndex = 2;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.Location = new System.Drawing.Point(50, 19);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(113, 20);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(50, 61);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(75, 20);
            this.lblDetalles.TabIndex = 4;
            this.lblDetalles.Text = "Detalles";
            // 
            // lblFechaExpiracion
            // 
            this.lblFechaExpiracion.AutoSize = true;
            this.lblFechaExpiracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaExpiracion.Location = new System.Drawing.Point(50, 110);
            this.lblFechaExpiracion.Name = "lblFechaExpiracion";
            this.lblFechaExpiracion.Size = new System.Drawing.Size(172, 20);
            this.lblFechaExpiracion.TabIndex = 5;
            this.lblFechaExpiracion.Text = "Fecha de Expiración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "MÉTODO DE PAGO";
            // 
            // dtFechaExpiracion
            // 
            this.dtFechaExpiracion.Location = new System.Drawing.Point(238, 110);
            this.dtFechaExpiracion.Name = "dtFechaExpiracion";
            this.dtFechaExpiracion.Size = new System.Drawing.Size(200, 20);
            this.dtFechaExpiracion.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(460, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Estado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaExpiracion);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lblFechaExpiracion);
            this.groupBox1.Controls.Add(this.lblDetalles);
            this.groupBox1.Controls.Add(this.lblTipoPago);
            this.groupBox1.Controls.Add(this.txtxDetalles);
            this.groupBox1.Controls.Add(this.txtTipoPago);
            this.groupBox1.Location = new System.Drawing.Point(76, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 156);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dgvMetodoPago
            // 
            this.dgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodoPago.Location = new System.Drawing.Point(76, 264);
            this.dgvMetodoPago.Name = "dgvMetodoPago";
            this.dgvMetodoPago.Size = new System.Drawing.Size(563, 150);
            this.dgvMetodoPago.TabIndex = 10;
            // 
            // frmMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.dgvMetodoPago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGrabar);
            this.Name = "frmMetodoPago";
            this.Text = "frmMetodoPago";
            this.Load += new System.EventHandler(this.frmMetodoPago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.TextBox txtxDetalles;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblFechaExpiracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaExpiracion;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMetodoPago;
    }
}