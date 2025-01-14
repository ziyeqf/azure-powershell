// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>Set assessment schedule for SQL Server.</summary>
    public partial class Schedule :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISchedule,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IScheduleInternal
    {

        /// <summary>Backing field for <see cref="DayOfWeek" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek? _dayOfWeek;

        /// <summary>Day of the week to run assessment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek? DayOfWeek { get => this._dayOfWeek; set => this._dayOfWeek = value; }

        /// <summary>Backing field for <see cref="Enable" /> property.</summary>
        private bool? _enable;

        /// <summary>Enable or disable assessment schedule on SQL virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public bool? Enable { get => this._enable; set => this._enable = value; }

        /// <summary>Backing field for <see cref="MonthlyOccurrence" /> property.</summary>
        private int? _monthlyOccurrence;

        /// <summary>
        /// Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek
        /// day of the month
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? MonthlyOccurrence { get => this._monthlyOccurrence; set => this._monthlyOccurrence = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private string _startTime;

        /// <summary>Time of the day in HH:mm format. Eg. 17:30</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="WeeklyInterval" /> property.</summary>
        private int? _weeklyInterval;

        /// <summary>Number of weeks to schedule between 2 assessment runs. Takes value from 1-6</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? WeeklyInterval { get => this._weeklyInterval; set => this._weeklyInterval = value; }

        /// <summary>Creates an new <see cref="Schedule" /> instance.</summary>
        public Schedule()
        {

        }
    }
    /// Set assessment schedule for SQL Server.
    public partial interface ISchedule :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>Day of the week to run assessment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Day of the week to run assessment.",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek) })]
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek? DayOfWeek { get; set; }
        /// <summary>Enable or disable assessment schedule on SQL virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable or disable assessment schedule on SQL virtual machine.",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enable { get; set; }
        /// <summary>
        /// Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek
        /// day of the month
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek day of the month",
        SerializedName = @"monthlyOccurrence",
        PossibleTypes = new [] { typeof(int) })]
        int? MonthlyOccurrence { get; set; }
        /// <summary>Time of the day in HH:mm format. Eg. 17:30</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time of the day in HH:mm format. Eg. 17:30",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string StartTime { get; set; }
        /// <summary>Number of weeks to schedule between 2 assessment runs. Takes value from 1-6</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of weeks to schedule between 2 assessment runs. Takes value from 1-6",
        SerializedName = @"weeklyInterval",
        PossibleTypes = new [] { typeof(int) })]
        int? WeeklyInterval { get; set; }

    }
    /// Set assessment schedule for SQL Server.
    internal partial interface IScheduleInternal

    {
        /// <summary>Day of the week to run assessment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.AssessmentDayOfWeek? DayOfWeek { get; set; }
        /// <summary>Enable or disable assessment schedule on SQL virtual machine.</summary>
        bool? Enable { get; set; }
        /// <summary>
        /// Occurrence of the DayOfWeek day within a month to schedule assessment. Takes values: 1,2,3,4 and -1. Use -1 for last DayOfWeek
        /// day of the month
        /// </summary>
        int? MonthlyOccurrence { get; set; }
        /// <summary>Time of the day in HH:mm format. Eg. 17:30</summary>
        string StartTime { get; set; }
        /// <summary>Number of weeks to schedule between 2 assessment runs. Takes value from 1-6</summary>
        int? WeeklyInterval { get; set; }

    }
}