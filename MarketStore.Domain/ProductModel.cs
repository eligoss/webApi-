using System;

namespace MarketStore.Domain
{
    public class ProductModel 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CategoryName { get; set; }

        public DateTime UpdateTimestamp { get; set; }

        public bool IsUpdated { get; set; }

        public int IsDeleted { get; set; }

        public int GetKey()
        {
            throw new NotImplementedException();
        }
    }
}
