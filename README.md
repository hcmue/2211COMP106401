# 2211COMP106401
Demo công nghệ NET lớp thứ 3


# Buổi 08 (25/10/2022): EF Core Code First
* Bước 1: Cài đặt thư viện
```cs
Tools > NuGet Package Manager > Package Manager Console

Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
```
* Bước 2: Tạo các entity model
	* Tạo các class sử dụng các thuộc tính validation
	* Khóa chính thì thêm ```[Key]```
	* Khóa ngoại thì thêm ```[ForeignKey("<ten_cot_khoa_ngoai>")]```

* Bước 3: Định nghĩa DbContext
	* Hàm tạo
	```cs
	public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
    {
    }
	```
	* Định nghĩa DbSet (thì mới tạo table)
	```cs
	public DbSet<Loai>? Loais { get; set; }
	```
* Bước 4: Tạo chuỗi kết nối ở appsettings.json
	```cs
	 "ConnectionStrings": {
		"MyDatabase": "Server=.; Database=K46COMP106401; Integrated Security=True"
	},
	```
* Bước 5: Vào trang ```Program.cs``` đăng ký dịch vụ DbContext
	```cs
	builder.Services.AddDbContext<MyDbContext>(options => {
		options.UseSqlServer(builder.Configuration.GetConnectionString("MyDatabase"));
	});
	```

* Bước 6: Mở Packages Manager Console
	* PM > ```Add-Migration mogration_name```
	* PM > ```Update-Database```