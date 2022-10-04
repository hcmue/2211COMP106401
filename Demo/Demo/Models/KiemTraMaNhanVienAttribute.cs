using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class KiemTraMaNhanVienAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;
            var dsMaDaCo = new string[] { 
                "1111", "7777", "admin", "member"
            };
            return !dsMaDaCo.Contains(value.ToString());
        }
    }
}