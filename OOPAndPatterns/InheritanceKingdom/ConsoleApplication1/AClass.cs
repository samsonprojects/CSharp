using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public class AClass
    {
        private string name;
        private string ID; //unique text identifier
        private SortedSet<Teacher> TeachersList = new SortedSet<Teacher>();

        public AClass(string Name)
        {
            this.name = Name;
            int IDname = this.name.ToUpper().GetHashCode();
            this.ID = IDname.ToString();

        }


        public SortedSet<Teacher> AddNewTeacher(Teacher newTeacher)
        {
            TeachersList.Add(newTeacher);
            return TeachersList;
        }
    }
}
