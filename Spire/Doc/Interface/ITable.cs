namespace Spire.Doc.Interface
{
    using Spire.Doc;
    using Spire.Doc.Collections;
    using Spire.Doc.Formatting;
    using System;
    using System.Reflection;

    public interface ITable : ICompositeObject
    {
        TableRow AddRow();
        TableRow AddRow(bool isCopyFormat);
        TableRow AddRow(bool isCopyFormat, bool autoPopulateCells);
        void ApplyHorizontalMerge(int rowIndex, int startCellIndex, int endCellIndex);
        void ApplyVerticalMerge(int columnIndex, int startRowIndex, int endRowIndex);
        void RemoveAbsPosition();
        void ResetCells(int rowsNum, int columnsNum);
        void ResetCells(int rowsNum, int columnsNum, RowFormat format, float cellWidth);

        TableRow FirstRow { get; }

        float IndentFromLeft { get; set; }

        TableCell this[int row, int column] { get; }

        TableCell LastCell { get; }

        TableRow LastRow { get; }

        RowCollection Rows { get; }

        RowFormat TableFormat { get; }

        float Width { get; }
    }
}

