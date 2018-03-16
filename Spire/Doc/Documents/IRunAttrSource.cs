namespace Spire.Doc.Documents
{
    using System;
    using System.Runtime.InteropServices;

    public interface IRunAttrSource
    {
        void ClearRunAttrs();
        object FetchInheritedRunAttr(int key);
        object GetDirectRunAttr(int key);
        void GetDirectRunAttrByIndex(int index, out int key, out object value);
        void SetRunAttr(int key, object value);

        int DirectRunAttrsCount { get; }
    }
}

