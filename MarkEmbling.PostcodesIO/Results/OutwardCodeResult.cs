﻿using RestSharp.Deserializers;
using System;
using System.Collections.Generic;

namespace MarkEmbling.PostcodesIO.Results
{
    [Serializable]
    public class OutwardCodeResult {
        public string Outcode { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int Northings { get; set; }
        public int Eastings { get; set; }
        [DeserializeAs(Name = "admin_district")]
        public List<string> AdminDistrict { get; set; }
        public List<string> Parish { get; set; }
        [DeserializeAs(Name = "admin_county")]
        public List<string> AdminCounty { get; set; }
        [DeserializeAs(Name = "admin_ward")]
        public List<string> AdminWard { get; set; }
    }
}