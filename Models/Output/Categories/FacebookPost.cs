#region Imports

using System;

#endregion

namespace Facebook.Models.Output.Categories {
    public class FacebookPost {
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

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the story.
        /// </summary>
        /// <value>
        /// The story.
        /// </value>
        public string Story { get; set; }

        #endregion
    }
}