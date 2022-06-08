namespace sqlProyecto
{
    partial class AgregarCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.clienteTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(112, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Nombre.Location = new System.Drawing.Point(247, 64);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(51, 15);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // clienteTextbox
            // 
            this.clienteTextbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.clienteTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clienteTextbox.ForeColor = System.Drawing.Color.Chartreuse;
            this.clienteTextbox.Location = new System.Drawing.Point(112, 117);
            this.clienteTextbox.Name = "clienteTextbox";
            this.clienteTextbox.Size = new System.Drawing.Size(316, 23);
            this.clienteTextbox.TabIndex = 2;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(556, 315);
            this.Controls.Add(this.clienteTextbox);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.button1);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label Nombre;
        private TextBox clienteTextbox;
    }
}