
using System.Drawing;

namespace CotizadorTiendaMayorista
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbNombreTienda = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbCalidadPremium = new System.Windows.Forms.RadioButton();
            this.rbCalidadStandard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelstock = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Prenda = new System.Windows.Forms.GroupBox();
            this.cbChupin = new System.Windows.Forms.CheckBox();
            this.cbCuelloMao = new System.Windows.Forms.CheckBox();
            this.cbMangaCorta = new System.Windows.Forms.CheckBox();
            this.rbPantalon = new System.Windows.Forms.RadioButton();
            this.rbCamisa = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkHistorialCotizaciones = new System.Windows.Forms.LinkLabel();
            this.lbNombreVendedor = new System.Windows.Forms.Label();
            this.btCotizar = new System.Windows.Forms.Button();
            this.lbPrecioCotizacion = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Prenda.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 113);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cotizador Express";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbDireccion);
            this.panel2.Controls.Add(this.lbNombreTienda);
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 43);
            this.panel2.TabIndex = 1;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbDireccion.Location = new System.Drawing.Point(541, 11);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(234, 18);
            this.lbDireccion.TabIndex = 1;
            this.lbDireccion.Text = "Ingresar direccion de la tienda";
            // 
            // lbNombreTienda
            // 
            this.lbNombreTienda.AutoSize = true;
            this.lbNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreTienda.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbNombreTienda.Location = new System.Drawing.Point(13, 11);
            this.lbNombreTienda.Name = "lbNombreTienda";
            this.lbNombreTienda.Size = new System.Drawing.Size(222, 18);
            this.lbNombreTienda.TabIndex = 0;
            this.lbNombreTienda.Text = "Ingresar nombre de la tienda";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.Prenda);
            this.panel3.Location = new System.Drawing.Point(0, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 390);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCant);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(409, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 65);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio unitario y cantidad";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(201, 28);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(66, 24);
            this.txtCant.TabIndex = 3;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(121, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(40, 28);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(66, 24);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "$";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCalidadPremium);
            this.groupBox2.Controls.Add(this.rbCalidadStandard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(83, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de la prenda";
            // 
            // rbCalidadPremium
            // 
            this.rbCalidadPremium.AutoSize = true;
            this.rbCalidadPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCalidadPremium.ForeColor = System.Drawing.Color.Black;
            this.rbCalidadPremium.Location = new System.Drawing.Point(158, 31);
            this.rbCalidadPremium.Name = "rbCalidadPremium";
            this.rbCalidadPremium.Size = new System.Drawing.Size(96, 22);
            this.rbCalidadPremium.TabIndex = 6;
            this.rbCalidadPremium.Text = "Premium";
            this.rbCalidadPremium.UseVisualStyleBackColor = true;
            // 
            // rbCalidadStandard
            // 
            this.rbCalidadStandard.AutoSize = true;
            this.rbCalidadStandard.Checked = true;
            this.rbCalidadStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCalidadStandard.ForeColor = System.Drawing.Color.Black;
            this.rbCalidadStandard.Location = new System.Drawing.Point(30, 31);
            this.rbCalidadStandard.Name = "rbCalidadStandard";
            this.rbCalidadStandard.Size = new System.Drawing.Size(96, 22);
            this.rbCalidadStandard.TabIndex = 5;
            this.rbCalidadStandard.TabStop = true;
            this.rbCalidadStandard.Text = "Standard";
            this.rbCalidadStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelstock);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(83, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelstock
            // 
            this.labelstock.AutoSize = true;
            this.labelstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstock.ForeColor = System.Drawing.Color.Black;
            this.labelstock.Location = new System.Drawing.Point(290, 28);
            this.labelstock.Name = "labelstock";
            this.labelstock.Size = new System.Drawing.Size(14, 18);
            this.labelstock.TabIndex = 1;
            this.labelstock.Text = "-";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(30, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(248, 18);
            this.label.TabIndex = 0;
            this.label.Text = "Unidades de stock disponibles: ";
            // 
            // Prenda
            // 
            this.Prenda.Controls.Add(this.cbChupin);
            this.Prenda.Controls.Add(this.cbCuelloMao);
            this.Prenda.Controls.Add(this.cbMangaCorta);
            this.Prenda.Controls.Add(this.rbPantalon);
            this.Prenda.Controls.Add(this.rbCamisa);
            this.Prenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenda.ForeColor = System.Drawing.Color.Black;
            this.Prenda.Location = new System.Drawing.Point(83, 19);
            this.Prenda.Name = "Prenda";
            this.Prenda.Size = new System.Drawing.Size(638, 188);
            this.Prenda.TabIndex = 0;
            this.Prenda.TabStop = false;
            this.Prenda.Text = "Prenda";
            // 
            // cbChupin
            // 
            this.cbChupin.AutoSize = true;
            this.cbChupin.Location = new System.Drawing.Point(293, 116);
            this.cbChupin.Name = "cbChupin";
            this.cbChupin.Size = new System.Drawing.Size(82, 22);
            this.cbChupin.TabIndex = 4;
            this.cbChupin.Text = "Chupín";
            this.cbChupin.UseVisualStyleBackColor = true;
            // 
            // cbCuelloMao
            // 
            this.cbCuelloMao.AutoSize = true;
            this.cbCuelloMao.Location = new System.Drawing.Point(474, 43);
            this.cbCuelloMao.Name = "cbCuelloMao";
            this.cbCuelloMao.Size = new System.Drawing.Size(116, 22);
            this.cbCuelloMao.TabIndex = 3;
            this.cbCuelloMao.Text = "Cuello Mao";
            this.cbCuelloMao.UseVisualStyleBackColor = true;
            // 
            // cbMangaCorta
            // 
            this.cbMangaCorta.AutoSize = true;
            this.cbMangaCorta.Location = new System.Drawing.Point(293, 43);
            this.cbMangaCorta.Name = "cbMangaCorta";
            this.cbMangaCorta.Size = new System.Drawing.Size(127, 22);
            this.cbMangaCorta.TabIndex = 2;
            this.cbMangaCorta.Text = "Manga Corta";
            this.cbMangaCorta.UseVisualStyleBackColor = true;
            // 
            // rbPantalon
            // 
            this.rbPantalon.AutoSize = true;
            this.rbPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPantalon.ForeColor = System.Drawing.Color.Black;
            this.rbPantalon.Location = new System.Drawing.Point(30, 116);
            this.rbPantalon.Name = "rbPantalon";
            this.rbPantalon.Size = new System.Drawing.Size(95, 22);
            this.rbPantalon.TabIndex = 1;
            this.rbPantalon.Text = "Pantalon";
            this.rbPantalon.UseVisualStyleBackColor = true;
            this.rbPantalon.CheckedChanged += new System.EventHandler(this.rbPantalon_CheckedChanged);
            // 
            // rbCamisa
            // 
            this.rbCamisa.AutoSize = true;
            this.rbCamisa.Checked = true;
            this.rbCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCamisa.ForeColor = System.Drawing.Color.Black;
            this.rbCamisa.Location = new System.Drawing.Point(30, 43);
            this.rbCamisa.Name = "rbCamisa";
            this.rbCamisa.Size = new System.Drawing.Size(86, 22);
            this.rbCamisa.TabIndex = 0;
            this.rbCamisa.TabStop = true;
            this.rbCamisa.Text = "Camisa";
            this.rbCamisa.UseVisualStyleBackColor = true;
            this.rbCamisa.CheckedChanged += new System.EventHandler(this.rbCamisa_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.linkHistorialCotizaciones);
            this.panel4.Controls.Add(this.lbNombreVendedor);
            this.panel4.Location = new System.Drawing.Point(0, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 43);
            this.panel4.TabIndex = 3;
            // 
            // linkHistorialCotizaciones
            // 
            this.linkHistorialCotizaciones.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.linkHistorialCotizaciones.AutoSize = true;
            this.linkHistorialCotizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkHistorialCotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkHistorialCotizaciones.LinkColor = System.Drawing.Color.SlateBlue;
            this.linkHistorialCotizaciones.Location = new System.Drawing.Point(541, 11);
            this.linkHistorialCotizaciones.Name = "linkHistorialCotizaciones";
            this.linkHistorialCotizaciones.Size = new System.Drawing.Size(175, 18);
            this.linkHistorialCotizaciones.TabIndex = 1;
            this.linkHistorialCotizaciones.TabStop = true;
            this.linkHistorialCotizaciones.Text = "Historial Cotizaciones";
            this.linkHistorialCotizaciones.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHistorialCotizaciones_LinkClicked);
            // 
            // lbNombreVendedor
            // 
            this.lbNombreVendedor.AutoSize = true;
            this.lbNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreVendedor.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbNombreVendedor.Location = new System.Drawing.Point(13, 11);
            this.lbNombreVendedor.Name = "lbNombreVendedor";
            this.lbNombreVendedor.Size = new System.Drawing.Size(358, 18);
            this.lbNombreVendedor.TabIndex = 0;
            this.lbNombreVendedor.Text = "nombre y apellido vendedor | codigo Vendedor";
            // 
            // btCotizar
            // 
            this.btCotizar.BackColor = System.Drawing.Color.SlateBlue;
            this.btCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCotizar.Location = new System.Drawing.Point(84, 634);
            this.btCotizar.Name = "btCotizar";
            this.btCotizar.Size = new System.Drawing.Size(255, 73);
            this.btCotizar.TabIndex = 4;
            this.btCotizar.Text = "Cotizar";
            this.btCotizar.UseVisualStyleBackColor = false;
            this.btCotizar.Click += new System.EventHandler(this.btCotizar_Click);
            // 
            // lbPrecioCotizacion
            // 
            this.lbPrecioCotizacion.AutoSize = true;
            this.lbPrecioCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioCotizacion.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbPrecioCotizacion.Location = new System.Drawing.Point(368, 655);
            this.lbPrecioCotizacion.Name = "lbPrecioCotizacion";
            this.lbPrecioCotizacion.Size = new System.Drawing.Size(334, 51);
            this.lbPrecioCotizacion.TabIndex = 5;
            this.lbPrecioCotizacion.Text = "$ : __________";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(804, 767);
            this.Controls.Add(this.lbPrecioCotizacion);
            this.Controls.Add(this.btCotizar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al asistente de Cotización";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Prenda.ResumeLayout(false);
            this.Prenda.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbNombreTienda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkHistorialCotizaciones;
        private System.Windows.Forms.Label lbNombreVendedor;
        private System.Windows.Forms.GroupBox Prenda;
        private System.Windows.Forms.RadioButton rbPantalon;
        private System.Windows.Forms.RadioButton rbCamisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelstock;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox cbChupin;
        private System.Windows.Forms.CheckBox cbCuelloMao;
        private System.Windows.Forms.CheckBox cbMangaCorta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbCalidadPremium;
        private System.Windows.Forms.RadioButton rbCalidadStandard;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCotizar;
        private System.Windows.Forms.Label lbPrecioCotizacion;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

