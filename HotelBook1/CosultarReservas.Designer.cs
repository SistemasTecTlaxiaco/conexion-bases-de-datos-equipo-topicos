namespace HotelBook1
{
    partial class CosultarReservas
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
            this.reserva = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnnuevareserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reserva)).BeginInit();
            this.SuspendLayout();
            // 
            // reserva
            // 
            this.reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserva.Location = new System.Drawing.Point(112, 69);
            this.reserva.Margin = new System.Windows.Forms.Padding(2);
            this.reserva.Name = "reserva";
            this.reserva.RowHeadersWidth = 51;
            this.reserva.RowTemplate.Height = 24;
            this.reserva.Size = new System.Drawing.Size(442, 206);
            this.reserva.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservas ";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(331, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnuevareserva
            // 
            this.btnnuevareserva.Location = new System.Drawing.Point(163, 302);
            this.btnnuevareserva.Name = "btnnuevareserva";
            this.btnnuevareserva.Size = new System.Drawing.Size(100, 35);
            this.btnnuevareserva.TabIndex = 7;
            this.btnnuevareserva.Text = "Nueva Reserva";
            this.btnnuevareserva.UseVisualStyleBackColor = true;
            this.btnnuevareserva.Click += new System.EventHandler(this.btnnuevareserva_Click);
            // 
            // CosultarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 384);
            this.Controls.Add(this.btnnuevareserva);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.reserva);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CosultarReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CosultarReservas";
            this.Load += new System.EventHandler(this.CosultarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView reserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnnuevareserva;
    }
}