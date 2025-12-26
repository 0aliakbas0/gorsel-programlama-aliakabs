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

namespace AccountsPayableSystem
{
    // --- ARAYÜZ ---
    public interface IPayable
    {
        decimal GetPaymentAmount(); 
    }

    // --- INVOICE SINIFI ---
    public class Invoice : IPayable
    {
        public string PartNumber { get; }
        public int Quantity { get; }
        public decimal PricePerItem { get; }

        public Invoice(string part, int quantity, decimal price)
        {
            PartNumber = part;
            Quantity = quantity;
            PricePerItem = price;
        }

        public decimal GetPaymentAmount() => Quantity * PricePerItem;

        public override string ToString() => 
            $"Fatura: {PartNumber}\nMiktar: {Quantity}, Birim Fiyat: {PricePerItem:C}";
    }

    // --- ABSTRACT EMPLOYEE SINIFI ---
    public abstract class Employee : IPayable
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Employee(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public abstract decimal GetPaymentAmount(); // IPayable'dan geliyor

        public override string ToString() => $"{FirstName} {LastName}";
    }

    // 1. Salaried Employee
    public class SalariedEmployee : Employee
    {
        public decimal WeeklySalary { get; }
        public SalariedEmployee(string f, string l, decimal s) : base(f, l) => WeeklySalary = s;
        public override decimal GetPaymentAmount() => WeeklySalary;
        public override string ToString() => $"Sabit Maaşlı: {base.ToString()}";
    }

    // 2. Hourly Employee
    public class HourlyEmployee : Employee
    {
        public decimal Wage { get; }
        public double Hours { get; }
        public HourlyEmployee(string f, string l, decimal w, double h) : base(f, l) { Wage = w; Hours = h; }
        public override decimal GetPaymentAmount() => Wage * (decimal)Hours;
        public override string ToString() => $"Saatlik Çalışan: {base.ToString()}";
    }

    // 3. Commission Employee
    public class CommissionEmployee : Employee
    {
        public decimal GrossSales { get; }
        public decimal CommissionRate { get; }
        public CommissionEmployee(string f, string l, decimal s, decimal r) : base(f, l) { GrossSales = s; CommissionRate = r; }
        public override decimal GetPaymentAmount() => GrossSales * CommissionRate;
        public override string ToString() => $"Komisyonlu: {base.ToString()}";
    }

    // 4. Base Plus Commission Employee
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        public decimal BaseSalary { get; set; } // Değiştirilebilir olmalı (+%10 için)
        public BasePlusCommissionEmployee(string f, string l, decimal s, decimal r, decimal b) 
            : base(f, l, s, r) => BaseSalary = b;

        public override decimal GetPaymentAmount() => BaseSalary + base.GetPaymentAmount();
        public override string ToString() => $"Maaş+Komisyonlu: {FirstName} {LastName}";
    }

    // --- TEST UYGULAMASI ---
    class PayableInterfaceTest
    {
        static void Main()
        {
            // Polimorfik IPayable listesi
            List<IPayable> payables = new List<IPayable>
            {
                new Invoice("0123", 3, 50.00M),
                new Invoice("5678", 2, 100.00M),
                new SalariedEmployee("Ali", "Akbaş", 800.00M),
                new HourlyEmployee("Ayşe", "Yılmaz", 20.00M, 40),
                new CommissionEmployee("Mehmet", "Öz", 5000.00M, 0.1M),
                new BasePlusCommissionEmployee("Can", "Demir", 2000.00M, 0.1M, 500.00M)
            };

            Console.WriteLine("Ödemeler İşleniyor...\n");

            foreach (var currentPayable in payables)
            {
                // 1. Nesne bilgilerini yazdır
                Console.WriteLine(currentPayable.ToString());

                // 2. Eğer BasePlusCommissionEmployee ise maaşı %10 artır
                if (currentPayable is BasePlusCommissionEmployee employee)
                {
                    decimal oldSalary = employee.BaseSalary;
                    employee.BaseSalary *= 1.10M; // %10 zam
                    Console.WriteLine($"--> Maaş Artışı Uygulandı! Eski: {oldSalary:C}, Yeni: {employee.BaseSalary:C}");
                }

                // 3. Ödeme tutarını yazdır
                Console.WriteLine($"Ödenecek Tutar: {currentPayable.GetPaymentAmount():C}\n");
            }

            Console.ReadKey();
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