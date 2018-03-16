namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Interface;
    using System;
    using System.Reflection;

    public class DropDownCollection : DocumentSerializableCollection
    {
        public DropDownCollection(Document doc) : base(doc, null)
        {
        }

        public DropDownItem Add(string text)
        {
            int num = 5;
            if (base.InnerList.Count > 0x18)
            {
                throw new ArgumentException(BookmarkStart.b("缪䔬䨮ᄰ圲䜴堶䤸ᘺ夼倾㙀ⵂ敄⭆⁈㡊㥌潎㝐㱒❔㩖祘㵚㑜㩞ൠݢ䕤٦ըݪɬᡮɰ卲౴ᡶ౸孺ॼၾꆀꮊ뎒랖漢철횢좤螦욨춪趬鶮蒰鎲\udcb4\uc3b6\udcb8\ud6ba캼龾뗀곂돆ꇈ껊ꯎꏐ볒ꗔ𥳐뷘듚ꫜ뇞쇠迢賤铦鷨엪", num));
            }
            DropDownItem item = new DropDownItem(base.Document) {
                Text = text
            };
            base.InnerList.Add(item);
            return item;
        }

        public void Clear()
        {
            base.InnerList.Clear();
        }

        protected override OwnerHolder CreateItem(IXDLSContentReader reader)
        {
            return new DropDownItem(base.Document);
        }

        protected override string GetTagItemName()
        {
            return BookmarkStart.b("儴䔶嘸䬺夼倾㙀ⵂ桄⹆㵈⹊⁌㱎", 15);
        }

        internal int method_5(DropDownItem A_0)
        {
            return base.InnerList.Add(A_0);
        }

        internal void method_6(DropDownCollection A_0)
        {
            int num = 0;
            int count = base.Count;
            while (num < count)
            {
                A_0.method_5(this[num].method_5());
                num++;
            }
        }

        public void Remove(int index)
        {
            int num = 12;
            if (index >= base.InnerList.Count)
            {
                throw new ArgumentException(BookmarkStart.b("瘱䘳夵䠷縹医䤽⸿ୁぃ⍅╇橉㭋❍⑏㩑瑓╕ⵗ㥙㑛繝य़ౡcͥၧ䩩࡫ŭᕯűᩳ兵౷婹᥻ٽꢅ", num));
            }
            DropDownItem item = (DropDownItem) base.InnerList[index];
            base.InnerList.Remove(item);
        }

        public DropDownItem this[int index]
        {
            get
            {
                return (DropDownItem) base.InnerList[index];
            }
        }
    }
}

