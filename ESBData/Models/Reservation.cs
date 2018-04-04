using System;
using System.Collections.Generic;
using System.Text;

namespace ESBData.Models
{
    public class UniqueIDsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string context { get; set; }
    }

    public class AddressesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string addressTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addressTypeDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addressStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string attn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stateProvince { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string postalCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string countryCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isPrimary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addressLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addressCleansed { get; set; }
    }

    public class MembershipsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string externalID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string programCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string membershipID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string membershipCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string membershipName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string membershipLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string membershipStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string enrollmentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateMembershipStarts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateMembershipExpires { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalStays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int awardCredits { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int awardAvailable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string primaryAirline { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int displaySequence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inactiveDate { get; set; }
    }

    public class ContactMethodsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dataValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string extraData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string optOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sourceDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isPrimary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string confirmation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inactiveDate { get; set; }
    }

    public class ActionCommentsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string externalID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commentTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commentClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string actionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string actionDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inactiveDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string guestViewable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string creatorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateCommentCreated { get; set; }
    }

    public class SpecialRequestsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string externalID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string requestType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string requestCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string requestComments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resortField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string actionTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string actionType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inactiveDate { get; set; }
    }

    public class UdfDataCollectionItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string cendynPropertyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string moduleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tableName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string columnName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string udfValue { get; set; }
    }

    public class Lead
    {
        /// <summary>
        /// 
        /// </summary>
        public string fK_Reservation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string externalLeadID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string externalLeadSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string leadAcquired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tentativeStartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tentativeEndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string assignedAgent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string assignedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contactMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contactAgent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string contactDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastFollowupMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastFollowupAgent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastFollowupDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bookingMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bookingAgent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bookingDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reasonforStay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string marketCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string campaignCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string campaignName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int priceEstimate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string flaggedForAttention { get; set; }
    }

    public class GuestProfile
    {
        /// <summary>
        /// 
        /// </summary>
        public string cendynPropertyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string propertyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<UniqueIDsItem> uniqueIDs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string profileTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string profileTypeDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nameCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string profileTypeCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string salutation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string firstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string familiarName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string middleName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string vipid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string vipCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string primaryLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string genderCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dobYear { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dobMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dobDayOfMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string arNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowMail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowEMail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string guestPriv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowSMS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowHistory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowMarketResearch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowThirdParty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string allowLoyaltyProgram { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string creatorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string lastUpdaterCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateProfileCreated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateProfileUpdated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string inactiveDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AddressesItem> addresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MembershipsItem> memberships { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ContactMethodsItem> contactMethods { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ActionCommentsItem> actionComments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SpecialRequestsItem> specialRequests { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<UdfDataCollectionItem> udfDataCollection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Lead lead { get; set; }
    }

    public class GuestsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string arrivalDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string departureDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int profileSequence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isPrimary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string folioID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int percentageBilled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GuestProfile guestProfile { get; set; }
    }

    public class TaxTypesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string description { get; set; }
    }

    public class StayDetailsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string externalID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stayDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string roomNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string roomType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string marketCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resSourceCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int numberOfRooms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int dailyRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string currencyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateStayDetailUpdated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TaxTypesItem> taxTypes { get; set; }
    }

    public class CancelPenaltiesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string ruleType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ruleCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ruleDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resortRuleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ruleID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int percentage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cancelByDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cancelPercentDue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cancelRoomNights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int activityDeposit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int roomDeposit { get; set; }
    }

    public class StayHeadersItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string stayBeginDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stayEndDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string buildingCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string roomNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string roomType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string marketSegmentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resSourceCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shareCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string invBlockCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resStatusType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rtc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string channelCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sourceSequence { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rateType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rateCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<StayDetailsItem> stayDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<CancelPenaltiesItem> cancelPenalties { get; set; }
    }

    public class ReservationsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string cendynPropertyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string propertyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<UniqueIDsItem> uniqueIDs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resStatusCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string confirmationNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string centralResNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resArriveDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resDepartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resArriveTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resDepartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int numRooms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string buildingCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string roomTypeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string roomNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rateCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rateCategoryCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int rateAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rateConfidential { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string packageCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int packageAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string packageDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string discountCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int discountAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int discountPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string discountReasonCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string guaranteedByCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string isNotRefundable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sharerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string legNumbers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string groupID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string groupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resSourceCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resSourceCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trvlAgntPmsID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trvlAgntCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trvlAgntIATA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trvlAgntName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string marketSegmentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string marketCodeCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string marketRegionCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string companyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string companyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string billingCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string billingName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int numAdults { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int numYouths { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int numChildren { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalRoomNights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateResMade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateResUpdated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resMadeBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resUpdatedBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string checkedInBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string checkedOutBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cancellationID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cancellationDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int averageRoomRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int depositAmountDue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int depositAmountPaid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int accountBalance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalOtherRevenue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalFBRevenue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalRoomRevenue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int totalRevenue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<GuestsItem> guests { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<StayHeadersItem> stayHeaders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ActionCommentsItem> actionComments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SpecialRequestsItem> specialRequests { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<UdfDataCollectionItem> udfDataCollection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TaxTypesItem> taxTypes { get; set; }
    }

    public class ReservationContainer
    {
        /// <summary>
        /// 
        /// </summary>
        public string echoToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ReservationsItem> reservations { get; set; }
    }

    public class Reservation
    {
        /// <summary>
        /// 
        /// </summary>
        public ReservationContainer reservationContainer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string subscriptionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cendynPropertyId { get; set; }
    }
}
