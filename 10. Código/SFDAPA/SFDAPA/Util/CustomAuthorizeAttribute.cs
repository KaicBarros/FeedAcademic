/*using System.Web;
using System.Web.Mvc;
using Model.Models;
using System.Web.Routing;

namespace BibliotecaWeb.Util
{
    public enum TipoUsuario { USUARIO, BALCONISTA }

    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        #region PropriedadesConstrutor

        /// <summary> Propriedade AllowAccess que permite o acesso a um método de ação. /// </summary>
        public bool AllowAccess { get; set; }

        /// <summary> Propriedade NivelAcesso que determina o nível de acesso de um método de ação. /// </summary>
        public TipoUsuario NivelAcesso;

        /// <summary> Propriedade referente ao método de ação que o usuário será redirecionado caso não tenha permissão. /// </summary>
        public string MetodoAcao;

        /// <summary> Propriedade referente à controladora que o usuário será redirecionado caso não tenha permissão. /// </summary>
        public string Controladora;

        /// <summary> Método Construtor. /// </summary>
        public CustomAuthorizeAttribute()
        {
            AllowAccess = false;
            MetodoAcao = "Index";
            Controladora = "Home";
        }

        #endregion

        /// <summary>
        /// Método AuthorizeCore - Valida se um usuário está autorizado para acessar um recurso.
        /// </summary>
        /// <param name="httpContext"> Objeto do tipo HttpContextBase contendo atributos de uma
        ///     requisição e/ou sessão do usuário. </param>
        /// <returns> Booleano que indica se o usuário está autorizado. </returns>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            Usuario usuario = SessionHelper.Get(SessionKeys.USUARIO) as Usuario;
            if(usuario == null)
                return false;
            if (httpContext.Request.IsAuthenticated && (usuario.TipoUsuario.Id == ((int) NivelAcesso + 1) || AllowAccess))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Método HandleUnauthorizedRequest - Permite redirecionar o usuário para a página inicial
        ///     quando o mesmo não tem permissão para acessar um recurso.
        /// </summary>
        /// <param name="filterContext"> Objeto do tipo AuthorizationContext, o qual é necesssário
        ///     para o redirecionamento do usuário. </param>
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            Usuario usuario = SessionHelper.Get(SessionKeys.USUARIO) as Usuario;
            if (usuario == null)
                HttpContext.Current.Session.Abandon();
            RouteValueDictionary rota = new RouteValueDictionary();
            rota["controller"] = Controladora;
            rota["action"] = MetodoAcao;
            filterContext.Result = new RedirectToRouteResult(rota);
        }
    }
}*/