using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4452
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan kar1 = new Karyawan("21.11", "Agung", 1000000);
            Karyawan kar2 = new Karyawan("4452", "Hidayat", 2000000);
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", kar1.Nik, kar1.Nama, kar1.Gajibulanan);
            Console.WriteLine("2    {0}/{1}         {2}", kar2.Nik, kar2.Nama, kar2.Gajibulanan);

            Console.WriteLine();
            Console.WriteLine("Asyiiik kenaikan gaji sebesar 10% !!");
            Console.WriteLine();

            kar1.NaikkanGaji(10);
            kar2.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", kar1.Nik, kar1.Nama, kar1.Gajibulanan);
            Console.WriteLine("2    {0}/{1}         {2}", kar2.Nik, kar2.Nama, kar2.Gajibulanan);
        }
    }
}
