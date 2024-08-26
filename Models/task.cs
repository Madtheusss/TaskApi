using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TaskApi.Models;

[Table("tasks")]
public class Task {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default;
    
    [Required]
    [StringLength(100)]
    public string Title { get; set; } = default;
    
    [Column(TypeName = "text")]
    public string Description { get; set; } = default;
    public bool Conclued { get; set; } = default;
}
