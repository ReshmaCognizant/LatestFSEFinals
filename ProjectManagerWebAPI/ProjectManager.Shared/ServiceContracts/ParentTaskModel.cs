using System;
using System.Runtime.Serialization;

namespace ProjectManager.Shared.ServiceContracts
{
    [DataContract]
    public class ParentTaskModel
    {
        int _parentID;        
        string _parentTaskName = "";

        [DataMember(Name = "projectID")]
        public int ParentID
        {
            get { return _parentID; }
            set { _parentID = value; }
        }

        [DataMember(Name = "parentTaskName")]
        public string ParentTaskName
        {
            get { return _parentTaskName; }
            set { _parentTaskName = value; }
        }        
    }
}
