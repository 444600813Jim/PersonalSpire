namespace Spire.Doc
{
    using Spire.Doc.Collections;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Text;

    public class VariableCollection : IEnumerable
    {
        private bool bool_0;
        private bool bool_1;
        private bool bool_2;
        private bool bool_3;
        private Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();
        private int[] int_0;
        private long long_0;

        public void Add(string name, string value)
        {
            if (value == null)
            {
                value = string.Empty;
            }
            this.dictionary_0.Add(name, value);
        }

        public IEnumerator GetEnumerator()
        {
            return this.dictionary_0.GetEnumerator();
        }

        public string GetNameByIndex(int index)
        {
            this.method_3(index);
            return this.method_2(index, true);
        }

        public string GetValueByIndex(int index)
        {
            this.method_3(index);
            return this.method_2(index, false);
        }

        internal void method_0(byte[] A_0)
        {
            MemoryStream input = new MemoryStream(A_0);
            BinaryReader reader = new BinaryReader(input, Encoding.Unicode);
            reader.ReadInt16();
            int num = reader.ReadInt16();
            reader.ReadInt16();
            int count = 0;
            string[] strArray = new string[num];
            for (int i = 0; i < num; i++)
            {
                count = reader.ReadUInt16();
                char[] chArray2 = reader.ReadChars(count);
                strArray[i] = new string(chArray2);
                reader.ReadInt32();
            }
            for (int j = 0; j < num; j++)
            {
                count = reader.ReadInt16();
                char[] chArray = reader.ReadChars(count);
                this.dictionary_0.Add(strArray[j], new string(chArray));
            }
        }

        internal byte[] method_1()
        {
            if (this.dictionary_0.Count == 0)
            {
                return null;
            }
            MemoryStream output = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(output, Encoding.Unicode);
            string[] strArray2 = new string[this.dictionary_0.Count];
            string[] strArray = new string[this.dictionary_0.Count];
            int index = 0;
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
            foreach (string str in this.dictionary_0.Keys)
            {
                dictionary.Add(str, this.dictionary_0[str]);
            }
            foreach (string str2 in dictionary.Keys)
            {
                strArray2[index] = str2;
                strArray[index] = dictionary[str2];
                index++;
            }
            writer.Write((byte) 0xff);
            writer.Write((byte) 0xff);
            short count = (short) this.dictionary_0.Count;
            writer.Write(count);
            writer.Write((short) 4);
            for (int i = 0; i < count; i++)
            {
                writer.Write((short) strArray2[i].Length);
                writer.Write(strArray2[i].ToCharArray());
                writer.Write(0x7fffffff);
            }
            for (int j = 0; j < count; j++)
            {
                writer.Write((short) strArray[j].Length);
                writer.Write(strArray[j].ToCharArray());
            }
            return output.ToArray();
        }

        private string method_2(int A_0, bool A_1)
        {
            IDictionaryEnumerator enumerator = this.dictionary_0.GetEnumerator();
            for (int i = 0; i <= A_0; i++)
            {
                enumerator.MoveNext();
            }
            return (A_1 ? ((string) enumerator.Entry.Key) : ((string) enumerator.Entry.Value));
        }

        private void method_3(int A_0)
        {
            int num = 6;
            if ((A_0 < 0) || (A_0 >= this.dictionary_0.Count))
            {
                throw new ArgumentOutOfRangeException(BookmarkStart.b("䔫䀭启圱䰳", num), BookmarkStart.b("攫䀭启圱䰳ᘵ唷伹伻䨽怿⁁⅃晅⑇⭉㹋⥍㕏⁑瑓≕し㭙㉛繝偟䉡գࡥ౧䩩kŭݯ᝱ٳ噵౷ቹᵻၽꁿﺋ꺍ﾏ뒓聯ﾝ슟캡솣향袧쎩슫躭쒯\udab1\ud1b3隵\udcb7\ud5b9\udfbb\ucbbd궿ꟁ꫃닅", num));
            }
        }

        public void Remove(string name)
        {
            this.dictionary_0.Remove(name);
        }

        public int Count
        {
            get
            {
                return this.dictionary_0.Count;
            }
        }

        public string this[string name]
        {
            get
            {
                if (this.dictionary_0.ContainsKey(name))
                {
                    return this.dictionary_0[name];
                }
                return null;
            }
            set
            {
                this.dictionary_0[name] = value;
            }
        }

        internal Dictionary<string, string> Items
        {
            get
            {
                return this.dictionary_0;
            }
        }
    }
}

