using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace LifeStyle
{
    public partial class frm_Avaliacao : Form
    {
        public frm_Avaliacao()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            cbx_objetivo.Enabled = true;
            nud_peso.Enabled = true;
            nud_massaMagra.Enabled = true;
            nud_altura.Enabled = true;
            nud_diaTreino.Enabled = true;
            btn_imprimir.Enabled = true;
            btn_limpar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_novo.Enabled = false;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            cbx_objetivo.Text = "";
            nud_peso.Value= 0;
            nud_massaMagra.Value = 0; 
            nud_altura.Value = 0; 
            nud_diaTreino.Value = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome.Enabled = false;
            cbx_objetivo.Enabled = false;
            nud_peso.Enabled = false;
            nud_massaMagra.Enabled = false;
            nud_altura.Enabled = false;
            nud_diaTreino.Enabled = false;
            btn_imprimir.Enabled = false;
            btn_limpar.Enabled = false;
            btn_cancelar.Enabled =false;
            btn_novo.Enabled = true;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Global.diretorio + @"\avaliacao.pdf"; // a string contém o caminho + nome do arquivo
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create); //FileStream recebe nome do arquivo + o modo de criação
            Document doc = new Document(PageSize.A4); // construtor recebe o tamanho da pagina
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF); // recebe documento que será escrito e o FileStream

            // Criação do Logo da pagina
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Global.diretorio + @"\logoLifeStyle.jpg");
            logo.ScaleToFit(100f, 80f); // tamanho do logo
            logo.SetAbsolutePosition(35f, 725f); // posição do logo na pagina (X, -Y) y=0 e x=0 imagem fica no rodape e y=700 e x=100 imagem fica no cabeçalho
                                                 //logo.Alignment = Element.ALIGN_LEFT;

            // Criação do paragrafo da pagina
            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("\nAcademia Life Style\n");
            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("\n\nAvaliação Física\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            string texto = "\n\nLife Style\n";
            paragrafo2.Add(texto);

            PdfPTable tabela = new PdfPTable(2); // numero de colunas
            tabela.DefaultCell.FixedHeight = 20; // altura da celula

            tabela.AddCell("Nome");
            tabela.AddCell(txt_nome.Text);
            tabela.AddCell("Objetivo");
            tabela.AddCell(cbx_objetivo.Text);
            tabela.AddCell("Altura");
            tabela.AddCell(nud_altura.Value.ToString());
            tabela.AddCell("Peso (KG)");
            tabela.AddCell(nud_peso.Value.ToString());
            tabela.AddCell("Massa Magra (KG)");
            tabela.AddCell(nud_massaMagra.Value.ToString());
            tabela.AddCell("Dias de Treino");
            tabela.AddCell(nud_diaTreino.Value.ToString());

            DialogResult res = MessageBox.Show("Deseja abrir o Relatório?", "Academia Life Style", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                System.Diagnostics.Process.Start(Global.diretorio + @"\avaliacao.pdf");
            }

            // Adicionando itens no documento
            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();
        }
    }
}
