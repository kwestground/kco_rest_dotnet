#region Copyright Header
//-----------------------------------------------------------------------
// <copyright file="OrderLineType.cs" company="Klarna AB">
//     Copyright 2014 Klarna AB
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
//
// </copyright>
//-----------------------------------------------------------------------
#endregion

namespace Klarna.Rest.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Order line type
    /// </summary>
    public enum OrderLineType
    {
        /// <summary>
        /// Order line is an physical product
        /// </summary>
        [EnumMember(Value = "physical")]
        Physical,

        /// <summary>
        /// Order line is a shipping fee
        /// </summary>
        [EnumMember(Value = "shipping_fee")]
        ShippingFee,

        /// <summary>
        /// Order line is a discount
        /// </summary>
        [EnumMember(Value = "dicount")]
        Discount
    }
}
