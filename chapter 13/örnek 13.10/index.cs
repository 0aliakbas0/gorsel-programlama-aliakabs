//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
using System;
using System.Collections.Generic;

namespace PayrollSystemWithBonus
{
    // IPayable arayüzü (12.12 ile uyumlu olması için)
    public interface IPayable
    {
        decimal GetPaymentAmount();
    }

    // --- GÜNCELLENMİŞ ABSTRACT EMPLOYEE SINIFI ---
    public abstract class Employee : IPayable
    {
        public string FirstName { get; }
        public string LastName { get; }
        // 12.13 için eklenen özellik
        public DateTime BirthDate { get; } 

        public Employee(string first, string last, DateTime birthDate)
        {
            FirstName = first;
            LastName = last;
            BirthDate = birthDate;
        }

        public abstract decimal GetPaymentAmount();

        public override string ToString() => 
            $"{FirstName} {LastName}\nDoğum Tarihi: {BirthDate:dd/MM/yyyy}";
    }

    // --- TÜRETİLMİŞ SINIFLAR (Örnek olarak SalariedEmployee) ---
    public class SalariedEmployee : Employee
    {
        public decimal WeeklySalary { get; }

        public SalariedEmployee(string f, string l, DateTime bd, decimal s) 
            : base(f, l, bd) => WeeklySalary = s;

        public override decimal GetPaymentAmount() => WeeklySalary;
    }

    // --- TEST UYGULAMASI ---
    class PayrollTest
    {
        static void Main()
        {
            int currentMonth = DateTime.Today.Month; // Mevcut ay

            // Çalışan listesi
            List<Employee> employees = new List<Employee>
            {
                // Doğum günü bu ay olan bir çalışan (Örn: Aralık)
                new SalariedEmployee("Ali", "Akbaş", new DateTime(2005, 12, 15), 1000.00M),
                // Doğum günü başka ay olan bir çalışan
                new SalariedEmployee("Ahmet", "Yılmaz", new DateTime(1995, 5, 20), 1200.00M)
            };

            Console.WriteLine($"Bordro Sistemi - Mevcut Ay: {currentMonth}\n");

            foreach (var emp in employees)
            {
                decimal totalPayment = emp.GetPaymentAmount();
                string bonusMessage = "";

                // 12.13 Mantığı: Doğum günü ayı kontrolü
                if (emp.BirthDate.Month == currentMonth)
                {
                    totalPayment += 100.00M; // 100$ Bonus
                    bonusMessage = " (+100$ Doğum Günü Bonusu Uygulandı!)";
                }

                Console.WriteLine(emp);
                Console.WriteLine($"Ödenecek Tutar: {totalPayment:C}{bonusMessage}\n");
            }

            Console.ReadKey();
        }
    }
}