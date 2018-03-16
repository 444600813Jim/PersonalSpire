namespace Spire.Doc.Collections
{
    using Spire.Doc;
    using System;
    using System.Reflection;

    public class PermissionCollection : CollectionEx
    {
        internal PermissionCollection(Document A_0) : base(A_0, A_0)
        {
        }

        public void Clear()
        {
            while (base.InnerList.Count > 0)
            {
                int index = base.InnerList.Count - 1;
                this.RemoveAt(index);
            }
        }

        public Permission FindById(string id)
        {
            id.Replace('-', '_');
            for (int i = 0; i < base.InnerList.Count; i++)
            {
                Permission permission = base.InnerList[i] as Permission;
                if (permission.Id.Equals(id, StringComparison.CurrentCultureIgnoreCase))
                {
                    return permission;
                }
            }
            return null;
        }

        internal void method_5(Permission A_0)
        {
            base.InnerList.Add(A_0);
        }

        internal void method_6(PermissionStart A_0)
        {
            int num = 2;
            if (this[A_0.Id] != null)
            {
                A_0.method_30(A_0.Id + BookmarkStart.b("眧", num) + Guid.NewGuid().ToString());
                A_0.RemoveSelf();
            }
            else
            {
                Permission permission = new Permission(A_0);
                this.method_5(permission);
            }
        }

        internal void method_7(PermissionEnd A_0)
        {
            Permission permission = this[A_0.Id];
            if (permission != null)
            {
                if (permission.PermissionEnd != null)
                {
                    A_0.RemoveSelf();
                }
                else
                {
                    permission.method_1(A_0);
                }
            }
        }

        internal void method_8(string A_0, string A_1)
        {
            if (!string.IsNullOrEmpty(A_1))
            {
                Permission permission = this.FindById(A_0);
                if (permission != null)
                {
                    permission.method_2(A_1);
                }
            }
        }

        public void Remove(Permission permission)
        {
            base.InnerList.Remove(permission);
            PermissionStart permissionStart = permission.PermissionStart;
            PermissionEnd permissionEnd = permission.PermissionEnd;
            if (permissionStart != null)
            {
                permissionStart.RemoveSelf();
            }
            if (permissionEnd != null)
            {
                permissionEnd.RemoveSelf();
            }
        }

        public void RemoveAt(int index)
        {
            Permission permission = base.InnerList[index] as Permission;
            this.Remove(permission);
        }

        public Permission this[string id]
        {
            get
            {
                return this.FindById(id);
            }
        }

        public Permission this[int index]
        {
            get
            {
                return (base.InnerList[index] as Permission);
            }
        }
    }
}

