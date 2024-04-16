
using System.ComponentModel.DataAnnotations;

namespace StoreWebApp.Models
{
    // { "_id" : { "$oid" : "5a8c58b660ca67641c1e15dc" }, "npa" : "403", "nxx" : "201", "npanxx" : "403201", "city" : "Calgary", "state" : "Alberta", "stateISO" : "AB", "country" : "Canada", "countryISO" : "CA", "zipCode" : "T2E6M4", "gmtOffset" : "-7", "gmtOffsetDST" : "-6", "dstObserved" : "1", "latitude" : "51.0478", "longitude" : "-114.0585" }
    public class ZipCodeData
    {
        public string? Npa { get; set; }

        public string? Nxx { get; set; }

        public string? Npanxx { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string StateISO { get; set; }

        public string Country { get; set; }

        public string CountryISO { get; set; }

        [Key]
        public string ZipCode { get; set; }

        public string? GmtOffset { get; set; }

        public string? GmtOffsetDST { get; set; }

        public string? DstObserved { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }

    public interface IZipCodeRepository
    {
        ZipCodeData GetZipCode(string zipCode);

        Task<ZipCodeData> GetZipCodeAsync(string zipCode);

        Task<List<ZipCodeData>> GetZipCodesAsync(string zipCode, int results = 20);


    }
}