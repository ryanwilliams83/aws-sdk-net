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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the DetectEntities operation.
    /// Inspects text for named entities, and returns information about them. For more information,
    /// about named entities, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-entities.html">Entities</a>
    /// in the Comprehend Developer Guide.
    /// </summary>
    public partial class DetectEntitiesRequest : AmazonComprehendRequest
    {
        private string _endpointArn;
        private LanguageCode _languageCode;
        private string _text;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name of an endpoint that is associated with a custom entity recognition
        /// model. Provide an endpoint if you want to detect entities by using your own custom
        /// model instead of the default model that is used by Amazon Comprehend.
        /// </para>
        ///  
        /// <para>
        /// If you specify an endpoint, Amazon Comprehend uses the language of your custom model,
        /// and it ignores any language code that you provide in your request.
        /// </para>
        ///  
        /// <para>
        /// For information about endpoints, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of the input documents. You can specify any of the primary languages
        /// supported by Amazon Comprehend. All documents must be in the same language.
        /// </para>
        ///  
        /// <para>
        /// If your request includes the endpoint for a custom entity recognition model, Amazon
        /// Comprehend uses the language of your custom model, and it ignores any language code
        /// that you specify here.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// A UTF-8 text string. The maximum string size is 100 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}