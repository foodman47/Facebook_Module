#region Imports

using System;

#endregion

namespace Facebook.Models.Output.Categories {
    public class FacebookPhoto {
        #region Public Properties

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        #endregion
    }
}