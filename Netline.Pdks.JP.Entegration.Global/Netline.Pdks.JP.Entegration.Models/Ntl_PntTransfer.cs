using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netline.Pdks.JP.Entegration.Models
{
    public class Ntl_PntTransfer
    {
        public int Id { get; set; } = 0;

        public string PerCode { get; set; } = "";          
        public int PntMonth { get; set; } = 0;      
        public int PntYear { get; set; } = 0; 
        public double SgkGun { get; set; } = 0;  
        public double VergiOdemeGunu { get; set; } = 0;          
        public double ToplamCalismaGunu { get; set; } = 0;     
        public double Gun { get; set; } = 0;         
        public double Saat { get; set; } = 0;        
        public double HTatGun { get; set; } = 0;    
        public double HTatSaat { get; set; } = 0;        
        public double GTatGun { get; set; } = 0;  
        public double GTatSaat { get; set; } = 0;    
        public double YillikIzinGun { get; set; } = 0;
        public double YillikIzinSaat { get; set; } = 0;
        public double SosyalIzinGun { get; set; } = 0;
        public double SosyalIzinSaat { get; set; } = 0;
        public double IdariGun { get; set; } = 0;
        public double IdariSaat { get; set; } = 0;
        public double UsizIzinGun { get; set; } = 0;
        public double UsizIzinSaat { get; set; } = 0;    
        public double IstrahatGun { get; set; } = 0;    
        public double IstrahatSaat { get; set; } = 0;          
        public double PandemiUsizGun { get; set; } = 0;   
        public double PandemiUsizSaat { get; set; } = 0;         
        public double Fzm1 { get; set; } = 0; 
        public double BayramMesaisi { get; set; } = 0;
        public double KisaCalismaOdenegiGun { get; set; } = 0; 
        public double KisaCalismaOdenegisaat { get; set; } = 0;
    }
}
