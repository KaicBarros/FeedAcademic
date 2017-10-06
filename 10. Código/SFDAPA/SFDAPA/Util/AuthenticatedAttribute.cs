/*
using System.Web;
using System.Web.Mvc;
using Model.Models;
using System.Web.Routing;

namespace SFDAPA.Util
{
    public class AuthenticatedAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// OnActionExecuting - Permite verificar se um usuário está autenticado
        ///     para realizar as operações do sistema.
        /// </summary>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!IsAuthenticated())
            {
                HttpContext.Current.Session.Abandon();
                RouteValueDictionary rota = new RouteValueDictionary();
                rota["controller"] = "Home";
                rota["action"] = "Index";
                filterContext.Result = new RedirectToRouteResult(rota);
            }
            base.OnActionExecuting(filterContext);
        }

        /// <summary>
        /// IsAuthenticated - Analisa se o usuário na sessão atual está autenticado.
        /// </summary>
        /// <returns> Booleano que indica se o usuário está autenticado. </returns>
        private bool IsAuthenticated()
        {
            Usuario usuario = SessionHelper.Get(SessionKeys.USUARIO) as Usuario;
            if (usuario == null)
                return false;
            if (HttpContext.Current.Request.IsAuthenticated)
                return true;
            else
                return false;
        }
    }
}
*/