# CtTinhTong
Mô hình 3tier hay còn gọi là mô hình 3 layer
Mô hình này có 3 lớp chính bao gồm:
1. Presentation Layer (GUI)
   Lớp này có nhiệm vụ tương tác với người dùng thông qua giao diện, thu thập thông tin, xác thực tính đúng đắn của dữ liệu trước khi đưa qua lớp BLL
2. Business Logic Layer (BLL)
   - Tiếp nhận các yêu cầu và xử lý dữ liệu từ lớp GUI trước khi truyền xuống lớp DAL
   - Kiểm tra các ràng buộc và tính hợp lệ của dữ liệu, xử lý các yêu cầu trước khi trả kết quả về lớp GUI
4. Data Access Layer (DAL)
   Lớp này có nhiệm vụ truy cập vào csdl và thực hiện các nhiệm vụ truy vấn dữ liệu như xuất, nhập, chỉnh sửa dữ liệu

