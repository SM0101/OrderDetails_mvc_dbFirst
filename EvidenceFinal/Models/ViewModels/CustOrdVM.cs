using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EvidenceFinal.Models.ViewModels
{
    public class CustOrdVM
    {
        [Required(ErrorMessage ="Can't be blank and Duplicate!")]
        public int CustomerID { get; set; }
        public string CutomerName { get; set; }
        public string BillingAddress { get; set; }
        public string Imagepath { get; set; }

        public int ItemID { get; set; }
        public string ItemName { get; set; }

        public int OrderID { get; set; }

        
        public int OrderNo { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-mm-yyyy}", ApplyFormatInEditMode =true )]

        public Nullable<System.DateTime> orderDate { get; set; }


        public Nullable<bool> OrderStatus { get; set; }
        public List<Order> Orders { get;  set; }
        public Customer Customer { get; set; }
    }
}