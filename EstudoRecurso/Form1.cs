using EstudoRecurso.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoRecurso
{
    public partial class Form1 : Form
    {
        //Instanciando os controladores
        private SuplementoController _supController;
        private PlanoController _planoController;
        public Form1()
        {
            InitializeComponent();
            _supController = new SuplementoController();
            _planoController = new PlanoController();
        }
        //Evento quando o formolario é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            //Carregar os suplementos no DataGridView
            AtualizarGrelhaSuplementos();
        }
        private void AtualizarGrelhaSuplementos()
        {
            var suplementos = _supController.ObterTodosSuplementos();
            dtaGridSuplementos.DataSource = suplementos;
        }
}
