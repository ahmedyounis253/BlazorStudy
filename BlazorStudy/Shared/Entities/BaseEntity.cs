namespace BlazorStudy.Shared;

public  class BaseEntity
{
    public Guid Id { get; set; }

    public DateTime? CreationTime { get;  set;}
    
    public DateTime? LastUpdateTime { get; set; }

}
