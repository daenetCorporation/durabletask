﻿//  ----------------------------------------------------------------------------------
//  Copyright Microsoft Corporation
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace DurableTask.Test.Orchestrations.Stress
{
    [DataContract]
    [KnownType(typeof(TestOrchestrationData))]
    public class TestOrchestrationData
    {
        [DataMember]
        public int NumberOfParallelTasks { get; set; }

        [DataMember]
        public int NumberOfSerialTasks { get; set; }

        [DataMember]
        public int MaxDelayTime { get; set; }

        [DataMember]
        public string ActivityTypeName { get; set; }

        [DataMember]
        public TimeSpan? DelayUnit { get; set; } //default value is TimeSpan.FromMinutes(1), this will be multiplied with MaxDelayTime to determine the wait time.
    }
}
