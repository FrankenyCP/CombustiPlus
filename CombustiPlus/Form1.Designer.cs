namespace CombustiPlus
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
            this.grpNuevo = new System.Windows.Forms.GroupBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.lblGalones = new System.Windows.Forms.Label();
            this.nudGalones = new System.Windows.Forms.NumericUpDown();
            this.lblPago = new System.Windows.Forms.Label();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.lstDetalle = new System.Windows.Forms.ListBox();
            this.grpDespachos = new System.Windows.Forms.GroupBox();
            this.lstDespachos = new System.Windows.Forms.ListBox();
            this.btnPorCombustible = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.grpNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGalones)).BeginInit();
            this.grpDetalle.SuspendLayout();
            this.grpDespachos.SuspendLayout();
            this.SuspendLayout();
            //
            // grpNuevo
            //
            this.grpNuevo.Controls.Add(this.lblPlaca);
            this.grpNuevo.Controls.Add(this.txtPlaca);
            this.grpNuevo.Controls.Add(this.lblCombustible);
            this.grpNuevo.Controls.Add(this.cmbCombustible);
            this.grpNuevo.Controls.Add(this.lblGalones);
            this.grpNuevo.Controls.Add(this.nudGalones);
            this.grpNuevo.Controls.Add(this.lblPago);
            this.grpNuevo.Controls.Add(this.cmbPago);
            this.grpNuevo.Controls.Add(this.btnCotizar);
            this.grpNuevo.Controls.Add(this.btnDespachar);
            this.grpNuevo.Location = new System.Drawing.Point(12, 12);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Size = new System.Drawing.Size(378, 216);
            this.grpNuevo.TabIndex = 0;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Nuevo despacho";
            //
            // lblPlaca
            //
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(10, 30);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 15);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            //
            // txtPlaca
            //
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(104, 27);
            this.txtPlaca.MaxLength = 10;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(264, 23);
            this.txtPlaca.TabIndex = 1;
            //
            // lblCombustible
            //
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Location = new System.Drawing.Point(10, 67);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(76, 15);
            this.lblCombustible.TabIndex = 2;
            this.lblCombustible.Text = "Combustible:";
            //
            // cmbCombustible
            //
            this.cmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Location = new System.Drawing.Point(104, 64);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(264, 23);
            this.cmbCombustible.TabIndex = 3;
            //
            // lblGalones
            //
            this.lblGalones.AutoSize = true;
            this.lblGalones.Location = new System.Drawing.Point(10, 104);
            this.lblGalones.Name = "lblGalones";
            this.lblGalones.Size = new System.Drawing.Size(52, 15);
            this.lblGalones.TabIndex = 4;
            this.lblGalones.Text = "Galones:";
            //
            // nudGalones
            //
            this.nudGalones.DecimalPlaces = 1;
            this.nudGalones.Location = new System.Drawing.Point(104, 101);
            this.nudGalones.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudGalones.Name = "nudGalones";
            this.nudGalones.Size = new System.Drawing.Size(117, 23);
            this.nudGalones.TabIndex = 5;
            this.nudGalones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            //
            // lblPago
            //
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(10, 141);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(37, 15);
            this.lblPago.TabIndex = 6;
            this.lblPago.Text = "Pago:";
            //
            // cmbPago
            //
            this.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(104, 138);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(264, 23);
            this.cmbPago.TabIndex = 7;
            //
            // btnCotizar
            //
            this.btnCotizar.Location = new System.Drawing.Point(10, 176);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(174, 30);
            this.btnCotizar.TabIndex = 8;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            //
            // btnDespachar
            //
            this.btnDespachar.Location = new System.Drawing.Point(194, 176);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(174, 30);
            this.btnDespachar.TabIndex = 9;
            this.btnDespachar.Text = "Despachar";
            this.btnDespachar.UseVisualStyleBackColor = true;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            //
            // grpDetalle
            //
            this.grpDetalle.Controls.Add(this.lstDetalle);
            this.grpDetalle.Location = new System.Drawing.Point(12, 236);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(378, 152);
            this.grpDetalle.TabIndex = 1;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle";
            //
            // lstDetalle
            //
            this.lstDetalle.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstDetalle.FormattingEnabled = true;
            this.lstDetalle.IntegralHeight = false;
            this.lstDetalle.ItemHeight = 15;
            this.lstDetalle.Location = new System.Drawing.Point(10, 22);
            this.lstDetalle.Name = "lstDetalle";
            this.lstDetalle.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDetalle.Size = new System.Drawing.Size(358, 120);
            this.lstDetalle.TabIndex = 0;
            //
            // grpDespachos
            //
            this.grpDespachos.Controls.Add(this.lstDespachos);
            this.grpDespachos.Controls.Add(this.btnPorCombustible);
            this.grpDespachos.Location = new System.Drawing.Point(400, 12);
            this.grpDespachos.Name = "grpDespachos";
            this.grpDespachos.Size = new System.Drawing.Size(698, 292);
            this.grpDespachos.TabIndex = 2;
            this.grpDespachos.TabStop = false;
            this.grpDespachos.Text = "Despachos del día";
            //
            // lstDespachos
            //
            this.lstDespachos.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstDespachos.FormattingEnabled = true;
            this.lstDespachos.IntegralHeight = false;
            this.lstDespachos.ItemHeight = 15;
            this.lstDespachos.Location = new System.Drawing.Point(10, 22);
            this.lstDespachos.Name = "lstDespachos";
            this.lstDespachos.Size = new System.Drawing.Size(678, 222);
            this.lstDespachos.TabIndex = 0;
            this.lstDespachos.SelectedIndexChanged += new System.EventHandler(this.lstDespachos_SelectedIndexChanged);
            //
            // btnPorCombustible
            //
            this.btnPorCombustible.Location = new System.Drawing.Point(10, 252);
            this.btnPorCombustible.Name = "btnPorCombustible";
            this.btnPorCombustible.Size = new System.Drawing.Size(160, 30);
            this.btnPorCombustible.TabIndex = 1;
            this.btnPorCombustible.Text = "Galones por combustible";
            this.btnPorCombustible.UseVisualStyleBackColor = true;
            this.btnPorCombustible.Click += new System.EventHandler(this.btnPorCombustible_Click);
            //
            // lblResumen
            //
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResumen.Location = new System.Drawing.Point(400, 316);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(70, 19);
            this.lblResumen.TabIndex = 3;
            this.lblResumen.Text = "0 despachos";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 400);
            this.Controls.Add(this.grpNuevo);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.grpDespachos);
            this.Controls.Add(this.lblResumen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CombustiPlus — Estación Bávaro";
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGalones)).EndInit();
            this.grpDetalle.ResumeLayout(false);
            this.grpDespachos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.ComboBox cmbCombustible;
        private System.Windows.Forms.Label lblGalones;
        private System.Windows.Forms.NumericUpDown nudGalones;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.ListBox lstDetalle;
        private System.Windows.Forms.GroupBox grpDespachos;
        private System.Windows.Forms.ListBox lstDespachos;
        private System.Windows.Forms.Button btnPorCombustible;
        private System.Windows.Forms.Label lblResumen;
    }
}
