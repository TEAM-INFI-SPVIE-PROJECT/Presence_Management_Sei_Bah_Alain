using Microsoft.EntityFrameworkCore;
using PresenceManagement.DataAccess.Models;
using UnivAssurance.DataAccess.Data;

namespace UnivAssurance.DataAccess.Data
{

    public class PresenceDbContext: DbContext
    {  
      protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Person>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.idPerson);
            });
            modelBuilder.Entity<Teacher>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.IdTeacher);
            });

            modelBuilder.Entity<Students>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.IdStudent);
            });

            modelBuilder.Entity<SessionCourse>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.IdSession);
            });
            modelBuilder.Entity<Semestre>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.IdSemestre);
            });
            modelBuilder.Entity<Role>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.idRole);
            });
            modelBuilder.Entity<matters>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.idMatter);
            });
            modelBuilder.Entity<Users>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.IdUsers);
            });
             modelBuilder.Entity<Admin>(entite =>{
                entite.HasKey(Proprietes =>Proprietes.IdAdmin);
            });
      }   
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Server=DESKTOP-3BEDEK9;Database=Presence_Management;User Id=sa;Password=1234;Encrypt=false; Trusted_Connection=true;");
            }
      }
        public PresenceDbContext()
        {
            
        } 
        public PresenceDbContext(DbContextOptions<DbContext> option):base (option)
        {
            
        }

        public virtual DbSet<Person> Person{get;set;}  
    }
    
}