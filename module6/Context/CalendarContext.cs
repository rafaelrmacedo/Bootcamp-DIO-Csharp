using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using module6.Entities;

namespace module6.Context
{
    //Herança com a classe DbContext
    public class CalendarContext : DbContext
    {
        //Constructor for DataBase
        public CalendarContext(DbContextOptions<CalendarContext> options) : base(options) {}

        public DbSet<Contact> Contacts { get; set; }
    }
}