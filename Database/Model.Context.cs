﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class АвтозаправкиEntities : DbContext
    {
        public АвтозаправкиEntities()
            : base("name=АвтозаправкиEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Автозаправка> Автозаправка { get; set; }
        public virtual DbSet<Акции_на_товар> Акции_на_товар { get; set; }
        public virtual DbSet<Акции_на_услугу> Акции_на_услугу { get; set; }
        public virtual DbSet<Запись> Запись { get; set; }
        public virtual DbSet<Общая> Общая { get; set; }
        public virtual DbSet<Постоянные_клиенты> Постоянные_клиенты { get; set; }
        public virtual DbSet<Сервер> Сервер { get; set; }
        public virtual DbSet<Товар> Товар { get; set; }
        public virtual DbSet<Топливо> Топливо { get; set; }
        public virtual DbSet<Услуга> Услуга { get; set; }
        public virtual DbSet<Чек> Чек { get; set; }
    }
}
