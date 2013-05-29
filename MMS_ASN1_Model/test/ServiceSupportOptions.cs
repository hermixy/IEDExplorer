
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace MMS_ASN1_Model {


    [ASN1PreparedElement]
    [ASN1BoxedType ( Name = "ServiceSupportOptions") ]
    public class ServiceSupportOptions : IASN1PreparedElement {
    
            private BitString val = null;

            [ASN1BitString( Name = "ServiceSupportOptions") ]            
            
            [ASN1SizeConstraint ( Max = 93L )]
        
            public BitString Value
            {
                get { return val; }
                set { val = value; }
            }            
            
            public ServiceSupportOptions() {
            }

            public ServiceSupportOptions(BitString value) {
                this.Value = value;
            }            


            public void initWithDefaults()
	    {
	    }

            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ServiceSupportOptions));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
