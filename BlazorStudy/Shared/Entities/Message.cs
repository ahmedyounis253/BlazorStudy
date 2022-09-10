namespace BlazorStudy.Shared;

public  class Message:BaseEntity
{
    public string MessageText { get; set; }

    public Guid FromUserId { get; set; }

    public User FromUser { get; set; }
   
    public Guid ToUserId { get; set; }

    public User ToUser { get; set; }

}
