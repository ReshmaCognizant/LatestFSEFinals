using System;
using System.Runtime.Serialization;

namespace ProjectManager.Shared.ServiceContracts
{
    [DataContract]
    public class TaskModel
    {
        int _taskID;
        int _parentID;
        int _projectID;
        string _taskName = "";
        DateTime _startDate;
        DateTime _endDate;
        int _priority;
        string _status = "";
        
        [DataMember(Name = "taskID")]
        public int TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }

        [DataMember(Name = "parentID")]
        public int ParentID
        {
            get { return _parentID; }
            set { _parentID = value; }
        }

        [DataMember(Name = "projectID")]
        public int ProjectID
        {
            get { return _projectID; }
            set { _projectID = value; }
        }

        [DataMember(Name = "taskName")]
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }

        [DataMember(Name = "startDate")]
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        [DataMember(Name = "endDate")]
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        [DataMember(Name = "priority")]
        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        [DataMember(Name = "status")]
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
