namespace Facebook.Json.Fields.Likes {
    public class Likes {
        #region Public Properties

        public Datum[] data { get; set; }
        public Paging paging { get; set; }
        public Summary summary { get; set; }

        #endregion
    }

    public class Paging {
        #region Public Properties

        public Cursors cursors { get; set; }
        public string next { get; set; }

        #endregion
    }

    public class Cursors {
        #region Public Properties

        public string after { get; set; }
        public string before { get; set; }

        #endregion
    }

    public class Summary {
        #region Public Properties

        public bool can_like { get; set; }
        public bool has_liked { get; set; }
        public int total_count { get; set; }

        #endregion
    }

    public class Datum {
        #region Public Properties

        public string id { get; set; }
        public string name { get; set; }

        #endregion
    }
}