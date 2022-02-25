using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesMvc.Models {

    public class Order {

        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(11,2)"), DataType(DataType.Currency)]
        public decimal Total { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual IEnumerable<Orderline> Orderlines { get; set; }

    }
}
