using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUD_EF
{
    public partial class Form1 : Form
    {
        int codProduto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lerProdutos();
        }
        private void lerProdutos()
        {
             CadastroEntities context = new CadastroEntities(); 
 
             IEnumerable<Produto> lista = from p in context.Produtos select p;
             grpProdutos.Text = "Produtos: " + lista.Count();
             gdvProdutos.DataSource = lista.ToList();
         }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            CadastroEntities context = new CadastroEntities(); 
            Produto novoproduto = new Produto() { nomeProduto = txtProdutoNome.Text, categoriaid = Convert.ToInt32(txtCategoriaID.Text)};

            context.AddToProdutos(novoproduto); 
            context.SaveChanges();
            lerProdutos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CadastroEntities context = new CadastroEntities();
            int codigoProduto = Convert.ToInt32(txtProdutoID.Text);

            Produto produto = context.Produtos.First(p => p.produtoId == codigoProduto);

            produto.nomeProduto = txtProdutoNome.Text;
            produto.categoriaid = Convert.ToInt32(txtCategoriaID.Text);
            context.SaveChanges();
            lerProdutos();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CadastroEntities context = new CadastroEntities();
            int codigoProduto = Convert.ToInt32(txtProdutoID.Text);

            Produto produto = context.Produtos.First(p => p.produtoId == codigoProduto);

            context.DeleteObject(produto); 
            context.SaveChanges(); 
            lerProdutos();
        }

        private void gdvProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //---Quando o usuário clicar no controle , exibe o conteudo da célula referente a primeira coluna (Column=0)
	        try
            {
		        //codigo do produto
                codProduto = Convert.ToInt32(gdvProdutos.Rows[e.RowIndex].Cells[0].Value);
                procuraProduto(codProduto);
	        } 
            catch 
            {}
        }

        private void procuraProduto(int codProduto)
        {
            CadastroEntities context = new CadastroEntities();

            Produto produto = context.Produtos.First(p => p.produtoId == codProduto);

            txtProdutoID.Text = produto.produtoId.ToString();
            txtProdutoNome.Text = produto.nomeProduto;
            txtCategoriaID.Text = produto.categoriaid.ToString();
        }

    }
}
