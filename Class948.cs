using Spire.Doc.Reporting;
using System;
using System.Data;

internal class Class948 : IRowsEnumerator
{
    private DataRow dataRow_0;
    private DataTable dataTable_0;
    private DataView dataView_0;
    private int int_0 = -1;
    private string[] string_0;

    public Class948(DataView A_0)
    {
        this.dataView_0 = A_0;
        this.dataTable_0 = A_0.Table;
        this.method_1(this.dataTable_0);
    }

    protected DataRow method_0()
    {
        if (this.int_0 >= this.Spire.Doc.Reporting.IRowsEnumerator.get_RowsCount())
        {
            return null;
        }
        if (this.dataView_0 == null)
        {
            return this.dataRow_0;
        }
        return this.dataView_0[this.int_0].Row;
    }

    private void method_1(DataTable A_0)
    {
        this.string_0 = new string[A_0.Columns.Count];
        for (int i = 0; i < this.string_0.Length; i++)
        {
            this.string_0[i] = this.dataTable_0.Columns[i].ColumnName;
        }
    }

    object IRowsEnumerator.GetCellValue(string A_0)
    {
        DataRow row = this.method_0();
        if (row == null)
        {
            return null;
        }
        return row[A_0];
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
            if (this.dataView_0 == null)
            {
                return 1;
            }
            return this.dataView_0.Count;
        }
    }

    string IRowsEnumerator.TableName
    {
        get
        {
            if (this.dataView_0 == null)
            {
                return "";
            }
            return this.dataView_0.Table.TableName;
        }
    }
}

