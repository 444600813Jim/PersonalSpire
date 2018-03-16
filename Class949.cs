using Spire.Doc.Reporting;
using System;
using System.Collections.Generic;
using System.Data;

internal class Class949 : IRowsEnumerator
{
    private IDataReader idataReader_0;
    private int int_0 = -1;
    private List<List<string>> list_0;
    private string[] string_0;

    public Class949(IDataReader A_0)
    {
        this.idataReader_0 = A_0;
        this.list_0 = new List<List<string>>();
        this.string_0 = new string[this.idataReader_0.FieldCount];
        for (int i = 0; i < this.idataReader_0.FieldCount; i++)
        {
            this.string_0[i] = this.idataReader_0.GetName(i);
        }
        while (this.idataReader_0.Read())
        {
            List<string> item = new List<string>();
            for (int j = 0; j < this.idataReader_0.FieldCount; j++)
            {
                item.Add(this.idataReader_0[j].ToString());
            }
            this.list_0.Add(item);
        }
    }

    protected List<string> method_0()
    {
        if (this.int_0 >= this.Spire.Doc.Reporting.IRowsEnumerator.get_RowsCount())
        {
            return null;
        }
        if (this.list_0 == null)
        {
            return null;
        }
        return this.list_0[this.int_0];
    }

    object IRowsEnumerator.GetCellValue(string A_0)
    {
        List<string> list = this.method_0();
        if (list == null)
        {
            return null;
        }
        return list[this.idataReader_0.GetOrdinal(A_0)];
    }

    bool IRowsEnumerator.NextRow()
    {
        if (this.int_0 < this.Spire.Doc.Reporting.IRowsEnumerator.get_RowsCount())
        {
            this.int_0++;
        }
        return !this.Spire.Doc.Reporting.IRowsEnumerator.get_IsEnd();
    }

    void IRowsEnumerator.Reset()
    {
        this.int_0 = -1;
    }

    string[] IRowsEnumerator.ColumnNames
    {
        get
        {
            return this.string_0;
        }
    }

    int IRowsEnumerator.CurrentRowIndex
    {
        get
        {
            return this.int_0;
        }
    }

    bool IRowsEnumerator.IsEnd
    {
        get
        {
            return (this.int_0 >= this.Spire.Doc.Reporting.IRowsEnumerator.get_RowsCount());
        }
    }

    bool IRowsEnumerator.IsLast
    {
        get
        {
            return (this.int_0 >= (this.Spire.Doc.Reporting.IRowsEnumerator.get_RowsCount() - 1));
        }
    }

    int IRowsEnumerator.RowsCount
    {
        get
        {
            return this.list_0.Count;
        }
    }

    string IRowsEnumerator.TableName
    {
        get
        {
            return this.idataReader_0.GetSchemaTable().TableName;
        }
    }
}

