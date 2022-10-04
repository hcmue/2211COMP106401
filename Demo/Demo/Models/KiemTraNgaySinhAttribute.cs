using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class KiemTraNgaySinhAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            try
            {
                var ngaySinh = (DateTime)value;
                if (DateTime.Now.Year - ngaySinh.Year < 18)
                {
                    return new ValidationResult("Chưa đủ 18 tuổi");
                }
                return ValidationResult.Success;
            }
            catch
            {
                return new ValidationResult("Ngày sinh không hợp lệ");
            }
        }
    }
}