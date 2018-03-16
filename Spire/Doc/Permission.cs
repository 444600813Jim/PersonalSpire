namespace Spire.Doc
{
    using Spire.Doc.Documents;
    using System;

    public class Permission
    {
        private bool[] bool_0;
        private float[] float_0;
        private Spire.Doc.PermissionEnd permissionEnd_0;
        private Spire.Doc.PermissionStart permissionStart_0;

        public Permission(Spire.Doc.PermissionStart start) : this(start, null)
        {
        }

        public Permission(Spire.Doc.PermissionStart start, Spire.Doc.PermissionEnd end)
        {
            this.permissionStart_0 = start;
            this.permissionEnd_0 = end;
        }

        internal void method_0(Spire.Doc.PermissionStart A_0)
        {
            this.permissionStart_0 = A_0;
        }

        internal void method_1(Spire.Doc.PermissionEnd A_0)
        {
            this.permissionEnd_0 = A_0;
        }

        internal void method_2(string A_0)
        {
            if (!string.IsNullOrEmpty(A_0))
            {
                if (this.permissionStart_0 != null)
                {
                    this.permissionStart_0.method_30(A_0);
                }
                if (this.permissionEnd_0 != null)
                {
                    this.permissionEnd_0.method_30(A_0);
                }
            }
        }

        internal Spire.Doc.Documents.DisplacedByCustomXml DisplacedByCustomXml
        {
            get
            {
                return this.permissionStart_0.DisplacedByCustomXml;
            }
        }

        internal string Editor
        {
            get
            {
                return this.permissionStart_0.Editor;
            }
        }

        public EditingGroup EditorGroup
        {
            get
            {
                return this.permissionStart_0.EditorGroup;
            }
        }

        public string Id
        {
            get
            {
                return this.permissionStart_0.Id;
            }
        }

        public Spire.Doc.PermissionEnd PermissionEnd
        {
            get
            {
                return this.permissionEnd_0;
            }
        }

        public Spire.Doc.PermissionStart PermissionStart
        {
            get
            {
                return this.permissionStart_0;
            }
        }
    }
}

