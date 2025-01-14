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