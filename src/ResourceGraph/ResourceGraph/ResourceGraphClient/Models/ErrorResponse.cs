// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.WindowsAzure.Governance.ResourcesCache.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error response.
    /// </summary>
    /// <remarks>
    /// An error response from the API.
    /// </remarks>
    public partial class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        /// <param name="error">Error information.</param>
        public ErrorResponse(Error error)
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error information.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Error == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Error");
            }
            if (Error != null)
            {
                Error.Validate();
            }
        }
    }
}
