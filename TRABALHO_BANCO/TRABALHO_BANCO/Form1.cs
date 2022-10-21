﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_BANCO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRABALHO_BANCODataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.tRABALHO_BANCODataSet.CLIENTE);

        }

        private void btInserir_Click(object sender, EventArgs e)
        {

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool isOK = true;

            // Recupera a string de conexão com os dados do servidor e da base de dados
            string connectionString = Properties.Settings.Default.TRABALHO_BANCOConnectionString;

            // Iniciar a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            // Cria o comando SQL
            comm = new SqlCommand(
                "DELETE FROM CLIENTE " +
                "WHERE CLI_CPF = @CLI_CPF", conn);

            // Declara e atribui os valores para as variáveis
            comm.Parameters.Add("@CLI_CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_CPF"].Value = mtxCPF.Text;


            try
            {
                // Tentar abrir uma conexão com o Servidor/Base de dados
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }

                // Tentar executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o Banco de Dados

                if (isOK == true)
                {
                    MessageBox.Show("Cliente deletado com sucesso!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de cidades 
                    this.cLIENTETableAdapter.Fill(this.tRABALHO_BANCODataSet.CLIENTE);
                }
            }

            //LimparForm();

        } // FIM DO EVENTO btExcluir_Click

        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
