using RG2System_Garage.Domain.Commands.Orcamento;
using RG2System_Garage.Domain.Enum;
using RG2System_Garage.Shared.Formulario.Toast;
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
    }
}
