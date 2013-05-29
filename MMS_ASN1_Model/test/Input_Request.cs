
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

namespace MMS_ASN1_Model
{


    [ASN1PreparedElement]
    [ASN1Sequence(Name = "Input_Request", IsSet = false)]
    public class Input_Request : IASN1PreparedElement
    {

        private Identifier operatorStationName_;

        [ASN1Element(Name = "operatorStationName", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]

        public Identifier OperatorStationName
        {
            get { return operatorStationName_; }
            set { operatorStationName_ = value; }
        }



        private bool echo_;
        [ASN1Boolean(Name = "")]

        [ASN1Element(Name = "echo", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = true)]

        public bool Echo
        {
            get { return echo_; }
            set { echo_ = value; }
        }



        private System.Collections.Generic.ICollection<MMSString> listOfPromptData_;

        private bool listOfPromptData_present = false;

        [ASN1SequenceOf(Name = "listOfPromptData", IsSetOf = false)]


        [ASN1Element(Name = "listOfPromptData", IsOptional = true, HasTag = true, Tag = 2, HasDefaultValue = false)]

        public System.Collections.Generic.ICollection<MMSString> ListOfPromptData
        {
            get { return listOfPromptData_; }
            set { listOfPromptData_ = value; listOfPromptData_present = true; }
        }



        private Unsigned32 inputTimeOut_;

        private bool inputTimeOut_present = false;

        [ASN1Element(Name = "inputTimeOut", IsOptional = true, HasTag = true, Tag = 3, HasDefaultValue = false)]

        public Unsigned32 InputTimeOut
        {
            get { return inputTimeOut_; }
            set { inputTimeOut_ = value; inputTimeOut_present = true; }
        }



        public bool isListOfPromptDataPresent()
        {
            return this.listOfPromptData_present == true;
        }

        public bool isInputTimeOutPresent()
        {
            return this.inputTimeOut_present == true;
        }


        public void initWithDefaults()
        {
            bool param_Echo =
        false;
            Echo = param_Echo;

        }


        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Input_Request));
        public IASN1PreparedElementData PreparedData
        {
            get { return preparedData; }
        }


    }

}
