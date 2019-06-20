// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Netapp.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of the request to list Cloud Volume operations. It contains a
    /// list of operations and a URL link to get the next set of results.
    /// </summary>
    public partial class OperationListResult
    {
        /// <summary>
        /// Initializes a new instance of the OperationListResult class.
        /// </summary>
        public OperationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationListResult class.
        /// </summary>
        /// <param name="value">List of Storage operations supported by the
        /// Storage resource provider.</param>
        public OperationListResult(IList<Operation> value = default(IList<Operation>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Storage operations supported by the Storage
        /// resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Operation> Value { get; set; }

    }
}
