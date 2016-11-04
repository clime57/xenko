﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Core;

namespace SiliconStudio.Xenko.Rendering.Materials.ComputeColors
{
    /// <summary>
    /// A color coming from a vertex stream
    /// </summary>
    /// <userdoc>A color coming from a vertex stream.</userdoc>
    [DataContract("ColorVertexStreamDefinition")]
    [Display("Color Vertex Stream")]
    public class ColorVertexStreamDefinition : IndexedVertexStreamDefinition
    {
        private const string semanticName = "COLOR";

        private static readonly int hashCode = semanticName.GetHashCode();

        public override int GetHashCode() => hashCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorVertexStreamDefinition"/> class.
        /// </summary>
        public ColorVertexStreamDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorVertexStreamDefinition"/> class.
        /// </summary>
        /// <param name="index">The index.</param>
        public ColorVertexStreamDefinition(int index)
            : base(index)
        {
        }

        protected override string GetSemanticPrefixName()
        {
            return semanticName;
        }

        public override int GetSemanticNameHash()
        {
            return hashCode;
        }
    }
}