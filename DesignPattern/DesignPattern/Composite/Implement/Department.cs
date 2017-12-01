using DesignPattern.Composite.Base;
using System.Collections.Generic;

namespace DesignPattern.Composite.Implement
{
    public class Department : Organization
    {
        private readonly List<Organization> _organizationInfo = new List<Organization>();

        public Department(string departmentName, string charge)
        {
            MemberPosition = departmentName;
            MemberName = charge;
        }

        public void Add(Organization org)
        {
            _organizationInfo.Add(org);
            org.ParentNode = this;
        }

        public void Remove(Organization org)
        {
            _organizationInfo.Remove(org);
        }

        public List<Organization> GetDepartmentMembers()
        {
            return _organizationInfo;
        }
    }
}
