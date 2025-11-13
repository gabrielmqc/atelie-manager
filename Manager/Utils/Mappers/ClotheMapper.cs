using Manager.Adapters.Outbound.Entities;
using Manager.Adapters.Outbound.Enums;
using Manager.Domain.Enums;
using Manager.Domain.Models;


namespace Manager.Utils.Mappers;

public class ClotheMapper
{
    public ClotheEntity ToEntity(ClotheBO clotheBo)
    {
        return new ClotheEntity(
                clotheBo.Id, clotheBo.CreatedAt, clotheBo.UpdatedAt, clotheBo.Type, clotheBo.Size, clotheBo.Color,
                clotheBo.Availability, clotheBo.ImageUrl, clotheBo.Price,
                Enum.Parse<ClotheStatusEntity>(clotheBo.Status.ToString()))
            ;
    }

    public ClotheBO ToBo(ClotheEntity entity)
    {
        return new ClotheBO(
            entity.Id, entity.CreatedAt, entity.UpdatedAt, entity.Type, entity.Size, entity.Color, entity.Availability,
            entity.ImageUrl, entity.Price, Enum.Parse<ClotheStatus>(entity.Status.ToString()));
    }
    
    public IEnumerable<ClotheBO> ToBoList(IEnumerable<ClotheEntity> entities)
    {
        return entities.Select(ToBo);
    }
}