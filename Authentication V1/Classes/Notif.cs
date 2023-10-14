using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_V1.Classes
{
    [FirestoreData]
    internal class Notif
    {
        [FirestoreProperty]
        public string Details { get; set; }
        [FirestoreProperty]
        public string Info { get; set; }
        [FirestoreProperty]
        public string Number { get; set; }
    }
}
