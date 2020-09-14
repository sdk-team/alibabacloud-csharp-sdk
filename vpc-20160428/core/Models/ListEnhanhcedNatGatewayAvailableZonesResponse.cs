// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListEnhanhcedNatGatewayAvailableZonesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=true)]
        public List<ListEnhanhcedNatGatewayAvailableZonesResponseZones> Zones { get; set; }
        public class ListEnhanhcedNatGatewayAvailableZonesResponseZones : TeaModel {
            [NameInMap("ZoneId")]
            [Validation(Required=true)]
            public string ZoneId { get; set; }

            [NameInMap("LocalName")]
            [Validation(Required=true)]
            public string LocalName { get; set; }

        }

    }

}
