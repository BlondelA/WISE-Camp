using System;
using System.Collections.Generic;
using System.Text;
using Metier.Entities;
using Microsoft.EntityFrameworkCore;
using CSharpFunctionalExtensions;
using Action = Metier.Entities.Action;

namespace Metier.Data
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> nameOrConnectionString) : base(nameOrConnectionString)
        {

        }

        public Result Commit()
        {
            try
            {
                SaveChanges();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Fail("Impossible d'enregistrer");
            }
        }

        public DbSet<Action> Actions { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Code> Codes { get; set; }
        public DbSet<CodeModalitePedagogique> CodeModalitePedagogiques { get; set; }
        public DbSet<Coordonnees> Coordonnees { get; set; }
        public DbSet<DomaineFormation> DomaineFormations { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Geolocalisation> Geolocalisations { get; set; }
        public DbSet<ModulesPrerequis> ModulesPrerequis { get; set; }
        public DbSet<Numtel> Numtels { get; set; }
        public DbSet<OrganismeFinanceur> OrganismeFinanceurs { get; set; }
        public DbSet<OrganismeFormateurs> OrganismeFormateurs { get; set; }
        public DbSet<OrganismeFormationResponsable> OrganismeFormationResponsables { get; set; }
        public DbSet<Periode> Periodes { get; set; }
        public DbSet<Potentiel> Potentiels { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SousModule> SousModules { get; set; }
        public DbSet<Web> Webs { get; set; }
        public DbSet<Utilisateur> Utilisateurs {get;set;}
        public DbSet<Role> Roles { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Action>().ToTable("Action");
        //}
        
    }
}
