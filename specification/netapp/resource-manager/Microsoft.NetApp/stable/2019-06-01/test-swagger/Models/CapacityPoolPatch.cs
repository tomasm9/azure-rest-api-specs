// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Netapp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Capacity pool patch resource
    /// </summary>
    [JsonTransformation]
    public partial class CapacityPoolPatch
    {
        /// <summary>
        /// Initializes a new instance of the CapacityPoolPatch class.
        /// </summary>
        public CapacityPoolPatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityPoolPatch class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="size">size</param>
        /// <param name="serviceLevel">serviceLevel</param>
        public CapacityPoolPatch(string location = default(string), string id = default(string), string name = default(string), string type = default(string), object tags = default(object), long? size = default(long?), string serviceLevel = default(string))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            Size = size;
            ServiceLevel = serviceLevel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public object Tags { get; set; }

        /// <summary>
        /// Gets or sets size
        /// </summary>
        /// <remarks>
        /// Provisioned size of the pool (in bytes). Allowed values are in 4TiB
        /// chunks (value must be multiply of 4398046511104).
        /// </remarks>
        [JsonProperty(PropertyName = "properties.size")]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or sets serviceLevel
        /// </summary>
        /// <remarks>
        /// The service level of the file system. Possible values include:
        /// 'Standard', 'Premium', 'Ultra'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.serviceLevel")]
        public string ServiceLevel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Size > 549755813888000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Size", 549755813888000);
            }
            if (Size < 4398046511104)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Size", 4398046511104);
            }
        }
    }
}
