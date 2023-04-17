using System;
using System.ComponentModel.DataAnnotations;

namespace RunLoyaltyBatchWeb.Models
{
    public class BatchEntity
    {
        public int BatchSelected { get; set; }

        [DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? SelectedDate { get; set; }
    }
}
