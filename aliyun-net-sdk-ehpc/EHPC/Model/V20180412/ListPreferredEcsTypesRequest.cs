/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class ListPreferredEcsTypesRequest : RpcAcsRequest<ListPreferredEcsTypesResponse>
    {
        public ListPreferredEcsTypesRequest()
            : base("EHPC", "2018-04-12", "ListPreferredEcsTypes", "ehs", "openAPI")
        {
        }

		private string spotStrategy;

		private string zoneId;

		private string instanceChargeType;

		public string SpotStrategy
		{
			get
			{
				return spotStrategy;
			}
			set	
			{
				spotStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string InstanceChargeType
		{
			get
			{
				return instanceChargeType;
			}
			set	
			{
				instanceChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
			}
		}

        public override ListPreferredEcsTypesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListPreferredEcsTypesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
