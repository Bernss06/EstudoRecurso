using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EstudoRecurso.Controllers;
using EstudoRecurso.Models;

namespace EstudoRecurso
{
    public partial class Form1 : Form
    {
        // Instanciação dos teus controladores
        private SuplementoController _suplementoController;
        private PlanoController _planoController;

        // Variáveis globais para controlo do orçamento na View
        private decimal orcamentoMensal = 0;
        private decimal totalGastoAtual = 0;

        public Form1()
        {
            InitializeComponent();
            _suplementoController = new SuplementoController();
            _planoController = new PlanoController();
        }

        // EVENTO: Carregar o Form
        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarGrelhaSuplementos();
        }

        #region Separador 1 - Gestão de Suplementos (CRUD)

        private void btnAdicionarSuplemento_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos estão preenchidos
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtPreco.Text))
                {
                    MessageBox.Show("Preencha os campos obrigatórios (Nome e Preço).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nome = txtNome.Text;
                string marca = txtMarca.Text;
                string categoria = txtCategoria.Text;
                decimal preco = decimal.Parse(txtPreco.Text);

                _suplementoController.AdicionarSuplemento(nome, marca, categoria, preco);
                AtualizarGrelhaSuplementos();
                LimparCamposSuplemento();

                MessageBox.Show("Suplemento registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("O formato do preço é inválido. Use números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarSuplemento_Click(object sender, EventArgs e)
        {
            if (dgvSuplementos.CurrentRow != null)
            {
                int idSelecionado = (int)dgvSuplementos.CurrentRow.Cells["Id"].Value;
                _suplementoController.EliminarSuplemento(idSelecionado);
                AtualizarGrelhaSuplementos();
            }
            else
            {
                MessageBox.Show("Selecione um suplemento na grelha para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarGrelhaSuplementos()
        {
            dgvSuplementos.DataSource = _suplementoController.ObterTodosSuplementos();
        }

        private void LimparCamposSuplemento()
        {
            txtNome.Clear();
            txtMarca.Clear();
            txtCategoria.Clear();
            txtPreco.Clear();
        }

        #endregion

        #region Separador 2 - Construção do Plano (Orçamento)

        private void btnDefinirOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                orcamentoMensal = decimal.Parse(txtOrcamento.Text);
                AtualizarVisorOrcamento();
                MessageBox.Show($"Orçamento definido para {orcamentoMensal}€", "Orçamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Valor de orçamento inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarAoPlano_Click(object sender, EventArgs e)
        {
            if (dgvSuplementos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um suplemento do catálogo primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ir buscar dados do item selecionado na grelha
                int id = (int)dgvSuplementos.CurrentRow.Cells["Id"].Value;
                string nome = dgvSuplementos.CurrentRow.Cells["Nome"].Value.ToString();
                decimal preco = (decimal)dgvSuplementos.CurrentRow.Cells["PrecoUnidade"].Value;

                int quantidade = int.Parse(txtQuantidadePlano.Text);
                decimal subtotal = preco * quantidade;

                // Regra de Negócio: Verificar Orçamento
                if (totalGastoAtual + subtotal > orcamentoMensal)
                {
                    MessageBox.Show("Atenção! Adicionar este item irá ultrapassar o teu plafond mensal!", "Orçamento Excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Opcional: lblAvisoOrcamento.Visible = true;
                }

                // Atualizar totais
                totalGastoAtual += subtotal;

                // Adicionar à ListBox visual (Carrinho)
                string linhaCarrinho = $"{quantidade}x {nome} - Subtotal: {subtotal}€";
                listBoxPlano.Items.Add(linhaCarrinho);

                AtualizarVisorOrcamento();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao adicionar ao plano. Verifique a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFecharPlano_Click(object sender, EventArgs e)
        {
            if (listBoxPlano.Items.Count == 0)
            {
                MessageBox.Show("Não pode fechar um plano vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pede ao controller para guardar na BD
            _planoController.FecharPlano(totalGastoAtual);

            MessageBox.Show("Plano guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpa a interface para um novo mês
            listBoxPlano.Items.Clear();
            totalGastoAtual = 0;
            AtualizarVisorOrcamento();
        }

        private void AtualizarVisorOrcamento()
        {
            lblGastoAtual.Text = $"{totalGastoAtual}€";
            lblSaldoDisponivel.Text = $"{orcamentoMensal - totalGastoAtual}€";
        }

        #endregion

        private void btnPlano_Click(object sender, EventArgs e)
        {
            var planoForm = new Views.FormsPlano();
            planoForm.Show();
            this.Hide();
        }
    }
}