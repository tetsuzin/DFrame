﻿using System.Collections.Generic;

namespace DFrame.Kubernetes.Models
{
    public class V1LabelSelector
    {
        public IList<V1LabelSelectorRequirement> matchExpressions { get; set; }
        public IDictionary<string, string> matchLabels { get; set; }
    }
}