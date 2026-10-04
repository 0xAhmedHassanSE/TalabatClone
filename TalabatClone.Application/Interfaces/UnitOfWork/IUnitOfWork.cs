

using TalabatClone.Application.Interfaces.Repos;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<int> SaveAllAsync();
        IUserRepo Users { get; }
        IGenericRepo<Restaurant> Restaurants { get; }
        IGenericRepo<Item> Items { get; }
        IGenericRepo<Order> Orders { get; }
        IGenericRepo<OrderItem> OrderItems { get; }
        IGenericRepo<OrderGroup> OrderGroups { get; }
        IGenericRepo<Cart> Carts { get; }
        IGenericRepo<CartItem> CartItems { get; }
        IGenericRepo<OrderAddress> OrderAddresss { get; }
        IGenericRepo<Category> Categorys { get; }
        IGenericRepo<Payment> Payments { get; }

    }
}
