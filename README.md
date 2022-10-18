# 2211COMP106401
Demo công nghệ NET lớp thứ 3

# Buổi 07 (18/10/2022)
* Area
	* Cách tạo: Right Click chọn New Scaffolded Item --> MVC Area --> đặt tên cho Area
	* Đăng ký route ở Program.cs (trước route default)
	```cs
	app.MapControllerRoute(
		name: "areas",
		pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
	);
	```
	* Tạo đại 1 cái area, ví dụ Admin
	* Tạo 1 controller, nhớ thêm property [Area("areaName")]
	* Nhớ tạo các file _ViewImport.cshtml, _ViewStart.cshtml trong thư mục Views của area đó.

* Repository Pattern
	* Là gì? Tầng DataAccess Layer che giấu việc thao tác data ở tầng business (ở action)
	* Tạo 1 cặp interface ICategoryReposirory và class MemoryCategoryReposirory
	* Đăng ký DI ở Program.cs:
	```cs
	builder.Services.AddScoped<ICategoryRepository, MemoryCategoryRepository>();
	```
	* Chỗ nào sử dụng thì Inject ở hàm tạo