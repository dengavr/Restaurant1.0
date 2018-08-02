using System.Collections.Generic;

namespace Restaurant.BLL
{
    public interface IDishOrderService : IService
    {
        void Add(DishOrderService DishOrder);
        ICollection<DishOrderService> All();
    }
    public interface IDishService : IService
    {
        void Add(DishDTO dish);
        ICollection<DishDTO> All();
    }
    public interface IIngredientService : IService
    {
        void Add(IngredientService dish);
        ICollection<IngredientService> All();
    }
    public interface IProductService : IService
    {
        void Add(ProductService dish);
        ICollection<ProductService> All();
    }
    public interface IProductOrderService : IService
    {
        void Add(ProductOrderService dish);
        ICollection<ProductOrderService> All();
    }
    public interface IReceiptService : IService
    {
        void Add(ReceiptService dish);
        ICollection<ReceiptService> All();
    }

}
