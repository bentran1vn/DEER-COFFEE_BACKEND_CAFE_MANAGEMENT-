using DeerCoffeeShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeerCoffeeShop.Domain.Entities
{
    public class RestaurantChain : Entity, ISoftDelete
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required string RestaurantChainID { get; set; }
        public required string RestaurantChain_AdminID { get; set; }
        [ForeignKey("RestaurantChain_AdminID")]
        public virtual required Employee RestaurantChain_Admin { get; set; }
        public required string RestaurantChainName { get; set; }
        public required string RestaurantChainHQAddress { get; set; }
        public required string RestaurantChainType { get; set; }
        public required int RestaurantChainTotalBranches { get; set; }
        public required int RestaurantChainTotalEmployees { get; set; }

        public DateTime? NgayXoa { get; set; }
        public string? NguoiXoaID { get; set; }
        [ForeignKey("NguoiXoaID")]
        public virtual Employee? NguoiXoa { get; set; }
        public bool IsDeleted { get; set; }
    }
}
