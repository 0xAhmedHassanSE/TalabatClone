
using AutoMapper;
using TalabatClone.Application.DTOs.RestaurantDTOs;
using TalabatClone.Application.Interfaces.UnitOfWork;
using TalabatClone.Application.Response;
using TalabatClone.Application.Services.InterFaces;
using TalabatClone.Domain.Entities;
using TalabatClone.Domain.Enums;

namespace TalabatClone.Application.Services.Implementation
{
    public class RestaurantServices : IRestaurantServices
    {
        readonly IUnitOfWork unitOfWork;
        readonly IMapper mapper;
        public RestaurantServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<Response<RestaurantResponseDto>> CreateRestaurantAsync(CreateRestaurantDto restaurantDto, string OwnerId)
        {
            var owner = await unitOfWork.Users.GetByIDAsync(OwnerId);
            if (owner is null)
                return new Response<RestaurantResponseDto>(false, null, "There is no User has this Id");

            var restaurant = mapper.Map<Restaurant>(restaurantDto);
            restaurant.OwnerId = OwnerId;
            restaurant.Status = RestaurantStatus.Closed;

            await unitOfWork.Restaurants.AddAsync(restaurant);
            await unitOfWork.SaveAllAsync();
            var restaurantResponseDTO = mapper.Map<RestaurantResponseDto>(restaurant);
            return new Response<RestaurantResponseDto>(true, restaurantResponseDTO, null);

        }

        public async Task<Response<RestaurantResponseDto>> GetRestaurantByIDAsync(int RestaurantId)
        {
            var restaurant = await unitOfWork.Restaurants.GetByIDAsync(RestaurantId);
            if (restaurant is null)
                return new Response<RestaurantResponseDto>(false, null, "There is no Restaurant has thid Id");

            return new Response<RestaurantResponseDto>(true, mapper.Map<RestaurantResponseDto>(restaurant), null);
        }

        public async Task<Response<List<RestaurantResponseDto>>> GetRestaurantsAsync()
        {
            var restaurants = await unitOfWork.Restaurants.GetAllAsync();
            if (restaurants is null)
                return new Response<List<RestaurantResponseDto>>(false, null, "There is no Restaurant has thid Id");

            var dtos = mapper.Map<List<RestaurantResponseDto>>(restaurants);
            return new Response<List<RestaurantResponseDto>>(true, dtos, null);
        }

        public async Task<Response<List<RestaurantResponseDto>>> GetRestaurantsByOwnerAsync(string OwnerId)
        {
            var owner = await unitOfWork.Users.GetByIDAsync(OwnerId);
            if (owner is null)
                return new Response<List<RestaurantResponseDto>>(false, null, "There is no such Id like this");
            var restaurants = await unitOfWork.Restaurants.GetAllAsync();
            var ownedRestaurants = restaurants.Where(res => res.OwnerId == OwnerId).ToList();
            return new Response<List<RestaurantResponseDto>>(true, mapper.Map<List<RestaurantResponseDto>>(ownedRestaurants), null);
        }

        public async Task UpdateRestaurant(int RestaurantId, UpdateRestaurantDto restaurantDto, string RequestingUserId)
        {
            var restaurant = await CheckNullableVlaues(RestaurantId, RequestingUserId);
            restaurant.Name = restaurantDto.Name;
            restaurant.Address = mapper.Map<Address>(restaurantDto.Address);
            await unitOfWork.SaveAllAsync();
        }

        public async Task UpdateRestaurantStatus(int RestaurantId, RestaurantStatus status, string RequestingUserId)
        {
            var restaurant = await CheckNullableVlaues(RestaurantId, RequestingUserId);
            restaurant.Status = status;
            await unitOfWork.SaveAllAsync();

        }
        private async Task<Restaurant> CheckNullableVlaues(int RestaurantId, string RequestingUserId)
        {
            var restaurant = await unitOfWork.Restaurants.GetByIDAsync(RestaurantId);
            if (restaurant is null)
                throw new Exception("There is no such Id like this");
            var user =await unitOfWork.Users.GetByIDAsync(RequestingUserId);
            if (user is null)
                throw new Exception("There is no such Id like this");
            if (restaurant.OwnerId != RequestingUserId)
                throw new Exception("No Authorize");
            return restaurant;
        }
        public async Task DeleteRestaurantById(int RestaurantId, string RequestingUserId)
        {
            var restaurant = await CheckNullableVlaues(RestaurantId, RequestingUserId);
            restaurant.IsDeleted = true;
            await unitOfWork.SaveAllAsync();
        }

    }
}
