﻿using System.Collections.Generic;

namespace DFrame.Kubernetes.Models
{
    public class V1Podaffinity
    {
        public IList<V1WeightedPodAffinityTerm> preferredDuringSchedulingIgnoredDuringExecution { get; set; }
        public IList<V1PodAffinityTerm> requiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }
}