﻿using System.Collections.Generic;

namespace MasterDetail.Web.Api.DTOs
{
    public class PersonalizationData
    {
        public IEnumerable<FeatureItem> Features { get; set; }
        public UiClaimsData UiClaims { get; set; }
    }
}