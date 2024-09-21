
namespace BackOffice
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
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.listaUsuarios = new System.Windows.Forms.ListBox();
            this.listaPosts = new System.Windows.Forms.ListBox();
            this.listaComentarios = new System.Windows.Forms.ListBox();
            this.btnEliminarPost = new System.Windows.Forms.Button();
            this.btnEliminarComentarios = new System.Windows.Forms.Button();
            this.txtBuscarUser = new System.Windows.Forms.TextBox();
            this.txtBuscarPost = new System.Windows.Forms.TextBox();
            this.btnBuscaPost = new System.Windows.Forms.Button();
            this.txtBuscarComentario = new System.Windows.Forms.TextBox();
            this.btnBuscaComentarios = new System.Windows.Forms.Button();
            this.fotoPost = new System.Windows.Forms.PictureBox();
            this.Mensaje = new System.Windows.Forms.Label();
            this.listaGrupos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.Location = new System.Drawing.Point(233, 34);
            this.btnBuscarUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(77, 25);
            this.btnBuscarUser.TabIndex = 1;
            this.btnBuscarUser.Text = "Buscar";
            this.btnBuscarUser.UseVisualStyleBackColor = true;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.AccessibleName = "lista";
            this.listaUsuarios.FormattingEnabled = true;
            this.listaUsuarios.ItemHeight = 16;
            this.listaUsuarios.Location = new System.Drawing.Point(57, 62);
            this.listaUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(253, 324);
            this.listaUsuarios.TabIndex = 4;
            this.listaUsuarios.SelectedIndexChanged += new System.EventHandler(this.listaUsuarios_SelectedIndexChanged);
            this.listaUsuarios.DoubleClick += new System.EventHandler(this.listaUsuarios_DoubleClick);
            // 
            // listaPosts
            // 
            this.listaPosts.FormattingEnabled = true;
            this.listaPosts.ItemHeight = 16;
            this.listaPosts.Location = new System.Drawing.Point(428, 62);
            this.listaPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaPosts.Name = "listaPosts";
            this.listaPosts.Size = new System.Drawing.Size(253, 324);
            this.listaPosts.TabIndex = 5;
            this.listaPosts.SelectedIndexChanged += new System.EventHandler(this.listaPosts_SelectedIndexChanged);
            this.listaPosts.DoubleClick += new System.EventHandler(this.listaPosts_DoubleClick);
            // 
            // listaComentarios
            // 
            this.listaComentarios.FormattingEnabled = true;
            this.listaComentarios.ItemHeight = 16;
            this.listaComentarios.Location = new System.Drawing.Point(1021, 70);
            this.listaComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaComentarios.Name = "listaComentarios";
            this.listaComentarios.Size = new System.Drawing.Size(252, 324);
            this.listaComentarios.TabIndex = 6;
            // 
            // btnEliminarPost
            // 
            this.btnEliminarPost.Location = new System.Drawing.Point(574, 390);
            this.btnEliminarPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPost.Name = "btnEliminarPost";
            this.btnEliminarPost.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarPost.TabIndex = 8;
            this.btnEliminarPost.Text = "Dar de baja";
            this.btnEliminarPost.UseVisualStyleBackColor = true;
            this.btnEliminarPost.Click += new System.EventHandler(this.btnEliminarPost_Click);
            // 
            // btnEliminarComentarios
            // 
            this.btnEliminarComentarios.Location = new System.Drawing.Point(1171, 398);
            this.btnEliminarComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarComentarios.Name = "btnEliminarComentarios";
            this.btnEliminarComentarios.Size = new System.Drawing.Size(102, 23);
            this.btnEliminarComentarios.TabIndex = 9;
            this.btnEliminarComentarios.Text = "Dar de baja";
            this.btnEliminarComentarios.UseVisualStyleBackColor = true;
            this.btnEliminarComentarios.Click += new System.EventHandler(this.btnEliminarComentarios_Click);
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Location = new System.Drawing.Point(47, 34);
            this.txtBuscarUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(169, 22);
            this.txtBuscarUser.TabIndex = 11;
            // 
            // txtBuscarPost
            // 
            this.txtBuscarPost.Location = new System.Drawing.Point(428, 37);
            this.txtBuscarPost.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarPost.Name = "txtBuscarPost";
            this.txtBuscarPost.Size = new System.Drawing.Size(169, 22);
            this.txtBuscarPost.TabIndex = 13;
            // 
            // btnBuscaPost
            // 
            this.btnBuscaPost.Location = new System.Drawing.Point(604, 37);
            this.btnBuscaPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscaPost.Name = "btnBuscaPost";
            this.btnBuscaPost.Size = new System.Drawing.Size(77, 25);
            this.btnBuscaPost.TabIndex = 12;
            this.btnBuscaPost.Text = "Buscar";
            this.btnBuscaPost.UseVisualStyleBackColor = true;
            this.btnBuscaPost.Click += new System.EventHandler(this.btnBuscaPost_Click);
            // 
            // txtBuscarComentario
            // 
            this.txtBuscarComentario.Location = new System.Drawing.Point(1020, 42);
            this.txtBuscarComentario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarComentario.Name = "txtBuscarComentario";
            this.txtBuscarComentario.Size = new System.Drawing.Size(169, 22);
            this.txtBuscarComentario.TabIndex = 15;
            // 
            // btnBuscaComentarios
            // 
            this.btnBuscaComentarios.Location = new System.Drawing.Point(1195, 42);
            this.btnBuscaComentarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscaComentarios.Name = "btnBuscaComentarios";
            this.btnBuscaComentarios.Size = new System.Drawing.Size(77, 25);
            this.btnBuscaComentarios.TabIndex = 14;
            this.btnBuscaComentarios.Text = "Buscar";
            this.btnBuscaComentarios.UseVisualStyleBackColor = true;
            this.btnBuscaComentarios.Click += new System.EventHandler(this.btnBuscaComentarios_Click);
            // 
            // fotoPost
            // 
            this.fotoPost.Location = new System.Drawing.Point(708, 63);
            this.fotoPost.Margin = new System.Windows.Forms.Padding(4);
            this.fotoPost.Name = "fotoPost";
            this.fotoPost.Size = new System.Drawing.Size(288, 325);
            this.fotoPost.TabIndex = 16;
            this.fotoPost.TabStop = false;
            this.fotoPost.Click += new System.EventHandler(this.fotoPost_Click);
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Location = new System.Drawing.Point(777, 42);
            this.Mensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(165, 17);
            this.Mensaje.TabIndex = 17;
            this.Mensaje.Text = "Previsualizacion del Post";
            // 
            // listaGrupos
            // 
            this.listaGrupos.ForeColor = System.Drawing.Color.Black;
            this.listaGrupos.FormattingEnabled = true;
            this.listaGrupos.ItemHeight = 16;
            this.listaGrupos.Location = new System.Drawing.Point(57, 398);
            this.listaGrupos.Name = "listaGrupos";
            this.listaGrupos.Size = new System.Drawing.Size(253, 212);
            this.listaGrupos.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 630);
            this.Controls.Add(this.listaGrupos);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.fotoPost);
            this.Controls.Add(this.txtBuscarComentario);
            this.Controls.Add(this.btnBuscaComentarios);
            this.Controls.Add(this.txtBuscarPost);
            this.Controls.Add(this.btnBuscaPost);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.btnEliminarComentarios);
            this.Controls.Add(this.btnEliminarPost);
            this.Controls.Add(this.listaComentarios);
            this.Controls.Add(this.listaPosts);
            this.Controls.Add(this.listaUsuarios);
            this.Controls.Add(this.btnBuscarUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BackOffice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarUser;
        private System.Windows.Forms.ListBox listaUsuarios;
        private System.Windows.Forms.ListBox listaPosts;
        private System.Windows.Forms.ListBox listaComentarios;
        private System.Windows.Forms.Button btnEliminarPost;
        private System.Windows.Forms.Button btnEliminarComentarios;
        private System.Windows.Forms.TextBox txtBuscarUser;
        private System.Windows.Forms.TextBox txtBuscarPost;
        private System.Windows.Forms.Button btnBuscaPost;
        private System.Windows.Forms.TextBox txtBuscarComentario;
        private System.Windows.Forms.Button btnBuscaComentarios;
        private System.Windows.Forms.PictureBox fotoPost;
        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.ListBox listaGrupos;
    }
}

