using TalabatClone.Application.Interfaces.Repos;
using TalabatClone.Application.Interfaces.UnitOfWork;
using TalabatClone.Domain.Entities;
using TalabatClone.Infrastructure.Database;
using TalabatClone.Infrastructure.Implementations.Repos;

namespace TalabatClone.Infrastructure.Implementations.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly TalabatDB talabatDB;
        public UnitOfWork(TalabatDB talabatDB) => this.talabatDB = talabatDB;

        IUserRepo? User;
        public IUserRepo Users => User ??= new UserRepo(talabatDB);
        IGenericRepo<Restaurant>? Restaurant;
        public IGenericRepo<Restaurant> Restaurants => Restaurant ??= new GenericRepo<Restaurant>(talabatDB);
        IGenericRepo<Item>? Item;
        public IGenericRepo<Item> Items => Item ??= new GenericRepo<Item>(talabatDB);
        IGenericRepo<Order>? Order;
        public IGenericRepo<Order> Orders => Order ??= new GenericRepo<Order>(talabatDB);
        IGenericRepo<OrderItem>? OrderItem;
        public IGenericRepo<OrderItem> OrderItems => OrderItem ??= new GenericRepo<OrderItem>(talabatDB);
        IGenericRepo<OrderGroup>? OrderGroup;
        public IGenericRepo<OrderGroup> OrderGroups => OrderGroup ??= new GenericRepo<OrderGroup>(talabatDB);
        IGenericRepo<Cart>? Cart;
        public IGenericRepo<Cart> Carts => Cart ??= new GenericRepo<Cart>(talabatDB);
        IGenericRepo<CartItem>? CartItem;
        public IGenericRepo<CartItem> CartItems => CartItem ??= new GenericRepo<CartItem>(talabatDB);
        IGenericRepo<OrderAddress>? OrderAddress;
        public IGenericRepo<OrderAddress> OrderAddresss => OrderAddress ??= new GenericRepo<OrderAddress>(talabatDB);
        IGenericRepo<Category>? Category;
        public IGenericRepo<Category> Categorys => Category ??= new GenericRepo<Category>(talabatDB);
        IGenericRepo<Payment>? Payment;
        public IGenericRepo<Payment> Payments => Payment ??= new GenericRepo<Payment>(talabatDB);

        public async ValueTask DisposeAsync() => await talabatDB.DisposeAsync();

        public async Task<int> SaveAllAsync() => await talabatDB.SaveChangesAsync();

    }
}
