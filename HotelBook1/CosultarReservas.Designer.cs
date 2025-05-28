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
            this.button1 = new System.Windows.Forms.Button();
            this.reserva = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reserva)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reserva
            // 
            this.reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserva.Location = new System.Drawing.Point(106, 85);
            this.reserva.Name = "reserva";
            this.reserva.RowHeadersWidth = 51;
            this.reserva.RowTemplate.Height = 24;
            this.reserva.Size = new System.Drawing.Size(589, 253);
            this.reserva.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservas ";
            // 
            // CosultarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reserva);
            this.Controls.Add(this.label1);
            this.Name = "CosultarReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CosultarReservas";
            this.Load += new System.EventHandler(this.CosultarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView reserva;
        private System.Windows.Forms.Label label1;
    }
}