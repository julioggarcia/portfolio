public class ContactService
{
  private readonly IConfiguration _config;
  public ContactService(IConfiguration config)
  {
    _config = config;
  }

  public string GetEmail() => _config["Contact:Email"] ?? "";
}