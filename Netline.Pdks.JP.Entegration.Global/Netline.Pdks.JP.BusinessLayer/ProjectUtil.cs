using Netline.Pdks.JP.Entegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace Netline.Pdks.JP.BusinessLayer
{
    public class ProjectUtil
    {
        static  string sqlConn ="";
        static  string testsqlConn ="";
        public ProjectUtil()
        {
            sqlConn = ConfigurationManager.ConnectionStrings["APILoggingConnection"].ConnectionString;
            testsqlConn = ConfigurationManager.ConnectionStrings["TestAPILoggingConnection"].ConnectionString;
        }

      
        public List<PersonelResult> getPersonels()
        {

            string query = $@" SELECT 
 distinct  P.CODE as SicilNo,
 p.name as Adi, p.SURNAME as Soyadi,
   amir.LOGICALREF as AmirSicilNo,
   ORGK.DESCRIPTION as KurumAdi,
   DEP.DESCRIPTION as Departman,
   amir.NAME + ' ' + amir.SURNAME AS UstYonetici,
   isnull(convert(varchar, a.begdate, 101), '') as IseGirisTarihi,
   isnull(convert(varchar, p.BIRTHDATE, 101), '') as DogumTarihi,
   unit.DESCRIPTION as Birim,
   (case when p.sex = 1 then 'Erkek' else 'Kadın' end) as Cinsiyet,
   isnull(convert(varchar, p.GROUPINDATE, 101), '') as GrubaGirisTarihi,
   year(getdate()) - year(p.GROUPINDATE) as ÇalışılanYıl,
   POS.DESCRIPTION as Pozisyon,
   mail.exp1 as Eposta,
   gsm.EXP1 as Gsm,
   phone.exp1 as Telefon,
   PR.IDTCNO  Tckno


FROM H_001_ASSIGNS A
left JOIN S_ORGUNITS ORGK ON(A.FIRMREF = ORGK.LOGICALREF)
left JOIN S_ORGUNITS ORGI ON(A.LOCREF = ORGI.LOGICALREF)
left JOIN S_ORGUNITS unit ON(A.UNITREF = unit.LOGICALREF)
left JOIN S_DEPARTMENTS DEP ON(A.DEPTREF = DEP.LOGICALREF)
left JOIN S_POSITIONS POS ON(A.POSITIONREF = POS.LOGICALREF)
left join H_001_PERSONS P on(a.PERREF = p.LOGICALREF)
LEFT JOIN H_001_PERIDINFOS PR ON P.LOGICALREF=PR.LOGICALREF
left join H_001_PERSONS amir on p.MANAGERREF = amir.LOGICALREF
left join H_001_CONTACTS mail on p.LOGICALREF = mail.CARDREF and mail.typ = '6'
left join H_001_CONTACTS gsm on p.LOGICALREF = gsm.CARDREF and gsm.typ = '3'
left join H_001_CONTACTS phone on p.LOGICALREF = phone.CARDREF and phone.typ = '2'
where p.TYP = 1  ";
            SqlConnection sql= new SqlConnection(sqlConn);
            List<PersonelResult> list=   sql.Query<PersonelResult>(query).ToList();
            return list;
        }
        public PersonelResult getPersonelByTckNo(string Tckno)
        {
            SqlConnection sql= new SqlConnection();
            string query = $@"  SELECT 
 distinct  P.CODE as SicilNo,
 p.name as Adi, p.SURNAME as Soyadi,
   amir.LOGICALREF as AmirSicilNo,
   ORGK.DESCRIPTION as KurumAdi,
   DEP.DESCRIPTION as Departman,
   amir.NAME + ' ' + amir.SURNAME AS UstYonetici,
   isnull(convert(varchar, a.begdate, 101), '') as IseGirisTarihi,
   isnull(convert(varchar, p.BIRTHDATE, 101), '') as DogumTarihi,
   unit.DESCRIPTION as Birim,
   (case when p.sex = 1 then 'Erkek' else 'Kadın' end) as Cinsiyet,
   isnull(convert(varchar, p.GROUPINDATE, 101), '') as GrubaGirisTarihi,
   year(getdate()) - year(p.GROUPINDATE) as ÇalışılanYıl,
   POS.DESCRIPTION as Pozisyon,
   mail.exp1 as Eposta,
   gsm.EXP1 as Gsm,
   phone.exp1 as Telefon,
   PR.IDTCNO  Tckno


FROM H_001_ASSIGNS A
left JOIN S_ORGUNITS ORGK ON(A.FIRMREF = ORGK.LOGICALREF)
left JOIN S_ORGUNITS ORGI ON(A.LOCREF = ORGI.LOGICALREF)
left JOIN S_ORGUNITS unit ON(A.UNITREF = unit.LOGICALREF)
left JOIN S_DEPARTMENTS DEP ON(A.DEPTREF = DEP.LOGICALREF)
left JOIN S_POSITIONS POS ON(A.POSITIONREF = POS.LOGICALREF)
left join H_001_PERSONS P on(a.PERREF = p.LOGICALREF)
LEFT JOIN H_001_PERIDINFOS PR ON P.LOGICALREF=PR.LOGICALREF
left join H_001_PERSONS amir on p.MANAGERREF = amir.LOGICALREF
left join H_001_CONTACTS mail on p.LOGICALREF = mail.CARDREF and mail.typ = '6'
left join H_001_CONTACTS gsm on p.LOGICALREF = gsm.CARDREF and gsm.typ = '3'
left join H_001_CONTACTS phone on p.LOGICALREF = phone.CARDREF and phone.typ = '2'
where p.TYP = 1  where PR.IDTCNO=@Tckno ";
            return sql.Query<PersonelResult>(query, new { Tckno }).FirstOrDefault();
        }
      
     
    }
}