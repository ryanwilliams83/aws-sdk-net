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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ChimeSDKVoice.Model;
using Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations;
using Amazon.ChimeSDKVoice.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ChimeSDKVoice
{
    /// <summary>
    /// Implementation for accessing ChimeSDKVoice
    ///
    /// 
    /// </summary>
    public partial class AmazonChimeSDKVoiceClient : AmazonServiceClient, IAmazonChimeSDKVoice
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeSDKVoiceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonChimeSDKVoiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKVoiceConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKVoiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKVoiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonChimeSDKVoiceClient Configuration Object</param>
        public AmazonChimeSDKVoiceClient(AmazonChimeSDKVoiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeSDKVoiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeSDKVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKVoiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeSDKVoiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Credentials and an
        /// AmazonChimeSDKVoiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeSDKVoiceClient Configuration Object</param>
        public AmazonChimeSDKVoiceClient(AWSCredentials credentials, AmazonChimeSDKVoiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKVoiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKVoiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeSDKVoiceClient Configuration Object</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeSDKVoiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKVoiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKVoiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKVoiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKVoiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeSDKVoiceClient Configuration Object</param>
        public AmazonChimeSDKVoiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeSDKVoiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IChimeSDKVoicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IChimeSDKVoicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ChimeSDKVoicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonChimeSDKVoiceEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssociatePhoneNumbersWithVoiceConnector

        internal virtual AssociatePhoneNumbersWithVoiceConnectorResponse AssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<AssociatePhoneNumbersWithVoiceConnectorResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        public virtual Task<AssociatePhoneNumbersWithVoiceConnectorResponse> AssociatePhoneNumbersWithVoiceConnectorAsync(AssociatePhoneNumbersWithVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<AssociatePhoneNumbersWithVoiceConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociatePhoneNumbersWithVoiceConnectorGroup

        internal virtual AssociatePhoneNumbersWithVoiceConnectorGroupResponse AssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<AssociatePhoneNumbersWithVoiceConnectorGroupResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        public virtual Task<AssociatePhoneNumbersWithVoiceConnectorGroupResponse> AssociatePhoneNumbersWithVoiceConnectorGroupAsync(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociatePhoneNumbersWithVoiceConnectorGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeletePhoneNumber

        internal virtual BatchDeletePhoneNumberResponse BatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<BatchDeletePhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeletePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        public virtual Task<BatchDeletePhoneNumberResponse> BatchDeletePhoneNumberAsync(BatchDeletePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeletePhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchUpdatePhoneNumber

        internal virtual BatchUpdatePhoneNumberResponse BatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<BatchUpdatePhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdatePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        public virtual Task<BatchUpdatePhoneNumberResponse> BatchUpdatePhoneNumberAsync(BatchUpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdatePhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePhoneNumberOrder

        internal virtual CreatePhoneNumberOrderResponse CreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePhoneNumberOrderResponseUnmarshaller.Instance;

            return Invoke<CreatePhoneNumberOrderResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePhoneNumberOrder service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        public virtual Task<CreatePhoneNumberOrderResponse> CreatePhoneNumberOrderAsync(CreatePhoneNumberOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePhoneNumberOrderResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePhoneNumberOrderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateProxySession

        internal virtual CreateProxySessionResponse CreateProxySession(CreateProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxySessionResponseUnmarshaller.Instance;

            return Invoke<CreateProxySessionResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        public virtual Task<CreateProxySessionResponse> CreateProxySessionAsync(CreateProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxySessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProxySessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSipMediaApplication

        internal virtual CreateSipMediaApplicationResponse CreateSipMediaApplication(CreateSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateSipMediaApplicationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        public virtual Task<CreateSipMediaApplicationResponse> CreateSipMediaApplicationAsync(CreateSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSipMediaApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSipMediaApplicationCall

        internal virtual CreateSipMediaApplicationCallResponse CreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return Invoke<CreateSipMediaApplicationCallResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipMediaApplicationCall service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        public virtual Task<CreateSipMediaApplicationCallResponse> CreateSipMediaApplicationCallAsync(CreateSipMediaApplicationCallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSipMediaApplicationCallResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSipRule

        internal virtual CreateSipRuleResponse CreateSipRule(CreateSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSipRuleResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        public virtual Task<CreateSipRuleResponse> CreateSipRuleAsync(CreateSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSipRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVoiceConnector

        internal virtual CreateVoiceConnectorResponse CreateVoiceConnector(CreateVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceConnectorResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        public virtual Task<CreateVoiceConnectorResponse> CreateVoiceConnectorAsync(CreateVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVoiceConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVoiceConnectorGroup

        internal virtual CreateVoiceConnectorGroupResponse CreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceConnectorGroupResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        public virtual Task<CreateVoiceConnectorGroupResponse> CreateVoiceConnectorGroupAsync(CreateVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVoiceConnectorGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePhoneNumber

        internal virtual DeletePhoneNumberResponse DeletePhoneNumber(DeletePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<DeletePhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        public virtual Task<DeletePhoneNumberResponse> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProxySession

        internal virtual DeleteProxySessionResponse DeleteProxySession(DeleteProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxySessionResponseUnmarshaller.Instance;

            return Invoke<DeleteProxySessionResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        public virtual Task<DeleteProxySessionResponse> DeleteProxySessionAsync(DeleteProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxySessionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProxySessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSipMediaApplication

        internal virtual DeleteSipMediaApplicationResponse DeleteSipMediaApplication(DeleteSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteSipMediaApplicationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        public virtual Task<DeleteSipMediaApplicationResponse> DeleteSipMediaApplicationAsync(DeleteSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipMediaApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSipMediaApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSipRule

        internal virtual DeleteSipRuleResponse DeleteSipRule(DeleteSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSipRuleResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        public virtual Task<DeleteSipRuleResponse> DeleteSipRuleAsync(DeleteSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSipRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceConnector

        internal virtual DeleteVoiceConnectorResponse DeleteVoiceConnector(DeleteVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        public virtual Task<DeleteVoiceConnectorResponse> DeleteVoiceConnectorAsync(DeleteVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceConnectorEmergencyCallingConfiguration

        internal virtual DeleteVoiceConnectorEmergencyCallingConfigurationResponse DeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual Task<DeleteVoiceConnectorEmergencyCallingConfigurationResponse> DeleteVoiceConnectorEmergencyCallingConfigurationAsync(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceConnectorEmergencyCallingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceConnectorGroup

        internal virtual DeleteVoiceConnectorGroupResponse DeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorGroupResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        public virtual Task<DeleteVoiceConnectorGroupResponse> DeleteVoiceConnectorGroupAsync(DeleteVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceConnectorGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceConnectorOrigination

        internal virtual DeleteVoiceConnectorOriginationResponse DeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorOriginationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        public virtual Task<DeleteVoiceConnectorOriginationResponse> DeleteVoiceConnectorOriginationAsync(DeleteVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceConnectorOriginationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceConnectorProxy

        internal virtual DeleteVoiceConnectorProxyResponse DeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorProxyResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        public virtual Task<DeleteVoiceConnectorProxyResponse> DeleteVoiceConnectorProxyAsync(DeleteVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorProxyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceConnectorProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceConnectorStreamingConfiguration

        internal virtual DeleteVoiceConnectorStreamingConfigurationResponse DeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorStreamingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual Task<DeleteVoiceConnectorStreamingConfigurationResponse> DeleteVoiceConnectorStreamingConfigurationAsync(DeleteVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceConnectorStreamingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceConnectorTermination

        internal virtual DeleteVoiceConnectorTerminationResponse DeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorTerminationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        public virtual Task<DeleteVoiceConnectorTerminationResponse> DeleteVoiceConnectorTerminationAsync(DeleteVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceConnectorTerminationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVoiceConnectorTerminationCredentials

        internal virtual DeleteVoiceConnectorTerminationCredentialsResponse DeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorTerminationCredentialsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual Task<DeleteVoiceConnectorTerminationCredentialsResponse> DeleteVoiceConnectorTerminationCredentialsAsync(DeleteVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceConnectorTerminationCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociatePhoneNumbersFromVoiceConnector

        internal virtual DisassociatePhoneNumbersFromVoiceConnectorResponse DisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<DisassociatePhoneNumbersFromVoiceConnectorResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        public virtual Task<DisassociatePhoneNumbersFromVoiceConnectorResponse> DisassociatePhoneNumbersFromVoiceConnectorAsync(DisassociatePhoneNumbersFromVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociatePhoneNumbersFromVoiceConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociatePhoneNumbersFromVoiceConnectorGroup

        internal virtual DisassociatePhoneNumbersFromVoiceConnectorGroupResponse DisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        public virtual Task<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse> DisassociatePhoneNumbersFromVoiceConnectorGroupAsync(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGlobalSettings

        internal virtual GetGlobalSettingsResponse GetGlobalSettings(GetGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<GetGlobalSettingsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlobalSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        public virtual Task<GetGlobalSettingsResponse> GetGlobalSettingsAsync(GetGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetGlobalSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPhoneNumber

        internal virtual GetPhoneNumberResponse GetPhoneNumber(GetPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        public virtual Task<GetPhoneNumberResponse> GetPhoneNumberAsync(GetPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<GetPhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPhoneNumberOrder

        internal virtual GetPhoneNumberOrderResponse GetPhoneNumberOrder(GetPhoneNumberOrderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberOrderResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberOrderResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumberOrder service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        public virtual Task<GetPhoneNumberOrderResponse> GetPhoneNumberOrderAsync(GetPhoneNumberOrderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberOrderResponseUnmarshaller.Instance;

            return InvokeAsync<GetPhoneNumberOrderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPhoneNumberSettings

        internal virtual GetPhoneNumberSettingsResponse GetPhoneNumberSettings(GetPhoneNumberSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberSettingsResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberSettingsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPhoneNumberSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        public virtual Task<GetPhoneNumberSettingsResponse> GetPhoneNumberSettingsAsync(GetPhoneNumberSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetPhoneNumberSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProxySession

        internal virtual GetProxySessionResponse GetProxySession(GetProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxySessionResponseUnmarshaller.Instance;

            return Invoke<GetProxySessionResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        public virtual Task<GetProxySessionResponse> GetProxySessionAsync(GetProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxySessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetProxySessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSipMediaApplication

        internal virtual GetSipMediaApplicationResponse GetSipMediaApplication(GetSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<GetSipMediaApplicationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        public virtual Task<GetSipMediaApplicationResponse> GetSipMediaApplicationAsync(GetSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSipMediaApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSipMediaApplicationAlexaSkillConfiguration

        internal virtual GetSipMediaApplicationAlexaSkillConfigurationResponse GetSipMediaApplicationAlexaSkillConfiguration(GetSipMediaApplicationAlexaSkillConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationAlexaSkillConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationAlexaSkillConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSipMediaApplicationAlexaSkillConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationAlexaSkillConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipMediaApplicationAlexaSkillConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationAlexaSkillConfiguration">REST API Reference for GetSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        public virtual Task<GetSipMediaApplicationAlexaSkillConfigurationResponse> GetSipMediaApplicationAlexaSkillConfigurationAsync(GetSipMediaApplicationAlexaSkillConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationAlexaSkillConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationAlexaSkillConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSipMediaApplicationAlexaSkillConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSipMediaApplicationLoggingConfiguration

        internal virtual GetSipMediaApplicationLoggingConfigurationResponse GetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSipMediaApplicationLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipMediaApplicationLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual Task<GetSipMediaApplicationLoggingConfigurationResponse> GetSipMediaApplicationLoggingConfigurationAsync(GetSipMediaApplicationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSipMediaApplicationLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSipRule

        internal virtual GetSipRuleResponse GetSipRule(GetSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipRuleResponseUnmarshaller.Instance;

            return Invoke<GetSipRuleResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        public virtual Task<GetSipRuleResponse> GetSipRuleAsync(GetSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetSipRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnector

        internal virtual GetVoiceConnectorResponse GetVoiceConnector(GetVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        public virtual Task<GetVoiceConnectorResponse> GetVoiceConnectorAsync(GetVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnectorEmergencyCallingConfiguration

        internal virtual GetVoiceConnectorEmergencyCallingConfigurationResponse GetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual Task<GetVoiceConnectorEmergencyCallingConfigurationResponse> GetVoiceConnectorEmergencyCallingConfigurationAsync(GetVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorEmergencyCallingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnectorGroup

        internal virtual GetVoiceConnectorGroupResponse GetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorGroupResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        public virtual Task<GetVoiceConnectorGroupResponse> GetVoiceConnectorGroupAsync(GetVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnectorLoggingConfiguration

        internal virtual GetVoiceConnectorLoggingConfigurationResponse GetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual Task<GetVoiceConnectorLoggingConfigurationResponse> GetVoiceConnectorLoggingConfigurationAsync(GetVoiceConnectorLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnectorOrigination

        internal virtual GetVoiceConnectorOriginationResponse GetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorOriginationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        public virtual Task<GetVoiceConnectorOriginationResponse> GetVoiceConnectorOriginationAsync(GetVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorOriginationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnectorProxy

        internal virtual GetVoiceConnectorProxyResponse GetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorProxyResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        public virtual Task<GetVoiceConnectorProxyResponse> GetVoiceConnectorProxyAsync(GetVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorProxyResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnectorStreamingConfiguration

        internal virtual GetVoiceConnectorStreamingConfigurationResponse GetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorStreamingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual Task<GetVoiceConnectorStreamingConfigurationResponse> GetVoiceConnectorStreamingConfigurationAsync(GetVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorStreamingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnectorTermination

        internal virtual GetVoiceConnectorTerminationResponse GetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorTerminationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        public virtual Task<GetVoiceConnectorTerminationResponse> GetVoiceConnectorTerminationAsync(GetVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorTerminationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVoiceConnectorTerminationHealth

        internal virtual GetVoiceConnectorTerminationHealthResponse GetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationHealthResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorTerminationHealthResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTerminationHealth service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        public virtual Task<GetVoiceConnectorTerminationHealthResponse> GetVoiceConnectorTerminationHealthAsync(GetVoiceConnectorTerminationHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationHealthResponseUnmarshaller.Instance;

            return InvokeAsync<GetVoiceConnectorTerminationHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableVoiceConnectorRegions

        internal virtual ListAvailableVoiceConnectorRegionsResponse ListAvailableVoiceConnectorRegions(ListAvailableVoiceConnectorRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableVoiceConnectorRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableVoiceConnectorRegionsResponseUnmarshaller.Instance;

            return Invoke<ListAvailableVoiceConnectorRegionsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableVoiceConnectorRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableVoiceConnectorRegions service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListAvailableVoiceConnectorRegions">REST API Reference for ListAvailableVoiceConnectorRegions Operation</seealso>
        public virtual Task<ListAvailableVoiceConnectorRegionsResponse> ListAvailableVoiceConnectorRegionsAsync(ListAvailableVoiceConnectorRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableVoiceConnectorRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableVoiceConnectorRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAvailableVoiceConnectorRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPhoneNumberOrders

        internal virtual ListPhoneNumberOrdersResponse ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumberOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumberOrdersResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumberOrdersResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumberOrders service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        public virtual Task<ListPhoneNumberOrdersResponse> ListPhoneNumberOrdersAsync(ListPhoneNumberOrdersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumberOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumberOrdersResponseUnmarshaller.Instance;

            return InvokeAsync<ListPhoneNumberOrdersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPhoneNumbers

        internal virtual ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumbersResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual Task<ListPhoneNumbersResponse> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<ListPhoneNumbersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProxySessions

        internal virtual ListProxySessionsResponse ListProxySessions(ListProxySessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProxySessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxySessionsResponseUnmarshaller.Instance;

            return Invoke<ListProxySessionsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProxySessions service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        public virtual Task<ListProxySessionsResponse> ListProxySessionsAsync(ListProxySessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProxySessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxySessionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProxySessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSipMediaApplications

        internal virtual ListSipMediaApplicationsResponse ListSipMediaApplications(ListSipMediaApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipMediaApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipMediaApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListSipMediaApplicationsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSipMediaApplications service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        public virtual Task<ListSipMediaApplicationsResponse> ListSipMediaApplicationsAsync(ListSipMediaApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipMediaApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipMediaApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSipMediaApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSipRules

        internal virtual ListSipRulesResponse ListSipRules(ListSipRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipRulesResponseUnmarshaller.Instance;

            return Invoke<ListSipRulesResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSipRules service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        public virtual Task<ListSipRulesResponse> ListSipRulesAsync(ListSipRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSipRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSupportedPhoneNumberCountries

        internal virtual ListSupportedPhoneNumberCountriesResponse ListSupportedPhoneNumberCountries(ListSupportedPhoneNumberCountriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSupportedPhoneNumberCountriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedPhoneNumberCountriesResponseUnmarshaller.Instance;

            return Invoke<ListSupportedPhoneNumberCountriesResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedPhoneNumberCountries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupportedPhoneNumberCountries service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListSupportedPhoneNumberCountries">REST API Reference for ListSupportedPhoneNumberCountries Operation</seealso>
        public virtual Task<ListSupportedPhoneNumberCountriesResponse> ListSupportedPhoneNumberCountriesAsync(ListSupportedPhoneNumberCountriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSupportedPhoneNumberCountriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedPhoneNumberCountriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSupportedPhoneNumberCountriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVoiceConnectorGroups

        internal virtual ListVoiceConnectorGroupsResponse ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorGroupsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorGroupsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectorGroups service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        public virtual Task<ListVoiceConnectorGroupsResponse> ListVoiceConnectorGroupsAsync(ListVoiceConnectorGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVoiceConnectorGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVoiceConnectors

        internal virtual ListVoiceConnectorsResponse ListVoiceConnectors(ListVoiceConnectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectors service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        public virtual Task<ListVoiceConnectorsResponse> ListVoiceConnectorsAsync(ListVoiceConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVoiceConnectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVoiceConnectorTerminationCredentials

        internal virtual ListVoiceConnectorTerminationCredentialsResponse ListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorTerminationCredentialsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual Task<ListVoiceConnectorTerminationCredentialsResponse> ListVoiceConnectorTerminationCredentialsAsync(ListVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVoiceConnectorTerminationCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSipMediaApplicationAlexaSkillConfiguration

        internal virtual PutSipMediaApplicationAlexaSkillConfigurationResponse PutSipMediaApplicationAlexaSkillConfiguration(PutSipMediaApplicationAlexaSkillConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationAlexaSkillConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationAlexaSkillConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutSipMediaApplicationAlexaSkillConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationAlexaSkillConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSipMediaApplicationAlexaSkillConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationAlexaSkillConfiguration">REST API Reference for PutSipMediaApplicationAlexaSkillConfiguration Operation</seealso>
        public virtual Task<PutSipMediaApplicationAlexaSkillConfigurationResponse> PutSipMediaApplicationAlexaSkillConfigurationAsync(PutSipMediaApplicationAlexaSkillConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationAlexaSkillConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationAlexaSkillConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutSipMediaApplicationAlexaSkillConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSipMediaApplicationLoggingConfiguration

        internal virtual PutSipMediaApplicationLoggingConfigurationResponse PutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutSipMediaApplicationLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSipMediaApplicationLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual Task<PutSipMediaApplicationLoggingConfigurationResponse> PutSipMediaApplicationLoggingConfigurationAsync(PutSipMediaApplicationLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutSipMediaApplicationLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutVoiceConnectorEmergencyCallingConfiguration

        internal virtual PutVoiceConnectorEmergencyCallingConfigurationResponse PutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorEmergencyCallingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual Task<PutVoiceConnectorEmergencyCallingConfigurationResponse> PutVoiceConnectorEmergencyCallingConfigurationAsync(PutVoiceConnectorEmergencyCallingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutVoiceConnectorEmergencyCallingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutVoiceConnectorLoggingConfiguration

        internal virtual PutVoiceConnectorLoggingConfigurationResponse PutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorLoggingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual Task<PutVoiceConnectorLoggingConfigurationResponse> PutVoiceConnectorLoggingConfigurationAsync(PutVoiceConnectorLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutVoiceConnectorLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutVoiceConnectorOrigination

        internal virtual PutVoiceConnectorOriginationResponse PutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorOriginationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorOrigination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        public virtual Task<PutVoiceConnectorOriginationResponse> PutVoiceConnectorOriginationAsync(PutVoiceConnectorOriginationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return InvokeAsync<PutVoiceConnectorOriginationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutVoiceConnectorProxy

        internal virtual PutVoiceConnectorProxyResponse PutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorProxyResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorProxy service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        public virtual Task<PutVoiceConnectorProxyResponse> PutVoiceConnectorProxyAsync(PutVoiceConnectorProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorProxyResponseUnmarshaller.Instance;

            return InvokeAsync<PutVoiceConnectorProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutVoiceConnectorStreamingConfiguration

        internal virtual PutVoiceConnectorStreamingConfigurationResponse PutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorStreamingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorStreamingConfiguration service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual Task<PutVoiceConnectorStreamingConfigurationResponse> PutVoiceConnectorStreamingConfigurationAsync(PutVoiceConnectorStreamingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutVoiceConnectorStreamingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutVoiceConnectorTermination

        internal virtual PutVoiceConnectorTerminationResponse PutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorTerminationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTermination service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        public virtual Task<PutVoiceConnectorTerminationResponse> PutVoiceConnectorTerminationAsync(PutVoiceConnectorTerminationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return InvokeAsync<PutVoiceConnectorTerminationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutVoiceConnectorTerminationCredentials

        internal virtual PutVoiceConnectorTerminationCredentialsResponse PutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorTerminationCredentialsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTerminationCredentials service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual Task<PutVoiceConnectorTerminationCredentialsResponse> PutVoiceConnectorTerminationCredentialsAsync(PutVoiceConnectorTerminationCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<PutVoiceConnectorTerminationCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestorePhoneNumber

        internal virtual RestorePhoneNumberResponse RestorePhoneNumber(RestorePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestorePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestorePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<RestorePhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestorePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        public virtual Task<RestorePhoneNumberResponse> RestorePhoneNumberAsync(RestorePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestorePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestorePhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<RestorePhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchAvailablePhoneNumbers

        internal virtual SearchAvailablePhoneNumbersResponse SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAvailablePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<SearchAvailablePhoneNumbersResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAvailablePhoneNumbers service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual Task<SearchAvailablePhoneNumbersResponse> SearchAvailablePhoneNumbersAsync(SearchAvailablePhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAvailablePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<SearchAvailablePhoneNumbersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlobalSettings

        internal virtual UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalSettingsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual Task<UpdateGlobalSettingsResponse> UpdateGlobalSettingsAsync(UpdateGlobalSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGlobalSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePhoneNumber

        internal virtual UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<UpdatePhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePhoneNumberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePhoneNumberSettings

        internal virtual UpdatePhoneNumberSettingsResponse UpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdatePhoneNumberSettingsResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumberSettings service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        public virtual Task<UpdatePhoneNumberSettingsResponse> UpdatePhoneNumberSettingsAsync(UpdatePhoneNumberSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePhoneNumberSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateProxySession

        internal virtual UpdateProxySessionResponse UpdateProxySession(UpdateProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxySessionResponseUnmarshaller.Instance;

            return Invoke<UpdateProxySessionResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProxySession service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        public virtual Task<UpdateProxySessionResponse> UpdateProxySessionAsync(UpdateProxySessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxySessionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProxySessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSipMediaApplication

        internal virtual UpdateSipMediaApplicationResponse UpdateSipMediaApplication(UpdateSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateSipMediaApplicationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplication service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        public virtual Task<UpdateSipMediaApplicationResponse> UpdateSipMediaApplicationAsync(UpdateSipMediaApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSipMediaApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSipMediaApplicationCall

        internal virtual UpdateSipMediaApplicationCallResponse UpdateSipMediaApplicationCall(UpdateSipMediaApplicationCallRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return Invoke<UpdateSipMediaApplicationCallResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplicationCall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplicationCall service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipMediaApplicationCall">REST API Reference for UpdateSipMediaApplicationCall Operation</seealso>
        public virtual Task<UpdateSipMediaApplicationCallResponse> UpdateSipMediaApplicationCallAsync(UpdateSipMediaApplicationCallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSipMediaApplicationCallResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSipRule

        internal virtual UpdateSipRuleResponse UpdateSipRule(UpdateSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSipRuleResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSipRule service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ResourceLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        public virtual Task<UpdateSipRuleResponse> UpdateSipRuleAsync(UpdateSipRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSipRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVoiceConnector

        internal virtual UpdateVoiceConnectorResponse UpdateVoiceConnector(UpdateVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceConnectorResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceConnector service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        public virtual Task<UpdateVoiceConnectorResponse> UpdateVoiceConnectorAsync(UpdateVoiceConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVoiceConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVoiceConnectorGroup

        internal virtual UpdateVoiceConnectorGroupResponse UpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceConnectorGroupResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVoiceConnectorGroup service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        public virtual Task<UpdateVoiceConnectorGroupResponse> UpdateVoiceConnectorGroupAsync(UpdateVoiceConnectorGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVoiceConnectorGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateE911Address

        internal virtual ValidateE911AddressResponse ValidateE911Address(ValidateE911AddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateE911AddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateE911AddressResponseUnmarshaller.Instance;

            return Invoke<ValidateE911AddressResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateE911Address service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateE911Address service method, as returned by ChimeSDKVoice.</returns>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.ThrottledClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKVoice.Model.UnauthorizedClientException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-voice-2022-08-03/ValidateE911Address">REST API Reference for ValidateE911Address Operation</seealso>
        public virtual Task<ValidateE911AddressResponse> ValidateE911AddressAsync(ValidateE911AddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateE911AddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateE911AddressResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateE911AddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}