#region Imports

#endregion

namespace Facebook.Json.Categories.Videos {
    public class VideosContainer {
        #region Public Properties

        public string id { get; set; }
        public Videos videos { get; set; }

        #endregion
    }

    public class Videos {
        #region Public Properties

        public Datum[] data { get; set; }
        public Paging paging { get; set; }

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

    public class Datum {
        #region Public Properties

        public string description { get; set; }
        public string id { get; set; }
        public string updated_time { get; set; }

        #endregion
    }
}