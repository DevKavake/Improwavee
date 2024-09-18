using System.ComponentModel.DataAnnotations;

namespace Improwave.Domain.Models.Common;

public class BaseEntity<T>
{
    [Key]
    public T Id { get; set; }

    public bool IsDelete { get; set; }

    public DateTime CreateDate { get; set; }




}