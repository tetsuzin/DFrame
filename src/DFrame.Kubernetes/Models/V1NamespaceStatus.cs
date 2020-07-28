﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DFrame.Kubernetes.Models
{
    public class V1NamespaceStatus
    {
        public IList<V1NamespaceCondition> conditions { get; set; }
        public string phase { get; set; }
    }
}
