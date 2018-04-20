namespace Facebook.Json.Fields.Shares {
    public class SharesContainer {
        #region Public Properties

        public string id { get; set; }
        public Shares shares { get; set; }

        #endregion
    }

    public class Shares {
        #region Public Properties

        public int count { get; set; }

        #endregion
    }
}