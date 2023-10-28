using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Entity
{
    internal class Deal
    {
        public Employer employer { get {  return employer; } set {  employer = value; } }
        public Seeker seeker { get { return seeker; } set { seeker = value; } }
        double commision { get { return commision; } set {  commision = value; } }
    }
}
