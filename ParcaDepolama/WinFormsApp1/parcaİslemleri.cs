using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class parcaİslemleri
    {
        public List<parcaDeposu> parcalar = new List<parcaDeposu>();

        public void yeniParcaEkle(parcaDeposu parca)
        {
            parcalar.Add(parca);
        }

        public void parcaGuncelle(int secilen, parcaDeposu guncelParca)
        {
            parcalar[secilen] = guncelParca;
        }

        public void parcaSil(int secilen)
        {
            parcalar.RemoveAt(secilen);
        }
    }
}
