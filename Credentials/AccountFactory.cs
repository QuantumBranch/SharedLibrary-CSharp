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

using System;
using System.IO;
using System.Net;

namespace OpenSharedLibrary.Credentials
{
    /// <summary>
    /// Account value factory class
    /// </summary>
    public class AccountFactory : IAccountFactory
    {
        /// <summary>
        /// Creates a new account instance
        /// </summary>
        public IAccount Create()
        {
            return new Account();
        }
        /// <summary>
        /// Creates a new account instance
        /// </summary>
        public IAccount Create(Username username, Passhash passhash, EmailAddress emailAddress, Token accessToken, bool isBlocked, byte level, DateTime dateTime, IPAddress ipAddress)
        {
            return new Account(username, passhash, emailAddress, accessToken, isBlocked, level, dateTime, ipAddress);
        }
        
    }
}
