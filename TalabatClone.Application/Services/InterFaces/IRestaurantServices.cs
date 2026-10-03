

using TalabatClone.Application.DTOs.RestaurantDTOs;
using TalabatClone.Application.Response;
using TalabatClone.Domain.Enums;

namespace TalabatClone.Application.Services.InterFaces
{
    public interface IRestaurantServices
    {
        Task<Response<RestaurantResponseDto>> CreateRestaurantAsync(CreateRestaurantDto restaurantDto , string OwnerId);
        Task<Response<RestaurantResponseDto>> GetRestaurantByIDAsync(int RestaurantId);
        Task<Response<List<RestaurantResponseDto>>> GetRestaurantsAsync();
        Task<Response<List<RestaurantResponseDto>>> GetRestaurantsByOwnerAsync(string OwnerId);
        Task UpdateRestaurant(int RestaurantId, UpdateRestaurantDto restaurantDto , string RequestingUserId);
        Task UpdateRestaurantStatus(int RestaurantId, RestaurantStatus status, string RequestingUserId);
        Task DeleteRestaurantById(int RestaurantId,string RequestingUserId);
    }
}
