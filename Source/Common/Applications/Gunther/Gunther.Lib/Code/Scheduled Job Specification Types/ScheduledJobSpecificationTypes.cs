﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


namespace Duomo.Common.Gunther.Lib
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:ScheduledJobSpecificationTypes")]
    [System.Xml.Serialization.XmlRootAttribute("ScheduledJobSpecificationListRoot", Namespace = "urn:ScheduledJobSpecificationTypes", IsNullable = false)]
    public partial class ScheduledJobSpecificationList
    {

        private ScheduledJobSpecification[] scheduledJobField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduledJob")]
        public ScheduledJobSpecification[] ScheduledJob
        {
            get
            {
                return this.scheduledJobField;
            }
            set
            {
                this.scheduledJobField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:ScheduledJobSpecificationTypes")]
    public partial class ScheduledJobSpecification
    {

        private JobBase itemField;

        private object item1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExecutorTask", typeof(ExecutorTask))]
        [System.Xml.Serialization.XmlElementAttribute("SystemProcessCall", typeof(SystemProcessCall))]
        public JobBase Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DailyScheduleSpecification", typeof(DailyScheduleSpecification))]
        [System.Xml.Serialization.XmlElementAttribute("HourlyScheduleSpecification", typeof(HourlyScheduleSpecification))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }
    }
}
