# 2211COMP106401
Demo công nghệ NET lớp thứ 3

# Buổi 09(01/11/2022) - EF Core - DB First

## Step 0: Chuẩn bị database, thư viện
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```

## Step 1: Gõ lệnh phát sinh entity từ database
PM > ```Scaffold-DbContext "Server=.; Database=MyeStoreK46;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data```

Thêm ```-f``` nếu muốn ghi đè

## Step 2: Cấu hình appsettings.json
```json
  "ConnectionStrings": {
    "MyStore": "Server=.; Database=MyeStoreK46;Integrated Security=True"
  },
```

## Step 3: Đăng ký (Program.cs)
```cs
builder.Services.AddDbContext<MyeStoreK46Context>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MyStore")));
```