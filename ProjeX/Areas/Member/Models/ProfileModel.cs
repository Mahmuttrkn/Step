using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjeX.Areas.Member.Models
{
    public class ProfileModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phonenumber { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }
        public IFormFile image { get; set; }
    }
}


//profil kısmı için öncelikle signup kısmında eksik yerlerimiz var oraları tanımlayacaz mesela profil bilgisi gibi sonradan kullanıcı bunları düzeltebilir zaten. o yüzden önce miggration yapacaz aspnetusers tablosuna profile html e bak oraya göre tanımla