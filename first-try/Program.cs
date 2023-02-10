using System;
namespace SMKCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama;
            int umur;
            Console.Write("Masukkan Nama : ");
            nama = Console.ReadLine();
            Console.Write("Masukkan Umur : ");
            umur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nama Kamu : " + nama + ", Umur Kamu : " + umur);
        }
    }
}