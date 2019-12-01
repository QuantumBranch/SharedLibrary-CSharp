﻿
// Copyright 2019 Nikita Fediuchin (QuantumBranch)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.IO;
using System.Numerics;

namespace QuantumBranch.OpenSharedLibrary
{
    /// <summary>
    /// Vector classes extension container class
    /// </summary>
    public static class VectorExtension
    {
        /// <summary>
        /// Two-dimensional vector byte array size
        /// </summary>
        public const int ByteSizeVector2 = sizeof(float) * 2;
        /// <summary>
        /// Three-dimensional vector byte array size
        /// </summary>
        public const int ByteSizeVector3 = sizeof(float) * 3;

        /// <summary>
        /// Converts two-dimensional vector to the byte array
        /// </summary>
        public static void ToBytes(this Vector2 vector, BinaryWriter binaryWriter)
        {
            binaryWriter.Write(vector.X);
            binaryWriter.Write(vector.Y);
        }
        /// <summary>
        /// Converts three-dimensional vector to the byte array
        /// </summary>
        public static void ToBytes(this Vector3 vector, BinaryWriter binaryWriter)
        {
            binaryWriter.Write(vector.X);
            binaryWriter.Write(vector.Y);
            binaryWriter.Write(vector.Z);
        }
        /// <summary>
        /// Converts two-dimensional integer vector to the byte array
        /// </summary>
        public static void ToBytesInt(this Vector2 vector, BinaryWriter binaryWriter)
        {
            binaryWriter.Write((int)vector.X);
            binaryWriter.Write((int)vector.Y);
        }
        /// <summary>
        /// Converts three-dimensional integer vector to the byte array
        /// </summary>
        public static void ToBytesInt(this Vector3 vector, BinaryWriter binaryWriter)
        {
            binaryWriter.Write((int)vector.X);
            binaryWriter.Write((int)vector.Y);
            binaryWriter.Write((int)vector.Z);
        }

        /// <summary>
        /// Converts byte array to the two-dimensional vector
        /// </summary>
        public static Vector2 ToVector2(BinaryReader binaryReader)
        {
            return new Vector2(binaryReader.ReadSingle(), binaryReader.ReadSingle());
        }
        /// <summary>
        /// Converts byte array to the three-dimensional vector
        /// </summary>
        public static Vector3 ToVector3(BinaryReader binaryReader)
        {
            return new Vector3(binaryReader.ReadSingle(), binaryReader.ReadSingle(), binaryReader.ReadSingle());
        }
        /// <summary>
        /// Converts byte array to the two-dimensional integer vector
        /// </summary>
        public static Vector2 ToVector2Int(BinaryReader binaryReader)
        {
            return new Vector2(binaryReader.ReadInt32(), binaryReader.ReadInt32());
        }
        /// <summary>
        /// Converts byte array to the three-dimensional integer vector
        /// </summary>
        public static Vector3 ToVector3Int(BinaryReader binaryReader)
        {
            return new Vector3(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        }
    }
}
