﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication_V1.Classes
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public string InstitutionalID { get; set; }

        [FirestoreProperty]
        public string Password { get; set; }

        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string Type { get; set; }

    }
}
