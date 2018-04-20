namespace Facebook.Models.Input {
    public interface IFacebookConfiguration {
        #region Public Properties

        /// <summary>
        /// Gets the application identifier.
        /// </summary>
        /// <value>
        /// The application identifier.
        /// </value>
        string AppId { get; }

        /// <summary>
        /// Gets the application secret.
        /// </summary>
        /// <value>
        /// The application secret.
        /// </value>
        string AppSecret { get; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>
        /// The limit.
        /// </value>
        int Limit { get; set; }

        /// <summary>
        /// Gets or sets the subscription.
        /// </summary>
        /// <value>
        /// The subscription.
        /// </value>
        string Subscription { get; set; }

        #endregion
    }
}