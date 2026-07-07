namespace EstudoRecurso
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDefinirOrcamento = new System.Windows.Forms.Button();
            this.btnAtualizarSaldo = new System.Windows.Forms.Button();
            this.txtSaldoDisponivel = new System.Windows.Forms.TextBox();
            this.txtGastoAtual = new System.Windows.Forms.TextBox();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddSuplemento = new System.Windows.Forms.Button();
            this.btnEliminarSuplemento = new System.Windows.Forms.Button();
            this.dtaGridSuplementos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPlano = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnFecharPlano = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPlano = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridSuplementos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDefinirOrcamento);
            this.groupBox1.Controls.Add(this.btnAtualizarSaldo);
            this.groupBox1.Controls.Add(this.txtSaldoDisponivel);
            this.groupBox1.Controls.Add(this.txtGastoAtual);
            this.groupBox1.Controls.Add(this.txtOrcamento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definição de Orçamento";
            // 
            // btnDefinirOrcamento
            // 
            this.btnDefinirOrcamento.Location = new System.Drawing.Point(434, 24);
            this.btnDefinirOrcamento.Name = "btnDefinirOrcamento";
            this.btnDefinirOrcamento.Size = new System.Drawing.Size(154, 31);
            this.btnDefinirOrcamento.TabIndex = 7;
            this.btnDefinirOrcamento.Text = "Definir Orçamento ";
            this.btnDefinirOrcamento.UseVisualStyleBackColor = true;
            this.btnDefinirOrcamento.Click += new System.EventHandler(this.btnDefinirOrcamento_Click);
            // 
            // btnAtualizarSaldo
            // 
            this.btnAtualizarSaldo.Location = new System.Drawing.Point(434, 137);
            this.btnAtualizarSaldo.Name = "btnAtualizarSaldo";
            this.btnAtualizarSaldo.Size = new System.Drawing.Size(154, 31);
            this.btnAtualizarSaldo.TabIndex = 6;
            this.btnAtualizarSaldo.Text = "Atualizar Saldo";
            this.btnAtualizarSaldo.UseVisualStyleBackColor = true;
            // 
            // txtSaldoDisponivel
            // 
            this.txtSaldoDisponivel.Location = new System.Drawing.Point(179, 141);
            this.txtSaldoDisponivel.Name = "txtSaldoDisponivel";
            this.txtSaldoDisponivel.Size = new System.Drawing.Size(249, 22);
            this.txtSaldoDisponivel.TabIndex = 5;
            // 
            // txtGastoAtual
            // 
            this.txtGastoAtual.Location = new System.Drawing.Point(179, 84);
            this.txtGastoAtual.Name = "txtGastoAtual";
            this.txtGastoAtual.Size = new System.Drawing.Size(249, 22);
            this.txtGastoAtual.TabIndex = 4;
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.Location = new System.Drawing.Point(179, 28);
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.Size = new System.Drawing.Size(249, 22);
            this.txtOrcamento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo Disponivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gasto Atual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite de Gastos do Mês";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bem Vindo,";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(94, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(19, 16);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "....";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnAddSuplemento);
            this.groupBox2.Controls.Add(this.btnEliminarSuplemento);
            this.groupBox2.Controls.Add(this.dtaGridSuplementos);
            this.groupBox2.Location = new System.Drawing.Point(4, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ver Lista Completa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ediar Item Selecionado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAddSuplemento
            // 
            this.btnAddSuplemento.Location = new System.Drawing.Point(349, 246);
            this.btnAddSuplemento.Name = "btnAddSuplemento";
            this.btnAddSuplemento.Size = new System.Drawing.Size(309, 44);
            this.btnAddSuplemento.TabIndex = 9;
            this.btnAddSuplemento.Text = "Adicionar Novo Suplemento";
            this.btnAddSuplemento.UseVisualStyleBackColor = true;
            this.btnAddSuplemento.Click += new System.EventHandler(this.btnAdicionarSuplemento_Click);
            // 
            // btnEliminarSuplemento
            // 
            this.btnEliminarSuplemento.Location = new System.Drawing.Point(349, 323);
            this.btnEliminarSuplemento.Name = "btnEliminarSuplemento";
            this.btnEliminarSuplemento.Size = new System.Drawing.Size(309, 43);
            this.btnEliminarSuplemento.TabIndex = 10;
            this.btnEliminarSuplemento.Text = "Eliminar Item Selecionado ";
            this.btnEliminarSuplemento.UseVisualStyleBackColor = true;
            this.btnEliminarSuplemento.Click += new System.EventHandler(this.btnEliminarSuplemento_Click);
            // 
            // dtaGridSuplementos
            // 
            this.dtaGridSuplementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridSuplementos.Location = new System.Drawing.Point(6, 21);
            this.dtaGridSuplementos.Name = "dtaGridSuplementos";
            this.dtaGridSuplementos.RowHeadersWidth = 51;
            this.dtaGridSuplementos.RowTemplate.Height = 24;
            this.dtaGridSuplementos.Size = new System.Drawing.Size(657, 206);
            this.dtaGridSuplementos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPlano);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.btnFecharPlano);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.btnAddItem);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.listBoxPlano);
            this.groupBox3.Location = new System.Drawing.Point(674, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 400);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Construção de Plano ";
            // 
            // btnPlano
            // 
            this.btnPlano.Location = new System.Drawing.Point(338, 198);
            this.btnPlano.Name = "btnPlano";
            this.btnPlano.Size = new System.Drawing.Size(152, 29);
            this.btnPlano.TabIndex = 11;
            this.btnPlano.Text = "Plano";
            this.btnPlano.UseVisualStyleBackColor = true;
            this.btnPlano.Click += new System.EventHandler(this.btnPlano_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(477, 31);
            this.button6.TabIndex = 7;
            this.button6.Text = "Limpar Plano ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnFecharPlano
            // 
            this.btnFecharPlano.Location = new System.Drawing.Point(13, 316);
            this.btnFecharPlano.Name = "btnFecharPlano";
            this.btnFecharPlano.Size = new System.Drawing.Size(477, 31);
            this.btnFecharPlano.TabIndex = 8;
            this.btnFecharPlano.Text = "Fechar Plano Mensal ";
            this.btnFecharPlano.UseVisualStyleBackColor = true;
            this.btnFecharPlano.Click += new System.EventHandler(this.btnFecharPlano_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 279);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(477, 31);
            this.button8.TabIndex = 9;
            this.button8.Text = "Remover Item";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(13, 242);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(477, 31);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "Adicionar Item Selecionado";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAdicionarAoPlano_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plano Atual ";
            // 
            // listBoxPlano
            // 
            this.listBoxPlano.HideSelection = false;
            this.listBoxPlano.Location = new System.Drawing.Point(13, 18);
            this.listBoxPlano.Name = "listBoxPlano";
            this.listBoxPlano.Size = new System.Drawing.Size(477, 164);
            this.listBoxPlano.TabIndex = 0;
            this.listBoxPlano.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.lblUserName);
            this.groupBox4.Location = new System.Drawing.Point(674, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 189);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Users";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(342, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(154, 31);
            this.button10.TabIndex = 9;
            this.button10.Text = "SAIR";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1189, 601);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridSuplementos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAtualizarSaldo;
        private System.Windows.Forms.TextBox txtSaldoDisponivel;
        private System.Windows.Forms.TextBox txtGastoAtual;
        private System.Windows.Forms.TextBox txtOrcamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddSuplemento;
        private System.Windows.Forms.Button btnEliminarSuplemento;
        private System.Windows.Forms.DataGridView dtaGridSuplementos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listBoxPlano;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnFecharPlano;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnDefinirOrcamento;
        private System.Windows.Forms.Button btnPlano;
    }
}

