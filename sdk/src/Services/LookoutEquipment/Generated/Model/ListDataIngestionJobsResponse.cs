/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the ListDataIngestionJobs operation.
    /// </summary>
    public partial class ListDataIngestionJobsResponse : AmazonWebServiceResponse
    {
        private List<DataIngestionJobSummary> _dataIngestionJobSummaries = new List<DataIngestionJobSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DataIngestionJobSummaries. 
        /// <para>
        /// Specifies information about the specific data ingestion job, including dataset name
        /// and status. 
        /// </para>
        /// </summary>
        public List<DataIngestionJobSummary> DataIngestionJobSummaries
        {
            get { return this._dataIngestionJobSummaries; }
            set { this._dataIngestionJobSummaries = value; }
        }

        // Check to see if DataIngestionJobSummaries property is set
        internal bool IsSetDataIngestionJobSummaries()
        {
            return this._dataIngestionJobSummaries != null && this._dataIngestionJobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An opaque pagination token indicating where to continue the listing of data ingestion
        /// jobs. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}