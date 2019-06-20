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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NetApp account resource
    /// </summary>
    [JsonTransformation]
    public partial class NetAppAccount
    {
        /// <summary>
        /// Initializes a new instance of the NetAppAccount class.
        /// </summary>
        public NetAppAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetAppAccount class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="activeDirectories">Active Directories</param>
        public NetAppAccount(string location, string id = default(string), string name = default(string), string type = default(string), object tags = default(object), string provisioningState = default(string), IList<ActiveDirectory> activeDirectories = default(IList<ActiveDirectory>))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            ProvisioningState = provisioningState;
            ActiveDirectories = activeDirectories;
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
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets active Directories
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeDirectories")]
        public IList<ActiveDirectory> ActiveDirectories { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
