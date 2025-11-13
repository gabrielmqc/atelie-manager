namespace Manager.Domain.Enums;

public enum ReservationStatus
{
    /// <summary>
    /// Reserva criada, aguardando confirmação do ateliê.
    /// </summary>
    Pending,

    /// <summary>
    /// Reserva confirmada pelo ateliê.
    /// </summary>
    Confirmed,

    /// <summary>
    /// A peça está separada e pronta para retirada.
    /// </summary>
    ReadyForPickup,

    /// <summary>
    /// O cliente retirou a peça.
    /// </summary>
    PickedUp,

    /// <summary>
    /// A peça foi devolvida, mas ainda está sendo inspecionada (ex: ajustes ou conferência de danos).
    /// </summary>
    ReturnedPending,

    /// <summary>
    /// A reserva foi concluída (peça devolvida e conferida).
    /// </summary>
    Completed,

    /// <summary>
    /// A reserva foi cancelada antes da retirada.
    /// </summary>
    Canceled,

    /// <summary>
    /// A reserva expirou automaticamente (cliente não compareceu).
    /// </summary>
    Expired
}