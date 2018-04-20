#region Imports

#endregion

namespace Facebook.Json.Categories.Events {
    public class EventsContainer {
        #region Public Properties

        public Events events { get; set; }
        public string id { get; set; }

        #endregion
    }

    public class Events {
        #region Public Properties

        public Datum[] data { get; set; }
        public Paging paging { get; set; }

        #endregion
    }

    public class Paging {
        #region Public Properties

        public Cursors cursors { get; set; }

        #endregion
    }

    public class Cursors {
        #region Public Properties

        public string after { get; set; }
        public string before { get; set; }

        #endregion
    }

    public class Datum {
        #region Public Properties

        public string description { get; set; }
        public string end_time { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public Place place { get; set; }
        public string start_time { get; set; }

        #endregion
    }

    public class Place {
        #region Public Properties

        public string id { get; set; }
        public Location location { get; set; }
        public string name { get; set; }

        #endregion
    }

    public class Location {
        #region Public Properties

        public string city { get; set; }
        public string country { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string state { get; set; }
        public string street { get; set; }
        public string zip { get; set; }

        #endregion
    }
}