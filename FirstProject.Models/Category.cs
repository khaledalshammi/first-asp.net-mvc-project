using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstProject.Models;

public class Category
{
    [Key]
    public int Id{ get; set; }
    [Required]
    [DisplayName("Category Name")]
    public string Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1,120,ErrorMessage="musnt be less than 1 and more than 120")]
    public int DisplayOrder { get; set; }
    [DisplayName("Created At")]
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}
