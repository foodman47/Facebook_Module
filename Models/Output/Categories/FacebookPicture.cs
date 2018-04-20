namespace Facebook.Models.Output.Categories {
    public class FacebookPicture {
        #region Public Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is silhouette.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is silhouette; otherwise, <c>false</c>.
        /// </value>
        public bool IsSilhouette { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }

        #endregion
    }
}