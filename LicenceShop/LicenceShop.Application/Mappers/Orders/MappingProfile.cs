using AutoMapper;
using LicenceShop.Application.Common.Dto;
using LicenceShop.Application.Common.Dto.Order;

namespace LicenceShop.Application.Mappers.Orders;

public class MappingProfile : Profile
{
    
    public MappingProfile()
    {
        CreateMap<UpdateOrderDto, Domain.Entities.Order>().ReverseMap();
        CreateMap<Domain.Entities.Order, Task<OrderDetailsDto>>().ConstructUsing(x => GetOrderDetails(x));
        CreateMap<IEnumerable<Domain.Entities.Order>, OrderPageableDto>().ConstructUsing(x => GetOrderPageableList(x));


    }

    private static async Task<OrderDetailsDto> GetOrderDetails(Domain.Entities.Order order)
    {
        return
            new OrderDetailsDto
            (
             order.OrderCode,
             order.Customer.UserName,
             order.TotalPrice, 
             order.Status,
             new OrderInfoDto(
                 order.Customer.Licences.Select(x => x.Name), 
                 order.Licences.Select(x => x.Owner.Email)
                 )
             );
    }
    
    
    
    private static OrderPageableDto GetOrderPageableList (IEnumerable<Domain.Entities.Order> order)
    {
        var orderList = order.Select(x =>  GetOrderDetails(x).Result).ToList();
        return new OrderPageableDto(orderList, new PaginationDto(0, 0));
    }
    
}