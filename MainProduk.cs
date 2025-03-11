using System;
using MOD_4;

class MainKodePos
{
    static void Main()
    {
        Console.Write("Masukkan nama barang: ");
        string produk = Console.ReadLine();
        Console.WriteLine($" Barang {produk}, Kode Produk : {KodeProduk.GetKodeProduk(produk)}");

        Console.WriteLine("\n---\n");
    }
}