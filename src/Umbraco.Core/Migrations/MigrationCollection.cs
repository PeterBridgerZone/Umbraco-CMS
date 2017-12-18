﻿using System.Collections.Generic;
using Umbraco.Core.Composing;

namespace Umbraco.Core.Migrations
{
    public class MigrationCollection : BuilderCollectionBase<IMigration>
    {
        public MigrationCollection(IEnumerable<IMigration> items)
            : base(items)
        { }
    }
}