namespace DeerCoffeeShop.Domain.Entities.Base
{
    public interface ISoftDelete
    {
        DateTime? NgayXoa { get; set; }
        string? NguoiXoaID { get; set; }
        bool IsDeleted { get; set; }


    }
}
