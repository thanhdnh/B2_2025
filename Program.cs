//https://github.com/thanhdnh/B2_2025
public class NhanVien
{
    //public string Ten{get; set;}
    private string ten;
    private float hsl;

    public NhanVien(){
        ten = "Default";
        hsl = 0;
    }
    public NhanVien(string ten, float hsl){
        this.ten = ten;
        this.hsl = hsl;
    }

    public string Ten
    {
        get => ten; set => ten = value;
    }
    public float Hsl
    {
        get => hsl; set => hsl = value;
    }
    public string ShowInfo(){
        return $"NhanVien[Ten: {ten}, HSL: {hsl}]";
    }
}
public class Program{
    public static void Main(string[] args){
        NhanVien nv1 = new NhanVien();
        NhanVien nv2 = new NhanVien("Nguyen A", 2.5f);
        Console.WriteLine(nv1.ShowInfo());
        Console.WriteLine(nv2.ShowInfo());
    }
}

/*  ############ LAB 02 ###############
    Cho một lớp Vector2D gồm 2 dữ liệu thành viên x, y 
    kiểu float đặc trưng cho toạ độ của vector 2 chiều.
    1. Xây dựng lớp Vector2D với các fields nói trên.
    2. Bổ sung getter và setter cho 2 fields nói trên.
    3. Khai báo constructor không tham số và có tham số.
    4. Khai báo phương thức Print() để in ra thông tin
    của vector 2D dưới dạng: Vector2D<x: 1.2, y: 3.4>
    5. Khai báo phương thức kiểm tra 2 vector trực giao.
    6. Khai báo phương thức tính độ dài của vector.
    7. Khai báo phương thức xác định góc (theo radian)
    giữa 2 vector.
    Trong chương trình chính: tạo ra một mảng 
    (List, ArrayList hay bất kì cấu trúc collection 
    nào), sau đó kiểm tra tất cả các hàm chức năng
    từ câu 4 đến câu 7.
*/