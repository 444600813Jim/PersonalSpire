namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;
    using System.Collections.Generic;

    public abstract class DocumentObject : DocumentSerializable, IDocumentObject
    {
        private bool bool_0;
        private bool bool_1;
        private byte[] byte_1;
        private long[] long_2;
        private Stack<Field> stack_0;
        private string[] string_3;
        private string[] string_4;

        protected DocumentObject(Document doc, DocumentObject owner) : base(doc, owner)
        {
        }

        internal abstract bool Accept(Class420 visitor);
        internal virtual VisitorAction AcceptEnd(Class420 visitor)
        {
            return VisitorAction.Continue;
        }

        internal virtual VisitorAction AcceptStart(Class420 visitor)
        {
            return VisitorAction.Continue;
        }

        public DocumentObject Clone()
        {
            return (DocumentObject) this.CloneImpl();
        }

        internal virtual void CloneCommit()
        {
            ICompositeObject obj2 = this as ICompositeObject;
            if (obj2 != null)
            {
                DocumentObjectCollection childObjects = obj2.ChildObjects;
                int num = 0;
                int count = childObjects.Count;
                while (num < count)
                {
                    childObjects[num].CloneCommit();
                    if (childObjects.Count < count)
                    {
                        num--;
                        count--;
                    }
                    num++;
                }
            }
        }

        internal virtual List<DocumentObject> GetChildElements(Spire.Doc.Documents.DocumentObjectType type, bool isDeep)
        {
            List<DocumentObject> list = new List<DocumentObject>();
            foreach (DocumentObject obj2 in this.ChildObjects)
            {
                if (obj2.DocumentObjectType == type)
                {
                    list.Add(obj2);
                }
                else if (isDeep)
                {
                    list.AddRange(obj2.GetChildElements(type, isDeep));
                }
            }
            return list;
        }

        internal bool method_10(Class420 A_0)
        {
            DocumentObject firstChild = this.FirstChild;
            if ((firstChild == null) && ((this is TextBox) || ((this is ShapeObject) && ((this as ShapeObject).ShapeType == ShapeType.TextBox))))
            {
                firstChild = new Paragraph(base.Document);
            }
            while (firstChild != null)
            {
                if (!this.method_11(firstChild))
                {
                    if (firstChild is DocOleObject)
                    {
                        Field item = new Field(base.m_doc) {
                            Type = FieldType.FieldEmbed
                        };
                        this.NonSupportedFields.Push(item);
                    }
                    if (!firstChild.Accept(A_0))
                    {
                        return false;
                    }
                }
                if ((firstChild is StructureDocumentTagRow) && (firstChild.NextSibling is StructureDocumentTagRow))
                {
                    firstChild = null;
                }
                else
                {
                    firstChild = firstChild.NextSibling as DocumentObject;
                }
            }
            return true;
        }

        private bool method_11(DocumentObject A_0)
        {
            if ((((A_0 is DocPicture) || (A_0 is TextBox)) || ((A_0 is ShapeObject) || (A_0 is ShapeGroup))) && ((this.stack_0 != null) && (this.stack_0.Count > 0)))
            {
                Field field = this.stack_0.Peek();
                if ((field != null) && (field.Type == FieldType.FieldEmbed))
                {
                    return true;
                }
                if ((field != null) && (field.Type == FieldType.FieldShape))
                {
                    this.bool_1 = false;
                    return false;
                }
            }
            else if ((A_0 is ParagraphBase) && (A_0 as ParagraphBase).SkipDocxItem)
            {
                (A_0 as ParagraphBase).SkipDocxItem = false;
                return true;
            }
            if (!(A_0 is Field) && !(A_0 is FieldMark))
            {
                return (this.bool_1 && ((this.stack_0 != null) && (this.stack_0.Count != 0)));
            }
            if ((this.stack_0 != null) && (this.stack_0.Count > 0))
            {
                Field field2 = this.stack_0.Peek();
                if ((field2 != null) && (field2.Type == FieldType.FieldEmbed))
                {
                    if ((A_0 is FieldMark) && ((A_0 as FieldMark).Type == FieldMarkType.FieldEnd))
                    {
                        this.stack_0.Pop();
                        this.bool_1 = true;
                    }
                    return true;
                }
            }
            return false;
        }

        internal bool method_12(VisitorAction A_0)
        {
            int num = 4;
            switch (A_0)
            {
                case VisitorAction.Continue:
                case VisitorAction.SkipThisElement:
                    return true;

                case VisitorAction.Stop:
                    return false;
            }
            throw new InvalidOperationException(BookmarkStart.b("缩䈫䔭帯崱䌳堵ᠷ䰹唻䴽⤿㙁⭃㑅桇⭉⽋㩍㥏㵑㩓硕", num));
        }

        internal int method_13(IDocumentObject A_0)
        {
            return this.ChildObjects.Add(A_0);
        }

        internal bool method_14(DocumentObject A_0)
        {
            int num = 0x12;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("紷嘹夻匽┿ⱁぃ", num));
            }
            for (DocumentObject obj2 = this.Owner; obj2 != null; obj2 = obj2.Owner)
            {
                if (obj2 == this)
                {
                    break;
                }
                if (obj2 == A_0)
                {
                    return true;
                }
            }
            return false;
        }

        private DocumentObject method_15(DocumentObject A_0, DocumentObject A_1, bool A_2)
        {
            int num = 14;
            if ((A_1 != null) && (A_1.Owner != this))
            {
                throw new ArgumentException(BookmarkStart.b("怳帵崷ᨹ主嬽☿❁㙃⍅♇⥉⥋湍㽏け㹓㍕㭗⹙籛㝝፟䉡੣॥ᱧ䩩൫乭፯ᩱᵳ᩵ᱷ婹፻᡽ꁿﮇꪉ摒뚗", num));
            }
            if (A_0 == null)
            {
                throw new ArgumentException(BookmarkStart.b("眳圵嘷吹医䨽怿⭁⩃㕅ⵇ㡉㡋湍ㅏ牑㩓⍕㑗㙙籛ㅝɟࡡţեᱧ䑩", num));
            }
            if (A_0 == this)
            {
                throw new ArgumentException(BookmarkStart.b("眳圵嘷吹医䨽怿⍁⁃≅桇⭉汋⅍㉏㡑ㅓ㕕ⱗ穙⡛ㅝ䁟ᅡţ੥๧䑩", num));
            }
            if (this.method_14(A_0))
            {
                throw new ArgumentException(BookmarkStart.b("怳帵崷ᨹ刻嬽㜿Łⱃ⽅⑇⹉汋❍⍏牑㕓㡕硗㭙㉛㵝՟ᅡၣ॥ᩧ䩩ͫ࡭偯ٱᱳή୷婹፻ᱽꚇ", num));
            }
            if (A_0 == A_1)
            {
                throw new ArgumentException(BookmarkStart.b("眳圵嘷吹医䨽怿⍁⁃≅桇⭉汋⅍㉏㡑ㅓ㕕ⱗ穙㹛㭝ٟൡᙣͥ䝧୩੫ᩭᕯq味ή౷ॹ᥻ች겁", num));
            }
            DocumentBase document = base.Document;
            if (A_0.Document != document)
            {
                throw new ArgumentException(BookmarkStart.b("怳帵崷ᨹ刻嬽㜿Łⱃ⽅⑇⹉汋㥍ㅏ⅑瑓㕕⩗㽙㵛⩝՟١䑣eᩧթū乭ᅯ剱ၳήṷᱹ᥻౽ꚅﮍﶏ望뢗ﾝ캟芡킣캥춧誩쎫삭햯銱삳\udeb5\ud9b7캹鲻\uddbd\ub2bfꟁꗃ닅귇껉뫍룏믑ꟓ鷗뛙맛돝藟賡郣죥", num));
            }
            if (A_0.Owner != null)
            {
                A_0.Owner.method_20(A_0);
            }
            if (A_2)
            {
                if (A_1 != null)
                {
                    this.method_16(A_0, A_1);
                }
                else
                {
                    this.method_16(A_0, this.LastChild);
                }
            }
            else if (A_1 != null)
            {
                DocumentObject previousSibling = (DocumentObject) A_1.PreviousSibling;
                if (previousSibling == null)
                {
                    previousSibling = A_1;
                }
                this.method_16(A_0, previousSibling);
            }
            else
            {
                this.method_16(A_0, this.LastChild);
            }
            A_0.method_0(this);
            return A_0;
        }

        private void method_16(DocumentObject A_0, DocumentObject A_1)
        {
            int num = 0x10;
            if (A_0 == null)
            {
                throw new ArgumentException(BookmarkStart.b("电夷吹刻儽㐿扁ⵃ⡅㭇⽉㹋㩍灏㍑瑓㡕ⵗ㙙せ繝ཟa๣ͥ୧ṩ䉫", num));
            }
            if (A_1 == null)
            {
                this.method_13(A_0);
            }
            else
            {
                int index = A_1.Owner.ChildObjects.IndexOf(A_1);
                if (index == (A_1.Owner.ChildObjects.Count - 1))
                {
                    this.ChildObjects.Insert(index + 1, A_0);
                }
                else
                {
                    this.ChildObjects.Insert(index, A_0);
                }
            }
        }

        internal DocumentObject method_17(DocumentObject A_0, DocumentObject A_1)
        {
            return this.method_15(A_0, A_1, true);
        }

        internal DocumentObject method_18(DocumentObject A_0, DocumentObject A_1)
        {
            return this.method_15(A_0, A_1, false);
        }

        internal void method_19()
        {
            int num = 2;
            if (this.Owner == null)
            {
                throw new InvalidOperationException(BookmarkStart.b("欧䬩䈫䀭弯䘱ᐳ䐵崷圹医䠽┿扁♃⍅⭇⭉㥋㵍㕏牑⁓㹕㵗⡙㥛繝य़ᅡ䑣ࡥݧ䩩ᱫ཭ɯ᝱ᩳɵ噷", num));
            }
            this.Owner.method_20(this);
        }

        internal DocumentObject method_20(DocumentObject A_0)
        {
            int num = 0x10;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("夵吷帹缻嘽⤿⹁⁃", num));
            }
            if (A_0.Owner != this)
            {
                throw new ArgumentException(BookmarkStart.b("戵倷匹伻ḽԿ⹁⅃⭅ⵇ⑉㡋湍㥏⅑瑓㡕㝗⹙籛㽝䁟ቡգᑥ൧ѩᡫ乭Ὧᑱ味ɵၷό屻ᅽꒃ얅낏힑ﾙ躟", num));
            }
            this.ChildObjects.Remove(A_0);
            A_0.method_0(null);
            return A_0;
        }

        internal int method_5()
        {
            ICompositeObject owner = this.Owner as ICompositeObject;
            if (owner != null)
            {
                return owner.ChildObjects.IndexOf(this);
            }
            return -1;
        }

        internal DocumentObject method_6(Spire.Doc.Documents.DocumentObjectType A_0)
        {
            for (DocumentObject obj2 = this.ParentObject; obj2 != null; obj2 = obj2.ParentObject)
            {
                if (obj2.DocumentObjectType == A_0)
                {
                    return obj2;
                }
            }
            return null;
        }

        internal DocumentObject method_7(Spire.Doc.Documents.DocumentObjectType A_0)
        {
            for (DocumentObject obj2 = this.ParentObject; obj2 != null; obj2 = obj2.ParentObject)
            {
                if (obj2.DocumentObjectType == A_0)
                {
                    return obj2;
                }
            }
            return null;
        }

        internal bool method_8(DocumentObject A_0)
        {
            for (OwnerHolder holder = A_0.OwnerBase; holder != null; holder = holder.OwnerBase)
            {
                if (holder == this)
                {
                    return true;
                }
            }
            return false;
        }

        internal bool method_9(Class420 A_0)
        {
            switch (this.AcceptStart(A_0))
            {
                case VisitorAction.SkipThisElement:
                    return true;

                case VisitorAction.Stop:
                    return false;
            }
            if (!this.method_10(A_0))
            {
                return false;
            }
            return this.method_12(this.AcceptEnd(A_0));
        }

        internal virtual void RemoveSelf()
        {
            ICompositeObject owner = this.Owner as ICompositeObject;
            if ((owner != null) && (owner.ChildObjects != null))
            {
                owner.ChildObjects.Remove(this);
            }
        }

        public abstract DocumentObjectCollection ChildObjects { get; }

        internal bool DeepDetached
        {
            get
            {
                if (this.DocumentObjectType == Spire.Doc.Documents.DocumentObjectType.Document)
                {
                    return false;
                }
                if (this.Owner != null)
                {
                    return this.Owner.DeepDetached;
                }
                return true;
            }
        }

        public abstract Spire.Doc.Documents.DocumentObjectType DocumentObjectType { get; }

        public DocumentObject FirstChild
        {
            get
            {
                if (this.LastChild == null)
                {
                    return null;
                }
                return this.ChildObjects[0];
            }
        }

        internal DocumentObject FirstNonMarkupDescendant
        {
            get
            {
                return Class681.smethod_15(this.FirstChild);
            }
        }

        internal bool HasChildElements
        {
            get
            {
                return (this.LastChild != null);
            }
        }

        public bool IsComposite
        {
            get
            {
                return (this is ICompositeObject);
            }
        }

        public DocumentObject LastChild
        {
            get
            {
                if (this.ChildObjects.Count <= 0)
                {
                    return null;
                }
                return this.ChildObjects[this.ChildObjects.Count - 1];
            }
        }

        internal DocumentObject LastNonMarkupDescendant
        {
            get
            {
                return Class681.smethod_16(this.LastChild);
            }
        }

        internal DocumentObject NextNonMarkupElementLimited
        {
            get
            {
                DocumentObject nextNonMarkupElementLimited = Class681.smethod_15((DocumentObject) this.NextSibling);
                if ((nextNonMarkupElementLimited == null) && Class681.smethod_14(this.ParentObject))
                {
                    nextNonMarkupElementLimited = this.ParentObject.NextNonMarkupElementLimited;
                }
                return nextNonMarkupElementLimited;
            }
        }

        public IDocumentObject NextSibling
        {
            get
            {
                ICompositeObject owner = this.Owner as ICompositeObject;
                if (owner == null)
                {
                    return null;
                }
                return owner.ChildObjects.method_8(this);
            }
        }

        private Stack<Field> NonSupportedFields
        {
            get
            {
                if (this.stack_0 == null)
                {
                    this.stack_0 = new Stack<Field>();
                }
                return this.stack_0;
            }
        }

        public DocumentObject Owner
        {
            get
            {
                return (DocumentObject) base.OwnerBase;
            }
        }

        internal DocumentObject ParentObject
        {
            get
            {
                return (base.OwnerBase as DocumentObject);
            }
        }

        public IDocumentObject PreviousSibling
        {
            get
            {
                ICompositeObject owner = this.Owner as ICompositeObject;
                if (owner == null)
                {
                    return null;
                }
                return owner.ChildObjects.method_9(this);
            }
        }
    }
}

