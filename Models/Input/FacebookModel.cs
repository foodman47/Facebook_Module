#region Imports

using Facebook.Enums;
using Facebook.Models.Input;

#endregion

namespace IFC.Facebok.Models.Input {
    public class FacebookModel : FacebookConfiguration, IFacebookModel {
        #region Public Properties

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public FacebookItemCategory Category { get; set; }

        #endregion
    }
}