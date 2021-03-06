
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
    [ASN1BoxedType ( Name = "VMDReset_Request") ]
    public class VMDReset_Request: IASN1PreparedElement {
    
            private bool val = false;

            [ASN1Boolean ( Name = "VMDReset-Request") ]            
            
            public bool Value
            {
                get { return val; }
                set { val = value; }
            }            
            
            public VMDReset_Request() {
            }

            public VMDReset_Request(bool value) {
                this.Value = value;
            }            

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(VMDReset_Request));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
