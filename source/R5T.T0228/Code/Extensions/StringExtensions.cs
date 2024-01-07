using System;


namespace R5T.T0228.Extensions
{
    public static class StringExtensions
    {

        /// <inheritdoc cref="IStringOperator.ToMethodName(string)"/>
        public static IMethodName ToMethodName(this string value)
        {
            return Instances.StringOperator_Extensions.ToMethodName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToNamespaceName(string)"/>
        public static INamespaceName ToNamespaceName(this string value)
        {
            return Instances.StringOperator_Extensions.ToNamespaceName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToPropertyName(string)"/>
        public static IPropertyName ToPropertyName(this string value)
        {
            return Instances.StringOperator_Extensions.ToPropertyName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToTypeName(string)"/>
        public static ITypeName ToTypeName(this string value)
        {
            return Instances.StringOperator_Extensions.ToTypeName(value);
        }
    }
}
