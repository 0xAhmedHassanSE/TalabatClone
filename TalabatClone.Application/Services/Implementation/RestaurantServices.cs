
using AutoMapper;
using TalabatClone.Application.CustomExceptions;
using TalabatClone.Application.DTOs.RestaurantDTOs;
using TalabatClone.Application.Interfaces.UnitOfWork;
using TalabatClone.Application.Services.InterFaces;
using TalabatClone.Domain.Entities;
using TalabatClone.Domain.Enums;

namespace TalabatClone.Application.Services.Implementation
{
    public class RestaurantServices : IRestaurantServices
    {
        const string OwnerNotFoundMessage = "There is no Owner has Id like this";
        const string RestaurantNotfoundMessage = "There is no Restaurant has Id like this";
        readonly IUnitOfWork unitOfWork;
        readonly IMapper mapper;
        public RestaurantServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<RestaurantResponseDto> CreateRestaurantAsync(CreateRestaurantDto restaurantDto, string OwnerId)
        {
            var owner = await unitOfWork.Users.GetByIDAsync(OwnerId);
            if (owner is null)
                throw new NotFoundException(OwnerNotFoundMessage);

            var restaurant = mapper.Map<Restaurant>(restaurantDto);
            restaurant.OwnerId = OwnerId;
            restaurant.Status = RestaurantStatus.Closed;

            await unitOfWork.Restaurants.AddAsync(restaurant);
            await unitOfWork.SaveAllAsync();

            return mapper.Map<RestaurantResponseDto>(restaurant);

        }

        public async Task<RestaurantResponseDto> GetRestaurantByIDAsync(int RestaurantId)
        {
            var restaurant = await unitOfWork.Restaurants.GetByIDAsync(RestaurantId);
            if (restaurant is null)
                throw new NotFoundException(RestaurantNotfoundMessage);

            return mapper.Map<RestaurantResponseDto>(restaurant);
        }

        public async Task<List<RestaurantResponseDto>> GetRestaurantsAsync()
        {
            var restaurants = await unitOfWork.Restaurants.GetAllAsync();
            if (restaurants is null)
                throw new NotFoundException(RestaurantNotfoundMessage);

            return mapper.Map<List<RestaurantResponseDto>>(restaurants);
        }

        public async Task<List<RestaurantResponseDto>> GetRestaurantsByOwnerAsync(string OwnerId)
        {
            var owner = await unitOfWork.Users.GetByIDAsync(OwnerId);
            if (owner is null)
                throw new NotFoundException(OwnerNotFoundMessage);
            var restaurants = await unitOfWork.Restaurants.FindAsync(res => res.OwnerId == OwnerId);
            return mapper.Map<List<RestaurantResponseDto>>(restaurants);
        }

        public async Task UpdateRestaurant(int RestaurantId, UpdateRestaurantDto restaurantDto, string RequestingUserId)
        {
            var restaurant = await GetRestaurantOrThrowAsync(RestaurantId, RequestingUserId);
            restaurant.Name = restaurantDto.Name;
            restaurant.Address = mapper.Map<Address>(restaurantDto.Address);
            await unitOfWork.SaveAllAsync();
        }

        public async Task UpdateRestaurantStatus(int RestaurantId, RestaurantStatus status, string RequestingUserId)
        {
            var restaurant = await GetRestaurantOrThrowAsync(RestaurantId, RequestingUserId);
            restaurant.Status = status;
            await unitOfWork.SaveAllAsync();

        }
        private async Task<Restaurant> GetRestaurantOrThrowAsync(int RestaurantId, string RequestingUserId)
        {
            var restaurant = await unitOfWork.Restaurants.GetByIDAsync(RestaurantId);
            if (restaurant is null)
                throw new NotFoundException(RestaurantNotfoundMessage);
            var owner = await unitOfWork.Users.GetByIDAsync(RequestingUserId);
            if (owner is null)
                throw new NotFoundException(OwnerNotFoundMessage);
            if (restaurant.OwnerId != RequestingUserId)
                throw new ForbiddenException("No Authorize");
            return restaurant;
        }
        public async Task DeleteRestaurantById(int RestaurantId, string RequestingUserId)
        {
            var restaurant = await GetRestaurantOrThrowAsync(RestaurantId, RequestingUserId);
            restaurant.IsDeleted = true;
            await unitOfWork.SaveAllAsync();
        }

    }
}
