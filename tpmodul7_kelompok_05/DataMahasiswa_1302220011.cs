using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tpmodul7_kelompok_05
{
    class IdentitasMHS
    {
        public NamaMahasiswa nama { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
    }
    class NamaMahasiswa
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    public class DataMahasiswa_1302220011
    {
        public static void ReadJSON()
        {   
            string json = File.ReadAllText("C://JSON//tp7_1_1302220011.json");
            IdentitasMHS mahasiswa = JsonSerializer.Deserialize<IdentitasMHS>(json);

            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
    }
}
