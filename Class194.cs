using Spire.Doc.Reporting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

internal class Class194 : IRowsEnumerator
{
    private DataRow dataRow_0;
    private DataTable dataTable_0;
    private IEnumerator ienumerator_0;
    private int int_0;
    private int int_1;
    private string[] string_0;
    private string string_1;
    private Type type_0;

    public Class194(MailMergeDataTable A_0)
    {
        this.int_0 = -1;
        this.string_1 = A_0.GroupName;
        A_0.SourceData.Reset();
        A_0.SourceData.MoveNext();
        this.ienumerator_0 = A_0.SourceData;
        try
        {
            this.type_0 = this.ienumerator_0.Current.GetType();
            this.method_2(this.ienumerator_0);
        }
        catch
        {
            this.type_0 = null;
            this.string_0 = null;
        }
        this.method_3();
    }

    public Class194(DataRow A_0)
    {
        this.int_0 = -1;
        this.dataRow_0 = A_0;
        this.method_1(A_0.Table);
    }

    public Class194(DataTable A_0)
    {
        this.int_0 = -1;
        this.dataTable_0 = A_0;
        this.method_1(this.dataTable_0);
    }

    protected object method_0()
    {
        if (this.int_0 >= this.Spire.Doc.Reporting.IRowsEnumerator.get_RowsCount())
        {
            return null;
        }
        if (this.ienumerator_0 != null)
        {
            this.ienumerator_0.Reset();
            for (int i = 0; i <= this.int_0; i++)
            {
                this.ienumerator_0.MoveNext();
            }
            return this.ienumerator_0.Current;
        }
        if (this.dataTable_0 != null)
        {
            return this.dataTable_0.Rows[this.int_0];
        }
        return this.dataRow_0;
    }

    private void method_1(DataTable A_0)
    {
        this.string_0 = new string[A_0.Columns.Count];
        for (int i = 0; i < this.string_0.Length; i++)
        {
            this.string_0[i] = A_0.Columns[i].ColumnName;
        }
    }

    private void method_2(IEnumerator A_0)
    {
        List<string> list = new List<string>();
        PropertyInfo[] properties = this.type_0.GetProperties();
        int index = 0;
        int length = properties.Length;
        while (index < length)
        {
            list.Add(properties[index].Name);
            index++;
        }
        this.string_0 = list.ToArray();
    }

    private void method_3()
    {
        this.ienumerator_0.Reset();
        while (this.ienumerator_0.MoveNext())
        {
            this.int_1++;
        }
        this.ienumerator_0.Reset();
    }

    object IRowsEnumerator.GetCellValue(string A_0)
    {
        if (this.method_0() is DataRow)
        {
            return (this.method_0() as DataRow)[A_0];
        }
        if (this.method_0() != null)
        {
            PropertyInfo[] properties = this.type_0.GetProperties();
            int index = 0;
            int length = properties.Length;
            while (index < length)
            {
                PropertyInfo info = properties[index];
                if (info.Name == A_0)
                {
                    return info.GetValue(this.method_0(), null);
                }
                index++;
            }
        }
        return null;
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
            if (this.dataTable_0 != null)
            {
                return this.dataTable_0.Rows.Count;
            }
            if (((this.int_1 == 0) && (this.dataRow_0 != null)) && ((this.dataRow_0.ItemArray != null) && (this.dataRow_0.ItemArray.Length > 0)))
            {
                return 1;
            }
            return this.int_1;
        }
    }

    string IRowsEnumerator.TableName
    {
        get
        {
            if (this.dataTable_0 != null)
            {
                return this.dataTable_0.TableName;
            }
            return this.string_1;
        }
    }
}

