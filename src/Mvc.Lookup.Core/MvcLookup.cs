﻿using System;
using System.Collections.Generic;

namespace NonFactors.Mvc.Lookup
{
    public abstract class MvcLookup
    {
        public String? Url { get; set; }
        public String? Name { get; set; }
        public String? Title { get; set; }
        public Boolean Multi { get; set; }
        public String? Dialog { get; set; }
        public Boolean ReadOnly { get; set; }
        public String? Placeholder { get; set; }
        public LookupFilterCase FilterCase { get; set; }
        public LookupFilterPredicate FilterPredicate { get; set; }

        public LookupFilter Filter { get; set; }
        public IList<LookupColumn> Columns { get; set; }
        public IList<String> AdditionalFilters { get; set; }

        protected MvcLookup()
        {
            FilterPredicate = LookupFilterPredicate.Contains;
            AdditionalFilters = new List<String>();
            FilterCase = LookupFilterCase.Lower;
            Columns = new List<LookupColumn>();
            Filter = new LookupFilter();
        }

        public abstract LookupData GetData();
    }
}
