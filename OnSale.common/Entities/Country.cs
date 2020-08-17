using System.ComponentModel.DataAnnotations;
using Xunit;

namespace OnSale.common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
