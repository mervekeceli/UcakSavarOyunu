using System;
using Savas.Library.Enum;

namespace Savas.Library.Interface
{
    internal interface IOyun
    {
        event EventHandler GecenSureDegisti;

        bool DevamEdiyorMu { get; }
        bool DuraklatildiMi { get; }
        TimeSpan GecenSure { get; }

        void Baslat();
        void AtesEt();
        void Duraklat();
        void DevamEttir();
        void UcaksavariHareketEttir(Yon yon);
    }
}
