using Manager.Domain.Enums;

namespace Manager.Domain.Models;

public class ReservationBO:AbstractEntityVO<long?>
{
    public ReservationBO(long? id, DateTime createdAt, DateTime updatedAt, 
        ClientBO client, ClotheBO clothe, DateTime startDate, DateTime endDate, ReservationStatus status)
        : base(id, createdAt, updatedAt)
    {
        Client = client;
        Clothe = clothe;
        StartDate = startDate;
        EndDate = endDate;
        Status = status;
    }

    public ClientBO Client { get; private set; }
    public ClotheBO Clothe { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public ReservationStatus Status { get; private set; }

    public void Cancel()
    {
        Status = ReservationStatus.Canceled;
        UpdatedAtNow();
    }
}