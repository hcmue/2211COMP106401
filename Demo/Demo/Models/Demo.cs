namespace Demo.Models
{
    public class DemoSyncAsync
    {
        public static int A()
        {
            Thread.Sleep(2000);
            return new Random().Next();
        }
        public static string B()
        {
            Thread.Sleep(5000);
            return "HCMUE.NET";
        }
        public static void C()
        {
            Thread.Sleep(3000);
        }

        #region Async
        public static async Task<int> AAsync()
        {
            await Task.Delay(2000);
            return new Random().Next();
        }
        public static async Task<string> BAsync()
        {
            await Task.Delay(5000);
            return "HCMUE.NET";
        }
        public static async Task CAsync()
        {
            await Task.Delay(3000);
        }
        #endregion
    }
}
