using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Week11Playground.Enums;
namespace Week11Playground.Models.Entities
{
    public class Organization
    {
        [Key] public Guid OrganizationId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrganizationTypeId OrganizationTypeId { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
