namespace ButtaLove.ViewModels;

public class ResultMessageViewModel
{
    public string MessageText { get; set; }
    public bool success { get; set; } = false;
    public string? ErrorString { get; set; }
}