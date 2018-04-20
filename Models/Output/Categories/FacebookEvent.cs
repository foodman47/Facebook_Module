#region Imports

using System;

#endregion

namespace Facebook.Models.Output.Categories {
    public class FacebookEvent {
        #region Public Properties

        public string Description { get; set; }
        public DateTime EndTime { get; set; }
        public string Id { get; set; }

        public string LocationCity { get; set; }
        public string LocationCountry { get; set; }
        public float LocationLatitude { get; set; }
        public float LocationLongitude { get; set; }
        public string LocationState { get; set; }
        public string LocationStreet { get; set; }
        public string LocationZip { get; set; }
        public string Name { get; set; }

        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
        public DateTime StartTime { get; set; }

        #endregion
    }
}