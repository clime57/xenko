﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using SiliconStudio.Core;
using SiliconStudio.Core.Serialization;

namespace SiliconStudio.Xenko.Shaders
{
    /// <summary>
    /// Enum to specify shader stage.
    /// </summary>
    [DataContract]
    public enum ShaderStage
    {
        /// <summary>
        /// No shader stage defined.
        /// </summary>
        None = 0,

        /// <summary>
        /// The vertex shader stage.
        /// </summary>
        Vertex = 1,

        /// <summary>
        /// The Hull shader stage.
        /// </summary>
        Hull = 2,

        /// <summary>
        /// The domain shader stage.
        /// </summary>
        Domain = 3,

        /// <summary>
        /// The geometry shader stage.
        /// </summary>
        Geometry = 4,

        /// <summary>
        /// The pixel shader stage.
        /// </summary>
        Pixel = 5,

        /// <summary>
        /// The compute shader stage.
        /// </summary>
        Compute = 6,
    }
}