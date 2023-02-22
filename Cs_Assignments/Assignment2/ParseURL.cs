namespace Assignment2;

public class ParseURL
{
    public void parseURL(string url)
    {
        string protocol, server, resource;
        string server_resource;
        if(url.Contains("://") == false)
        {
            protocol = "";
            server_resource = url;
        }
        else
        {
            protocol = url.Substring(0, url.IndexOf("://"));
            server_resource = url.Substring(url.IndexOf("://") + 3);
        }

        if (server_resource.Contains("/")){
            string[] spl = server_resource.Split('/');
            server = spl[0];
            resource = spl[1];
        }
        else
        {
            server = server_resource;
            resource = "";
        }

        Console.WriteLine($"Protocol: {protocol}");
        Console.WriteLine($"Server: {server}");
        Console.WriteLine($"Resource: {resource}");


    }
}

