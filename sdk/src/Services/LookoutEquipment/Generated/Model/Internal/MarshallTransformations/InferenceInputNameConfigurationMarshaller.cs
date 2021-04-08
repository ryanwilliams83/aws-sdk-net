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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutEquipment.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InferenceInputNameConfiguration Marshaller
    /// </summary>       
    public class InferenceInputNameConfigurationMarshaller : IRequestMarshaller<InferenceInputNameConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InferenceInputNameConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetComponentTimestampDelimiter())
            {
                context.Writer.WritePropertyName("ComponentTimestampDelimiter");
                context.Writer.Write(requestObject.ComponentTimestampDelimiter);
            }

            if(requestObject.IsSetTimestampFormat())
            {
                context.Writer.WritePropertyName("TimestampFormat");
                context.Writer.Write(requestObject.TimestampFormat);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InferenceInputNameConfigurationMarshaller Instance = new InferenceInputNameConfigurationMarshaller();

    }
}