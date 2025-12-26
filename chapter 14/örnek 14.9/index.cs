using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StationeryHubApp
{
    public partial class MainForm : Form
    {
        // Sabitler
        private const decimal DiscountRate = 0.05M; // %5
        private const decimal TaxRate = 0.15M;      // %15
        private const decimal DiscountThreshold = 500.00M;

        // Ürün fiyatlarını tutan bir yapı
        private Dictionary<CheckBox, TextBox> itemControls;
        private Dictionary<CheckBox, decimal> itemPrices;

        public MainForm()
        {
            InitializeComponent();
            InitializeStationeryData();
        }

        private void InitializeStationeryData()
        {
            // Kontrolleri eşleştiriyoruz (Örn: chkPen seçiliyse txtQtyPen aktif olur)
            itemControls = new Dictionary<CheckBox, TextBox>
            {
                { chkPen, txtQtyPen },
                { chkNotebook, txtQtyNotebook },
                { chkPaper, txtQtyPaper },
                { chkStapler, txtQtyStapler }
            };

            // Birim fiyatlar
            itemPrices = new Dictionary<CheckBox, decimal>
            {
                { chkPen, 2.50M },
                { chkNotebook, 15.00M },
                { chkPaper, 45.00M },
                { chkStapler, 30.00M }
            };

            // Başlangıç ayarları
            foreach (var entry in itemControls)
            {
                entry.Value.Enabled = false; // Checkbox seçilmeden miktar girilemez
                entry.Value.Text = "0";
                
                // Eventleri bağla
                entry.Key.CheckedChanged += (s, e) => {
                    entry.Value.Enabled = entry.Key.Checked;
                    if (!entry.Key.Checked) entry.Value.Text = "0";
                    CalculateInvoice();
                };
                
                entry.Value.TextChanged += (s, e) => CalculateInvoice();
            }
        }

        private void CalculateInvoice()
        {
            decimal subtotal = 0;

            foreach (var item in itemControls)
            {
                if (item.Key.Checked && decimal.TryParse(item.Value.Text, out decimal qty))
                {
                    subtotal += qty * itemPrices[item.Key];
                }
            }

            // İndirim Hesabı (%5 if > $500)
            decimal discount = (subtotal > DiscountThreshold) ? subtotal * DiscountRate : 0;
            decimal totalAfterDiscount = subtotal - discount;

            // Vergi Hesabı (%15)
            decimal tax = totalAfterDiscount * TaxRate;
            decimal amountDue = totalAfterDiscount + tax;

            // Etiketleri Güncelle
            lblSubtotal.Text = $"Ara Toplam: {subtotal:C}";
            lblDiscount.Text = $"İndirim: {discount:C}";
            lblTax.Text = $"Vergi: {tax:C}";
            lblTotal.Text = $"Ödenecek Tutar: {amountDue:C}";
        }

        // Reset Butonu
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInvoiceNum.Text = "Fatura No Giriniz...";
            txtOrderNum.Text = "Sipariş No Giriniz...";
            txtCustomerName.Text = "Müşteri Adı...";
            txtAddress.Text = "Ofis Adresi...";

            foreach (var item in itemControls)
            {
                item.Key.Checked = false;
                item.Value.Text = "0";
                item.Value.Enabled = false;
            }
            CalculateInvoice();
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
//Ali Akbaş tarafından yapılmıştır. 2024481058//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058