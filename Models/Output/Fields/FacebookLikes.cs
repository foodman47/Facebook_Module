namespace Facebook.Models.Output.Fields {
    public class FacebookLikes {
        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether this instance can like.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance can like; otherwise, <c>false</c>.
        /// </value>
        public bool CanLike { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has liked.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has liked; otherwise, <c>false</c>.
        /// </value>
        public bool HasLiked { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the total count.
        /// </summary>
        /// <value>
        /// The total count.
        /// </value>
        public int TotalCount { get; set; }

        #endregion
    }
}