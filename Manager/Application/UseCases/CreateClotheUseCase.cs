using Manager.Application.Dtos.Request;
using Manager.Application.Ports.In;
using Manager.Application.Ports.Out;
using Manager.Domain.Enums;
using Manager.Domain.Models;

namespace Manager.Application.UseCases;

public class CreateClotheUseCase : ICreateClotheUseCase
{
    private readonly IClotheRepository _clotheRepository;

    public CreateClotheUseCase(IClotheRepository clotheRepository)
    {
        _clotheRepository = clotheRepository;
    }


    public async Task ExecuteAsync(CreateClotheRequest request)
    {
        var clothe = new ClotheBO(null, DateTime.Now, DateTime.Now, request.Type, request.Size, request.Color,
            DateTime.Now, request.ImageUrl, request.Price, ClotheStatus.Free);
        await _clotheRepository.AddAsync(clothe);
    }
}