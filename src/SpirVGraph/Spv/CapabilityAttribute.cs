using System;
using System.Collections.Generic;
using System.Text;

namespace SpirVGraph.Spv
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class CapabilityAttribute: Attribute
    {
        private readonly Capability.Enumerant _capability;

        public CapabilityAttribute(Capability.Enumerant capability)
        {
            _capability = capability;
        }

        public Capability.Enumerant Capability
        {
            get { return _capability; }
        }
    }
}
