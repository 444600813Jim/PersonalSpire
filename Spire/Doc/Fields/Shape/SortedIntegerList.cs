namespace Spire.Doc.Fields.Shape
{
    using Spire.Doc;
    using System;
    using System.Diagnostics;
    using System.Reflection;

    [DebuggerStepThrough]
    public class SortedIntegerList
    {
        private byte byte_0;
        private const int int_0 = 0x10;
        private int[] int_1;
        private int int_2;
        private long long_0;
        private object[] object_0;

        public SortedIntegerList()
        {
            this.int_1 = new int[0x10];
            this.object_0 = new object[0x10];
        }

        public SortedIntegerList(int initialCapacity)
        {
            int num = 0x12;
            if (initialCapacity < 0)
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("儷吹唻䨽⤿⍁⡃Յ⥇㩉ⵋⵍ㥏♑ⵓ", num));
            }
            this.int_1 = new int[initialCapacity];
            this.object_0 = new object[initialCapacity];
        }

        public void Add(int key, object value)
        {
            int num2 = 2;
            int num = BinarySearch(this.int_1, 0, this.int_2, key);
            if (num >= 0)
            {
                throw new ArgumentException(BookmarkStart.b("䰧弩尫䈭夯儱唳䈵崷", num2));
            }
            this.method_1(~num, key, value);
        }

        public static int BinarySearch(int[] array, int index, int length, int value)
        {
            int num = index;
            int num2 = (index + length) - 1;
            while (num <= num2)
            {
                int num3 = (num + num2) >> 1;
                int num4 = array[num3];
                if (num4 == value)
                {
                    return num3;
                }
                if (num4 < value)
                {
                    num = num3 + 1;
                }
                else
                {
                    num2 = num3 - 1;
                }
            }
            return ~num;
        }

        public void Clear()
        {
            this.int_2 = 0;
            this.int_1 = new int[0x10];
            this.object_0 = new object[0x10];
        }

        public bool Contains(int key)
        {
            return (this.IndexOfKey(key) >= 0);
        }

        public bool ContainsKey(int key)
        {
            return (this.IndexOfKey(key) >= 0);
        }

        public bool ContainsValue(object value)
        {
            return (this.IndexOfValue(value) >= 0);
        }

        protected SortedIntegerList CreateEmptyCopy()
        {
            SortedIntegerList list = (SortedIntegerList) base.MemberwiseClone();
            list.int_2 = 0;
            list.int_1 = new int[this.int_1.Length];
            list.object_0 = new object[this.object_0.Length];
            return list;
        }

        public object GetByIndex(int index)
        {
            int num = 11;
            if ((index < 0) || (index >= this.int_2))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("堰崲儴制䄸", num));
            }
            return this.object_0[index];
        }

        public int GetKey(int index)
        {
            int num = 3;
            if ((index < 0) || (index >= this.int_2))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䀨䔪䤬䨮䤰", num));
            }
            return this.int_1[index];
        }

        public int IndexOfKey(int key)
        {
            int num = Class85.smethod_7(this.int_1, 0, this.int_2, key);
            if (num < 0)
            {
                return -1;
            }
            return num;
        }

        public int IndexOfValue(object value)
        {
            return Array.IndexOf<object>(this.object_0, value, 0, this.int_2);
        }

        private void method_0(int A_0)
        {
            int num = (this.int_1.Length == 0) ? 0x10 : (this.int_1.Length * 2);
            if (num < A_0)
            {
                num = A_0;
            }
            this.Capacity = num;
        }

        private void method_1(int A_0, int A_1, object A_2)
        {
            if (this.int_2 == this.int_1.Length)
            {
                this.method_0(this.int_2 + 1);
            }
            if (A_0 < this.int_2)
            {
                Array.Copy(this.int_1, A_0, this.int_1, A_0 + 1, this.int_2 - A_0);
                Array.Copy(this.object_0, A_0, this.object_0, A_0 + 1, this.int_2 - A_0);
            }
            this.int_1[A_0] = A_1;
            this.object_0[A_0] = A_2;
            this.int_2++;
        }

        public void Remove(int key)
        {
            int index = this.IndexOfKey(key);
            if (index >= 0)
            {
                this.RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            int num = 13;
            if ((index < 0) || (index >= this.int_2))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("娲嬴匶尸䌺", num));
            }
            this.int_2--;
            if (index < this.int_2)
            {
                Array.Copy(this.int_1, index + 1, this.int_1, index, this.int_2 - index);
                Array.Copy(this.object_0, index + 1, this.object_0, index, this.int_2 - index);
            }
            this.int_1[this.int_2] = 0;
            this.object_0[this.int_2] = null;
        }

        public void SetByIndex(int index, object value)
        {
            int num = 2;
            if ((index < 0) || (index >= this.int_2))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䄧䐩䠫䬭䠯", num));
            }
            this.object_0[index] = value;
        }

        public void TrimToSize()
        {
            this.Capacity = this.int_2;
        }

        public int Capacity
        {
            get
            {
                return this.int_1.Length;
            }
            set
            {
                int num = 0x13;
                if (value != this.int_1.Length)
                {
                    if (value < this.int_2)
                    {
                        throw new ArgumentOutOfRangeException(BookmarkStart.b("伸娺儼䨾⑀", num));
                    }
                    if (value > 0)
                    {
                        int[] destinationArray = new int[value];
                        object[] objArray = new object[value];
                        if (this.int_2 > 0)
                        {
                            Array.Copy(this.int_1, 0, destinationArray, 0, this.int_2);
                            Array.Copy(this.object_0, 0, objArray, 0, this.int_2);
                        }
                        this.int_1 = destinationArray;
                        this.object_0 = objArray;
                    }
                    else
                    {
                        this.int_1 = new int[0x10];
                        this.object_0 = new object[0x10];
                    }
                }
            }
        }

        public int Count
        {
            get
            {
                return this.int_2;
            }
        }

        public object this[int key]
        {
            get
            {
                int index = this.IndexOfKey(key);
                if (index < 0)
                {
                    return null;
                }
                return this.object_0[index];
            }
            set
            {
                int index = Class85.smethod_7(this.int_1, 0, this.int_2, key);
                if (index >= 0)
                {
                    this.object_0[index] = value;
                }
                else
                {
                    this.method_1(~index, key, value);
                }
            }
        }
    }
}

