﻿
namespace PostcodesApi.App.Common.Responses.PostcodesIoApi
{
    public class GetPostcodeResponse : Response
    {
        public GetPostcodeResponse(Root postcodeResponse)
        {
            Result = postcodeResponse;
        }

        public Root Result { get; set; }

        public class Codes
        {
            public Codes(string? admin_district, string? admin_county, string? admin_ward, string? parish, string? parliamentary_constituency, string? ccg, string? ccg_id, string? ced, string? nuts, string? lsoa, string? msoa, string? lau2, string? pfa)
            {
                this.admin_district = admin_district;
                this.admin_county = admin_county;
                this.admin_ward = admin_ward;
                this.parish = parish;
                this.parliamentary_constituency = parliamentary_constituency;
                this.ccg = ccg;
                this.ccg_id = ccg_id;
                this.ced = ced;
                this.nuts = nuts;
                this.lsoa = lsoa;
                this.msoa = msoa;
                this.lau2 = lau2;
                this.pfa = pfa;
            }

            public string? admin_district { get; set; }
            public string? admin_county { get; set; }
            public string? admin_ward { get; set; }
            public string? parish { get; set; }
            public string? parliamentary_constituency { get; set; }
            public string? ccg { get; set; }
            public string? ccg_id { get; set; }
            public string? ced { get; set; }
            public string? nuts { get; set; }
            public string? lsoa { get; set; }
            public string? msoa { get; set; }
            public string? lau2 { get; set; }
            public string? pfa { get; set; }
        }

        public class Root
        {
            public Root(string? postcode, int quality, int eastings, int northings, string? country, string? nhs_ha, double longitude, double latitude, string? european_electoral_region, string? primary_care_trust, string? region, string? lsoa, string? msoa, string? incode, string? outcode, string? parliamentary_constituency, string? admin_district, string? parish, string? admin_county, string? date_of_introduction, string? admin_ward, string? ced, string? ccg, string? nuts, string? pfa, Codes? codes)
            {
                this.postcode = postcode;
                this.quality = quality;
                this.eastings = eastings;
                this.northings = northings;
                this.country = country;
                this.nhs_ha = nhs_ha;
                this.longitude = longitude;
                this.latitude = latitude;
                this.european_electoral_region = european_electoral_region;
                this.primary_care_trust = primary_care_trust;
                this.region = region;
                this.lsoa = lsoa;
                this.msoa = msoa;
                this.incode = incode;
                this.outcode = outcode;
                this.parliamentary_constituency = parliamentary_constituency;
                this.admin_district = admin_district;
                this.parish = parish;
                this.admin_county = admin_county;
                this.date_of_introduction = date_of_introduction;
                this.admin_ward = admin_ward;
                this.ced = ced;
                this.ccg = ccg;
                this.nuts = nuts;
                this.pfa = pfa;
                this.codes = codes;
            }

            public string? postcode { get; set; }
            public int quality { get; set; }
            public int eastings { get; set; }
            public int northings { get; set; }
            public string? country { get; set; }
            public string? nhs_ha { get; set; }
            public double longitude { get; set; }
            public double latitude { get; set; }
            public string? european_electoral_region { get; set; }
            public string? primary_care_trust { get; set; }
            public string? region { get; set; }
            public string? lsoa { get; set; }
            public string? msoa { get; set; }
            public string? incode { get; set; }
            public string? outcode { get; set; }
            public string? parliamentary_constituency { get; set; }
            public string? admin_district { get; set; }
            public string? parish { get; set; }
            public string? admin_county { get; set; }
            public string? date_of_introduction { get; set; }
            public string? admin_ward { get; set; }
            public string? ced { get; set; }
            public string? ccg { get; set; }
            public string? nuts { get; set; }
            public string? pfa { get; set; }
            public Codes? codes { get; set; }
        }
    }
}
