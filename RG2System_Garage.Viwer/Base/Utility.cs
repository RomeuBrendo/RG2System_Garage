using Microsoft.Reporting.WinForms;
using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Shared.Formulario.Toast;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace RG2System_Garage.Viwer.Base
{

    public static class Utility
    {

        public static bool PesquisaDataGrid(DataGridView grid, string descricao, int index)
        {
            try
            {
                if (descricao.Trim() != "")
                    foreach (DataGridViewRow item in grid.Rows)
                    {
                        if (item.Cells[index].Value.ToString().StartsWith(descricao))
                        {
                            grid.Focus();
                            item.Cells[index].Selected = true;

                            return true;
                        }
                    }
                Toast.ShowToast("Decrição não localizada", EnumToast.Informacao);

                //this.Focus();
                return false;
            }
            catch
            {
                Toast.ShowToast("Erro ao popular grid", EnumToast.Erro);
                return false;
            }
        }

        public static void PDFOrcamento(OrcamentoResponse orcamento)
        {

        }

        public static void ExportarRelatorio(string formato, string nomeArquivo, LocalReport report)
        {
            try
            {
                Directory.CreateDirectory("Relatorios");

                var bytes = report.Render(formato);
                File.WriteAllBytes(nomeArquivo, bytes);
                Process.Start(nomeArquivo);
            }
            catch (Exception ex)
            {
                Toast.ShowToast("Erro ao renderizar PDF Detalhes: " + ex, EnumToast.Erro);
            }

        }

        public static List<ProdutosOrcamentoResponse> PopulaProdutosOrcamento(List<OrcamentoItensResponse> itens)
        {
            var produtosServicos = new List<ProdutosOrcamentoResponse>();
            foreach (var item in itens.ToList())
            {
                var produto = new ProdutosOrcamentoResponse();

                switch (item.ProdutoServico.Tipo)
                {
                    case EnumTipo.Produto:
                        produto.Descricao = "Produto";
                        break;

                    case EnumTipo.Servico:
                        produto.Descricao = "Serviço";
                        break;

                }

                produto.Tipo = item.ProdutoServico.Tipo.ToString();
                produto.Descricao = item.ProdutoServico.Descricao;
                produto.Quantidade = item.Quantidade;
                produto.PrecoVenda = item.PrecoVenda;

                produtosServicos.Add(produto);
            }

            return produtosServicos;
        }
    }
}
