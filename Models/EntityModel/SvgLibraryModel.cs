using System.ComponentModel.DataAnnotations; 

namespace WebConfigurationApi.Models.EntityModel
{
    public class SvgLibraryModel
    {
        [Key]
        public int iconId { get; set; }
        public string iconName { get; set; }
        public string svgPath { get; set; }
    }
}
