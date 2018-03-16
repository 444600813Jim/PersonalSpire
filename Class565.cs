using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

internal class Class565
{
    private static readonly Dictionary<ShapeType, Class43> dictionary_0 = new Dictionary<ShapeType, Class43>();
    private static volatile IDictionary idictionary_0;
    private static readonly object object_0 = new object();
    private static readonly object object_1 = new object();

    private Class565()
    {
    }

    internal static string smethod_0(ShapeType A_0)
    {
        return (string) smethod_4()[A_0];
    }

    internal static Class43 smethod_1(ShapeType A_0)
    {
        Class43 class2 = null;
        lock (object_1)
        {
            if (dictionary_0.ContainsKey(A_0))
            {
                class2 = dictionary_0[A_0];
            }
        }
        if (class2 == null)
        {
            lock (object_1)
            {
                if (dictionary_0.ContainsKey(A_0))
                {
                    return dictionary_0[A_0];
                }
                dictionary_0[A_0] = null;
                string str = smethod_0(A_0);
                if (Class567.smethod_16(str))
                {
                    class2 = Class964.smethod_3(new Class466(str));
                    dictionary_0[A_0] = class2;
                }
            }
        }
        return class2;
    }

    public static string smethod_2(string A_0)
    {
        byte[] bytes = Convert.FromBase64String(A_0);
        return Encoding.ASCII.GetString(bytes);
    }

    private static IDictionary smethod_3()
    {
        IDictionary dictionary2;
        int num = 0;
        using (Stream stream = Class1040.smethod_0(BookmarkStart.b("甥堧䌩師䬭ḯ瘱嬳唵ᘷ根夻䴽⼿㝁㙃╅ⵇ㥉手㵍㡏㍑⑓㍕⡗⡙㥛ⵝ՟ᙡᝣ", 0)))
        {
            string s = string.Empty;
            using (StreamReader reader = new StreamReader(stream))
            {
                s = smethod_2(BookmarkStart.b("瘥性猩", num) + reader.ReadToEnd());
            }
            using (TextReader reader2 = new StringReader(s))
            {
                string str2;
                Dictionary<ShapeType, string> dictionary = new Dictionary<ShapeType, string>();
                for (int i = -2; (str2 = reader2.ReadLine()) != null; i++)
                {
                    dictionary.Add((ShapeType) i, str2);
                }
                dictionary2 = dictionary;
            }
        }
        return dictionary2;
    }

    private static IDictionary smethod_4()
    {
        if (idictionary_0 == null)
        {
            lock (object_0)
            {
                if (idictionary_0 == null)
                {
                    idictionary_0 = smethod_3();
                }
            }
        }
        return idictionary_0;
    }
}

