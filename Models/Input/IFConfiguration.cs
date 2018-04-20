namespace Facebook.Models.Input {
    public class IFConfiguration : AbstractFacebookConfiguration {
        #region Private Constants

        private const string _appId = "app_id_to_get_on_FB";
        private const string _appSecret = "app_secret_to_get_on_FB";

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="IFConfiguration"/> class.
        /// </summary>
        public IFConfiguration() : base(_appId, _appSecret) {}

        #endregion
    }
}