namespace lectura_y_escritura_de_archivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btescribirarchivo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnabrirarchivo = new System.Windows.Forms.Button();
            this.txtarchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(44, 32);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(44, 13);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Location = new System.Drawing.Point(44, 69);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(52, 13);
            this.lbdireccion.TabIndex = 1;
            this.lbdireccion.Text = "Direccion";
            this.lbdireccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(44, 120);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(32, 13);
            this.lbedad.TabIndex = 2;
            this.lbedad.Text = "Edad";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(100, 25);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(93, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(100, 62);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(93, 20);
            this.txtdireccion.TabIndex = 4;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(100, 113);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(93, 20);
            this.txtedad.TabIndex = 5;
            // 
            // btescribirarchivo
            // 
            this.btescribirarchivo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btescribirarchivo.ImageIndex = 0;
            this.btescribirarchivo.ImageList = this.imageList1;
            this.btescribirarchivo.Location = new System.Drawing.Point(12, 191);
            this.btescribirarchivo.Name = "btescribirarchivo";
            this.btescribirarchivo.Size = new System.Drawing.Size(134, 47);
            this.btescribirarchivo.TabIndex = 6;
            this.btescribirarchivo.Text = "Escribir Archivo";
            this.btescribirarchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btescribirarchivo.UseVisualStyleBackColor = true;
            this.btescribirarchivo.Click += new System.EventHandler(this.btescribirarchivo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "153746__citroen-survolt_p.jpg");
            this.imageList1.Images.SetKeyName(1, "untitled.png");
            // 
            // btnabrirarchivo
            // 
            this.btnabrirarchivo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnabrirarchivo.ImageIndex = 1;
            this.btnabrirarchivo.ImageList = this.imageList1;
            this.btnabrirarchivo.Location = new System.Drawing.Point(395, 280);
            this.btnabrirarchivo.Name = "btnabrirarchivo";
            this.btnabrirarchivo.Size = new System.Drawing.Size(115, 54);
            this.btnabrirarchivo.TabIndex = 7;
            this.btnabrirarchivo.Text = "Abrir archivo";
            this.btnabrirarchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnabrirarchivo.UseVisualStyleBackColor = true;
            this.btnabrirarchivo.Click += new System.EventHandler(this.btnabrirarchivo_Click);
            // 
            // txtarchivo
            // 
            this.txtarchivo.Enabled = false;
            this.txtarchivo.Location = new System.Drawing.Point(168, 297);
            this.txtarchivo.Name = "txtarchivo";
            this.txtarchivo.Size = new System.Drawing.Size(209, 20);
            this.txtarchivo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Archivo";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(214, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(331, 265);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Direccion";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Edad";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos de texto|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 346);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtarchivo);
            this.Controls.Add(this.btnabrirarchivo);
            this.Controls.Add(this.btescribirarchivo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.lbdireccion);
            this.Controls.Add(this.lbnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btescribirarchivo;
        private System.Windows.Forms.Button btnabrirarchivo;
        private System.Windows.Forms.TextBox txtarchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

