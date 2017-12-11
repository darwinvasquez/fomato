using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Principal;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data.Common;

namespace disec.Models
{
    // Puede agregar datos del perfil del usuario agregando más propiedades a la clase ApplicationUser. Para más información, visite http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public string GRAD_ALFABETICO { set; get; }
        public string NOMBRES { set; get; }
        public string APELLIDOS { set; get; }
        public string IDENTIFICACION { set; get; }
        public string SEXO { set; get; }
        public string SITUACION_LABORAL { set; get; }
        public string CARGO_ACTUAL { set; get; }
        public string NUMERO_CELULAR { set; get; }
        public string CORREO_ELECTRONICO { set; get; }
        public string FISICA { set; get; }
        public string DESCRIPCION_DEPENDENCIA { set; get; }
        public string SIGLA_DEPENDENCIA { set; get; }
        public string ESPECIALIDAD { set; get; }
        public Nullable<decimal> CODIGO_FISICA { get; set; }
        public Nullable<decimal> CODIGO_REGIONAL { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbConnection oracleConexion)
          : base(oracleConexion, contextOwnsConnection: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext(new OracleConnection(ConfigurationManager.ConnectionStrings["ContextIdentity"].ConnectionString));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);         
            modelBuilder.HasDefaultSchema("USR_SIMOP"); // Use uppercase!
            modelBuilder.Entity<ApplicationUser>().ToTable("CADNETOID");
            modelBuilder.Entity<IdentityRole>().ToTable("CADNETROLES");
            modelBuilder.Entity<IdentityUserRole>().ToTable("CADNETOIDROLES");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("CADNETCLAIMS");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("CADNETLOGINS");

        }
    }

    public static class IdentityExtension
    {

        public static string GetGrado(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.GRAD_ALFABETICO : string.Empty;
        }

        public static string GetNombres(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.NOMBRES : string.Empty;
        }

        public static string GetApellidos(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.APELLIDOS : string.Empty;
        }

        public static string GetIdentificacion(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.IDENTIFICACION : string.Empty;
        }

        public static string GetSexo(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.SEXO : string.Empty;
        }

        public static string GetSituacionLaboral(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.SITUACION_LABORAL : string.Empty;
        }

        public static string GetCargo(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.CARGO_ACTUAL : string.Empty;
        }

        public static string GetCelular(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.NUMERO_CELULAR : string.Empty;
        }

        public static string GetEmail(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.CORREO_ELECTRONICO : string.Empty;
        }

        public static string GetUnidad(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.FISICA : string.Empty;
        }

        public static string GetDependencia(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.DESCRIPCION_DEPENDENCIA : string.Empty;
        }

        public static string GetSiglaDependencia(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.SIGLA_DEPENDENCIA : string.Empty;
        }

        public static string GetEspecialidad(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (user != null) ? user.ESPECIALIDAD : string.Empty;
        }
        //public static int GetRegionPolicia(this IIdentity identity)
        //{
        //    ContextDisec db = new ContextDisec();
        //    var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());

        //    if (user != null)
        //    {
        //        CADNETOID usuario = db.CADNETOIDs.Find(user.Id);
        //        return Convert.ToInt32(usuario.VM_UNIDAD_DEPENDENCIA.REGI_CODIGO);
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        //public static int GetCodigoDepartamento(this IIdentity identity)
        //{
        //    ContextDisec db = new ContextDisec();
        //    var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());

        //    if (user != null)
        //    {
        //        CADNETOID usuario = db.CADNETOIDs.Find(user.Id);
        //        return Convert.ToInt32(usuario.VM_UNIDAD_DEPENDENCIA.LUGE_CODIGO_DEPARTAMENTO);
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        public static int GetCodigoFisica(this IIdentity identity)
        {
            var user = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());

            if (user != null)
            {
                return Convert.ToInt32(user.CODIGO_FISICA);
            }
            else
            {
                return 0;
            }
        }

    }
}