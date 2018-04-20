namespace Facebook.Json.Categories.Picture {
    public class PictureContainer {
        #region Public Properties

        public string id { get; set; }
        public Picture picture { get; set; }

        #endregion
    }

    public class Picture {
        #region Public Properties

        public Data data { get; set; }

        #endregion
    }

    public class Data {
        #region Public Properties

        public bool is_silhouette { get; set; }
        public string url { get; set; }

        #endregion
    }
}