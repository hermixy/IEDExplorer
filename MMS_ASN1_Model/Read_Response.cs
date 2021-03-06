
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
    [ASN1Sequence ( Name = "Read_Response", IsSet = false  )]
    public class Read_Response : IASN1PreparedElement {
                    
	private VariableAccessSpecification variableAccessSpecification_ ;
	
        private bool  variableAccessSpecification_present = false ;
	
        [ASN1Element ( Name = "variableAccessSpecification", IsOptional =  true , HasTag =  true, Tag = 0 , HasDefaultValue =  false )  ]
    
        public VariableAccessSpecification VariableAccessSpecification
        {
            get { return variableAccessSpecification_; }
            set { variableAccessSpecification_ = value; variableAccessSpecification_present = true;  }
        }
        
                
          
	private System.Collections.Generic.ICollection<AccessResult> listOfAccessResult_ ;
	
[ASN1SequenceOf( Name = "listOfAccessResult", IsSetOf = false  )]

    
        [ASN1Element ( Name = "listOfAccessResult", IsOptional =  false , HasTag =  true, Tag = 1 , HasDefaultValue =  false )  ]
    
        public System.Collections.Generic.ICollection<AccessResult> ListOfAccessResult
        {
            get { return listOfAccessResult_; }
            set { listOfAccessResult_ = value;  }
        }
        
                
  
        public bool isVariableAccessSpecificationPresent () {
            return this.variableAccessSpecification_present == true;
        }
        

            public void initWithDefaults() {
            	
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Read_Response));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}
