using Microsoft.EntityFrameworkCore;
using Api.Entities;

namespace Api.Context
{
    public class AppointmentsContext : DbContext
    {
        public AppointmentsContext(DbContextOptions<AppointmentsContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    };
}