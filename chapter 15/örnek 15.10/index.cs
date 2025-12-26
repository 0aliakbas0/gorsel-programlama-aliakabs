//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
//Ali Akbaş tarafından yapılmıştır. 2024481058
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TabPageApp
{
    public partial class MainForm : Form
    {
        // Kontrolleri kolay yönetmek için diziler tanımlıyoruz
        private TextBox[] textBoxes;
        private LinkLabel[] linkLabels;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomLogic();
        }

        private void InitializeCustomLogic()
        {
            // Kontrolleri dizilere atıyoruz (Tasarımdaki isimlere göre)
            textBoxes = new TextBox[] { txtUrl1, txtUrl2, txtUrl3, txtUrl4, txtUrl5, txtUrl6 };
            linkLabels = new LinkLabel[] { lnk1, lnk2, lnk3, lnk4, lnk5, lnk6 };

            // Başlangıç değerleri
            string[] defaultNames = { "Google", "GitHub", "StackOverflow", "Microsoft", "YouTube", "Twitter" };
            string[] defaultUrls = { "https://google.com", "https://github.com", "https://stackoverflow.com", 
                                     "https://microsoft.com", "https://youtube.com", "https://twitter.com" };

            for (int i = 0; i < 6; i++)
            {
                // CheckedListBox'a öğeleri ekle
                checkedListBox1.Items.Add(defaultNames[i]);
                
                // Textbox'lara varsayılan linkleri yaz
                textBoxes[i].Text = defaultUrls[i];
                
                // LinkLabel'ları ayarla
                linkLabels[i].Text = defaultNames[i];
                linkLabels[i].Tag = defaultUrls[i]; // URL'yi Tag içinde saklayalım
                linkLabels[i].Visible = false;      // Başlangıçta gizli
            }
        }

        // 1. TabPage: CheckedListBox seçimi değiştikçe LinkLabel görünürlüğünü ayarla
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // e.Index hangi öğenin tıklandığını verir
            // NewValue öğenin yeni halini (seçili/değil) verir
            linkLabels[e.Index].Visible = (e.NewValue == CheckState.Checked);
        }

        // 2. TabPage: TextBox değiştikçe LinkLabel'ın yönlendireceği adresi güncelle
        private void txtUrls_TextChanged(object sender, EventArgs e)
        {
            TextBox changedBox = sender as TextBox;
            if (changedBox != null)
            {
                // Hangi textbox olduğunu bulup ilgili LinkLabel'ın Tag'ini güncelle
                int index = Array.IndexOf(textBoxes, changedBox);
                if (index != -1)
                {
                    linkLabels[index].Tag = changedBox.Text;
                }
            }
        }

        // 3. TabPage: LinkLabel'a tıklandığında tarayıcıyı aç
        private void linkLabels_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel clickedLabel = sender as LinkLabel;
            if (clickedLabel != null && clickedLabel.Tag != null)
            {
                try
                {
                    string url = clickedLabel.Tag.ToString();
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı URL formatı!");
                }
            }
        }
    }
}