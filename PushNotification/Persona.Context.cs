﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PushNotification
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PersonasEntities : DbContext
    {
        public PersonasEntities()
            : base("name=PersonasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<persona> personas { get; set; }
    
        public virtual int deletePersona(Nullable<int> cedula)
        {
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deletePersona", cedulaParameter);
        }
    
        public virtual ObjectResult<getPersonas_Result> getPersonas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPersonas_Result>("getPersonas");
        }
    
        public virtual ObjectResult<getPersonasId_Result> getPersonasId(Nullable<int> cedula)
        {
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPersonasId_Result>("getPersonasId", cedulaParameter);
        }
    
        public virtual int postPersona(Nullable<int> cedula, string apellidos, string nombres, string sn_habilitado, Nullable<bool> genero)
        {
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(int));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("apellidos", apellidos) :
                new ObjectParameter("apellidos", typeof(string));
    
            var nombresParameter = nombres != null ?
                new ObjectParameter("nombres", nombres) :
                new ObjectParameter("nombres", typeof(string));
    
            var sn_habilitadoParameter = sn_habilitado != null ?
                new ObjectParameter("sn_habilitado", sn_habilitado) :
                new ObjectParameter("sn_habilitado", typeof(string));
    
            var generoParameter = genero.HasValue ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("postPersona", cedulaParameter, apellidosParameter, nombresParameter, sn_habilitadoParameter, generoParameter);
        }
    
        public virtual int putPersona(Nullable<int> cedula, string apellidos, string nombres, string sn_habilitado, Nullable<bool> genero)
        {
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(int));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("apellidos", apellidos) :
                new ObjectParameter("apellidos", typeof(string));
    
            var nombresParameter = nombres != null ?
                new ObjectParameter("nombres", nombres) :
                new ObjectParameter("nombres", typeof(string));
    
            var sn_habilitadoParameter = sn_habilitado != null ?
                new ObjectParameter("sn_habilitado", sn_habilitado) :
                new ObjectParameter("sn_habilitado", typeof(string));
    
            var generoParameter = genero.HasValue ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("putPersona", cedulaParameter, apellidosParameter, nombresParameter, sn_habilitadoParameter, generoParameter);
        }
    }
}
