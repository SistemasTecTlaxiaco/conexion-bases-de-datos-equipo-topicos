namespace HotelBook1
{
    partial class Principal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.btnCancerlar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(451, 309);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(189, 54);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.Location = new System.Drawing.Point(180, 309);
            this.btnHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(189, 54);
            this.btnHabitaciones.TabIndex = 10;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.UseVisualStyleBackColor = true;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnCancerlar
            // 
            this.btnCancerlar.Location = new System.Drawing.Point(564, 178);
            this.btnCancerlar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancerlar.Name = "btnCancerlar";
            this.btnCancerlar.Size = new System.Drawing.Size(189, 54);
            this.btnCancerlar.TabIndex = 9;
            this.btnCancerlar.Text = "Cancelar reserva";
            this.btnCancerlar.UseVisualStyleBackColor = true;
            this.btnCancerlar.Click += new System.EventHandler(this.btnCancerlar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(312, 178);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(189, 54);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar reservas";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(38, 178);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(189, 54);
            this.btnReserva.TabIndex = 7;
            this.btnReserva.Text = "Hacer reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menú Principal";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHabitaciones);
            this.Controls.Add(this.btnCancerlar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnCancerlar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Label label1;
    }
}