
namespace CotizadorTiendaMayorista
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbNombreVendedor2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDireccion2 = new System.Windows.Forms.Label();
            this.lbNombreTienda2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.initControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.initControllerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.initControllerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadUnidadesCotizadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initControllerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initControllerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initControllerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 113);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(354, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cotizador Express";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbNombreVendedor2);
            this.panel4.Location = new System.Drawing.Point(-1, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1112, 43);
            this.panel4.TabIndex = 5;
            // 
            // lbNombreVendedor2
            // 
            this.lbNombreVendedor2.AutoSize = true;
            this.lbNombreVendedor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreVendedor2.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbNombreVendedor2.Location = new System.Drawing.Point(13, 11);
            this.lbNombreVendedor2.Name = "lbNombreVendedor2";
            this.lbNombreVendedor2.Size = new System.Drawing.Size(358, 18);
            this.lbNombreVendedor2.TabIndex = 0;
            this.lbNombreVendedor2.Text = "nombre y apellido vendedor | codigo Vendedor";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbDireccion2);
            this.panel2.Controls.Add(this.lbNombreTienda2);
            this.panel2.Location = new System.Drawing.Point(-1, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 43);
            this.panel2.TabIndex = 4;
            // 
            // lbDireccion2
            // 
            this.lbDireccion2.AutoSize = true;
            this.lbDireccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion2.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbDireccion2.Location = new System.Drawing.Point(518, 11);
            this.lbDireccion2.Name = "lbDireccion2";
            this.lbDireccion2.Size = new System.Drawing.Size(234, 18);
            this.lbDireccion2.TabIndex = 1;
            this.lbDireccion2.Text = "Ingresar direccion de la tienda";
            // 
            // lbNombreTienda2
            // 
            this.lbNombreTienda2.AutoSize = true;
            this.lbNombreTienda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreTienda2.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbNombreTienda2.Location = new System.Drawing.Point(13, 11);
            this.lbNombreTienda2.Name = "lbNombreTienda2";
            this.lbNombreTienda2.Size = new System.Drawing.Size(222, 18);
            this.lbNombreTienda2.TabIndex = 0;
            this.lbNombreTienda2.Text = "Ingresar nombre de la tienda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(447, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Historial de Cotizaciones";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendedor,
            this.idCotizacion,
            this.fechaHora,
            this.prenda,
            this.cantidadUnidadesCotizadas,
            this.valor});
            this.dgv1.Location = new System.Drawing.Point(63, 257);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(979, 150);
            this.dgv1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // initControllerBindingSource
            // 
            this.initControllerBindingSource.DataSource = typeof(CotizadorTiendaMayorista.Controllers.InitController);
            // 
            // initControllerBindingSource1
            // 
            this.initControllerBindingSource1.DataSource = typeof(CotizadorTiendaMayorista.Controllers.InitController);
            // 
            // initControllerBindingSource2
            // 
            this.initControllerBindingSource2.DataSource = typeof(CotizadorTiendaMayorista.Controllers.InitController);
            // 
            // idVendedor
            // 
            this.idVendedor.HeaderText = "id Vendedor";
            this.idVendedor.MinimumWidth = 6;
            this.idVendedor.Name = "idVendedor";
            this.idVendedor.ReadOnly = true;
            this.idVendedor.Width = 125;
            // 
            // idCotizacion
            // 
            this.idCotizacion.HeaderText = "Id Cotizacion";
            this.idCotizacion.MinimumWidth = 6;
            this.idCotizacion.Name = "idCotizacion";
            this.idCotizacion.ReadOnly = true;
            this.idCotizacion.Width = 125;
            // 
            // fechaHora
            // 
            this.fechaHora.HeaderText = "Fecha hora";
            this.fechaHora.MinimumWidth = 6;
            this.fechaHora.Name = "fechaHora";
            this.fechaHora.ReadOnly = true;
            this.fechaHora.Width = 125;
            // 
            // prenda
            // 
            this.prenda.HeaderText = "Prenda";
            this.prenda.MinimumWidth = 6;
            this.prenda.Name = "prenda";
            this.prenda.ReadOnly = true;
            this.prenda.Width = 125;
            // 
            // cantidadUnidadesCotizadas
            // 
            this.cantidadUnidadesCotizadas.HeaderText = "Cantidad unidades cotizadas";
            this.cantidadUnidadesCotizadas.MinimumWidth = 6;
            this.cantidadUnidadesCotizadas.Name = "cantidadUnidadesCotizadas";
            this.cantidadUnidadesCotizadas.ReadOnly = true;
            this.cantidadUnidadesCotizadas.Width = 200;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.MinimumWidth = 6;
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 633);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Historial de Cotizaciones";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initControllerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initControllerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initControllerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbNombreVendedor2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDireccion2;
        private System.Windows.Forms.Label lbNombreTienda2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource initControllerBindingSource;
        private System.Windows.Forms.BindingSource initControllerBindingSource1;
        private System.Windows.Forms.BindingSource initControllerBindingSource2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadUnidadesCotizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}