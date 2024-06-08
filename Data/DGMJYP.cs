using Microsoft.EntityFrameworkCore;

namespace Data
{
    [PrimaryKey(nameof(MJSECD), nameof(MJJYCD), nameof(MJJUCD), nameof(MJDGNO), nameof(MJSYNO))]
    public class DGMJYP
    {
        public int MJSECD { get; set; }
        public int MJJYCD { get; set; }
        public int MJJUCD { get; set; }
        public string MJJYNM { get; set; }
        public string MJTNNM { get; set; }
        public string MJTNKM { get; set; }
        public int MJTKCD { get; set; }
        public int MJDGNO { get; set; }
        public int MJSYNO { get; set; }
        public decimal MJBUAI { get; set; }
        public decimal MJKIRO { get; set; }
        public int MJKINT { get; set; }
        public int MJKIHT { get; set; }
        public int MJEICD { get; set; }
        public int MJEIBN { get; set; }
        public int MJKAKB { get; set; }
        public int MJTACD { get; set; }
        public int MJBMCD { get; set; }
        public int MJSEDT { get; set; }
        public string MJSYKB { get; set; }
        public int MJNYDT { get; set; }
        public string MJTAKB { get; set; }
        public int MJTADT { get; set; }
        public int MJKPKB { get; set; }
        public string MJMPB1 { get; set; }
        public string MJMPB2 { get; set; }
        public string MJMPB3 { get; set; }
        public int MJSKDT { get; set; }
        public int MJSKKG { get; set; }
        public int MJSYMO { get; set; }
        public int MJHOMO { get; set; }
        public int MJKHKG { get; set; }
        public int MJKSKG { get; set; }
        public int MJJTKG { get; set; }
        public int MJKYKG { get; set; }
        public int MJRHKG { get; set; }
        public int MJIKKG { get; set; }
        public int MJHFLG { get; set; }
        public string MJDFLG { get; set; }
        public string MJFLG1 { get; set; }
        public string MJFLG2 { get; set; }
        public string MJFLG3 { get; set; }
        public string MJFIL1 { get; set; }
        public string MJFIL2 { get; set; }
        public string MJFIL3 { get; set; }
        public int MJUPDT { get; set; }
        public int MJUPTM { get; set; }
        public string MJUPID { get; set; }
        public int MJUPSN { get; set; }
        public int MJWRDT { get; set; }
        public int MJWRTM { get; set; }
        public string MJWRID { get; set; }
        public int MJWRSN { get; set; }
   }
}