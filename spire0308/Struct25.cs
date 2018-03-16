using Spire.Doc.Converters;
using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct Struct25
{
    internal bool bool_0;
    internal int int_0;
    internal int int_1;
    internal PrepareTableState prepareTableState_0;
    internal Struct25(bool A_0, int A_1, int A_2)
    {
        this.bool_0 = A_0;
        this.int_1 = A_2;
        this.int_0 = A_1;
        if (this.int_0 > this.int_1)
        {
            this.prepareTableState_0 = PrepareTableState.EnterTable;
        }
        else if (this.int_0 < this.int_1)
        {
            this.prepareTableState_0 = PrepareTableState.LeaveTable;
        }
        else
        {
            this.prepareTableState_0 = PrepareTableState.NoChange;
        }
    }

    internal Struct25(bool A_0, int A_1, int A_2, bool A_3)
    {
        this.bool_0 = A_0;
        this.int_1 = A_2;
        this.int_0 = A_1;
        if (this.int_0 > this.int_1)
        {
            this.prepareTableState_0 = PrepareTableState.EnterTable;
        }
        else if (this.int_0 < this.int_1)
        {
            this.prepareTableState_0 = PrepareTableState.LeaveTable;
        }
        else if ((A_0 && A_3) && (this.int_0 == this.int_1))
        {
            this.prepareTableState_0 = PrepareTableState.LeaveTable;
            this.int_0 = 0;
        }
        else
        {
            this.prepareTableState_0 = PrepareTableState.NoChange;
        }
    }
}

