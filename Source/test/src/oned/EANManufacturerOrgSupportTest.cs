/*
 * Copyright (C) 2010 ZXing authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using NUnit.Framework;

namespace com.google.zxing.oned
{
   /// <summary>
   /// Tests <see cref="EANManufacturerOrgSupport" />.
   /// 
   /// <author>Sean Owen</author>
   /// </summary>
   [TestFixture]
   public sealed class EANManufacturerOrgSupportTest
   {
      [Test]
      public void testLookup()
      {
         EANManufacturerOrgSupport support = new EANManufacturerOrgSupport();
         Assert.IsNull(support.lookupCountryIdentifier("472000"));
         Assert.AreEqual("US/CA", support.lookupCountryIdentifier("000000"));
         Assert.AreEqual("MO", support.lookupCountryIdentifier("958000"));
         Assert.AreEqual("GB", support.lookupCountryIdentifier("500000"));
         Assert.AreEqual("GB", support.lookupCountryIdentifier("509000"));
      }
   }
}