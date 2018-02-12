﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using Xunit;

namespace Microsoft.Azure.Commands.OperationalInsights.Test
{
    public class QueryTests : OperationalInsightsScenarioTestBase
    {
        [Fact]
        public void TestSimpleQuery()
        {
            RunDataPowerShellTest("Test-SimpleQuery");
        }

        [Fact]
        public void TestSimpleQueryWithTimespan()
        {
            RunDataPowerShellTest("Test-SimpleQueryWithTimespan");
        }

        [Fact]
        public void TestExceptionWithSyntaxError()
        {
            RunDataPowerShellTest("Test-ExceptionWithSyntaxError");
        }

        [Fact]
        public void TestExceptionWithShortWait()
        {
            RunDataPowerShellTest("Test-ExceptionWithShortWait");
        }

        [Fact]
        public void TestAsJob()
        {
            RunDataPowerShellTest("Test-AsJob");
        }
    }
}