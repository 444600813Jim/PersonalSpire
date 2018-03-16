namespace Spire.Doc.Formatting
{
    using Spire.Doc;
    using Spire.Doc.Interface;
    using System;
    using System.Diagnostics;

    public abstract class AttrCollection : FormatBase
    {
        internal AttrCollection()
        {
        }

        public AttrCollection(IDocument doc) : base(doc)
        {
        }

        public AttrCollection(FormatBase parent, int baseKey) : base(parent, baseKey)
        {
        }

        public AttrCollection(IDocument doc, DocumentObject owner) : base(doc, owner)
        {
        }

        internal virtual void ClearAttrs()
        {
            base.ClearFormatting();
        }

        internal virtual AttrCollection Clone()
        {
            return (base.CloneImpl() as AttrCollection);
        }

        internal override bool HasValue(int propertyKey)
        {
            return base.HasValue(propertyKey);
        }

        internal object method_31(int A_0)
        {
            if ((((A_0 == 0x271a) || (A_0 == 12)) || (A_0 == 14)) && !base.HasKey(A_0))
            {
                return null;
            }
            return base.method_5(A_0);
        }

        internal object method_32(int A_0)
        {
            object obj2 = this.method_31(A_0);
            if (obj2 == null)
            {
                return this.method_33(A_0);
            }
            return obj2;
        }

        internal object method_33(int A_0)
        {
            return this.GetDefValue(A_0);
        }

        internal void method_34(int A_0, string A_1)
        {
            if (Class567.smethod_16(A_1))
            {
                this.SetAttr(A_0, A_1);
            }
        }

        internal void method_35(int A_0, AttrCollection A_1)
        {
            object obj2 = this.method_31(A_0);
            if (obj2 != null)
            {
                this.Remove(A_0);
                A_1.SetAttr(A_0, obj2);
            }
        }

        internal void method_36(int A_0, AttrCollection A_1)
        {
            object obj2 = this.method_31(A_0);
            if (obj2 != null)
            {
                A_1.SetAttr(A_0, obj2);
            }
            else
            {
                A_1.Remove(A_0);
            }
        }

        internal void method_37(AttrCollection A_0)
        {
            this.method_39(A_0, null);
        }

        internal void method_38(AttrCollection A_0, bool A_1)
        {
            this.method_37(A_0);
        }

        internal void method_39(AttrCollection A_0, Interface26 A_1)
        {
            int num = 2;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䰧天堫漭䐯䘱䘳䔵", num));
            }
            for (int i = 0; i < base.Count; i++)
            {
                int num3 = base.method_18(i);
                object obj2 = base.method_19(i);
                this.method_40(A_0, num3, obj2, A_1);
            }
        }

        private void method_40(AttrCollection A_0, int A_1, object A_2, Interface26 A_3)
        {
            object obj2;
            if (A_2 is Interface31)
            {
                Interface31 interface2 = (Interface31) A_2;
                if (interface2.imethod_0())
                {
                    return;
                }
                if (interface2 is Interface33)
                {
                    Interface33 interface3 = (Interface33) A_0[A_1];
                    obj2 = ((Interface33) interface2).imethod_2(interface3);
                }
                else
                {
                    obj2 = interface2.imethod_1();
                }
            }
            else if (A_2 is Class650)
            {
                obj2 = ((Class650) A_2).method_3(A_0, A_1);
            }
            else
            {
                obj2 = A_2;
            }
            if (A_3 != null)
            {
                A_3.imethod_0(A_0, A_1, obj2);
            }
            else
            {
                A_0[A_1] = obj2;
            }
        }

        internal void method_41(AttrCollection A_0, params int[] A_1)
        {
            int num = 2;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䰧天堫漭䐯䘱䘳䔵", num));
            }
            if (A_1 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("䌧伩唫崭", num));
            }
            foreach (int num3 in A_1)
            {
                object obj2 = base[num3];
                if (obj2 != null)
                {
                    this.method_40(A_0, num3, obj2, null);
                }
            }
        }

        internal void method_42(AttrCollection A_0)
        {
            this.method_43(A_0, -1);
        }

        internal void method_43(AttrCollection A_0, int A_1)
        {
            int num = 0x10;
            if (A_0 == null)
            {
                throw new ArgumentNullException(BookmarkStart.b("吵夷䤹夻缽㐿㙁㙃㕅", num));
            }
            for (int i = 0; i < A_0.Count; i++)
            {
                int num3 = A_0.method_18(i);
                if (num3 != A_1)
                {
                    int num4 = base.method_17(num3);
                    if (num4 >= 0)
                    {
                        object obj3 = A_0.method_19(i);
                        object obj2 = base.method_19(num4);
                        if (obj3.Equals(obj2))
                        {
                            base.method_11(num4);
                        }
                        else
                        {
                            smethod_2(obj2, obj3);
                        }
                    }
                    else
                    {
                        object obj4 = this.method_33(num3);
                        if (obj4 is Interface31)
                        {
                            obj4 = ((Interface31) obj4).imethod_1();
                            object obj5 = A_0.method_19(i);
                            smethod_2(obj4, obj5);
                        }
                        base[num3] = obj4;
                    }
                }
            }
        }

        internal bool method_44(AttrCollection A_0, int[] A_1)
        {
            return smethod_0(this, A_0, A_1);
        }

        internal bool method_45(int[] A_0)
        {
            for (int i = 0; i < base.Count; i++)
            {
                int num2 = base.method_18(i);
                if (Class85.smethod_7(A_0, 0, A_0.Length, num2) < 0)
                {
                    object obj2 = base.method_19(i);
                    if (!(obj2 is Interface31) || !((Interface31) obj2).imethod_0())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected void SetAttr(int key, object value, bool isNonDefault)
        {
            if (isNonDefault)
            {
                this.SetAttr(key, value);
            }
            else
            {
                this.Remove(key);
            }
        }

        internal static bool smethod_0(AttrCollection A_0, AttrCollection A_1, int[] A_2)
        {
            // This item is obfuscated and can not be translated.
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            while (true)
            {
                bool flag;
                bool flag2;
                bool flag4 = smethod_1(A_0, ref num, ref num3, A_2);
                bool flag3 = smethod_1(A_1, ref num2, ref num4, A_2);
                if (!flag4)
                {
                }
                if (!(flag = (flag2 = false) ? ((num3 == num4) && A_0.method_19(num++).Equals(A_1.method_19(num2++))) : (!flag4 && !flag3)) || !flag2)
                {
                    return flag;
                }
            }
        }

        private static bool smethod_1(AttrCollection A_0, ref int A_1, ref int A_2, int[] A_3)
        {
            int count = A_0.Count;
            int num2 = (A_3 != null) ? A_3.Length : 0;
            while (A_1 < count)
            {
                A_2 = A_0.method_18(A_1);
                if ((A_3 == null) || (Class85.smethod_7(A_3, 0, num2, A_2) < 0))
                {
                    return true;
                }
                A_1++;
            }
            return false;
        }

        private static void smethod_2(object A_0, object A_1)
        {
            if (A_0 is Interface33)
            {
                ((Interface33) A_0).imethod_3((Interface33) A_1);
            }
        }

        [Conditional("SPR_DEBUG")]
        internal static void smethod_3(params object[] A_0)
        {
        }

        [Conditional("SPR_DEBUG")]
        internal static void smethod_4(params object[] A_0)
        {
        }
    }
}

