using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using WarriorProof.Contacts.Enumerations;

namespace WarriorProof.Models
{
    public class TrucksInfoViewModel
    {
        [Required]
        public int NumberOfTrucks { get; set; }
        [Required]
        public IEnumerable<string> LineOfBusinesses { get; set; }

        public string FormattedLOBS {
            get {
                StringBuilder b = new StringBuilder();
                int i = 0;
                foreach (var l in LineOfBusinesses)
                {
                    LineOfBusiness lob = (LineOfBusiness)Int32.Parse(l);
                    if (i != 0)
                        b.Append("  -  ");
                    b.Append(lob.ToString());
                    i++;

                }
                return b.ToString();
            }
        }
    }
}
