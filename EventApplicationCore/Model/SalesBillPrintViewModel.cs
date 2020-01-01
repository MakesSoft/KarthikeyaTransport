using System.Collections.Generic;

namespace MyAccountProject.Model
{
    public class SalesBillPrintViewModel
    {
        public SalesBillViewModel SalesBillViewModel { get; set; }
        public List<SalesBillItemsViewModel> SalesItemBillViewModel { get; set; }
        public List<string> PrintOptions { get; set; }
        public bool DispatchPrint { get; set; }
    }
}