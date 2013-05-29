
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
    [ASN1Sequence(Name = "ReportSemaphoreEntryStatus_Response", IsSet = false)]
    public class ReportSemaphoreEntryStatus_Response : IASN1PreparedElement
    {

        private System.Collections.Generic.ICollection<SemaphoreEntry> listOfSemaphoreEntry_;

        [ASN1SequenceOf(Name = "listOfSemaphoreEntry", IsSetOf = false)]


        [ASN1Element(Name = "listOfSemaphoreEntry", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]

        public System.Collections.Generic.ICollection<SemaphoreEntry> ListOfSemaphoreEntry
        {
            get { return listOfSemaphoreEntry_; }
            set { listOfSemaphoreEntry_ = value; }
        }



        private bool moreFollows_;
        [ASN1Boolean(Name = "")]

        [ASN1Element(Name = "moreFollows", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = true)]

        public bool MoreFollows
        {
            get { return moreFollows_; }
            set { moreFollows_ = value; }
        }




        public void initWithDefaults()
        {
            bool param_MoreFollows =
        false;
            MoreFollows = param_MoreFollows;

        }


        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ReportSemaphoreEntryStatus_Response));
        public IASN1PreparedElementData PreparedData
        {
            get { return preparedData; }
        }


    }

}
