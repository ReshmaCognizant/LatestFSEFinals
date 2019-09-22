using System.Runtime.Serialization;

namespace ProjectManager.Shared.ServiceContracts
{
    [DataContract]
    public class UserModel
    {
        int _userID;
        string _firstName = "";
        string _lastName = "";
        int _employeeID;
        int _projectID;
        int _taskID;

        [DataMember(Name = "userID")]
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        [DataMember(Name = "firstName")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        [DataMember(Name = "lastName")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        [DataMember(Name = "employeeID")]
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        [DataMember(Name = "projectID")]
        public int ProjectID
        {
            get { return _projectID; }
            set { _projectID = value; }
        }

        [DataMember(Name = "taskID")]
        public int TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }
    }
}
