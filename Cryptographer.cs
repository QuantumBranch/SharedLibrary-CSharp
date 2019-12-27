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

using System.Security.Cryptography;
using System.Text;

namespace OpenSharedLibrary
{
    /// <summary>
    /// Cryptography usefull method container class
    /// </summary>
    public static class Cryptographer
    {
        /// <summary>
        /// SHA512 hash byte array size
        /// </summary>
        public const int ByteSizeSHA512 = 64; // (512 / 8)

        /// <summary>
        /// Returns byte array SHA512 hash value
        /// </summary>
        public static byte[] ToSHA512(byte[] array)
        {
            using var encryptor = SHA512.Create();
            return encryptor.ComputeHash(array);
        }
        /// <summary>
        /// Returns byte array SHA512 hash value
        /// </summary>
        public static byte[] ToSHA512(byte[] array, int iterationCount)
        {
            using (var encryptor = SHA512.Create())
            {
                for (int i = 0; i < iterationCount; i++)
                    array = encryptor.ComputeHash(array);
            }

            return array;
        }
        /// <summary>
        /// Returns string SHA512 hash value
        /// </summary>
        public static byte[] ToSHA512(string value, Encoding encoding)
        {
            var array = encoding.GetBytes(value);
            return ToSHA512(array);
        }
        /// <summary>
        /// Returns string SHA512 hash value
        /// </summary>
        public static byte[] ToSHA512(string value, Encoding encoding, int iterationCount)
        {
            var array = encoding.GetBytes(value);
            return ToSHA512(array, iterationCount);
        }

        /// <summary>
        /// Fills an array of bytes with a cryptographically strong sequence of random values
        /// </summary>
        public static void FillWithSecureRandom(byte[] array)
        {
            using var rngCsp = new RNGCryptoServiceProvider();
            rngCsp.GetBytes(array);
        }
        /// <summary>
        /// Returns an array of bytes with a cryptographically strong sequence of random values
        /// </summary>
        public static byte[] GetSecureRandom(int size)
        {
            var array = new byte[size];
            using var rngCsp = new RNGCryptoServiceProvider();
            rngCsp.GetBytes(array);
            return array;
        }
    }
}