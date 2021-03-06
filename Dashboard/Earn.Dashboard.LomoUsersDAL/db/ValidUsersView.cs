//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//

// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>

namespace Earn.Dashboard.LomoUsersDAL.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class ValidUsersView
    {
        public System.Guid Id { get; set; }
        public int PartitionId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MsId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsSuppressed { get; set; }
        public string Json { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> LinkedToUserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Source { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}