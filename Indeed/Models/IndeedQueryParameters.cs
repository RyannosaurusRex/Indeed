using System;

namespace Indeed.Models
{
    #region Models
    /// <summary>
    /// A model of the query parameters used as input to the Indeed search service.
    /// </summary>
    public class IndeedQueryParameters
    {
        /// <summary>
        /// Searches Job Title.
        /// </summary>
        public string JobQuery { get; set; }
        
        /// <summary>
        /// Searches for jobs near a particular location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Sort by relevance or date. Default is relevance.
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// Distance from search location ("as the crow flies"). Default is 25.
        /// </summary>
        public string SearchRadius { get; set; }

        /// <summary>
        /// Site type. To show only jobs from job boards use 'jobsite'. For jobs from direct employer websites use 'employer'.
        /// </summary>
        public string St { get; set; }

        /// <summary>
        /// Job type. Allowed values: "fulltime", "parttime", "contract", "internship", "temporary".
        /// </summary>
        public string Jt { get; set; }

        /// <summary>
        /// Start results at this result number, beginning with 0. Default is 0.
        /// </summary>
        public string Start { get; set; }

        /// <summary>
        /// Maximum number of results returned per query. Default is 10
        /// </summary>
        public string Limit { get; set; }

        /// <summary>
        /// Number of days back to search.
        /// </summary>
        public string FromAge { get; set; }

        /// <summary>
        /// Filter duplicate results. 0 turns off duplicate job filtering. Default is 1.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// If latlong=1, returns latitude and longitude information for each job result. Default is 0.
        /// </summary>
        public string LatitudeLongitude { get; set; }

        /// <summary>
        /// Search within country specified. Default is us. See below for a complete list of supported countries.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Channel Name: Group API requests to a specific channel.
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// The IP number of the end-user to whom the job results will be displayed. This field is required.
        /// </summary>
        public string UserIP { get; set; }

        /// <summary>
        /// The User-Agent (browser) of the end-user to 
        /// whom the job results will be displayed. 
        /// This can be obtained from the "User-Agent" 
        /// HTTP request header from the end-user. 
        /// This field is required.
        /// </summary>
        public string UserAgent { get; set; }
    }
    #endregion
}
