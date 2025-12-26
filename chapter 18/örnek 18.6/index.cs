using System;

namespace BubbleSortOptimization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test için bir dizi oluşturalım
            int[] data = { 99, 10, 45, 22, 7, 30, 81, 50, 12, 60 };

            Console.WriteLine("Sıralama Öncesi Dizi:");
            PrintArray(data);

            EnhancedBubbleSort(data);

            Console.WriteLine("\nSıralama Sonrası Dizi:");
            PrintArray(data);
            
            Console.ReadKey();
        }

        static void EnhancedBubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;

            // Dış döngü her bir "geçişi" (pass) temsil eder
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false; // Her geçiş başında swap durumunu sıfırla

                // İç döngü karşılaştırmaları yapar
                // Geliştirme (a): n - 1 - i yaparak zaten yerine yerleşmiş olan 
                // sondaki elemanları tekrar kontrol etmiyoruz.
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Yer değiştirme (Swap) işlemi
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swapped = true; // Bir yer değiştirme yapıldığını işaretle
                    }
                }

                // Geliştirme (b): Eğer bu geçişte hiçbir yer değiştirme yapılmadıysa
                // dizi zaten sıralıdır, döngüden erken çıkabiliriz.
                if (!swapped)
                {
                    Console.WriteLine($"\n{i + 1}. geçişte sıralama tamamlandı (Erken Çıkış).");
                    break;
                }
                
                Console.WriteLine($"{i + 1}. geçiş tamamlandı.");
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
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
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058