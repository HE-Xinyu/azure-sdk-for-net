// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Models
{
    /// <summary> Status of an indexing operation for a single document. </summary>
    public partial class IndexingResult
    {
        /// <summary> Initializes a new instance of <see cref="IndexingResult"/>. </summary>
        /// <param name="key"> The key of a document that was in the indexing request. </param>
        /// <param name="succeeded"> A value indicating whether the indexing operation succeeded for the document identified by the key. </param>
        /// <param name="status"> The status code of the indexing operation. Possible values include: 200 for a successful update or delete, 201 for successful document creation, 400 for a malformed input document, 404 for document not found, 409 for a version conflict, 422 when the index is temporarily unavailable, or 503 for when the service is too busy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        internal IndexingResult(string key, bool succeeded, int status)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Key = key;
            Succeeded = succeeded;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="IndexingResult"/>. </summary>
        /// <param name="key"> The key of a document that was in the indexing request. </param>
        /// <param name="errorMessage"> The error message explaining why the indexing operation failed for the document identified by the key; null if indexing succeeded. </param>
        /// <param name="succeeded"> A value indicating whether the indexing operation succeeded for the document identified by the key. </param>
        /// <param name="status"> The status code of the indexing operation. Possible values include: 200 for a successful update or delete, 201 for successful document creation, 400 for a malformed input document, 404 for document not found, 409 for a version conflict, 422 when the index is temporarily unavailable, or 503 for when the service is too busy. </param>
        internal IndexingResult(string key, string errorMessage, bool succeeded, int status)
        {
            Key = key;
            ErrorMessage = errorMessage;
            Succeeded = succeeded;
            Status = status;
        }

        /// <summary> The key of a document that was in the indexing request. </summary>
        public string Key { get; }
        /// <summary> The error message explaining why the indexing operation failed for the document identified by the key; null if indexing succeeded. </summary>
        public string ErrorMessage { get; }
        /// <summary> A value indicating whether the indexing operation succeeded for the document identified by the key. </summary>
        public bool Succeeded { get; }
    }
}
