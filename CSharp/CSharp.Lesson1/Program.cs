namespace CSharp.Lesson1;

class Program
{
    static void Main(string[] args)
    {
        /*
         * có 2 loại kiểu dữ liệu trong C# là value type và reference type
         *
         * struct khác gì với class ?
         * struct trong C nó sinh ra để giả lập cho 1 cái class vì trong C ko có class
         *
         * struct khác gì với class và tại sao nó lại nm ở value type
         *
         * reference là class, object, string, array
         *
         * Câu quan trọng liêu quan đến value type và reference về vùng nhớ
         * Khi mà anh gõ int a = 5;
         * Khi một value type đc khai báo ra thì sẽ có 1 vùng nhớ được sử dụng (Stack - RAM)
         *
         * Anh có 1 class Student
         * sau đó anh new mới Student s = new Student()
         * 2 vùng nhớ Stack và Heap và sau đó vùng nớ stack đó sẽ tham chiếu s tham chiếu đến vùng nhớ đc tạo mới trong heap
         * Khi mã gõ câu lệnh này thì sẽ có 2 vùng nhớ được sử dụng (Stack và Heap)
         * keyword s sẽ tham chiếu sử dụng vùng nhớ Stack
         * và tham chiếu đến object đc tạo trong heap
         * thì làm sao để tham chiếu, nó lưu lại địa chỉ của thằng tạo trong heap
         *
         * Anh có 1 class Student
         * Sau đó anh new mới Student s = new Student()
         * Khi anh sử dụng câu lệnh này thì có 2 vùng nhớ đc sử dụng stack và heap
         * Ngay mã gõ cau lenh này th sẽ có 2 vùn nhớ đc taạo ra
         * Keyword s biến tham chi sẽ sử dụng vùng nhớ stack
         * và tham chiếu đến object vừa đc tạo trogn heap
         * thi lam sao de tham chieu no luu dia chi cau thang tao trong heap
         * => quan trong khi di phong van luon
         * Student s1 = new Student()
         * Student s1 = s2
         * vung nho thi se co 2
         * s1 và s2 đc tao trên stack
         * 1 object Student dc se dc tao tren heap
         * luc nay s1, s2 se cung tham chieu 1 đou tuong trong hepa\
         * những hàm khai bao la static th nó sẽ nam o vung nho rienh va ton tai suot vong doi cua app chuong trinh
         * 1 thứ phục vụ cho cái quá trình code. Đó là in ra màn hình
         */
        //traditional style
        // int a = 5;
        // int b = 10;
        // Console.WriteLine("Number a = " + a);
        // Console.WriteLine("Number b = " + b);
        // Console.WriteLine("Number a + b  = " + (a + b));
        
        //// Modern Style - PlaceHolder: thay thế
        // Console.WriteLine("Number a = {0}", a );
        // Console.WriteLine("Number b = {0}", b);
        // Console.WriteLine("Number {0},  {1}", a, b);
        
        
        // Modern Style - Interpolation: nội suy, suy ra từ A với B 
        // Console.WriteLine($"Number a = {a}, b = {b}", a, b);
        // Console.WriteLine($"Number {a} + {b}  = {a + b}", a, b);
        
        //implicit declaration
        // var i = 12.4;
        // Console.WriteLine(i);
        // Console.WriteLine(i.GetType());
        
        //function có 2 dạng là pass by value, va reference(ref va out)

        // static void InSoRaManHinh(int a)
        // {
        //     Console.WriteLine($"Pass by value - Number a = {a}", a);
        // }
        //
        // InSoRaManHinh(12);
        //
        //giờ mình học xài reference function
        //ref và out
        //ref thì nó lưu vào biến con trỏ, bên trong có thể thay đối giá trị của bên ngoài

        // int m = 3;
        //
        // static void PassByReference(ref int a)
        // {
        //     a = 36; //a là mặt nạ của m
        // }
        // //hay nói cách khác thì a chính là m 
        //
        // Console.WriteLine("Before Number m = " + m);
        // PassByReference(ref m);
        // Console.WriteLine("After Number m = " + m);
        
        // phải học kĩ ref và out mới đọc đc tài liệu cảu .net
        // ref là bình thường thôi, out nè
        
        /*
         *Khi chơi voi out bat buoc phai sua lai bien tham so, do lai value cho tham so
         * out nay co nghia la tao hua se tra out cho may mot gia tri
         * out nay kho can phai khai bao bien ben ngoai, chuyen vo luon
         * 
         */
        static void PassByReference(out int b)
        {
            b = 36;
            Console.WriteLine("PassByReference - Result: " + b);            
        }

        static void SumInt(int a, out int result)
        {
            result = 0;
            for (int i = 0; i <= a; i++)
            {
                result += i;
            }
            //đéo cần return luôn tại vì mình  có out rồi
        }
        
        SumInt(3, out int result);
        //không có result nhưng mà mình vẫn log đc result ra nha
        Console.WriteLine(result);
    }
}