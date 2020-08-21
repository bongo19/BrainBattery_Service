using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainBattery_Objects
{
    public class Medication
    {
        /// <summary>
        /// Medication Id
        /// </summary>
        public int MedicationId { get; set; }
        /// <summary>
        /// Medication Brand Name
        /// </summary>
        public string MedicationBrandName { get; set; }
        /// <summary>
        /// Medication Generic Name
        /// </summary>
        public string MedicationGenericName { get; set; }
        /// <summary>
        /// User Id of the User Prescribed Medication
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// List of Notes taken over a period of time by the user
        /// </summary>
        public List<MedicationNote> MedicationNotes { get; set; }



    }
}
