﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using Microsoft.OData;

namespace Microsoft.AspNet.OData.Formatter.Serialization
{
    /// <summary>
    /// Represents an <see cref="ODataSerializer"/> to serialize <see cref="ODataError"/>s.
    /// </summary>
    public partial class ODataErrorSerializer
    {
        /// <summary>
        /// Return true of the object is an HttpError.
        /// </summary>
        /// <param name="error">The error to test.</param>
        /// <returns>true of the object is an HttpError</returns>
        internal static bool IsHttpError(object error)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create an ODataError from an HttpError.
        /// </summary>
        /// <param name="error">The error to use.</param>
        /// <returns>an ODataError.</returns>
        internal static ODataError CreateODataError(object error)
        {
            throw new NotImplementedException();
        }
    }
}