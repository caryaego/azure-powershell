// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Custom linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("CustomDataSource")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CustomDataSourceLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the CustomDataSourceLinkedService class.
        /// </summary>
        public CustomDataSourceLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomDataSourceLinkedService class.
        /// </summary>

        /// <param name="additionalProperties">The nested object which contains the information and credential which can
        /// be used to connect with related store or compute resource.
        /// </param>

        /// <param name="connectVia">The integration runtime reference.
        /// </param>

        /// <param name="description">Linked service description.
        /// </param>

        /// <param name="parameters">Parameters for linked service.
        /// </param>

        /// <param name="annotations">List of tags that can be used for describing the linked service.
        /// </param>

        /// <param name="typeProperties">Custom linked service properties.
        /// </param>
        public CustomDataSourceLinkedService(object typeProperties, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), System.Collections.Generic.IDictionary<string, ParameterSpecification> parameters = default(System.Collections.Generic.IDictionary<string, ParameterSpecification>), System.Collections.Generic.IList<object> annotations = default(System.Collections.Generic.IList<object>))

        : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            this.TypeProperties = typeProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets custom linked service properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties")]
        public object TypeProperties {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.TypeProperties == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TypeProperties");
            }

        }
    }
}