// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    /// <summary> Storage class volume binding mode. </summary>
    public readonly partial struct VolumeBindingMode : IEquatable<VolumeBindingMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VolumeBindingMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VolumeBindingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ImmediateValue = "Immediate";
        private const string WaitForFirstConsumerValue = "WaitForFirstConsumer";

        /// <summary> Immediate binding mode. </summary>
        public static VolumeBindingMode Immediate { get; } = new VolumeBindingMode(ImmediateValue);
        /// <summary> Wait for first consumer binding mode. </summary>
        public static VolumeBindingMode WaitForFirstConsumer { get; } = new VolumeBindingMode(WaitForFirstConsumerValue);
        /// <summary> Determines if two <see cref="VolumeBindingMode"/> values are the same. </summary>
        public static bool operator ==(VolumeBindingMode left, VolumeBindingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VolumeBindingMode"/> values are not the same. </summary>
        public static bool operator !=(VolumeBindingMode left, VolumeBindingMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VolumeBindingMode"/>. </summary>
        public static implicit operator VolumeBindingMode(string value) => new VolumeBindingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VolumeBindingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VolumeBindingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
