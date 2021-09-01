﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WWTravelClubDB
{
    public class LibraryDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MainDbContext>
    {
        private const string connectionString = @"Server=SESTO-L2103005;Database=wwtravelclub;
                                                    Trusted_Connection=True;MultipleActiceResultSets=true";

        public MainDbContext CreateDbContext(params string[] args)
        {
            var builder = new DbContextOptionsBuilder<MainDbContext>();
            builder.UseSqlServer(connectionString);

            return new MainDbContext(builder.Options);
        }
    }

}