using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Escuela.Models
{
    public class DataModel:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DataModel():base("Datamodel")
        {
            
        }
         
        public virtual DbSet<Alumno> Alumnos { get; set; }
    }
}