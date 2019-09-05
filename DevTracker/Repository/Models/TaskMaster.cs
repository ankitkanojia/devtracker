//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskMaster()
        {
            this.CommentMasters = new HashSet<CommentMaster>();
            this.DependantTasks = new HashSet<DependantTask>();
            this.DependantTasks1 = new HashSet<DependantTask>();
            this.TaskAttachments = new HashSet<TaskAttachment>();
            this.TimeTrackers = new HashSet<TimeTracker>();
        }
    
        public long TaskMasterId { get; set; }
        public string TaskCode { get; set; }
        public long TaskCategoryId { get; set; }
        public long ProjectId { get; set; }
        public string Title { get; set; }
        public long TaskTypeMasterId { get; set; }
        public string Description { get; set; }
        public long AssignyId { get; set; }
        public long ReporterId { get; set; }
        public long PriorityMasterId { get; set; }
        public long TaskStatusMasterId { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> EstimateTimeHours { get; set; }
        public Nullable<int> ActualTimeHours { get; set; }
        public int CompletionPercentage { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> CreatedDateInt { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedDateInt { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentMaster> CommentMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DependantTask> DependantTasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DependantTask> DependantTasks1 { get; set; }
        public virtual Project Project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAttachment> TaskAttachments { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }
        public virtual TaskStatusMaster TaskStatusMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
        public virtual UserMaster UserMaster1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeTracker> TimeTrackers { get; set; }
    }
}
