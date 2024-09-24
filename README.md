# Project Kiểm Thử ![Python](https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python&logoColor=white) ![Flask](https://img.shields.io/badge/Flask-000000?style=for-the-badge&logo=flask&logoColor=white) ![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white) ![Selenium](https://img.shields.io/badge/Selenium-43B02A?style=for-the-badge&logo=selenium&logoColor=white) ![NUnit](https://img.shields.io/badge/NUnit-DD0031?style=for-the-badge&logo=nunit&logoColor=white) ![Postman](https://img.shields.io/badge/Postman-FF6C37?style=for-the-badge&logo=postman&logoColor=white)

## 📋 Mô Tả
Dự án này thực hiện kiểm thử chức năng đăng nhập của một ứng dụng web sử dụng **NUnit**, **Selenium WebDriver** và **Postman** cho kiểm thử API. Quy trình bao gồm cài đặt công cụ, tạo các test case, thực hiện kiểm thử tự động và kiểm thử API.

## 🛠️ Công Cụ Sử Dụng
- **Visual Studio 2019**
- **NUnit**
- **Selenium WebDriver**
- **Postman**
- **Python & Flask**

## 🚀 Các Bước Thực Hiện

### 1. Cài Đặt
#### 1.1. Cài đặt NUnit và Selenium WebDriver
- Sử dụng **NuGet Package Manager** trong Visual Studio để cài đặt Selenium.
- Kiểm tra phần **Installed** để đảm bảo đã cài thành công.

#### 1.2. Cài đặt Postman cho kiểm thử API
- Tải Postman từ [đây](https://www.postman.com/downloads/).
- Cài đặt và đăng nhập bằng email trường.

### 2. Kiểm Thử Đơn Vị (Unit Test)
#### 2.1. Tạo Unit Test Project
- Tạo project mới trong Visual Studio chọn **Unit Test Project (.NET Framework)**.

#### 2.2. Tạo Test Case
- Kiểm thử chức năng đăng nhập với các trường hợp: thành công, sai email, sai mật khẩu, và cả hai sai.
- Sử dụng file `.csv` để lưu dữ liệu đầu vào cho từng test case.

#### 2.3. Viết và Chạy Unit Test
- Sử dụng Selenium để tự động hóa việc điền thông tin đăng nhập và kiểm tra kết quả.
- Kết quả kiểm thử được xác minh bằng việc so sánh URL hiện tại với URL mong muốn hoặc kiểm tra thông báo lỗi.

### 3. Kiểm Thử Bằng Selenium WebDriver
- Tạo test case đăng ký tài khoản mới bằng cách sử dụng Selenium.
- Tạo email ngẫu nhiên để tránh trùng lặp và kiểm tra quá trình đăng ký thành công.

### 4. Kiểm Thử API với Postman
#### 4.1. Viết API bằng Python Flask
- Tạo API với các phương thức **GET**, **POST**, **PUT**, **DELETE** để quản lý dữ liệu sản phẩm.
- Lưu trữ dữ liệu trong file `data_77_Chien.json`.

#### 4.2. Kiểm Thử API
- Tạo Collection trong Postman và thêm các request để kiểm thử từng chức năng của API:
  - **GET**: Lấy tất cả dữ liệu.
  - **POST**: Thêm dữ liệu mới.
  - **PUT**: Cập nhật dữ liệu.
  - **DELETE**: Xóa dữ liệu.
- Xác minh kết quả kiểm thử bằng cách kiểm tra dữ liệu trả về và trạng thái phản hồi.

## 🎯 Kết Quả
- **Unit Test**: Các test case đăng nhập được thực hiện thành công với các kết quả phù hợp.
- **Selenium Testing**: Quá trình đăng ký tài khoản mới hoàn tất và kiểm tra thành công.
- **API Testing**: Tất cả các chức năng của API được kiểm thử và xác minh đúng.

## 📚 Hướng Dẫn Sử Dụng
1. **Clone repository** về máy.
2. **Cài đặt các package** cần thiết thông qua NuGet.
3. **Chạy project** trong Visual Studio để thực hiện kiểm thử.
4. **Sử dụng Postman** để kiểm thử các API đã được triển khai.

## 📞 Liên Hệ
- **Nguyễn Chiến**  
- Email: [2151053006chien@ou.edu.vn](mailto:2151053006chien@ou.edu.vn)

---

*Chúc bạn thành công với dự án kiểm thử của mình!*
