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
    /// A facet containing additional statistics on the response of a query.
    /// Can be either FacetResult or FacetError.
    /// </summary>
    public partial class Facet
    {
        /// <summary>
        /// Initializes a new instance of the Facet class.
        /// </summary>
        public Facet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Facet class.
        /// </summary>
        /// <param name="expression">Facet expression, same as in the
        /// corresponding facet request.</param>
        public Facet(string expression)
        {
            Expression = expression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets facet expression, same as in the corresponding facet
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Expression == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Expression");
            }
        }
    }
}
