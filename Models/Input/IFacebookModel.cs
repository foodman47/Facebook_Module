#region Imports

using Facebook.Enums;

#endregion

namespace Facebook.Models.Input {
    public interface IFacebookModel : IFacebookConfiguration {
        #region Public Properties

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        FacebookItemCategory Category { get; set; }

        #endregion
    }
}