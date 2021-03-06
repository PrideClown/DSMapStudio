﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Numerics;
using Veldrid;

namespace StudioCore.Resource
{
    public enum FlverLayoutType
    {
        LayoutMinimal,
        LayoutSky,
        LayoutStandard,
        LayoutUV2,
        LayoutUV3,
        LayoutUV4
    }

    public static class FlverLayoutUtils
    {
        public static VertexLayoutDescription GetLayoutDescription(FlverLayoutType type)
        {
            switch (type)
            {
                case FlverLayoutType.LayoutMinimal:
                    return FlverLayoutMinimal.Layout;
                case FlverLayoutType.LayoutSky:
                    return FlverLayoutSky.Layout;
                case FlverLayoutType.LayoutStandard:
                    return FlverLayout.Layout;
                case FlverLayoutType.LayoutUV2:
                    return FlverLayoutUV2.Layout;
                case FlverLayoutType.LayoutUV3:
                    return FlverLayoutUV2.Layout;
                case FlverLayoutType.LayoutUV4:
                    return FlverLayoutUV2.Layout;
                default:
                    throw new ArgumentException("Invalid layout type");
            }
        }

        public static unsafe uint GetLayoutVertexSize(FlverLayoutType type)
        {
            switch (type)
            {
                case FlverLayoutType.LayoutMinimal:
                    return (uint)sizeof(FlverLayoutMinimal);
                case FlverLayoutType.LayoutSky:
                    return (uint)sizeof(FlverLayoutSky);
                case FlverLayoutType.LayoutStandard:
                    return (uint)sizeof(FlverLayout);
                case FlverLayoutType.LayoutUV2:
                    return (uint)sizeof(FlverLayoutUV2);
                case FlverLayoutType.LayoutUV3:
                    return (uint)sizeof(FlverLayoutUV2);
                case FlverLayoutType.LayoutUV4:
                    return (uint)sizeof(FlverLayoutUV2);
                default:
                    throw new ArgumentException("Invalid layout type");
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FlverLayoutMinimal
    {
        public Vector3 Position;
        public fixed short Uv1[2];
        public fixed sbyte Normal[4];
        public fixed byte Color[4];

        public static VertexLayoutDescription Layout = new VertexLayoutDescription(
            new VertexElementDescription("position", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Float3),
            new VertexElementDescription("uv1", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2),
            new VertexElementDescription("normal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("color", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Byte4));
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FlverLayoutSky
    {
        public Vector3 Position;
        public fixed sbyte Normal[4];

        public static VertexLayoutDescription Layout = new VertexLayoutDescription(
            new VertexElementDescription("position", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Float3),
            new VertexElementDescription("normal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4));
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FlverLayout
    {
        public Vector3 Position;
        public fixed short Uv1[2];
        public fixed sbyte Normal[4];
        public fixed sbyte Binormal[4];
        public fixed sbyte Bitangent[4];
        public fixed byte Color[4];

        public static VertexLayoutDescription Layout = new VertexLayoutDescription(
            new VertexElementDescription("position", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Float3),
            new VertexElementDescription("uv1", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2),
            new VertexElementDescription("normal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("binormal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("bitangent", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("color", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Byte4));
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FlverLayoutUV2
    {
        public Vector3 Position;
        public fixed short Uv1[2];
        public fixed sbyte Normal[4];
        public fixed sbyte Binormal[4];
        public fixed sbyte Bitangent[4];
        public fixed byte Color[4];
        public fixed short Uv2[2];

        public static VertexLayoutDescription Layout = new VertexLayoutDescription(
            new VertexElementDescription("position", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Float3),
            new VertexElementDescription("uv1", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2),
            new VertexElementDescription("normal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("binormal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("bitangent", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("color", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Byte4),
            new VertexElementDescription("uv2", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2));
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FlverLayoutUV3
    {
        public Vector3 Position;
        public fixed short Uv1[2];
        public fixed sbyte Normal[4];
        public fixed sbyte Binormal[4];
        public fixed sbyte Bitangent[4];
        public fixed byte Color[4];
        public fixed short Uv2[2];
        public fixed short Uv3[2];

        public static VertexLayoutDescription Layout = new VertexLayoutDescription(
            new VertexElementDescription("position", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Float3),
            new VertexElementDescription("uv1", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2),
            new VertexElementDescription("normal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("binormal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("bitangent", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("color", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Byte4),
            new VertexElementDescription("uv2", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2),
            new VertexElementDescription("uv3", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2));
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct FlverLayoutUV4
    {
        public Vector3 Position;
        public fixed short Uv1[2];
        public fixed sbyte Normal[4];
        public fixed sbyte Binormal[4];
        public fixed sbyte Bitangent[4];
        public fixed byte Color[4];
        public fixed short Uv2[2];
        public fixed short Uv3[2];
        public fixed short Uv4[2];

        public static VertexLayoutDescription Layout = new VertexLayoutDescription(
            new VertexElementDescription("position", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Float3),
            new VertexElementDescription("uv1", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2),
            new VertexElementDescription("normal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("binormal", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("bitangent", VertexElementSemantic.TextureCoordinate, VertexElementFormat.SByte4),
            new VertexElementDescription("color", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Byte4),
            new VertexElementDescription("uv2", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2),
            new VertexElementDescription("uv3", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2),
            new VertexElementDescription("uv4", VertexElementSemantic.TextureCoordinate, VertexElementFormat.Short2));
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct CollisionLayout
    {
        public const uint SizeInBytes = 20;
        public Vector3 Position;
        public fixed sbyte Normal[4];
        public fixed byte Color[4];
    }
}
