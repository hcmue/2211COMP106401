namespace Demo.Models
{
    public static class MyExtension
    {
        public static int SoNgauNhien(this int number)
        {
            return new Random().Next(1, number);
        }

        public static int DemSoNgay(this DateTime start, DateTime stop)
        {
            return Math.Abs((stop - start).Days);
        }
    }
}
