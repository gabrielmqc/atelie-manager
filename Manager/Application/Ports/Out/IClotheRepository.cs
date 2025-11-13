using Manager.Domain.Models;

namespace Manager.Application.Ports.Out;

public interface IClotheRepository
{
    Task AddAsync(ClotheBO clothe);
    Task<ClotheBO?> GetByIdAsync(Guid id);
    Task<IEnumerable<ClotheBO>> GetAllAsync();
}