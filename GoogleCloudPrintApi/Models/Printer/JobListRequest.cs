﻿using Newtonsoft.Json;
using GoogleCloudPrintApi.Attributes;
using GoogleCloudPrintApi.Infrastructures;

namespace GoogleCloudPrintApi.Models.Printer
{
    public class JobListRequest : IRequest
    {
        /// <summary>
        /// Required. Unique printer identification (generated by Google Cloud Print).
        /// </summary>
        [JsonProperty("printerid"), Form(isRequiredFor: VersionOption.All)]
        public string PrinterId { get; set; }

        /// <summary>
        /// Optional. Restricts the search to this many jobs past the offset.
        /// </summary>
        [JsonProperty("limit"), Form]
        public string Limit { get; set; }

        /// <summary>
        /// Optional. Starts the search at the given offset.
        /// </summary>
        [JsonProperty("offset"), Form]
        public string Offset { get; set; }

        /// <summary>
        /// Optional. Restrict the search to jobs submitted by the given user email address
        /// that the authenticated user has permission to view.
        /// </summary>
        [JsonProperty("owner"), Form]
        public string Owner { get; set; }

        /// <summary>
        /// Optional. Restricts the search to jobs whose title or tags contain the given query
        /// as a substring (case-insensitive).
        /// </summary>
        [JsonProperty("q"), Form]
        public string Query { get; set; }

        /// <summary>
        /// Optional. Specifies the sort order of the returned print jobs. Supported values:
        /// CREATE_TIME, CREATE_TIME_DESC (default), STATUS, STATUS_DESC, TITLE, TITLE_DESC
        /// </summary>
        [JsonProperty("sortorder"), Form]
        public string SortOrder { get; set; }

        /// <summary>
        /// Optional. Restricts the search to jobs which currently have one of the given status:
        /// QUEUED, IN_PROGRESS, DONE, ERROR, SUBMITTED, HELD
        /// </summary>
        [JsonProperty("status"), Form]
        public string Status { get; set; }
    }
}