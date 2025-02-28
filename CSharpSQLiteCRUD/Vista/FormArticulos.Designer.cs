namespace CSharpSQLiteCRUD.Vista
{
    partial class FormArticulos
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
            this.dgvListadoArt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLupaMedida = new System.Windows.Forms.Button();
            this.btnLupaCategoria = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoArt
            // 
            this.dgvListadoArt.AllowUserToAddRows = false;
            this.dgvListadoArt.AllowUserToDeleteRows = false;
            this.dgvListadoArt.AllowUserToOrderColumns = true;
            this.dgvListadoArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArt.Location = new System.Drawing.Point(12, 67);
            this.dgvListadoArt.Name = "dgvListadoArt";
            this.dgvListadoArt.ReadOnly = true;
            this.dgvListadoArt.Size = new System.Drawing.Size(692, 310);
            this.dgvListadoArt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(75, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(213, 27);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(294, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtArt
            // 
            this.txtArt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArt.Location = new System.Drawing.Point(710, 89);
            this.txtArt.Name = "txtArt";
            this.txtArt.ReadOnly = true;
            this.txtArt.Size = new System.Drawing.Size(277, 27);
            this.txtArt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(710, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Artículo: (*)";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(710, 156);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(277, 27);
            this.txtMarca.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca: (*)";
            // 
            // txtMedida
            // 
            this.txtMedida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedida.Location = new System.Drawing.Point(710, 227);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.ReadOnly = true;
            this.txtMedida.Size = new System.Drawing.Size(213, 27);
            this.txtMedida.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(710, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Medida: (*)";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(710, 294);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(213, 27);
            this.txtCategoria.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(710, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Categoría: (*)";
            // 
            // btnLupaMedida
            // 
            this.btnLupaMedida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupaMedida.Location = new System.Drawing.Point(937, 227);
            this.btnLupaMedida.Name = "btnLupaMedida";
            this.btnLupaMedida.Size = new System.Drawing.Size(50, 27);
            this.btnLupaMedida.TabIndex = 20;
            this.btnLupaMedida.Text = ":::";
            this.btnLupaMedida.UseVisualStyleBackColor = true;
            this.btnLupaMedida.Visible = false;
            // 
            // btnLupaCategoria
            // 
            this.btnLupaCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupaCategoria.Location = new System.Drawing.Point(937, 294);
            this.btnLupaCategoria.Name = "btnLupaCategoria";
            this.btnLupaCategoria.Size = new System.Drawing.Size(50, 27);
            this.btnLupaCategoria.TabIndex = 21;
            this.btnLupaCategoria.Text = ":::";
            this.btnLupaCategoria.UseVisualStyleBackColor = true;
            this.btnLupaCategoria.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Location = new System.Drawing.Point(710, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 37);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(838, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 37);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::CSharpSQLiteCRUD.Properties.Resources.logout256_24927;
            this.btnSalir.Location = new System.Drawing.Point(412, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 79);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Image = global::CSharpSQLiteCRUD.Properties.Resources.task_document_paper_descending_priority_tasks_documents_icon_142254;
            this.btnReporte.Location = new System.Drawing.Point(313, 383);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(93, 79);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CSharpSQLiteCRUD.Properties.Resources.delete_file256_25240;
            this.btnEliminar.Location = new System.Drawing.Point(214, 383);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 79);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::CSharpSQLiteCRUD.Properties.Resources.document_add_114467;
            this.btnNuevo.Location = new System.Drawing.Point(16, 383);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 79);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::CSharpSQLiteCRUD.Properties.Resources.application_edit_12962;
            this.btnActualizar.Location = new System.Drawing.Point(115, 383);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 79);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(999, 515);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLupaCategoria);
            this.Controls.Add(this.btnLupaMedida);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListadoArt);
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Artículos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLupaMedida;
        private System.Windows.Forms.Button btnLupaCategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}