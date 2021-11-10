using System;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using Flight.Dto.AirPlanNameDto;
using Flight.Dto.City;
using Flight.Dto.CompanyAirLine;
using Flight.Dto.Flight;
using Flight.Dto.Inventory;
using Flight.Dto.Order;
using Flight.Entity.Domain;


namespace Flight.Mapping
{
    public static class Extensions
    {
        public static string ToPersianDate(this DateTime input)
        {
            var pc = new System.Globalization.PersianCalendar();
            return
                $"{pc.GetYear(input)}/{pc.GetMonth(input)}/{pc.GetDayOfMonth(input)} {pc.GetHour(input)}:{pc.GetMinute(input)}";
        }
    }
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {

            CreateMap<CreateCity, City>();
            CreateMap<City, CityViewModel>();


            CreateMap<CreateAirName, Airplane>();
            CreateMap<Airplane, AirPlanNameViewModel>();


            CreateMap<CreateCompany, AirLine>();
            CreateMap<AirLine, CompanyViewModel>();


            CreateMap<CreateFlight, Entity.Domain.Flight>();
            //CreateMap<Entity.Domain.Flight, FlightViewModel>();

            CreateMap<CreateInventory, Inventory>();

            CreateMap<OrderDto, Order>();

            CreateMap<Entity.Domain.Flight, FlightOutputDto>()
                .ForMember(dto => dto.DestinationName, e => e.MapFrom(x => x.Destination.Name))
                .ForMember(dto => dto.SourceName, e => e.MapFrom(x => x.Source.Name))
                .ForMember(dto => dto.FlightDate, e => e.MapFrom(x => x.FlightDate.ToPersianDate()))
                ;
        }
    }
}
