// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Output of check name availability API. </summary>
    public partial class CdnNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of CdnNameAvailabilityResult. </summary>
        internal CdnNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of CdnNameAvailabilityResult. </summary>
        /// <param name="nameAvailable"> Indicates whether the name is available. </param>
        /// <param name="reason"> The reason why the name is not available. </param>
        /// <param name="message"> The detailed error message describing why the name is not available. </param>
        internal CdnNameAvailabilityResult(bool? nameAvailable, string reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> Indicates whether the name is available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason why the name is not available. </summary>
        public string Reason { get; }
        /// <summary> The detailed error message describing why the name is not available. </summary>
        public string Message { get; }
    }
}
