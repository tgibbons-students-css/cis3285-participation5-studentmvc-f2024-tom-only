using System.Xml.Linq;

namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class NullStudent : IStudentInterface
    {
        public NullStudent()
        { /* Do nothing */ }
        public int Id
        {
            get { return -1; }   // Always return default value
            set { /* Do nothing */ }
        }

        public string Name
        {
            get { return "Null Student"; }   // Always return default value
            set { /* Do nothing */ }
        }

        public int Credits
        {
            get { return -999; }   // Always return default value
            set { /* Do nothing */ }
        }


    }
}
