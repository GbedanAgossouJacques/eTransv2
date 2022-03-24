using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTrans.Client.Models.Visitors
{
    public class CLient
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenoms { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300";
        public string Description { get; set; } = "Je vais donner le meilleur de moi meme tout au long de cette semaine";
        public DateTime DateDeNaissance { get; set; }
        public DateTime DateDeCreaction { get; set; }
        public string NumeroDeTelephone { get; set; }
        public bool EstAbonnee { get; set; } = false;
        public string Sex { get; set; }
        public string CityOfOriigin { get; set; }
        public string CurrentCity { get; set; }
        public DateTime DateOfBirth  { get; set; }
        public string TelNumero { get; set; }
        public bool IsSubscribe { get; set; } = false;
        public override string ToString()
        {
            return string.Format(" Nom : {0};\n Prenoms : {4};\n Sexe : {1};\n Date de naissance : {2};\n Numero de telephone: {3}", Nom, Prenoms, Sex, DateOfBirth, TelNumero, Prenoms); 
        }

    }
}
