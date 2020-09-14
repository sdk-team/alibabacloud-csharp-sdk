// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVSwitchAttributeRequest : TeaModel {
        [NameInMap("VSwitchId")]
        [Validation(Required=true)]
        public string VSwitchId { get; set; }

        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public int? Ipv6CidrBlock { get; set; }

    }

}
