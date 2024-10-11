using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayers.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMappinConfig: Profile
    {
        public AutoMappinConfig()
        {
            CreateMap<RoomAddDto, Room>(); //MAPLEME VE TERS MAPLEME
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap(); // Aynı mapi tersle "ReverseMap"

        }
    }
}
