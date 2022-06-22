namespace sqlProyecto
{
    partial class detalles
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
            this.gridDetallePedido = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pagar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pago = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.idpedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetallePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDetallePedido
            // 
            this.gridDetallePedido.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetallePedido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gridDetallePedido.Location = new System.Drawing.Point(30, 52);
            this.gridDetallePedido.Name = "gridDetallePedido";
            this.gridDetallePedido.RowTemplate.Height = 25;
            this.gridDetallePedido.Size = new System.Drawing.Size(836, 233);
            this.gridDetallePedido.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(708, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(29, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.ForeColor = System.Drawing.Color.ForestGreen;
            this.cliente.Location = new System.Drawing.Point(95, 21);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(13, 15);
            this.cliente.TabIndex = 4;
            this.cliente.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(154, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "El cliente debe pagar:";
            // 
            // pagar
            // 
            this.pagar.AutoSize = true;
            this.pagar.BackColor = System.Drawing.Color.Black;
            this.pagar.ForeColor = System.Drawing.Color.ForestGreen;
            this.pagar.Location = new System.Drawing.Point(279, 21);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(19, 15);
            this.pagar.TabIndex = 6;
            this.pagar.Text = "$0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(351, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "El cliente pagó:";
            // 
            // pago
            // 
            this.pago.AutoSize = true;
            this.pago.BackColor = System.Drawing.SystemColors.ControlText;
            this.pago.ForeColor = System.Drawing.Color.Cyan;
            this.pago.Location = new System.Drawing.Point(460, 21);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(19, 15);
            this.pago.TabIndex = 8;
            this.pago.Text = "$0";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlText;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Cyan;
            this.button6.Location = new System.Drawing.Point(335, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(347, 35);
            this.button6.TabIndex = 12;
            this.button6.Text = "Ver";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(614, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pedido nro:";
            // 
            // idpedido
            // 
            this.idpedido.AutoSize = true;
            this.idpedido.BackColor = System.Drawing.SystemColors.ControlText;
            this.idpedido.ForeColor = System.Drawing.Color.DarkKhaki;
            this.idpedido.Location = new System.Drawing.Point(688, 21);
            this.idpedido.Name = "idpedido";
            this.idpedido.Size = new System.Drawing.Size(13, 15);
            this.idpedido.TabIndex = 14;
            this.idpedido.Text = "0";
            // 
            // detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(878, 368);
            this.Controls.Add(this.idpedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridDetallePedido);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "detalles";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.gridDetallePedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridDetallePedido;
        private Button button2;
        private Button button1;
        private Label cliente;
        private Label label1;
        private Label label2;
        private Label pagar;
        private Label label4;
        private Label pago;
        private Button button6;
        private Label label6;
        private Label idpedido;
    }
}