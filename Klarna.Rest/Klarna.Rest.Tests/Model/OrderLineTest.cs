#region Copyright Header
//-----------------------------------------------------------------------
// <copyright file="OrderLineTest.cs" company="Klarna AB">
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

namespace Klarna.Rest.Tests.Model
{
    using NUnit.Framework;

    /// <summary>
    /// Unit tests of the order line.
    /// </summary>
    [TestFixture]
    class OrderLineTest
    {
        /// <summary>
        /// Expected JSON string.
        /// </summary>
        private const string JSON = "{\r\n  \"type\": \"physical\",\r\n  \"name\": \"Physical Product\",\r\n  \"quantity\": 1,\r\n  \"unit_price\": 12300\r\n}";

        /// <summary>
        /// Test that extra merchant data can be casted to an attachment.
        /// </summary>
        [Test]
        public void TestCastOrderLineType()
        {
            var orderLine = TestsHelper.GetOrderLine();

            var json = orderLine.ConvertToJson();
            Assert.AreEqual(JSON, json);
        }
    }
}
