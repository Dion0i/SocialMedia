using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Insfraestructure.Data.Configurations;

namespace SocialMedia.Insfraestructure.Data;

public partial class SocialMediaContext : DbContext
{
    public SocialMediaContext()
    {
    }

    public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // we are not using this more. modelBuilder.Entity<Comment>(entity => { we had moved this dates to CommentConfiguration... });
        modelBuilder.ApplyConfiguration(new CommentConfiguration()); // This is the subtitutle of the above.

        // we are not using this more. modelBuilder.Entity<Post>(entity =>{ we had moved this dates to PostConfiguration...});
        modelBuilder.ApplyConfiguration(new PostConfiguration()); // This is the subtitutle of the above.

        // we are not using this more. modelBuilder.Entity<User>(entity => { we had moved this dates to UserConfiguration... });
        modelBuilder.ApplyConfiguration(new UserConfiguration()); // This is the subtitutle of the above.

        // Read MMG above if you have any confussion.
    }
}
