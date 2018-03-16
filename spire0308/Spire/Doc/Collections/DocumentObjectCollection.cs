namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using Spire.Doc.Documents;
    using Spire.Doc.Documents.XML;
    using Spire.Doc.Fields;
    using Spire.Doc.Interface;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public abstract class DocumentObjectCollection : DocumentSerializableCollection, IDocumentObjectCollection
    {
        internal Class54 class54_0;

        internal DocumentObjectCollection(Document A_0) : this(A_0, null)
        {
        }

        internal DocumentObjectCollection(Document A_0, DocumentObject A_1) : base(A_0, A_1)
        {
            this.class54_0 = new Class54();
        }

        public int Add(IDocumentObject entity)
        {
            int num2 = 4;
            if (entity == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("伩䈫娭夯䘱䴳", num2));
            }
            int count = base.Count;
            this.OnInsert(count, (DocumentObject) entity);
            count = base.Count;
            count = this.method_14(count, (DocumentObject) entity);
            base.InnerList.Add(entity);
            this.OnInsertComplete(count, (DocumentObject) entity);
            this.method_16(count, (DocumentObject) entity);
            return count;
        }

        public void Clear()
        {
            this.OnClear();
            base.InnerList.Clear();
        }

        public bool Contains(IDocumentObject entity)
        {
            return base.InnerList.Contains(entity);
        }

        public int IndexOf(IDocumentObject entity)
        {
            return base.InnerList.IndexOf(entity);
        }

        public void Insert(int index, IDocumentObject entity)
        {
            int num = 2;
            if (entity == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䴧䐩堫䜭䐯䬱", num));
            }
            this.OnInsert(index, (DocumentObject) entity);
            if (!base.m_doc.bool_3 && (entity is FormField))
            {
                index = this.method_17(index, (DocumentObject) entity);
            }
            base.InnerList.Insert(index, entity);
            this.OnInsertComplete(index, (DocumentObject) entity);
            if (!base.m_doc.bool_3 && (entity is FormField))
            {
                this.method_18(index, (DocumentObject) entity);
            }
        }

        internal int method_10(int A_0, DocumentObjectType A_1, bool A_2)
        {
            // This item is obfuscated and can not be translated.
            DocumentObject obj2;
            do
            {
                if (A_2)
                {
                }
                A_0++;
                if ((A_0 > (base.InnerList.Count - 1)) || (A_0 < 0))
                {
                    return -1;
                }
                obj2 = base.InnerList[A_0] as DocumentObject;
            }
            while (obj2.DocumentObjectType != A_1);
            return A_0;
        }

        internal void method_11(DocumentObjectType A_0)
        {
            for (int i = 0; i < base.Count; i++)
            {
                DocumentObject obj2 = this[i];
                if (obj2.DocumentObjectType == A_0)
                {
                    obj2.method_0(null);
                    base.InnerList.RemoveAt(i);
                    i--;
                }
            }
        }

        internal void method_12(DocumentObjectCollection A_0)
        {
            int num = 0;
            int count = base.Count;
            while (num < count)
            {
                A_0.Add(this[num].Clone());
                num++;
            }
        }

        private bool method_13(DocumentObject A_0)
        {
            bool flag;
            A_0.GetType();
            if (!(flag = this.TypesOfElement[0].IsInstanceOfType(A_0)) && (this.TypesOfElement.Length > 1))
            {
                flag = this.TypesOfElement[1].IsInstanceOfType(A_0);
            }
            if (!flag)
            {
                flag = this.TypesOfElement[2].IsInstanceOfType(A_0);
            }
            return flag;
        }

        private int method_14(int A_0, DocumentObject A_1)
        {
            if ((base.m_doc != null) && !base.m_doc.bool_3)
            {
                if (A_1 is FormField)
                {
                    A_0 = this.method_17(A_0, A_1);
                    return A_0;
                }
                if ((A_1 is Field) && ((A_1 as Field).End != null))
                {
                    base.Document.ClonedFields.Push(A_1 as Field);
                }
            }
            return A_0;
        }

        private void method_15(int A_0, DocumentObject A_1)
        {
            if ((base.m_doc != null) && !base.m_doc.bool_3)
            {
                if (A_1 is FormField)
                {
                    this.method_18(A_0, A_1);
                }
                else if ((A_1 is FieldMark) && (base.Document.ClonedFields.Count > 0))
                {
                    Field field = base.Document.ClonedFields.Peek();
                    if ((A_1 as FieldMark).Type == FieldMarkType.FieldSeparator)
                    {
                        field.Separator = A_1 as FieldMark;
                    }
                    else
                    {
                        base.Document.ClonedFields.Pop().End = A_1 as FieldMark;
                    }
                }
            }
        }

        private void method_16(int A_0, DocumentObject A_1)
        {
            if ((base.m_doc != null) && !base.m_doc.bool_3)
            {
                if (A_1 is FormField)
                {
                    this.method_19(A_0, A_1);
                }
                else if ((A_1 is FieldMark) && (base.Document.ClonedFields.Count > 0))
                {
                    Field field = base.Document.ClonedFields.Peek();
                    if ((A_1 as FieldMark).Type == FieldMarkType.FieldSeparator)
                    {
                        field.Separator = A_1 as FieldMark;
                    }
                    else
                    {
                        base.Document.ClonedFields.Pop().End = A_1 as FieldMark;
                    }
                }
            }
        }

        private int method_17(int A_0, DocumentObject A_1)
        {
            int num = 0x13;
            switch ((A_1 as FormField).FormFieldType)
            {
                case FormFieldType.TextInput:
                {
                    TextFormField field = A_1 as TextFormField;
                    if ((field.Name == null) || (field.Name == string.Empty))
                    {
                        field.Name = (BookmarkStart.b("洸帺䔼䬾Ṁ", num) + Guid.NewGuid().ToString().Replace(BookmarkStart.b("ᐸ", num), BookmarkStart.b("昸", num))).Substring(0, 20);
                    }
                    if ((field.DefaultText == null) || (field.DefaultText == string.Empty))
                    {
                        field.DefaultText = BookmarkStart.b("㬘㤚㼜㴞䍠", num);
                    }
                    break;
                }
                case FormFieldType.CheckBox:
                {
                    CheckBoxFormField field3 = A_1 as CheckBoxFormField;
                    if ((field3.Name == null) || (field3.Name == string.Empty))
                    {
                        field3.Name = (BookmarkStart.b("稸区堼尾⩀᱂", num) + Guid.NewGuid().ToString().Replace(BookmarkStart.b("ᐸ", num), BookmarkStart.b("昸", num))).Substring(0, 20);
                    }
                    break;
                }
                case FormFieldType.DropDown:
                {
                    DropDownFormField field2 = A_1 as DropDownFormField;
                    if ((field2.Name == null) || (field2.Name == string.Empty))
                    {
                        field2.Name = (BookmarkStart.b("紸䤺刼伾Ṁ", num) + Guid.NewGuid().ToString().Replace(BookmarkStart.b("ᐸ", num), BookmarkStart.b("昸", num))).Substring(0, 20);
                    }
                    break;
                }
            }
            (this.Owner as Paragraph).method_78((A_1 as FormField).Name);
            (this.Owner as Paragraph).Items.Insert(A_0, new BookmarkStart(base.Document, (A_1 as FormField).Name));
            A_0++;
            return A_0;
        }

        private void method_18(int A_0, DocumentObject A_1)
        {
            if (A_1 is TextFormField)
            {
                (this.Owner as Paragraph).Items.Insert(++A_0, new FieldMark(base.m_doc, FieldMarkType.FieldSeparator));
                (this.Owner as Paragraph).Items.Insert(++A_0, new FieldMark(base.m_doc, FieldMarkType.FieldEnd));
                (this.Owner as Paragraph).Items.Insert(++A_0, new BookmarkEnd(base.Document, (A_1 as FormField).Name));
            }
            else
            {
                (this.Owner as Paragraph).Items.Insert(++A_0, new FieldMark(base.m_doc, FieldMarkType.FieldEnd));
                (this.Owner as Paragraph).Items.Insert(++A_0, new BookmarkEnd(base.Document, (A_1 as FormField).Name));
            }
        }

        private void method_19(int A_0, DocumentObject A_1)
        {
            int num = 0x11;
            FieldType type = (A_1 as FormField).Type;
            switch (type)
            {
                case FieldType.FieldFormTextInput:
                    (A_1 as TextFormField).Code = BookmarkStart.b("然瘸椺瀼款рᭂᅄ", num);
                    break;

                case FieldType.FieldFormCheckBox:
                    (A_1 as CheckBoxFormField).Code = BookmarkStart.b("然瘸椺瀼簾ीقلెୈъᕌ", num);
                    break;

                default:
                    if (type == FieldType.FieldFormDropDown)
                    {
                        (A_1 as DropDownFormField).Code = BookmarkStart.b("然瘸椺瀼笾ፀూᕄ͆و᱊͌", num);
                    }
                    break;
            }
            FieldMark entity = new FieldMark(base.m_doc, FieldMarkType.FieldSeparator);
            (this.Owner as Paragraph).Items.Add(entity);
            (A_1 as FormField).Separator = entity;
            FieldMark mark2 = new FieldMark(base.m_doc, FieldMarkType.FieldEnd);
            (this.Owner as Paragraph).Items.Add(mark2);
            (A_1 as FormField).End = mark2;
            (this.Owner as Paragraph).Items.Add(new BookmarkEnd(base.Document, (A_1 as FormField).Name));
        }

        internal DocumentObject method_20(DocumentObjectType A_0)
        {
            int num = 0;
            int count = base.Count;
            while (num < count)
            {
                DocumentObject obj2 = this[num];
                if (obj2.DocumentObjectType == A_0)
                {
                    return obj2;
                }
                num++;
            }
            return null;
        }

        internal DocumentObject method_21(DocumentObjectType A_0)
        {
            for (int i = base.Count - 1; i >= 0; i--)
            {
                DocumentObject obj2 = this[i];
                if (obj2.DocumentObjectType == A_0)
                {
                    return obj2;
                }
            }
            return null;
        }

        internal void method_5(int A_0, IDocumentObject A_1)
        {
            int num = 10;
            if (A_1 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("唯就䀳張䰷䌹", num));
            }
            this.OnInsert(A_0, (DocumentObject) A_1);
            if (!base.m_doc.bool_3 && (A_1 is FormField))
            {
                A_0 = this.method_17(A_0, (DocumentObject) A_1);
            }
            base.InnerList.Insert(A_0, A_1);
            this.OnInsertComplete(A_0, (DocumentObject) A_1);
            if (!base.m_doc.bool_3 && (A_1 is FormField))
            {
                this.method_18(A_0, (DocumentObject) A_1);
            }
        }

        private void method_6(IDocumentObject A_0)
        {
            if (A_0 is Paragraph)
            {
                foreach (ParagraphBase base2 in (A_0 as Paragraph).Items)
                {
                    if (base2 is BookmarkStart)
                    {
                        Bookmark bookmark2 = base.Document.Bookmarks.FindByName((base2 as BookmarkStart).Name);
                        if (bookmark2 != null)
                        {
                            if (bookmark2.BookmarkStart != null)
                            {
                                bookmark2.BookmarkStart.bool_9 = true;
                            }
                            if (bookmark2.BookmarkEnd != null)
                            {
                                bookmark2.BookmarkEnd.bool_9 = true;
                            }
                            base.Document.Bookmarks.InnerList.Remove(bookmark2);
                        }
                    }
                    else if (base2 is TextBox)
                    {
                        foreach (BodyRegion region in (base2 as TextBox).Body.Items)
                        {
                            this.method_6(region);
                        }
                    }
                }
            }
            else if (A_0 is Table)
            {
                foreach (TableRow row in (A_0 as Table).Rows)
                {
                    foreach (TableCell cell in row.Cells)
                    {
                        foreach (BodyRegion region2 in cell.Items)
                        {
                            this.method_6(region2);
                        }
                    }
                }
            }
            else if (A_0 is BookmarkStart)
            {
                Bookmark bookmark = base.Document.Bookmarks.FindByName((A_0 as BookmarkStart).Name);
                if (bookmark != null)
                {
                    if (bookmark.BookmarkStart != null)
                    {
                        bookmark.BookmarkStart.bool_9 = true;
                    }
                    if (bookmark.BookmarkEnd != null)
                    {
                        bookmark.BookmarkEnd.bool_9 = true;
                    }
                    base.Document.Bookmarks.InnerList.Remove(bookmark);
                }
            }
        }

        private void method_7(IDocumentObject A_0)
        {
            if (A_0 is Paragraph)
            {
                foreach (ParagraphBase base2 in (A_0 as Paragraph).Items)
                {
                    if (base2 is PermissionStart)
                    {
                        Permission permission2 = base.Document.Permissions.FindById((base2 as PermissionStart).Id);
                        if (permission2 != null)
                        {
                            if (permission2.PermissionStart != null)
                            {
                                permission2.PermissionStart.bool_8 = true;
                            }
                            if (permission2.PermissionEnd != null)
                            {
                                permission2.PermissionEnd.bool_8 = true;
                            }
                            base.Document.Permissions.InnerList.Remove(permission2);
                        }
                    }
                    else if (base2 is TextBox)
                    {
                        foreach (BodyRegion region in (base2 as TextBox).Body.Items)
                        {
                            this.method_7(region);
                        }
                    }
                }
            }
            else if (A_0 is Table)
            {
                foreach (TableRow row in (A_0 as Table).Rows)
                {
                    foreach (TableCell cell in row.Cells)
                    {
                        foreach (BodyRegion region2 in cell.Items)
                        {
                            this.method_7(region2);
                        }
                    }
                }
            }
            else if (A_0 is PermissionStart)
            {
                Permission permission = base.Document.Permissions.FindById((A_0 as PermissionStart).Id);
                if (permission != null)
                {
                    if (permission.PermissionStart != null)
                    {
                        permission.PermissionStart.bool_8 = true;
                    }
                    if (permission.PermissionEnd != null)
                    {
                        permission.PermissionEnd.bool_8 = true;
                    }
                    base.Document.Permissions.InnerList.Remove(permission);
                }
            }
        }

        internal DocumentObject method_8(DocumentObject A_0)
        {
            int index = this.IndexOf(A_0);
            if ((index >= 0) && (index <= (base.Count - 2)))
            {
                return this[index + 1];
            }
            return null;
        }

        internal DocumentObject method_9(DocumentObject A_0)
        {
            int index = this.IndexOf(A_0);
            if ((index >= 1) && (index <= (base.Count - 1)))
            {
                return this[index - 1];
            }
            return null;
        }

        protected virtual void OnClear()
        {
            int num = 0;
            int count = base.Count;
            while (num < count)
            {
                this[num].method_0(null);
                num++;
            }
            this.class54_0.method_2(ChangeItemsType.Clear, null);
        }

        protected virtual void OnInsert(int index, DocumentObject entity)
        {
            int num = 1;
            if (!this.method_13(entity))
            {
                throw new ArgumentException(string.Format(BookmarkStart.b("搦䠨䔪䌬䀮䔰ጲ尴夶䨸帺似䬾慀≂⭄杆♈⥊❌⩎㉐❒畔㡖㽘筚⥜♞ᅠ٢䕤ᱦ奨ᙪ䵬ٮὰݲᩴ坶൸፺᡼彾婢늂", num), entity.DocumentObjectType, this.Owner.DocumentObjectType));
            }
            if (this.Joined)
            {
                bool flag = entity.Owner == null;
                bool deepDetached = this.Owner.DeepDetached;
                Document document = entity.Document;
                if (base.Document != document)
                {
                    if (!flag)
                    {
                        throw new InvalidOperationException(BookmarkStart.b("縦䘨帪ബ䰮倰崲ᔴ夶嘸伺ᴼ帾╀❂敄⥆♈歊⹌⍎㹐㵒㭔㉖㵘筚㡜ㅞᕠ੢ᅤṦ䥨൪Ὤnᱰ卲ᩴͶᅸṺོ彾ﮎ", num));
                    }
                    entity.CloneRelationsTo(base.Document, this.Owner);
                }
                if (!flag)
                {
                    entity.RemoveSelf();
                }
                entity.method_0(this.Owner);
                if (((this.Owner is ShapeGroup) && (entity is ShapeObject)) && ((entity as ShapeObject).ShapeType == ShapeType.Image))
                {
                    (entity as ShapeObject).ImageData.method_0(this.Owner);
                }
            }
            this.class54_0.method_2(ChangeItemsType.Add, entity);
        }

        protected virtual void OnInsertComplete(int index, DocumentObject entity)
        {
            if (this.Joined)
            {
                if (!this.Owner.DeepDetached)
                {
                    entity.CloneCommit();
                    if (((entity is Section) && (entity.Document != null)) && !entity.Document.bool_3)
                    {
                        (entity as Section).method_28();
                    }
                }
                if ((entity is TextBox) && (this.Owner is Paragraph))
                {
                    (this.Owner as Paragraph).HasTextBox = true;
                }
            }
        }

        protected virtual void OnRemove(int index)
        {
            DocumentObject obj2 = this[index];
            obj2.method_0(null);
            this.class54_0.method_2(ChangeItemsType.Remove, obj2);
        }

        public void Remove(IDocumentObject entity)
        {
            this.method_6(entity);
            this.method_7(entity);
            this.OnRemove(this.IndexOf(entity));
            base.InnerList.Remove(entity);
        }

        public void RemoveAt(int index)
        {
            this.method_6(base.InnerList[index] as IDocumentObject);
            this.method_7(base.InnerList[index] as IDocumentObject);
            this.OnRemove(index);
            base.InnerList.RemoveAt(index);
        }

        public DocumentObject FirstItem
        {
            get
            {
                if (base.Count <= 0)
                {
                    return null;
                }
                return this[0];
            }
        }

        public DocumentObject this[int index]
        {
            get
            {
                return (base.InnerList[index] as DocumentObject);
            }
        }

        internal bool Joined
        {
            get
            {
                return (base.OwnerBase != null);
            }
        }

        public DocumentObject LastItem
        {
            get
            {
                if (base.Count <= 0)
                {
                    return null;
                }
                return this[base.Count - 1];
            }
        }

        internal DocumentObject Owner
        {
            get
            {
                return (DocumentObject) base.OwnerBase;
            }
        }

        protected abstract Type[] TypesOfElement { get; }

        public delegate void ChangeItems(DocumentObjectCollection.ChangeItemsType type, DocumentObject entity);

        public enum ChangeItemsType
        {
            Add,
            Remove,
            Clear
        }

        internal class Class54 : IEnumerable
        {
            private List<DocumentObjectCollection.ChangeItems> list_0 = new List<DocumentObjectCollection.ChangeItems>();

            public void method_0(DocumentObjectCollection.ChangeItems A_0)
            {
                int num = 13;
                if (this.list_0.Contains(A_0))
                {
                    throw new ArgumentException(BookmarkStart.b("嬲吴夶崸场堼䴾慀≂⥄㕆ⱈ⩊⥌㙎煐㙒ⵔ㹖⩘⽚⹜", num));
                }
                this.list_0.Add(A_0);
            }

            public void method_1(DocumentObjectCollection.ChangeItems A_0)
            {
                int num = 11;
                if (!this.list_0.Contains(A_0))
                {
                    throw new ArgumentException(BookmarkStart.b("夰刲嬴匶唸帺似Ἶ⽀ⱂㅄ杆ⱈ㍊⑌㱎═⁒", num));
                }
                this.list_0.Remove(A_0);
            }

            public void method_2(DocumentObjectCollection.ChangeItemsType A_0, DocumentObject A_1)
            {
                foreach (DocumentObjectCollection.ChangeItems items in this.list_0)
                {
                    items.DynamicInvoke(new object[] { A_0, A_1 });
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.list_0.GetEnumerator();
            }
        }
    }
}

