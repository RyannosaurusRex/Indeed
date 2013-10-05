using System;

namespace Indeed.Models
{
    /// <summary>
    /// Represents a single row that is 
    /// returned by the Indeed search service.
    /// </summary>
    public class IndeedSearchResult
    {
        /// <summary>
        /// The time the job listing was posted formatted
        /// for display.
        /// </summary>
        /// <example>6 days ago</example>
        public string FormattedRelativeTime { get; set; }

        /// <summary>
        /// Has this job listing expired?
        /// </summary>
        /// <example>false</example>
        public string Expired { get; set; }

        /// <summary>
        /// Is this an Indeed sponsored job?
        /// </summary>
        /// <example>false</example>
        public string Sponsored { get; set; }

        /// <summary>
        /// The indeed job key.
        /// </summary>
        /// <example>0123456789abcdef</example>
        public string JobKey { get; set; }

        /// <summary>
        /// Latitude of the job's location.
        /// </summary>
        /// <example>41.057693</example>
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude of the job's location.
        /// </summary>
        /// <example>-73.54395</example>
        public string Longitude { get; set; }

        /// <summary>
        /// Code to be placed on the onMouseDown event of the title link.
        /// </summary>
        /// <example>indeed_clk(this, '');</example>
        public string OnMouseDown { get; set; }

        /// <summary>
        /// A short description of the summary of the job.
        /// </summary>
        /// <example>Indeed is looking for strategic Account Executives to help in the expansion of our Stamford, CT location. We are 
        /// in the process of interviewing sales candidates who have 2-5 years of sales experience and who have experience 
        /// generating new business and growing existing accounts. A strong candidate will have excellent communication 
        /// skills, consistent work ethic and a desire to be a part of the...</example>
        public string Snippet { get; set; }

        /// <summary>
        /// The date that the job was posted.
        /// </summary>
        /// <example>Tue, 03 Aug 2010 14:00:47 GMT</example>
        public string Date { get; set; }

        /// <summary>
        /// The country where the job is located.  This
        /// will be in the format of a country code.
        /// </summary>
        /// <example>US</example>
        public string Country { get; set; }

        /// <summary>
        /// The state where the job is located.
        /// </summary>
        /// <example>CT</example>
        public string State { get; set; }

        /// <summary>
        /// The source of the job posting.
        /// </summary>
        /// <example>Indeed</example>
        public string Source { get; set; }

        /// <summary>
        /// The city where the job is located.
        /// </summary>
        /// <example>Stamford</example>
        public string City { get; set; }

        /// <summary>
        /// The job title.
        /// </summary>
        /// <example>Sales Account Executive</example>
        public string JobTitle { get; set; }

        /// <summary>
        /// The company the job is for.
        /// </summary>
        /// <example>Indeed</example>
        public string Company { get; set; }

        /// <summary>
        /// Full location of the job listing that is
        /// formatted for display.
        /// </summary>
        /// <example>Stamford, CT 06902</example>
        public string FormattedLocationFull { get; set; }

        /// <summary>
        /// The URL of the job posting on Indeed.com
        /// </summary>
        /// <example>http://www.indeed.com/rc/clk?jk=0123456789abcdef</example>
        /// <remarks>Notice that the job key is part of the URL.</remarks>
        public string URL { get; set; }
    }
}
