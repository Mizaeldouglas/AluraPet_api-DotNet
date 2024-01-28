using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace AluraPet_api.Models;

public class Tutor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required] [StringLength(120)] public string Name { get; set; } = String.Empty;

    [MaxLength(20)] [Required] [Phone] public string Phone { get; set; } = String.Empty;

    [MaxLength(255)] public string City { get; set; } = String.Empty;

    [MaxLength(255)] public string Avatar { get; set; } = String.Empty;

    [MaxLength(1000)] public string About { get; set; } = String.Empty;
}