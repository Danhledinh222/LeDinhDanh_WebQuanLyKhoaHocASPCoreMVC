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
![Database Diagram](<img width="1530" height="879" alt="AnhDatabase" src="https://github.com/user-attachments/assets/13c9323c-4346-45e1-bca2-28bb05ce6b5f" />
)

### 2. Trang chủ Dashboard
![Trang Chủ](<img width="1919" height="1024" alt="Anhtrangchu" src="https://github.com/user-attachments/assets/3a04a96c-e127-4e39-9f7d-ff217274e242" />
)

### 3. Quản lý Lớp học phần
![Quản lý Lớp](<img width="1919" height="1017" alt="AnhTrangcon" src="https://github.com/user-attachments/assets/ebd84ac9-b466-4825-8242-58fc09d3a3d0" />
)

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
* **Trường:** Đại học Sư phạm Kỹ thuật – Đại học Đà Nẵng
