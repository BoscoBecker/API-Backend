namespace WebApplication1.Models.Entities;

public class TransferEntity
{
    public Guid IdTransfer { get; set; }
    
    public int SenderId { get; set; }
    public WalletEntity Sender { get; set; }

    public int ReceiverId { get; set; }
    public WalletEntity Receiver { get; set; }

    public decimal Valor { get; set; }
    
    public TransferEntity(Guid idTransfer, int senderId, WalletEntity sender, int receiverId, WalletEntity receiver, decimal valor)
    {
        IdTransfer = idTransfer;
        SenderId = senderId;
        Sender = sender;
        ReceiverId = receiverId;
        Receiver = receiver;
        Valor = valor;
    }
    


}