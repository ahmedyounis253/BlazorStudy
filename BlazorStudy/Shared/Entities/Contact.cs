namespace BlazorStudy.Shared;

public class Contact:BaseEntity
{
    public ContactType ContactType { get; set; }=ContactType.Mobile;
        
    public string? PhoneNumber { get; set;  }

    public Guid UserId { get; set; }
    
    public User? User { get; set; }  
}
