using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OtobüsTakip
{
    public static class Data
    {
        public static DataTable table_yolcu;
        public static DataTable DataTable_Yolcular()
        {
            table_yolcu = new DataTable("Yolcular");
            table_yolcu.Columns.Add(new DataColumn("ID", typeof(int)));
            table_yolcu.Columns.Add(new DataColumn("Koltuk_No", typeof(int)));
            table_yolcu.Columns.Add(new DataColumn("Durum", typeof(int))); 
            table_yolcu.Columns.Add(new DataColumn("Ad_Soyad", typeof(string)));
            table_yolcu.Columns.Add(new DataColumn("Cinsiyet", typeof(string)));
            table_yolcu.Columns.Add(new DataColumn("Islem_Tarih", typeof(DateTime)));
            table_yolcu.Columns.Add(new DataColumn("Islem_Yapan", typeof(string)));
            table_yolcu.Columns.Add(new DataColumn("Otobus_Plaka", typeof(string)));

            return table_yolcu;
        }

        public static void DataTable_Yolcular_Insert(int koltuk_no, int durum, string ad_soyad, string cinsiyet, DateTime tarih, string gorevli, string plaka)
        {
            int recno = 0;
            try
            {
                recno = table_yolcu.Rows.Count + 1;
            }
            catch (NullReferenceException)
            {
                recno = 1;
            }
            table_yolcu.Rows.Add(recno, koltuk_no, durum, ad_soyad, cinsiyet, tarih, gorevli, plaka);
        }


        public static DataTable table_otobus;
        public static DataTable DataTable_Otobus()
        {
            int recno = 0;
            try
            {
                recno = table_otobus.Rows.Count + 1;
            }
            catch (NullReferenceException)
            {
                recno = 1;
            }

            table_otobus = new DataTable("Otobüsler");
            table_otobus.Columns.Add(new DataColumn("ID", typeof(int)));
            table_otobus.Columns.Add(new DataColumn("Plaka", typeof(string)));
            table_otobus.Columns.Add(new DataColumn("Koltuk_Adet", typeof(int))); 

            table_otobus.Rows.Add(recno, "35 MZ 35", 47);
            table_otobus.Rows.Add(recno, "35 MZ 36", 47);
            table_otobus.Rows.Add(recno, "35 MZ 37", 47);
            table_otobus.Rows.Add(recno, "35 MZ 38", 47);



            return table_yolcu;
        }
    }
}
