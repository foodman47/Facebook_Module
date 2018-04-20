namespace Facebook.Json.Categories.Posts {
    public class PostsContainer {
        #region Public Properties

        public string id { get; set; }
        public Posts posts { get; set; }

        #endregion
    }

    public class Posts {
        #region Public Properties

        public Datum[] data { get; set; }
        public Paging paging { get; set; }

        #endregion
    }

    public class Paging {
        #region Public Properties

        public string next { get; set; }
        public string previous { get; set; }

        #endregion
    }

    public class Datum {
        #region Public Properties

        public string created_time { get; set; }
        public string id { get; set; }
        public string message { get; set; }
        public string story { get; set; }

        #endregion
    }
}