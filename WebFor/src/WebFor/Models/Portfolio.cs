﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFor.Models
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string PortfolioTitle { get; set; }
        public DateTime PortfolioDateCreated { get; set; }
        public DateTime PortfolioDateBuilt { get; set; }
        public string PortfolioThumbnail { get; set; }
        public string PortfolioBody { get; set; }
        public string PortfolioSiteAddress { get; set; }
        public string PortfolioCategory { get; set; }
    }
}
