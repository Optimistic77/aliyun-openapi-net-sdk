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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.nlp_automl.Model.V20191111;

namespace Aliyun.Acs.nlp_automl.Transform.V20191111
{
    public class ListDatasetResponseUnmarshaller
    {
        public static ListDatasetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDatasetResponse listDatasetResponse = new ListDatasetResponse();

			listDatasetResponse.HttpResponse = _ctx.HttpResponse;
			listDatasetResponse.RequestId = _ctx.StringValue("ListDataset.RequestId");
			listDatasetResponse.Data = _ctx.StringValue("ListDataset.Data");
			listDatasetResponse.Code = _ctx.IntegerValue("ListDataset.Code");
			listDatasetResponse.Message = _ctx.StringValue("ListDataset.Message");
			listDatasetResponse.Success = _ctx.BooleanValue("ListDataset.Success");
        
			return listDatasetResponse;
        }
    }
}
