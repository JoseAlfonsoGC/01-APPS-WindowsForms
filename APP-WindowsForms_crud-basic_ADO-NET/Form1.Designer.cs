
namespace APP_WindowsForms_crud_basic_ADO_NET
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBoxBuscarId = new System.Windows.Forms.PictureBox();
            this.pictureBoxBuscarNombre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscarId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscarNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // txtApellido
            // 
            resources.ApplyResources(this.txtApellido, "txtApellido");
            this.txtApellido.Name = "txtApellido";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.Name = "txtCorreo";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtBuscarId
            // 
            resources.ApplyResources(this.txtBuscarId, "txtBuscarId");
            this.txtBuscarId.Name = "txtBuscarId";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtBuscarNombre
            // 
            resources.ApplyResources(this.txtBuscarNombre, "txtBuscarNombre");
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGuardar.BackgroundImage = global::APP_WindowsForms_crud_basic_ADO_NET.Properties.Resources.guardar;
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEditar.BackgroundImage = global::APP_WindowsForms_crud_basic_ADO_NET.Properties.Resources.edita;
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEliminar.BackgroundImage = global::APP_WindowsForms_crud_basic_ADO_NET.Properties.Resources.eliminar;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // pictureBoxBuscarId
            // 
            this.pictureBoxBuscarId.Image = global::APP_WindowsForms_crud_basic_ADO_NET.Properties.Resources.buscarID;
            resources.ApplyResources(this.pictureBoxBuscarId, "pictureBoxBuscarId");
            this.pictureBoxBuscarId.Name = "pictureBoxBuscarId";
            this.pictureBoxBuscarId.TabStop = false;
            this.pictureBoxBuscarId.Click += new System.EventHandler(this.pictureBoxBuscarId_Click);
            // 
            // pictureBoxBuscarNombre
            // 
            this.pictureBoxBuscarNombre.Image = global::APP_WindowsForms_crud_basic_ADO_NET.Properties.Resources.buscarNombre;
            resources.ApplyResources(this.pictureBoxBuscarNombre, "pictureBoxBuscarNombre");
            this.pictureBoxBuscarNombre.Name = "pictureBoxBuscarNombre";
            this.pictureBoxBuscarNombre.TabStop = false;
            this.pictureBoxBuscarNombre.Click += new System.EventHandler(this.pictureBoxBuscarNombre_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBoxBuscarNombre);
            this.Controls.Add(this.pictureBoxBuscarId);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscarId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscarNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBoxBuscarId;
        private System.Windows.Forms.PictureBox pictureBoxBuscarNombre;
    }
}

