using Tipe_Laptop;
using Tipe_Processor;
using Tipe_Vga;

Laptop laptop1 = new Laptop();
laptop1 = new Vivobook();
laptop1.vga = new Nvidia();
laptop1.processor = new CoreI5();

Laptop laptop2 = new Laptop();
laptop2 = new IdeaPad();
laptop2.vga = new Tipe_Vga.AMD();
laptop2.processor = new Ryzen();

Predator predator = new Predator();
predator.vga = new Tipe_Vga.AMD();
predator.processor = new CoreI7();

Console.WriteLine("1. Jalankan method LaptopDinyalakan() dan LaptopDimatikan() pada laptop2");
laptop2.LaptopDinyalakan();
laptop2.LaptopDimatikan();

Console.WriteLine("\n2. Jalankan method Ngoding() pada laptop1");
//laptop1.Ngoding();
Console.WriteLine("Yuhuuu tidak bisa");

Console.WriteLine("\n3. Dapatkah Anda menampilkan di console spesifikasi (merk vga, merk processor, tipe processor)");
Console.WriteLine("apa yang digunakan laptop1?");
Console.WriteLine("Bisa");
Console.WriteLine(laptop1.vga.merk);
Console.WriteLine(laptop1.processor.merk);
Console.WriteLine(laptop1.processor.tipe);

Console.WriteLine("\n4. Jalankan method BermainGame() pada predator");
predator.BermainGame();

Console.WriteLine("\n5. Buatlah sebuah variabel acer bertipe data ACER, kemudian masukkan objek Predator sebagai nilainya");
Console.WriteLine("Jalankan method BermainGame() pada acer");
ACER acer = new ACER();
acer = new Predator();
//acer.BermainGame();
Console.WriteLine("Yuhuuu tidak bisa");

namespace Tipe_Processor
{
    public class Processor
    {
        public string merk, tipe;
        public Intel intel;
        public CoreI3 corei3;
        public CoreI5 corei5;
        public CoreI7 corei7;
        public AMD amd;
        public Ryzen ryzen;
        public Athlon athlon;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }
    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "Core i3";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core i5";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "Core i7";
        }
    }
    public class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "RAYZEN";
        }
    }
    public class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
}
namespace Tipe_Vga
{
    public class Vga
    {
        public string merk;
        public Nvidia nvidia;
        public AMD amd;
    }
    public class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }
    public class AMD : Vga
    {
        public AMD()
        {
            merk = "AMD";
        } 
    }
}
namespace Tipe_Laptop
{
    using Tipe_Processor;
    using Tipe_Vga;
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;
        public ASUS asus;
        public ROG rog;
        public Vivobook vivobook;
        public ACER acer;
        public Swift swift;
        public Predator predator;
        public Lenovo lenovo;
        public IdeaPad ideapad;
        public Legion legion;
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    class ASUS : Laptop
    {
        public ASUS()
        {
            merk = "ASUS";
        }
    }
    class ROG : ASUS
    {
        public ROG()
        {
            tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class ACER : Laptop
    {
        public ACER()
        {
            merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            merk = "Lenovo";
        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }
}