//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058

//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
using System;
using System.IO;
using System.Linq;

namespace TelephoneWordGenerator
{
    class Program
    {
        // Tuş takımı eşleşmeleri (0 ve 1 boş bırakılmıştır)
        private static readonly string[] keypad = {
            "",    // 0
            "",    // 1
            "ABC", // 2
            "DEF", // 3
            "GHI", // 4
            "JKL", // 5
            "MNO", // 6
            "PRS", // 7
            "TUV", // 8
            "WXY"  // 9
        };

        static void Main(string[] args)
        {
            Console.Write("Lütfen 7 haneli bir telefon numarası giriniz (0 ve 1 içermemeli): ");
            string phoneNumber = Console.ReadLine();

            // Giriş kontrolü
            if (phoneNumber.Length != 7 || phoneNumber.Any(c => c < '2' || c > '9'))
            {
                Console.WriteLine("Hatalı giriş! Lütfen sadece 2-9 arası rakamlardan oluşan 7 haneli bir numara girin.");
                return;
            }

            string fileName = "combinations.txt";
            
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    GenerateWords(phoneNumber, "", 0, writer);
                }
                Console.WriteLine($"\nBaşarılı! {Math.Pow(3, 7)} kombinasyon '{fileName}' dosyasına yazıldı.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Dosya yazma hatası: " + ex.Message);
            }
        }

        // Özyinelemeli (Recursive) Kelime Oluşturucu
        static void GenerateWords(string number, string currentWord, int index, StreamWriter writer)
        {
            // 7 harfe ulaştığımızda dosyaya yaz
            if (index == 7)
            {
                writer.WriteLine(currentWord);
                return;
            }

            // Mevcut rakamın karşılık geldiği harfleri al
            int digit = int.Parse(number[index].ToString());
            string letters = keypad[digit];

            // Her bir harf için bir alt basamağa dallan
            foreach (char letter in letters)
            {
                GenerateWords(number, currentWord + letter, index + 1, writer);
            }
        }
    }
}
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058