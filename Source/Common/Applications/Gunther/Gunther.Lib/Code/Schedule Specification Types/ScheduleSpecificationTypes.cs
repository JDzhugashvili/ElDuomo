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
using Duomo.Common.Lib.Dates;

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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:ScheduleSpecificationTypes")]
    public partial class HourlyScheduleSpecification
    {

        private System.DateTime startTimeField;

        private System.DateTime endTimeField;

        private string daysOfWeekField;

        private HolidayCalendarEnumeration holidayCalendarField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DaysOfWeek
        {
            get
            {
                return this.daysOfWeekField;
            }
            set
            {
                this.daysOfWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HolidayCalendarEnumeration HolidayCalendar
        {
            get
            {
                return this.holidayCalendarField;
            }
            set
            {
                this.holidayCalendarField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:ScheduleSpecificationTypes")]
    public partial class DailyScheduleSpecification
    {

        private System.DateTime timeField;

        private string daysOfWeekField;

        private HolidayCalendarEnumeration holidayCalendarField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DaysOfWeek
        {
            get
            {
                return this.daysOfWeekField;
            }
            set
            {
                this.daysOfWeekField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HolidayCalendarEnumeration HolidayCalendar
        {
            get
            {
                return this.holidayCalendarField;
            }
            set
            {
                this.holidayCalendarField = value;
            }
        }
    }
}
