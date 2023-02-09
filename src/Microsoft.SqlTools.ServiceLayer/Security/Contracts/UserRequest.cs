//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.SqlTools.Hosting.Protocol.Contracts;
using Microsoft.SqlTools.ServiceLayer.Utility;
using Microsoft.SqlTools.Utility;

namespace Microsoft.SqlTools.ServiceLayer.Security.Contracts
{    
    /// <summary>
    /// Create User parameters
    /// </summary>
    public class CreateUserParams : GeneralRequestDetails
    {
        public string OwnerUri { get; set; }

        public UserInfo User { get; set; }
    }

    /// <summary>
    /// Create User result
    /// </summary>
    public class CreateUserResult : ResultStatus
    {
        public UserInfo User { get; set; }        
    }


    /// <summary>
    /// Create User request type
    /// </summary>
    public class CreateUserRequest
    {
        /// <summary>
        /// Request definition
        /// </summary>
        public static readonly
            RequestType<CreateUserParams, CreateUserResult> Type =
            RequestType<CreateUserParams, CreateUserResult>.Create("objectmanagement/createuser");
    }

    /// <summary>
    /// Delete User params
    /// </summary>
    public class DeleteUserParams : GeneralRequestDetails
    {
        public string OwnerUri { get; set; }

        public string UserName { get; set; }
    }

    /// <summary>
    /// Delete User request type
    /// </summary>
    public class DeleteUserRequest
    {
        /// <summary>
        /// Request definition
        /// </summary>
        public static readonly
            RequestType<DeleteUserParams, ResultStatus> Type =
            RequestType<DeleteUserParams, ResultStatus>.Create("objectmanagement/deleteuser");
    }
}
