namespace MenuDeColmado
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
            cmbProductos = new ComboBox();
            lblMenu = new Label();
            lblProductos = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            rdoEfectivo = new RadioButton();
            lblMetodoPago = new Label();
            rdoTarjeta = new RadioButton();
            rdoTransferencia = new RadioButton();
            lblTotal = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Items.AddRange(new object[] { "Habichuelas Rojas (1 lb) - $65", "Aceite de Soya (16 oz) - $85", "Queso Amarillo (1 lb) - $180", "Huevos (Unidad) - $8", "Azúcar Blanca (1 lb) - $30", "Café Molido (Sobre) - $25", "Leche Evaporada (Lata) - $60" });
            cmbProductos.Location = new Point(199, 156);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(171, 23);
            cmbProductos.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(240, 44);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(338, 32);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu de Colmado La Fuerza";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductos.Location = new Point(199, 119);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(87, 21);
            lblProductos.TabIndex = 2;
            lblProductos.Text = "Productos";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(199, 200);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(79, 21);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(199, 238);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(171, 23);
            txtCantidad.TabIndex = 4;
            // 
            // rdoEfectivo
            // 
            rdoEfectivo.AutoSize = true;
            rdoEfectivo.Location = new Point(400, 160);
            rdoEfectivo.Name = "rdoEfectivo";
            rdoEfectivo.Size = new Size(67, 19);
            rdoEfectivo.TabIndex = 5;
            rdoEfectivo.TabStop = true;
            rdoEfectivo.Text = "Efectivo";
            rdoEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoPago.Location = new Point(400, 119);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(136, 21);
            lblMetodoPago.TabIndex = 6;
            lblMetodoPago.Text = "Metodo de pago";
            // 
            // rdoTarjeta
            // 
            rdoTarjeta.AutoSize = true;
            rdoTarjeta.Location = new Point(400, 203);
            rdoTarjeta.Name = "rdoTarjeta";
            rdoTarjeta.Size = new Size(60, 19);
            rdoTarjeta.TabIndex = 7;
            rdoTarjeta.TabStop = true;
            rdoTarjeta.Text = "Tarjeta";
            rdoTarjeta.UseVisualStyleBackColor = true;
            // 
            // rdoTransferencia
            // 
            rdoTransferencia.AutoSize = true;
            rdoTransferencia.Location = new Point(400, 242);
            rdoTransferencia.Name = "rdoTransferencia";
            rdoTransferencia.Size = new Size(95, 19);
            rdoTransferencia.TabIndex = 8;
            rdoTransferencia.TabStop = true;
            rdoTransferencia.Text = "Transferencia";
            rdoTransferencia.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(199, 325);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(171, 32);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total a pagar:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(199, 285);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(171, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotal);
            Controls.Add(rdoTransferencia);
            Controls.Add(rdoTarjeta);
            Controls.Add(lblMetodoPago);
            Controls.Add(rdoEfectivo);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblProductos);
            Controls.Add(lblMenu);
            Controls.Add(cmbProductos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProductos;
        private Label lblMenu;
        private Label lblProductos;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private RadioButton rdoEfectivo;
        private Label lblMetodoPago;
        private RadioButton rdoTarjeta;
        private RadioButton rdoTransferencia;
        private Label lblTotal;
        private Button btnCalcular;
    }
}
