using AutoMapper;
using dutch_retreat.ModelViews;
using DutchTreat.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dutch_retreat.Data
{
    public class DutchMappingProfile : Profile
    {
        public DutchMappingProfile()
        {
            CreateMap<Order, OrderModelView>()
                .ForMember(o => o.OrderId, ex => ex.MapFrom(o => o.Id))
                .ReverseMap();
            CreateMap<OrderItem, OrderItemModelView>()
                .ReverseMap();
            CreateMap<Product, ProductModelView>()
                .ReverseMap();
        }
    }
}
