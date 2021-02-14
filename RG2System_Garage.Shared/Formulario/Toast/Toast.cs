using RG2System_Garage.Domain.Enum;

namespace RG2System_Garage.Shared.Formulario.Toast
{
    public class Toast
    {
        public static void ShowToast(string menssagem, EnumToast enumToast)
        {
            frmToast frmToast = new frmToast(menssagem, enumToast);
            frmToast.Show();
        }
    }
}
