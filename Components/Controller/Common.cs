namespace Common
{
    static class CommonDef
    {
        public static bool _isOpen = false;

        public static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("http://localhost:5291"),
        };
    }
}