﻿//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControleCond
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ControleCondDBEntities : DbContext
    {
        public ControleCondDBEntities()
            : base("name=ControleCondDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TB_APARTAMENTO> TB_APARTAMENTO { get; set; }
        public DbSet<TB_BLOCO> TB_BLOCO { get; set; }
        public DbSet<TB_COND> TB_COND { get; set; }
        public DbSet<TB_MORADOR> TB_MORADOR { get; set; }
    }
}