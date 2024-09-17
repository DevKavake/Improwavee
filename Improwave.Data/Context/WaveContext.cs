using Microsoft.EntityFrameworkCore;

namespace Improwave.Data.Context;

public class WaveContext : DbContext
{
    #region Constructor

    public WaveContext(DbContextOptions<WaveContext> options) : base(options)
    {
    }

    #endregion
}