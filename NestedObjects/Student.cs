using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The student's legal first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The student's legal last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }
        /// <summary>
        /// Student's cell phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        public Advisor AssignedAdvisor { get; set; }
    }
    
}
