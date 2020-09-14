// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatGatewayConvertStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NatGatewayId")]
        [Validation(Required=true)]
        public string NatGatewayId { get; set; }

        [NameInMap("Bid")]
        [Validation(Required=true)]
        public string Bid { get; set; }

        [NameInMap("AliUid")]
        [Validation(Required=true)]
        public long AliUid { get; set; }

        [NameInMap("DstNatType")]
        [Validation(Required=true)]
        public string DstNatType { get; set; }

        [NameInMap("ConvertSteps")]
        [Validation(Required=true)]
        public List<GetNatGatewayConvertStatusResponseConvertSteps> ConvertSteps { get; set; }
        public class GetNatGatewayConvertStatusResponseConvertSteps : TeaModel {
            [NameInMap("StepName")]
            [Validation(Required=true)]
            public string StepName { get; set; }

            [NameInMap("StepStatus")]
            [Validation(Required=true)]
            public string StepStatus { get; set; }

            [NameInMap("StepStartTime")]
            [Validation(Required=true)]
            public string StepStartTime { get; set; }

        }

    }

}
