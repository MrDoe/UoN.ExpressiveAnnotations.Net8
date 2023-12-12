﻿/* https://github.com/MrDoe/UoN.ExpressiveAnnotations.Net8
 * Original work Copyright (c) 2014 Jarosław Waliszko
 * Modified work Copyright (c) 2018 The University of Nottingham
 * Modified work Copyright (c) 2023 Christoph Döllinger
 * Licensed MIT: http://opensource.org/licenses/MIT */

namespace UoN.ExpressiveAnnotations.Net8.Analysis
{
    /// <summary>
    ///     Token definition.
    /// </summary>
    public class Token
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="type">The token type.</param>
        /// <param name="value">The token value.</param>
        /// <param name="rawValue">The token raw value.</param>
        /// <param name="location">The token location within a specified expression.</param>
        public Token(TokenType type, object value, string rawValue, Location location)
        {
            Type = type;
            Value = value;
            RawValue = rawValue;
            Location = location;
        }

        /// <summary>
        ///     Gets the token type.
        /// </summary>
        public TokenType Type { get; private set; }

        /// <summary>
        ///     Gets the token value (converted to appropriate type).
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        ///     Gets the token raw value (not converted expression string).
        /// </summary>
        public string RawValue { get; private set; }

        /// <summary>
        ///     Gets or sets the token location within a specified expression.
        /// </summary>
        public Location Location { get; private set; }

        /// <summary>
        ///     Generates a human-reabable string for the token instance (handy for debugging purposes).
        /// </summary>
        /// <returns>
        ///     A string that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $@"""{RawValue}"" {Type} ({Location.Line}, {Location.Column})";
        }
    }
}
