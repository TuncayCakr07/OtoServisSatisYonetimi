﻿

using System;

namespace OtoServisSatis.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string EMail { get; set; }

        public string Telefon { get; set; }

        public string KullaniciAdi { get; set; }

        public string Sifre { get; set; }

        public bool Durum { get; set; }

        public DateTime KayitTarihi { get; set; }

        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
