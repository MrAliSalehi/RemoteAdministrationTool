namespace RemoteAdministrationTool.Admin.Classes.Extensions
{
    public static class Extensions
    {
        public static bool IsWithin(this int value, int minimum, int maximum)
        {
            return value >= minimum && value <= maximum;
        }
    }
}