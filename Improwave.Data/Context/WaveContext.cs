using Improwave.Domain.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Improwave.Data.Context;

public class WaveContext : DbContext
{
    #region Constructor

    public WaveContext(DbContextOptions<WaveContext> options) : base(options)
    {
    }

    #endregion

    #region Db Sets

    public DbSet<User> Users { get; set; }

    #endregion
}