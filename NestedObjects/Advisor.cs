﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// The advisor's legal first and last name
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// The advisor's work email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Building and room number where the advisor's office is located
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}