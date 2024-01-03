namespace Chat.Data.Models;

public class Statistics
{
    public int StatisticId { get; set; }
    public int TotalMessages { get; set; }
    public float AverageMessagesPerUser { get; set; }
    public float AverageMessagesPerChannel { get; set; }
    public int[] TopUsers { get; set; }
}