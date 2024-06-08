namespace Common
{
    static class CommonDef
    {
        public static bool _isOpen = false;

        public static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://test-blazor-web-app-001.azurewebsites.net/"),
        };
    }
}