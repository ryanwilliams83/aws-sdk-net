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
    /// Container for the parameters to the DeleteInferenceScheduler operation.
    /// Deletes an inference scheduler that has been set up. Already processed output results
    /// are not affected.
    /// </summary>
    public partial class DeleteInferenceSchedulerRequest : AmazonLookoutEquipmentRequest
    {
        private string _inferenceSchedulerName;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler to be deleted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string InferenceSchedulerName
        {
            get { return this._inferenceSchedulerName; }
            set { this._inferenceSchedulerName = value; }
        }

        // Check to see if InferenceSchedulerName property is set
        internal bool IsSetInferenceSchedulerName()
        {
            return this._inferenceSchedulerName != null;
        }

    }
}