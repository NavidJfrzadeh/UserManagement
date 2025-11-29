namespace App.Core;

public class SiteSettings
{
    public Sqlconfigurations SqlConfigurations { get; set; }
    public int PageSize { get; set; }
    public Logging Logging { get; set; }
    public string AllowedHosts { get; set; }
}

public class Sqlconfigurations
{
    public string ConnectionString { get; set; }
}

public class Logging
{
    public Loglevel LogLevel { get; set; }
}

public class Loglevel
{
    public string Default { get; set; }
    public string MicrosoftAspNetCore { get; set; }
}