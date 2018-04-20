namespace Facebook.Models.Input {
    public class FacebookConfiguration : AbstractFacebookConfiguration {
        #region Public Properties

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>
        /// The application identifier.
        /// </value>
        public new string AppId { get { return base.AppId; } set { base.AppId = value; } }

        /// <summary>
        /// Gets or sets the application secret.
        /// </summary>
        /// <value>
        /// The application secret.
        /// </value>
        public new string AppSecret { get { return base.AppSecret; } set { base.AppSecret = value; } }

        #endregion
    }
}