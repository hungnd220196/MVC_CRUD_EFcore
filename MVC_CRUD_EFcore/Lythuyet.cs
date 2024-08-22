namespace MVC_CRUD_EFcore
{
    public class Lythuyet
    {
        /*
        - Cài đặt DbContext trong mô hình Code First của Entity Framework (EF) là bước quan trọng trong quá trình phát triển ứng dụng với cơ sở dữ liệu. 
        DbContext là trung tâm quản lý dữ liệu, thực hiện việc truy vấn và lưu trữ các đối tượng trong cơ sở dữ liệu.
        
        - Migration trong Entity Framework (EF) là một tính năng cho phép bạn cập nhật cấu trúc cơ sở dữ liệu khi mô hình dữ liệu trong code của bạn thay đổi. 
        Migration giúp duy trì đồng bộ giữa mô hình dữ liệu trong code và cơ sở dữ liệu, quản lý các thay đổi mà không cần phải xóa và tạo lại cơ sở dữ liệu mỗi khi có sự thay đổi trong model.
         

        - Partial View trong ASP.NET Core là một khái niệm dùng để chia nhỏ giao diện thành các phần tái sử dụng được. Thay vì viết mã giao diện cho các thành phần giao diện nhiều lần, bạn có thể tách chúng ra thành các partial view và sử dụng lại ở nhiều nơi trong ứng dụng.

        Khi nào sử dụng Partial View?
        Tái sử dụng giao diện: Khi bạn có một phần giao diện cần sử dụng lại nhiều lần, như các thành phần header, footer, sidebar, form đăng nhập, hoặc một danh sách các mục.
        Chia nhỏ giao diện phức tạp: Giúp quản lý và bảo trì mã giao diện dễ dàng hơn khi giao diện chính quá phức tạp.
        Tải một phần trang: Trong các tình huống AJAX, bạn có thể tải một phần trang mà không cần phải reload toàn bộ trang.

        Tạo Partial View
        Tạo một Partial View: Một partial view có thể được tạo bằng cách thêm một file .cshtml mới vào thư mục Views.

        Để tạo một partial view, bạn chỉ cần thêm một file .cshtml và đặt tên cho nó với tiền tố _ để dễ nhận biết. Ví dụ: _ProductList.cshtml.
        Chứa mã giao diện tái sử dụng: Mã trong partial view này chỉ chứa các phần giao diện mà bạn muốn tái sử dụng.


        - View Component trong ASP.NET Core là một tính năng mạnh mẽ cho phép bạn tái sử dụng các thành phần giao diện phức tạp một cách dễ dàng. 
          View Component tương tự như Partial View, nhưng nó mạnh mẽ hơn vì có thể chứa logic phức tạp, hỗ trợ Dependency Injection và trả về nội dung HTML một cách độc lập.
         
         + Sự khác biệt giữa View Component và Partial View:
           Logic xử lý: View Component hỗ trợ logic phức tạp hơn và cho phép sử dụng Dependency Injection, trong khi Partial View chỉ đơn thuần là phần giao diện.
           Khả năng tái sử dụng: View Component có thể được tái sử dụng một cách mạnh mẽ và độc lập với các View khác.
           Tính chất độc lập: View Component không phụ thuộc vào Model của View chứa nó, trong khi Partial View thường phụ thuộc vào Model của View mà nó được sử dụng.
        

         - Tag Helper trong ASP.NET Core là một tính năng mạnh mẽ cho phép bạn sử dụng các cú pháp HTML đơn giản và trực quan để làm việc với dữ liệu trong Razor views. Tag Helper giúp tăng cường HTML với các thuộc tính tùy chỉnh và làm cho mã Razor dễ đọc, dễ duy trì hơn bằng cách tận dụng sức mạnh của cả HTML và C#.

           + Khi nào sử dụng Tag Helper?
           Tích hợp với HTML một cách tự nhiên: Khi bạn muốn sử dụng các thẻ HTML quen thuộc kết hợp với các thuộc tính mạnh mẽ của C#.
           Tăng cường các phần tử HTML: Khi bạn muốn mở rộng các thẻ HTML chuẩn để tương tác với các tính năng trong ASP.NET Core, như form, liên kết, hiển thị dữ liệu, xác thực...
           Tái sử dụng logic: Khi bạn cần áp dụng cùng một logic cho nhiều phần tử HTML trong ứng dụng.
           
           + Các Tag Helper phổ biến
           ASP.NET Core cung cấp một số Tag Helper tích hợp sẵn để xử lý các tác vụ thường gặp:

           1.Anchor Tag Helper (<a>):

           Giúp bạn tạo ra các liên kết URL động bằng cách sử dụng các thuộc tính asp-controller, asp-action, asp-route, v.v.
            
           2.Form Tag Helper (<form>):
           Hỗ trợ xây dựng các form với các thuộc tính asp-action, asp-controller, asp-route, v.v.

           3.Input Tag Helper (<input>, <textarea>, <select>): asp-for

           4. Validation Tag Helper (<span>, <div>): asp-validation-for

         
         */
    }
}
