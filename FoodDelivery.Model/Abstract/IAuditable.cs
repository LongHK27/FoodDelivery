using System;

namespace FoodDelivery.Model.Abstract
{
    public interface IAuditable
    {
        DateTime CreateDate { get; set; }
        string CreateBy { get; set; }
        int Status { get; set; }
        string Name { get; set; }
        string Alias { get; set; }
        string ImageLink { get; set; }
        string Description { get; set; }
    }
}