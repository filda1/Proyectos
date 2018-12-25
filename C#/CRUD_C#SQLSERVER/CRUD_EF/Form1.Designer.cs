namespace CRUD_EF
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdutoID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdutoNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoriaID = new System.Windows.Forms.TextBox();
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.gdvProdutos = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtProdutoID
            // 
            this.txtProdutoID.Location = new System.Drawing.Point(143, 183);
            this.txtProdutoID.Name = "txtProdutoID";
            this.txtProdutoID.Size = new System.Drawing.Size(52, 20);
            this.txtProdutoID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.Location = new System.Drawing.Point(143, 209);
            this.txtProdutoNome.Name = "txtProdutoNome";
            this.txtProdutoNome.Size = new System.Drawing.Size(148, 20);
            this.txtProdutoNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categoria";
            // 
            // txtCategoriaID
            // 
            this.txtCategoriaID.Location = new System.Drawing.Point(142, 235);
            this.txtCategoriaID.Name = "txtCategoriaID";
            this.txtCategoriaID.Size = new System.Drawing.Size(52, 20);
            this.txtCategoriaID.TabIndex = 1;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.gdvProdutos);
            this.grpProdutos.Location = new System.Drawing.Point(12, 12);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(379, 165);
            this.grpProdutos.TabIndex = 2;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Produtos :";
            // 
            // gdvProdutos
            // 
            this.gdvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvProdutos.Location = new System.Drawing.Point(3, 16);
            this.gdvProdutos.Name = "gdvProdutos";
            this.gdvProdutos.Size = new System.Drawing.Size(373, 146);
            this.gdvProdutos.TabIndex = 0;
            this.gdvProdutos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvProdutos_CellEnter);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(66, 271);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(147, 271);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(228, 271);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 306);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.grpProdutos);
            this.Controls.Add(this.txtCategoriaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProdutoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdutoID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdutoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdutoNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoriaID;
        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.DataGridView gdvProdutos;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

