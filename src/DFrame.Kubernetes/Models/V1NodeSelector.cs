﻿using System.Collections.Generic;

namespace DFrame.Kubernetes.Models
{
    public class V1NodeSelector
    {
        public IList<V1NodeSelectorTerm> nodeSelectorTerms { get; set; }
    }
}
