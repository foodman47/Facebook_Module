namespace Facebook.Json.Categories.Photos {
    public class PhotosContainer {
        #region Public Properties

        public string id { get; set; }
        public Photos photos { get; set; }

        #endregion
    }

    public class Photos {
        #region Public Properties

        public Datum[] data { get; set; }
        public Paging paging { get; set; }

        #endregion
    }

    public class Paging {
        #region Public Properties

        public Cursors cursors { get; set; }

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

        public string created_time { get; set; }
        public string id { get; set; }

        #endregion
    }
}