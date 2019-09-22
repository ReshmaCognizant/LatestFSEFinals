using System;
using System.Runtime.Serialization;

namespace ProjectManager.Shared.ServiceContracts
{
    [DataContract]
    public class ProjectModel
    {
        int _projectID;
        string _projectName = "";
        DateTime _startDate = default(DateTime);
        DateTime _endDate = default(DateTime);
        int _priority;

        [DataMember(Name = "projectID")]
        public int ProjectID
        {
            get { return _projectID; }
            set { _projectID = value; }
        }

        [DataMember(Name = "projectName")]
        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
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
    }
}
