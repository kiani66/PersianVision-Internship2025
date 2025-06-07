namespace ConsoleApp7
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    // 🟦 Enum
    public enum Role
    {
        Admin,
        Employee
    }
}
