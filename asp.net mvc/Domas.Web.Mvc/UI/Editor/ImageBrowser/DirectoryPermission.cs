﻿using System;

namespace Domas.Web.Mvc.UI
{
    public class DirectoryPermission : IDirectoryPermission
    {
        public bool CanAccess(string rootPath, string childPath)
        {
            return childPath.StartsWith(rootPath, StringComparison.OrdinalIgnoreCase);
        }
    }
}
