using System.Web;
using System.Collections.Generic;
using System.Linq;
using asp_mvc_2.Models.DB;
using asp_mvc_2.Models.EntityManager;
using System.Web.Mvc;

namespace asp_mvc_2.Security
{
    public class AuthorizeRoleAttribute : AuthorizeAttribute
    {
        private readonly string[] userAssignedroles;
        public AuthorizeRoleAttribute(params string[] roles)
        {
            this.userAssignedroles = roles;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            using (DemoDBEntities db = new DemoDBEntities())
            {
                UserManager UM = new UserManager();
                foreach (var roles in userAssignedroles)
                {
                    if (authorize)
                        return authorize;
                }
            }
                return base.AuthorizeCore(httpContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("~/Home/UnAuthorized");
        }
    }
}