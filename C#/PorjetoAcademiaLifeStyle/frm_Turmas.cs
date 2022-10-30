using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace LifeStyle
{
    public partial class frm_Turmas : Form
    {
        string idSelecionado = "";
        int modoSalvar = 0;
        public frm_Turmas()
        {
            InitializeComponent();
        }
        private void frm_Turmas_Load(object sender, EventArgs e)
        {
            AtualizaDataGridView();

            //***************** popular comboBox Professor ************************

           string query = @"
                            SELECT
                                N_IDPROFESSOR,
                                T_NOMEPROFESSOR
                                FROM
                                tb_professores
                                ORDER BY
                                T_NOMEPROFESSOR
                                
                    ";
            cbx_professores.Items.Clear();
            cbx_professores.DataSource = Banco.dql(query);
            cbx_professores.DisplayMember = "T_NOMEPROFESSOR";
            cbx_professores.ValueMember = "N_IDPROFESSOR";

            //***************** popular comboBox Status ************************

            Dictionary<string, string> _status = new Dictionary<string, string>();

          //_status.Add("Key", "Value");
            _status.Add("A", "Ativa");
            _status.Add("P", "Paralisada");
            _status.Add("C", "Cancelada");
         
            cbx_Status.Items.Clear();
            cbx_Status.DataSource = new BindingSource(_status, null); //DataSource = _status  DataMember=null
            cbx_Status.DisplayMember = "Value";
            cbx_Status.ValueMember = "Key";
           
            //***************** popular comboBox Horarios ************************

            query = @"
                            SELECT
                                N_IDHORARIO,
                                T_DSCHORARIO
                                FROM
                                tb_horarios
                                ORDER BY
                                N_IDHORARIO
               ";

            cbx_Horario.Items.Clear();
            cbx_Horario.DataSource = Banco.dql(query);
            cbx_Horario.DisplayMember = "T_DSCHORARIO";
            cbx_Horario.ValueMember = "N_IDHORARIO";

        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {                    
         
            DataGridView dgv = (DataGridView)sender;
            int cont = dgv.SelectedRows.Count;
            
            if (cont > 0)
            {
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
               
                string  query = @"
                        SELECT
                            T_DSCTURMA,
                            N_IDPROFESSOR,
                            N_IDHORARIO,
                            N_MAXALUNOS,
                            T_STATUS
                        FROM
                            tb_turmas
                        WHERE
                            N_IDTURMA=" + idSelecionado; 

                DataTable dt = Banco.dql(query);
               
                txt_dscTurma.Text = dt.Rows[0].ItemArray[0].ToString();
                cbx_professores.SelectedValue = dt.Rows[0].ItemArray[1].ToString();
                nud_MaxAlunos.Value = decimal.Parse(dt.Rows[0].ItemArray[3].ToString());
                cbx_Status.SelectedValue = dt.Rows[0].ItemArray[4].ToString();
                cbx_Horario.SelectedValue = dt.Rows[0].ItemArray[2].ToString();
                txt_vagas.Text = CalculaVagas();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_dscTurma.Clear();
            cbx_professores.SelectedIndex = -1;
            nud_MaxAlunos.Value = 0;
            cbx_Status.SelectedIndex = -1;
            cbx_Horario.SelectedIndex = -1;
            txt_dscTurma.Focus();
            modoSalvar = 1;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_turmas.SelectedRows[0].Index;
            
            string query = "";

            Turma t = new Turma();

            t.IDTURMA = int.Parse(idSelecionado);
            t.DSCTURMA = txt_dscTurma.Text;
            t.IDPROFESSOR = Convert.ToInt32(cbx_professores.SelectedValue);
            t.IDHORARIO = Convert.ToInt32(cbx_Horario.SelectedValue);
            t.MAXALUNOS =   Convert.ToInt32(Math.Round(nud_MaxAlunos.Value, 0));
            t.STATUS = Convert.ToString(cbx_Status.SelectedValue);


            if(modoSalvar == 0)
            {
                query = "UPDATE tb_turmas SET T_DSCTURMA='" + t.DSCTURMA + "', N_IDPROFESSOR=" + t.IDPROFESSOR + ", N_IDHORARIO=" + t.IDHORARIO + ", N_MAXALUNOS= " + t.MAXALUNOS + ", T_STATUS='" + t.STATUS + "' WHERE N_IDTURMA=" + idSelecionado;

            }
            else
            {
                query = "INSERT INTO tb_turmas (T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS) VALUES ('"+ t.DSCTURMA + "', " + t.IDPROFESSOR + ", " + t.IDHORARIO + ", " + t.MAXALUNOS + ", '" + t.STATUS  + "')";
            }
            Banco.dml(query);
            modoSalvar = 0; // modo edição ativado
            AtualizaDataGridView();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma a exclusão da turma?", "Academia Life Style", MessageBoxButtons.YesNo, MessageBoxIcon.Question);       

            if(res == DialogResult.Yes)
            {
                string query = "DELETE FROM tb_turmas WHERE N_IDTURMA=" + idSelecionado;
                Banco.dml(query);
                AtualizaDataGridView();

            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {

            string nomeArquivo = Global.diretorio + @"\turmas.pdf"; // a string contém o caminho + nome do arquivo
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
            paragrafo.Add("\n\nRelatório de Turmas\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            string texto = "\n\nLife Style\n";
            paragrafo2.Add(texto);

            PdfPTable tabela = new PdfPTable(3); // numero de colunas
            tabela.DefaultCell.FixedHeight = 20; // altura da celula

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            string query = String.Format(@"
                SELECT 
                    N_IDTURMA, 
                    T_DSCTURMA, 
                    T_DSCHORARIO 
                FROM 
                    tb_turmas
                INNER JOIN
                    tb_horarios
                ON
                     tb_turmas.N_IDHORARIO = tb_horarios.N_IDHORARIO
                ");

            DataTable dtTurmas = Banco.dql(query);

            for (int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].ItemArray[0].ToString());
                tabela.AddCell(dtTurmas.Rows[i].ItemArray[1].ToString());
                tabela.AddCell(dtTurmas.Rows[i].ItemArray[2].ToString());

            }

            DialogResult res = MessageBox.Show("Deseja abrir o Relatório?", "Academia Life Style", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                System.Diagnostics.Process.Start(Global.diretorio + @"\turmas.pdf");
            }

            // Adicionando itens no documento
            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();
        }
       
        private void AtualizaDataGridView()
        {

            string query = @"
                            SELECT
                                N_IDTURMA AS 'Id',
                                T.T_DSCTURMA AS 'Turma',
                                P.T_NOMEPROFESSOR AS 'Professor',
                                H.T_DSCHORARIO AS 'Horario',
                                CASE
                                WHEN T.T_STATUS = 'A' THEN 'Ativa'
                                WHEN T.T_STATUS = 'P' THEN 'Paralisada'
                                WHEN T.T_STATUS = 'C' THEN 'Cancelada'
                                END as 'Status'
                                
                            FROM 
                                tb_turmas AS T
                                INNER JOIN
                                tb_professores AS  P on p.N_IDPROFESSOR = T.N_IDPROFESSOR,
                                tb_horarios as H on H.N_IDHORARIO = T.N_IDHORARIO    
                            ";

            dgv_turmas.DataSource = Banco.dql(query);
            dgv_turmas.Columns[0].Width = 50;
            dgv_turmas.Columns[1].Width = 100;
            dgv_turmas.Columns[2].Width = 100;
            dgv_turmas.Columns[3].Width = 100;
            dgv_turmas.Columns[4].Width = 80;
        }
        private string CalculaVagas()
        {
            int vagas = 0;
            Turma t = new Turma();

            string query = String.Format(@"
                            SELECT
                       count(N_IDALUNO) AS 'contVagas'
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS='A' and N_IDTURMA={0}", idSelecionado);
            DataTable dt = Banco.dql(query);
            vagas = Convert.ToInt32( Math.Round(nud_MaxAlunos.Value, 0).ToString());

            //vagas -= int.Parse(dt.Rows[0].ItemArray[0].ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            return vagas.ToString();
        }
        private void txt_vagas_TextChanged(object sender, EventArgs e)
        {
              txt_vagas.Text= CalculaVagas();
        }
    }
}
