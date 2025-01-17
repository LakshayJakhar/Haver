﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Haver.Models
{
    [ModelMetadataType(typeof(EmployeeMetaData))]
    public class Employee : Auditable
    {
        public int ID { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string FormalName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public string PhoneNumber
        {
            get
            {
                if (String.IsNullOrEmpty(Phone))
                {
                    return "";
                }
                else
                {
                    return "(" + Phone.Substring(0, 3) + ") " + Phone.Substring(3, 3) + "-" + Phone.Substring(6, 4);
                }
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool Active { get; set; } = true;

        [ScaffoldColumn(false)]
        [Timestamp]
        public Byte[] RowVersion { get; set; }//Added for concurrency

        public EmployeePhoto EmployeePhoto { get; set; }
        public EmployeeThumbnail EmployeeThumbnail { get; set; }
        public ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();
    }
}
