/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020 - 2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: B20120071
**				ÖĞRENCİ ADI............: AHMET
**				ÖĞRENCİ SOYADI.........: KEŞAB
**              DERSİN ALINDIĞI GRUP...: 1-A
****************************************************************************/
using System;
using System.Windows.Forms;
using Savas.Library.Concrete;
using Savas.Library.Enum;

namespace Savas.Desktop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;

        public AnaForm()
        {
            InitializeComponent();

            _oyun = new Oyun(ucaksavarPanel, savasAlaniPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UcaksavariHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UcaksavariHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
                case Keys.D:
                    _oyun.Duraklat();
                    break;
                case Keys.S:
                    _oyun.DevamEttir();
                    break;
            }
        }

        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }

        private void savasAlaniPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
