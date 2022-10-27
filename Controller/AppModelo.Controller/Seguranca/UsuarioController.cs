using AppModelo.Model.Infra.Repositories;

namespace AppModelo.Controller.Seguranca
{
    public class UsuarioController
    {
        public bool EfetuarLogin(string usuario, string senha)
        {
            var repositorio = new UsuarioRepository();
            var usuarioEncontrado = repositorio.Obter(usuario,senha);

            if (usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
