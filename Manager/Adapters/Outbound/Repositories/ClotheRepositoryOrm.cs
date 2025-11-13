using Manager.Adapters.Outbound.Entities;
using Manager.Application.Ports.Out;
using Manager.Domain.Models;
using Manager.Infrastructure.Persistence.Context;
using Manager.Utils.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Manager.Adapters.Outbound.Repositories;

public class ClotheRepositoryOrm : IClotheRepository
{
    private readonly AppDbContext _context;
    private readonly ClotheMapper _clotheMapper;

    public ClotheRepositoryOrm(AppDbContext context)
    {
        _context = context;
        _clotheMapper = new ClotheMapper();
    }

    public async Task AddAsync(ClotheBO clothe)
    {
        ClotheEntity entity = _clotheMapper.ToEntity(clothe);
        await _context.Clothes.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<ClotheBO?> GetByIdAsync(Guid id)
    {
        ClotheEntity entity = await _context.Clothes.FindAsync(id) ?? throw new InvalidOperationException();

        return _clotheMapper.ToBo(entity);
    }

    public async Task<IEnumerable<ClotheBO>> GetAllAsync()
    {
        IEnumerable<ClotheEntity> entities = await _context.Clothes.ToListAsync();
        return _clotheMapper.ToBoList(entities);
    }
}