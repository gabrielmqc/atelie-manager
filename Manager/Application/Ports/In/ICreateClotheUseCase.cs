using Manager.Application.Dtos.Request;

namespace Manager.Application.Ports.In;

public interface ICreateClotheUseCase
{
    Task ExecuteAsync(CreateClotheRequest request);

}