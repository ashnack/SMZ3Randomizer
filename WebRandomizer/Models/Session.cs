﻿using System.Collections.Generic;

namespace WebRandomizer.Models {

    public enum SessionState {
        Created,
        Running,
        Done,
    }

    public class Session {
        public int Id { get; set; }
        public string Guid { get; set; }
        public SessionState State { get; set; }
        public List<Client> Clients { get; set; }
        public Seed Seed { get; set; }
    }

}
