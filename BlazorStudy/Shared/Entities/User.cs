namespace BlazorStudy.Shared;


public  class User:BaseSettingEntity
{
    public string EmailAddress {get; set;}

    public string Password {get; set;}

    public string? About {get; set;}

    public bool IsDarkMode { get; set; }

    public DateTime BirthDate { get; set;}

    public bool IsActive { get; set; }

    public string? ChatTheme { get; set; }
}
