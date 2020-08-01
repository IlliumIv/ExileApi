using ExileCore.PoEMemory.Elements.InventoryElements;
using System.Collections.Generic;

namespace ExileCore.PoEMemory.MemoryObjects
{
    public class TradeWindow : Element
    {
        // see sell window
        // 3,1,0,0
        public Element SellDialog => GetChildAtIndex(3)?.GetChildAtIndex(1)?.GetChildAtIndex(0)?.GetChildAtIndex(0);
        public Element YourOfferElement => SellDialog?.GetChildAtIndex(0);
        public IList<NormalInventoryItem> YourOffer => ExtractNormalInventoryItems(YourOfferElement?.Children);
        public Element OtherOfferElement => SellDialog?.GetChildAtIndex(1);
        public IList<NormalInventoryItem> OtherOffer => ExtractNormalInventoryItems(OtherOfferElement?.Children);
        public string NameSeller => SellDialog?.GetChildAtIndex(2).Text.Replace("'s Offer", "");
        public Element AcceptButton => SellDialog?.GetChildAtIndex(5);
        public bool SellerAccepted => AcceptButton?.GetChildAtIndex(0).Text == "cancel accept";
        public Element CancelButton => SellDialog?.GetChildAtIndex(6);

        private IList<NormalInventoryItem> ExtractNormalInventoryItems(IList<Element> children)
        {
            var resultList = new List<NormalInventoryItem>();

            for (var i = 1; i < children.Count; i++)
            {
                resultList.Add(children[i].AsObject<NormalInventoryItem>());
            }
            return resultList;
        }
    }
}
