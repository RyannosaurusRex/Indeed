using System;
using System.Collections.Generic;
using Indeed.Models;
using System.Xml;
using System.Diagnostics.Contracts;

namespace Indeed
{
    /// <summary>
    /// Wraps the Indeed search API to return job search results.
    /// </summary>
    public class IndeedSearch
    {

        /// <summary>
        /// Searches Indeed.
        /// </summary>
        /// <param name="parameters">The search query parameters.</param>
        /// <param name="apiPublisherKey">Your Indeed API key.</param>
        /// <returns>The Indeed job search results.</returns>
        public static List<IndeedSearchResult> GetSearchResults(IndeedQueryParameters parameters, string apiPublisherKey)
        {
            Contract.Requires(null != apiPublisherKey);
            Contract.Requires("" != apiPublisherKey.Trim());

            string requestUrl = "http://api.indeed.com/ads/apisearch" +
                                            String.Format("?publisher={0}", apiPublisherKey) +
                                            String.Format("&q={0}", parameters.JobQuery) +
                                            String.Format("&l={0}", parameters.Location) +
                                            String.Format("&sort={0}", parameters.Sort) +
                                            String.Format("&radius={0}", parameters.SearchRadius) +
                                            String.Format("&st={0}", parameters.St) +
                                            String.Format("&jt={0}", parameters.Jt) +
                                            String.Format("&start={0}", parameters.Start) +
                                            String.Format("&limit={0}", parameters.Limit) +
                                            String.Format("&fromage={0}", parameters.FromAge) +
                                            String.Format("&filter={0}", parameters.Filter) +
                                            String.Format("&latlong={0}", parameters.LatitudeLongitude) +
                                            String.Format("&co={0}", parameters.Country) +
                                            String.Format("&chnl={0}", parameters.Channel) +
                                            String.Format("&userip={0}", parameters.UserIP) +
                                            String.Format("&useragent={0}", parameters.UserAgent) +
                                            "&v=2";

            XmlDocument doc = new XmlDocument();
            doc.Load(requestUrl);
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//results//result");

            var results = new List<IndeedSearchResult>();
            foreach (XmlNode node in nodes)
            {
                IndeedSearchResult result = new IndeedSearchResult();
                result.JobTitle = node["jobtitle"].InnerText;
                result.Company = node["company"].InnerText;
                result.City = node["city"].InnerText;
                result.State = node["state"].InnerText;
                result.Country = node["country"].InnerText;
                result.FormattedLocationFull = node["formattedLocation"].InnerText;
                result.Source = node["source"].InnerText;
                result.Date = node["date"].InnerText;
                result.Snippet = node["snippet"].InnerText;
                result.URL = node["url"].InnerText;
                result.OnMouseDown = node["onmousedown"].InnerText;
                result.Latitude = node["latitude"].InnerText;
                result.JobKey = node["jobkey"].InnerText;
                result.Sponsored = node["sponsored"].InnerText;
                result.Expired = node["expired"].InnerText;
                result.FormattedLocationFull = node["formattedLocationFull"].InnerText;
                result.FormattedRelativeTime = node["formattedRelativeTime"].InnerText;

                results.Add(result);
            }

            return results;
        }

        /// <summary>
        /// Returns the Indeed job search results based on the specified query parameters.
        /// This overload uses the project's properties file to supply Indeed with the Publisher Number/API key.
        /// </summary>
        /// <param name="parameters">Indeed search parameters.</param>
        /// <returns>The Indeed job search results.</returns>
        public List<IndeedSearchResult> GetSearchResults(IndeedQueryParameters parameters)
        {
            return GetSearchResults(parameters, Properties.Resources.PublisherNumber);
        }
    }
}
