﻿// <copyright file="AggregateVersionException.cs" company="Cognisant">
// Copyright (c) Cognisant. All rights reserved.
// </copyright>

namespace CR.AggregateRepository.Core.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <inheritdoc />
    /// <summary>
    /// Thrown when an incorrect aggregate version is specified
    /// </summary>
    [Serializable]
    public class AggregateVersionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateVersionException" /> class
        /// </summary>
        // ReSharper disable once InheritdocConsiderUsage
        public AggregateVersionException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateVersionException"/> class.
        /// </summary>
        /// <param name="message">Message displayed with the exception.</param>
        // ReSharper disable once InheritdocConsiderUsage
        public AggregateVersionException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateVersionException"/> class.
        /// </summary>
        /// <param name="message">Message displayed with the exception</param>
        /// <param name="inner">The exception that threw this exception</param>
        // ReSharper disable once InheritdocConsiderUsage
        public AggregateVersionException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateVersionException"/> class.
        /// </summary>
        /// <param name="info">Serialization info</param>
        /// <param name="context">Context</param>
        // ReSharper disable once InheritdocConsiderUsage
        protected AggregateVersionException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
