namespace Chat.Data.Models;

public class Captcha
{
    public int CaptchaId { get; set; }
    public string CaptchaString { get; set; }
    public DateTime CreatedAt { get; set; }
}