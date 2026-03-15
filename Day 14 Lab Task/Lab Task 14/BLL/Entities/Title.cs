using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entities
{
    public class Title : EntityBase
    {
        public Title() => this.entityState = EntityState.Added;
        public string TitleId { get; set; }
        public string TitleName { 
            get; set
            {
                if (field != value)
                {
                    field = value;
                    if (entityState != EntityState.Added)
                        this.entityState = EntityState.Modified;
                }
            }
        
        }
        public string Type { get; set; }
        public string PubId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YtdSales { get; set; }
        public string Notes { get; set; }
        public DateTime PubDate { get; set; }
    }
}
