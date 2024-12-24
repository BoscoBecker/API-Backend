namespace WebApplication1.Models.Entities;

public class WalletEntity {
    public string FullName { get; set; }
    public string CPFCNPJ { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }
    public decimal CurrentBalance { get; set; }
    public UserType UserType { get; set; }
    
    public WalletEntity(string fullName, string cpfcnpj, string mail, string password, UserType userType, decimal currentBalance = 0 )
    {
        FullName = fullName;
        CPFCNPJ = cpfcnpj;
        Mail = mail;
        Password = password;
        CurrentBalance = currentBalance;
        UserType = userType;
    }



}