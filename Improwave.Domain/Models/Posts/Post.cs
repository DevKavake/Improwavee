using Improwave.Domain.Models.Common;

namespace Improwave.Domain.Models.Posts;

public class Post:BaseEntity<int>
{
    public string AutorName { get; set; }

    public string Content { get; set; }

    public string MainImage { get; set; }

    public string Images { get; set; }

    public string Tags { get; set; }
    
    public string TimeToRead { get; set; }

    public DateTime CreateDate { get; set; }
   
}