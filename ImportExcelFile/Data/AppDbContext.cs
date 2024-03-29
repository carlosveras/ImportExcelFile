﻿using ImportExcelFile.Models;
using Microsoft.EntityFrameworkCore;

namespace ImportExcelFile.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ImportExcelFileTableModel> ImportExcelFileTable {  get; set; }

    }
}
