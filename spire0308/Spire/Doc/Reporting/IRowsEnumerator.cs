namespace Spire.Doc.Reporting
{
    using System;

    public interface IRowsEnumerator
    {
        object GetCellValue(string columnName);
        bool NextRow();
        void Reset();

        string[] ColumnNames { get; }

        int CurrentRowIndex { get; }

        bool IsEnd { get; }

        bool IsLast { get; }

        int RowsCount { get; }

        string TableName { get; }
    }
}

