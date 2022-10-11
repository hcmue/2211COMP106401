using System.Text;

namespace Demo.Models
{
    public class MyTools
    {
        public static string LayMaBaoMat(int doDai = 5)
        {
            var sb = new StringBuilder();
            var rd = new Random();
            var pattern = @"qazwsxedcrfvtgbyhnujmik,olp[]{}()1234567890!~@#$%^&*";
            for (int i = 0; i < doDai; i++)
            {
                sb.Append(pattern[rd.Next(pattern.Length)]);
            }
            return sb.ToString();
        }
    }
}
