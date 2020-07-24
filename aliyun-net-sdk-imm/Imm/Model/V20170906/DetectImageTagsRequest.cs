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
using Aliyun.Acs.imm;
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class DetectImageTagsRequest : RpcAcsRequest<DetectImageTagsResponse>
    {
        public DetectImageTagsRequest()
            : base("imm", "2017-09-06", "DetectImageTags")
        {
			Method = MethodType.POST;
        }

		private string project;

		private string imageUri;

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
				DictionaryUtil.Add(QueryParameters, "ImageUri", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DetectImageTagsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DetectImageTagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
