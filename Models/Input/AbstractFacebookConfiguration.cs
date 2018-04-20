namespace Facebook.Models.Input {
    public abstract class AbstractFacebookConfiguration : IFacebookConfiguration {
        #region Public Properties

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>
        /// The application identifier.
        /// </value>
        public string AppId { get; protected set; }

        /// <summary>
        /// Gets or sets the application secret.
        /// </summary>
        /// <value>
        /// The application secret.
        /// </value>
        public string AppSecret { get; protected set; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        /// <value>
        /// The limit.
        /// </value>
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the subscription.
        /// </summary>
        /// <value>
        /// The subscription.
        /// </value>
        public string Subscription { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractFacebookConfiguration"/> class.
        /// </summary>
        /// <param name="appId">The application identifier.</param>
        /// <param name="appSecret">The application secret.</param>
        protected AbstractFacebookConfiguration(string appId, string appSecret)
                : this() {
            AppId = appId;
            AppSecret = appSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractFacebookConfiguration"/> class.
        /// </summary>
        protected AbstractFacebookConfiguration() {
            Limit = 25;
        }

        #endregion
    }
}