# 🎓 Hệ Thống Quản Lý Đào Tạo - ASP.NET Core MVC

Đây là bài tập môn học lập trình C# tại **Trường Đại học Sư phạm Kỹ thuật – Đại học Đà Nẵng**. Ứng dụng được xây dựng theo mô hình **MVC** nhằm quản lý thông tin sinh viên, giảng viên, môn học và quá trình đăng ký học phần.

## 🚀 Công Nghệ Sử Dụng
* **Framework:** ASP.NET Core 9.0 MVC
* **ORM:** Entity Framework Core (Code First)
* **Database:** Microsoft SQL Server
* **Giao diện:** Bootstrap 5, Bootstrap Icons, CSS3
* **Công cụ:** Visual Studio 2022, SQL Server Management Studio (SSMS)

## 📂 Cấu Trúc Cơ Sở Dữ Liệu
Dự án được thiết kế với 5 bảng chính liên kết chặt chẽ:
1.  **Students:** Lưu trữ thông tin cá nhân sinh viên.
2.  **Teachers:** Quản lý thông tin giảng viên và bộ môn.
3.  **Courses:** Danh mục môn học và số tín chỉ.
4.  **CourseClasses:** Lớp học phần (liên kết Môn học - Giảng viên).
5.  **Enrollments:** Bảng trung gian đăng ký lớp (Sinh viên - Lớp học phần) và quản lý điểm số.

## ✨ Tính Năng Chính
* **Dashboard:** Trang chủ quản trị hiện đại, điều hướng nhanh.
* **CRUD Hoàn Chỉnh:** Thêm, Xem, Sửa, Xóa cho tất cả các thực thể trong hệ thống.
* **Validation:** Kiểm tra tính hợp lệ dữ liệu đầu vào (ví dụ: điểm từ 0-10, số tín chỉ từ 1-10).
* **Giao diện Responsive:** Hiển thị tốt trên nhiều thiết bị khác nhau.

## 📸 Hình Ảnh Demo

### 1. Sơ đồ Database (ER Diagram)
![Database Diagram](AnhDatabase.png)

### 2. Trang chủ Dashboard
![Trang Chủ](Anhtrangchu.jpg)

### 3. Quản lý Lớp học phần
![Quản lý Lớp](AnhTrangcon.png)

## 🛠 Hướng Dẫn Cài Đặt
1.  **Clone dự án:**
    ```bash
    git clone [https://github.com/Danhledinh222/LeDinhDanh_WebQuanLyKhoaHocASPCoreMVC.git](https://github.com/Danhledinh222/LeDinhDanh_WebQuanLyKhoaHocASPCoreMVC.git)
    ```
2.  **Cấu hình Connection String:** Mở file `appsettings.json` và thay đổi `Server` thành tên SQL Server của bạn.
3.  **Sinh Database (Migration):** Mở *Package Manager Console* trong Visual Studio và chạy các lệnh:
    ```powershell
    Add-Migration InitialCreate
    Update-Database
    ```
4.  **Chạy ứng dụng:** Nhấn `F5` hoặc nút `Start` trong Visual Studio.

## 👤 Thông Tin Tác Giả
* **Họ và tên:** Lê Đình Danh
* **MSV:** 2415053122308
* **Lớp:** 125DHPC02
* **Trường:** Đại học Sư phạm Kỹ thuật – Đại học Đà Nẵng
