using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace OfficeAutomatic.Models
{
    public class Conference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "编码")]
        public string Code { get; set; }
        [Display(Name = "可容纳人数")]
        public int TotalUsers { get; set; }
        [Display(Name = "是否有投影仪")]
        public bool HasProjector { get; set; }
        [Display(Name = "位置")]
        public string Location { get; set; }
    }
    public enum ScheduleType
    {
        Conference=1,
        Car=2,
        Vacation=3
    }
    [global::System.Data.Linq.Mapping.TableAttribute()]
    public partial class Seminar : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public string CurrentUser { get; set; }
        public Guid ParentID { get; set; }
        public ScheduleType ScheduleType { get; set; }
        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _Subject;

        private string _Location;

        private System.Nullable<System.DateTime> _StartTime;

        private System.Nullable<System.DateTime> _EndTime;

        private string _Description;

        private System.Nullable<int> _Owner;

        private System.Nullable<int> _Reminder;

        private System.Nullable<int> _Priority;

        private System.Nullable<bool> _Recurrence;

        private string _RecurrenceType;

        private System.Nullable<int> _RecurrenceCount;

        private string _Categorize;

        private string _CustomStyle;

        private System.Nullable<bool> _AllDay;

        private System.Nullable<System.DateTime> _RecurrenceStartDate;

        private System.Nullable<System.DateTime> _RecurrenceEndDate;

        private string _RecurrenceRule;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnSubjectChanging(string value);
        partial void OnSubjectChanged();
        partial void OnLocationChanging(string value);
        partial void OnLocationChanged();
        partial void OnStartTimeChanging(System.Nullable<System.DateTime> value);
        partial void OnStartTimeChanged();
        partial void OnEndTimeChanging(System.Nullable<System.DateTime> value);
        partial void OnEndTimeChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnOwnerChanging(System.Nullable<int> value);
        partial void OnOwnerChanged();
        partial void OnReminderChanging(System.Nullable<int> value);
        partial void OnReminderChanged();
        partial void OnPriorityChanging(System.Nullable<int> value);
        partial void OnPriorityChanged();
        partial void OnRecurrenceChanging(System.Nullable<bool> value);
        partial void OnRecurrenceChanged();
        partial void OnRecurrenceTypeChanging(string value);
        partial void OnRecurrenceTypeChanged();
        partial void OnRecurrenceCountChanging(System.Nullable<int> value);
        partial void OnRecurrenceCountChanged();
        partial void OnCategorizeChanging(string value);
        partial void OnCategorizeChanged();
        partial void OnCustomStyleChanging(string value);
        partial void OnCustomStyleChanged();
        partial void OnAllDayChanging(System.Nullable<bool> value);
        partial void OnAllDayChanged();
        partial void OnRecurrenceStartDateChanging(System.Nullable<System.DateTime> value);
        partial void OnRecurrenceStartDateChanged();
        partial void OnRecurrenceEndDateChanging(System.Nullable<System.DateTime> value);
        partial void OnRecurrenceEndDateChanged();
        partial void OnRecurrenceRuleChanging(string value);
        partial void OnRecurrenceRuleChanged();
        #endregion

        public Seminar()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Subject", DbType = "NVarChar(100)")]
        public string Subject
        {
            get
            {
                return this._Subject;
            }
            set
            {
                if ((this._Subject != value))
                {
                    this.OnSubjectChanging(value);
                    this.SendPropertyChanging();
                    this._Subject = value;
                    this.SendPropertyChanged("Subject");
                    this.OnSubjectChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Location", DbType = "NVarChar(100)")]
        public string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                if ((this._Location != value))
                {
                    this.OnLocationChanging(value);
                    this.SendPropertyChanging();
                    this._Location = value;
                    this.SendPropertyChanged("Location");
                    this.OnLocationChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_StartTime", DbType = "DateTime")]
        public System.Nullable<System.DateTime> StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                if ((this._StartTime != value))
                {
                    this.OnStartTimeChanging(value);
                    this.SendPropertyChanging();
                    this._StartTime = value;
                    this.SendPropertyChanged("StartTime");
                    this.OnStartTimeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_EndTime", DbType = "DateTime")]
        public System.Nullable<System.DateTime> EndTime
        {
            get
            {
                return this._EndTime;
            }
            set
            {
                if ((this._EndTime != value))
                {
                    this.OnEndTimeChanging(value);
                    this.SendPropertyChanging();
                    this._EndTime = value;
                    this.SendPropertyChanged("EndTime");
                    this.OnEndTimeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Description", DbType = "NVarChar(500)")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._Description = value;
                    this.SendPropertyChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Owner", DbType = "Int")]
        public System.Nullable<int> Owner
        {
            get
            {
                return this._Owner;
            }
            set
            {
                if ((this._Owner != value))
                {
                    this.OnOwnerChanging(value);
                    this.SendPropertyChanging();
                    this._Owner = value;
                    this.SendPropertyChanged("Owner");
                    this.OnOwnerChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Reminder", DbType = "Int")]
        public System.Nullable<int> Reminder
        {
            get
            {
                return this._Reminder;
            }
            set
            {
                if ((this._Reminder != value))
                {
                    this.OnReminderChanging(value);
                    this.SendPropertyChanging();
                    this._Reminder = value;
                    this.SendPropertyChanged("Reminder");
                    this.OnReminderChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Priority", DbType = "Int")]
        public System.Nullable<int> Priority
        {
            get
            {
                return this._Priority;
            }
            set
            {
                if ((this._Priority != value))
                {
                    this.OnPriorityChanging(value);
                    this.SendPropertyChanging();
                    this._Priority = value;
                    this.SendPropertyChanged("Priority");
                    this.OnPriorityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Recurrence", DbType = "Bit")]
        public System.Nullable<bool> Recurrence
        {
            get
            {
                return this._Recurrence;
            }
            set
            {
                if ((this._Recurrence != value))
                {
                    this.OnRecurrenceChanging(value);
                    this.SendPropertyChanging();
                    this._Recurrence = value;
                    this.SendPropertyChanged("Recurrence");
                    this.OnRecurrenceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_RecurrenceType", DbType = "NVarChar(100)")]
        public string RecurrenceType
        {
            get
            {
                return this._RecurrenceType;
            }
            set
            {
                if ((this._RecurrenceType != value))
                {
                    this.OnRecurrenceTypeChanging(value);
                    this.SendPropertyChanging();
                    this._RecurrenceType = value;
                    this.SendPropertyChanged("RecurrenceType");
                    this.OnRecurrenceTypeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_RecurrenceCount", DbType = "Int")]
        public System.Nullable<int> RecurrenceCount
        {
            get
            {
                return this._RecurrenceCount;
            }
            set
            {
                if ((this._RecurrenceCount != value))
                {
                    this.OnRecurrenceCountChanging(value);
                    this.SendPropertyChanging();
                    this._RecurrenceCount = value;
                    this.SendPropertyChanged("RecurrenceCount");
                    this.OnRecurrenceCountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Categorize", DbType = "NVarChar(100)")]
        public string Categorize
        {
            get
            {
                return this._Categorize;
            }
            set
            {
                if ((this._Categorize != value))
                {
                    this.OnCategorizeChanging(value);
                    this.SendPropertyChanging();
                    this._Categorize = value;
                    this.SendPropertyChanged("Categorize");
                    this.OnCategorizeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CustomStyle", DbType = "NVarChar(100)")]
        public string CustomStyle
        {
            get
            {
                return this._CustomStyle;
            }
            set
            {
                if ((this._CustomStyle != value))
                {
                    this.OnCustomStyleChanging(value);
                    this.SendPropertyChanging();
                    this._CustomStyle = value;
                    this.SendPropertyChanged("CustomStyle");
                    this.OnCustomStyleChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_AllDay", DbType = "Bit")]
        public System.Nullable<bool> AllDay
        {
            get
            {
                return this._AllDay;
            }
            set
            {
                if ((this._AllDay != value))
                {
                    this.OnAllDayChanging(value);
                    this.SendPropertyChanging();
                    this._AllDay = value;
                    this.SendPropertyChanged("AllDay");
                    this.OnAllDayChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_RecurrenceStartDate", DbType = "DateTime")]
        public System.Nullable<System.DateTime> RecurrenceStartDate
        {
            get
            {
                return this._RecurrenceStartDate;
            }
            set
            {
                if ((this._RecurrenceStartDate != value))
                {
                    this.OnRecurrenceStartDateChanging(value);
                    this.SendPropertyChanging();
                    this._RecurrenceStartDate = value;
                    this.SendPropertyChanged("RecurrenceStartDate");
                    this.OnRecurrenceStartDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_RecurrenceEndDate", DbType = "DateTime")]
        public System.Nullable<System.DateTime> RecurrenceEndDate
        {
            get
            {
                return this._RecurrenceEndDate;
            }
            set
            {
                if ((this._RecurrenceEndDate != value))
                {
                    this.OnRecurrenceEndDateChanging(value);
                    this.SendPropertyChanging();
                    this._RecurrenceEndDate = value;
                    this.SendPropertyChanged("RecurrenceEndDate");
                    this.OnRecurrenceEndDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_RecurrenceRule", DbType = "NVarChar(2000)")]
        public string RecurrenceRule
        {
            get
            {
                return this._RecurrenceRule;
            }
            set
            {
                if ((this._RecurrenceRule != value))
                {
                    this.OnRecurrenceRuleChanging(value);
                    this.SendPropertyChanging();
                    this._RecurrenceRule = value;
                    this.SendPropertyChanged("RecurrenceRule");
                    this.OnRecurrenceRuleChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    public class OfficeContext : DbContext
    {
        public OfficeContext()
            : base("OfficeContext")
        {

        }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Seminar> Seminars { get; set; } 
    }
}