using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using Cryptography;

namespace Fopex.DAL.Common
{
    public class Constants
    {
        //testing
        public class PageActions
        {
            public const string DATA_REQUEST = "DATA_REQUEST";
            public const string INQUIRY = "INQUIRY";
            public const string GENERATE_PASSCODE = "GENERATE_PASSCODE";
            public const string HAVE_PASSCODE = "HAVE_PASSCODE";
            public const string PAYMENT = "PAYMENT";
            public const string ERROR_INVALID_ACTION = "Invalid Action";
        }

        /* public class Configuration
         {
             public const string DOMAIN = "DOMAIN";
             public const string LDAP = "LDAP";
             public const string ADUSER = "ADUSER";
             public const string PWD = "PWD";
             public const string RETRY_COUNT = "RETRY_COUNT";
             public const string PASSWORD_EXPIRY = "PASSWORD_EXPIRY";
             public const string EMAIL_SERVICE_URL = "EMAIL_SERVICE_URL";
             public const string EMAIL_USER = "EMAIL_USER";
             public const string EMAIL_PWD = "EMAIL_PWD";
             public const string EMAIL_FROM = "EMAIL_FROM";
             public const string PASSWORD_DEFAULT = "PASSWORD_DEFAULT";
             public const string PAGE_SIZE = "PAGE_SIZE";
             public const string HIGHLIGHT_COLOR = "#F2F0E1";
             public const string APPROVEREJECT = "APPROVED/REJECT";
             public const string AGENT_PORTAL = "AGENT_PORTAL";
         }
         * */
        public class ErrorCodes
        {
            public const string SUCCESS = "0";
            public const string SUCCESS_HBPS = "00";
            public const string SYSTEM_ERROR = "1";
            public const string EXTERNAL_SYSTEM_FAILURE = "140";
            public const string PASSWORD_EXPIRE = "101";
            public const string AGENT_NOT_FOUND = "103";
            public const string SUB_SYSTEM_RESPONSE_NOT_MAPPED = "115";
            public const string INQUIRY_TXN_NOT_FOUND = "117";
            public const string AGENT_USER_DETAIL_FAILURE = "124";
            public const string ACCOUNT_NOT_FOUND = "131";
            public const string INVALID_AMOUNT = "132";
            public const string GENERAL_ERROR = "142";
            public const string INVALID_LOGIN_ID = "298";
            public const string INVALID_CHANNEL = "299";
            public const string INVALID_SENDER_CNIC = "300";
            public const string INVALID_RECEIVER_CNIC = "301";
            public const string INVALID_SENDER_MOBILE = "302";
            public const string INVALID_RECEIVER_MOBILE = "303";
            public const string INVALID_MOBILE = "304";
            public const string INVALID_SESSION_IDENTIFIER = "305";
            public const string INVALID_TRANSACTION_TYPE_ID = "306";
            public const string INVALID_EMAIL_ADDRESS = "307";
            public const string INVALID_CNIC = "308";
            public const string INVALID_MPIN = "309";
            public const string INVALID_PASSCODE = "310";
            public const string SENDER_RECEIVER_MOBILE_SAME = "314";
            public const string SENDER_RECEIVER_CNIC_SAME = "315";
            public const string TRANSACTION_NOT_FOUND = "109";
            public const string INVALID_ACTION_DATA = "316";
            public const string CUSTOMER_NOT_FOUND = "318";
            public const string FACE_CNIC_IMAGE_REQUIRED = "319";
            public const string ERROR_FACE_IMAGE = "320";
            public const string ERROR_CNIC_IMAGE = "321";
            public const string AGENT_CITY_ERROR = "322";
            public const string AGENT_USER_PASSWORD_USED = "323";
            public const string PASSWORD_POLICY_NOT_MATCHED = "324";
            public const string INVALID_TXN_PURPOSE = "325";
            public const string INVALID_BIOMETRIC_DATA = "326";
            public const string INVALID_BIOMETRIC_FINGER_INDEX = "327";
            public const string INVALID_TXN_ID = "328";
            public const string INVALID_BANK = "329";
            public const string INVALID_BANK_ACCOUNT = "330";
            public const string FROM_TO_ACCOUNT_SAME = "331";
            public const string INVALID_BIOMETRIC_SERIAL = "340";
            public const string INVALID_BIOMETRIC_FORMAT = "341";
            public const string INVALID_REQUEST = "344";
            public const string INVALID_EXPIRY_DATE = "383";
            public const string FATCA_ERROR = "384";
            public const string AGENT_USER_CREATED = "385";
            public const string USER_EXISTS_CNIC = "386";
            public const string USER_EXISTS_MOBILE_NUMBER = "387";
            public const string TRANS_ASSIGNED = "388";
            public const string LIMIT_ASSIGNED = "389";
            public const string STOCK_NOT_FOUND = "311";
            public const string USER_BLOCKED = "390";
            public const string USER_UNBLOCKED = "391";
            public const string CNIC_BLACK_LISTED = "392";
            public const string MOBIL_BLACK_LISTED = "393";
            public const string FINGER_NOT_MATCHED = "363";
            public const string BIOMETRIC_INVENTORY_ASSIGNED = "411";
            public const string INVALID_PRODUCT_LENGTH = "500";
            public const string EXTERNAL_SYSTEM_TIMEOUT = "412";
            public const string DEVICE_MISMATCH = "137";
            public const string DISB_NOT_FOUND = "210";
            public const string PASSCODE_FAILURE = "901";
            public const string DEBIT_CARD_REQUEST_ALREADY_EXIST = "902";
            public const string AGENT_USER_UPDATED = "903";

            public const string BUNDLE_NOT_FOUND = "1801";
            public const string TXN_TYPE_EXISTS = "1802";
            public const string BUNDLE_EXIST = "1803";
            public const string BUNDLE_TRAN_NOT_FOUND = "1804";
        }


        public class QRErrorCodes
        {
            public const string PENDING = "-1";
            public const string SUCCESS = "0";
            public const string SYSTEM_ERROR = "1";
            public const string TERMINAL_ID_NOT_FOUND ="2";
            public const string Reference_ID_already_exists ="3";
            public const string REFERENCE_ID_NOT_FOUND ="4";
            public const string INVALID_REFERENCE_ID ="5";
            public const string	INVALID_TRANSACTION_TYPE ="6";
            public const string	INSUFFICIENT_BALANCE="7";
            public const string	INVALID_AMOUNT ="8";
            public const string	INVALID_GUID="9";
            public const string	GUID_ALREADY_EXIST="10";
            public const string	SYSTEM_STATE_NOT_VERIFIED ="11";
            public const string	TRANSACTION_NOT_ALLOWED_ON_CHANNEL="12";
            public const string	ACCOUNT_CLOSED="13";
            public const string INVALID_VENDOR = "14";
            public const string QR_TRANSACTION_NOT_FOUND_MESSAGE = "15";
            public const string QR_TRANSACTION_SUCCESS_MESSAGE = "16";
        }

        public class QRErrorCodesMessage
        {
            public const string PENDING = "PENDING";
            public const string SUCCESS = "SUCCESS";
            public const string SYSTEM_ERROR = "SYSTEM_ERROR";
            public const string TERMINAL_ID_NOT_FOUND = "TERMINAL_ID_NOT_FOUND";
            public const string REFERENCE_ID_ALREADY_EXISTS = "REFERENCE_ID_ALREADY_EXISTS";
            public const string REFERENCE_ID_NOT_FOUND = "REFERENCE_ID_NOT_FOUND";
            public const string INVALID_REFERENCE_ID = "INVALID_REFERENCE_ID";
            public const string INVALID_TRANSACTION_TYPE = "INVALID_TRANSACTION_TYPE";
            public const string INSUFFICIENT_BALANCE = "INSUFFICIENT_BALANCE";
            public const string INVALID_AMOUNT = "INVALID_AMOUNT";
            public const string INVALID_GUID = "INVALID_GUID";
            public const string GUID_ALREADY_EXIST = "GUID_ALREADY_EXIST";
            public const string SYSTEM_STATE_NOT_VERIFIED = "SYSTEM_STATE_NOT_VERIFIED";
            public const string TRANSACTION_NOT_ALLOWED_ON_CHANNEL = "TRANSACTION_NOT_ALLOWED_ON_CHANNEL";
            public const string ACCOUNT_CLOSED = "ACCOUNT_CLOSED";
            public const string INVALID_VENDOR = "INVALID_VENDOR";
            public const string QR_TRANSACTION_NOT_FOUND_MESSAGE = "No QR Transaction found against selected Reference Id.";
            public const string QR_TRANSACTION_SUCCESS_MESSAGE = "Transaction successfully processed";
        }



        public class QRType
        {
            public const string QRTYPE_VENDI = "VENDI";
            public const string QRTYPE_AGPORTAL = "AGPORTAL";
            public const string QRTYPE_MOBILE = "MOBILE";
        }

        public class ErrorMessage
        {
            public const string INQUIRY_SUCCESS = "Please enter your MPin and press Submit to complete the transaction.";
            public const string TERMINAL_NOT_FOUND = "No QR Terminal found against selected Agent.";
            public const string INVALID_QR_STRING = "Invalid QR String found against Agent Terminal.";
            public const string MERCHANT_IN_PROGRESS = "Merchant creation is in process. Kindly check later.";

            public const string QR_VENDI_TRANSACTION_SUCCESS = "00";
            public const string QR_TRANSACTION_FAIL = "1";
            public const string QR_TRANSACTION_SUCCESS_MESSAGE = "Transaction successfully processed";
            public const string QR_TRANSACTION_NOT_FOUND_MESSAGE = "No QR Transaction found against selected Reference Id.";


            public const string VENDOR_INCORRECT = "VENDOR_INCORRECT";
            public const string USER_INCORRECT = "USER_INCORRECT";
            public const string PWD_INCORRECT = "PWD_INCORRECT";
            public const string CREDINTIAL_INCORRECT = "CREDINTIAL_INCORRECT";
            public const string GENERAL_ERROR = "GENERAL_ERROR";
            public const string REFERENCE_ID_NOT_FOUND = "REFERENCE_ID_NOT_FOUND";


        }

        public class UserMessage
        {
            public const string QR_DROPDOWN_DEFAULT_TEXT = "My QR Code";
        }

        public class CacheKey
        {
            public class AgentConfiguration
            {
                public const string HIDE_FIELDS_FROM_TPE = "HIDE_FIELDS_FROM_TPE";
                public const string MASK_FIELDS_IN_LOGS = "MASK_FIELDS_IN_LOGS";
                public const string APP_VERSION_MIN = "APP_VERSION_MIN";
                public const string APP_VERSION_MAX = "APP_VERSION_MAX";
                public const string APP_VERSION_FOR_UPDATE_PROMPT = "APP_VERSION_FOR_UPDATE_PROMPT";
                public const string APP_CACHE_VERSION = "APP_CACHE_VERSION";
                public const string TPE_SYS_CHANNEL = "TPE_SYS_CHANNEL";
                public const string TPE_SYS_PWD = "TPE_SYS_PWD";
                public const string TPE_SYS_USER = "TPE_SYS_USER";
                public const string HBPS_SYS_USER = "HBPS_SYS_USER";
                public const string HBPS_SYS_PWD = "HBPS_SYS_PWD";
                public const string HBPS_CACHE_EXPIRY_TIME = "HBPS_CACHE_EXPIRY_TIME";
                public const string ALERTING_SYS_USER = "ALERTING_SYS_USER";
                public const string ALERTING_SYS_PWD = "ALERTING_SYS_PWD";
                public const string ALERTING_SYS_CHANNEL = "ALERTING_SYS_CHANNEL";
                public const string ALERTING_EMAIL_FROM = "ALERTING_SYS_CHANNEL";
                public const string AGENT_MPIN_LENGTH = "AGENT_MPIN_LENGTH";
                public const string PASSCODE_LENGTH = "PASSCODE_LENGTH";
                public const string IS_BIOMETRIC_REMITTANCE_SEND = "IS_BIOMETRIC_REMITTANCE_SEND";
                public const string IS_BIOMETRIC_REMITTANCE_RECEIVE = "IS_BIOMETRIC_REMITTANCE_RECEIVE";
                public const string ACCOUNT_OPEN_BVS_ACCT_CLASS = "ACCOUNT_OPEN_BVS_ACCT_CLASS";
                public const string ACCOUNT_OPEN_NON_BVS_ACCT_CLASS = "ACCOUNT_OPEN_NON_BVS_ACCT_CLASS";
                public const string LEVEL_UPGRADE_ACCOUNT_CLASS = "LEVEL_UPGRADE_ACCOUNT_CLASS";
                public const string LEVEL_UPGRADE_ACCOUNT_CLASS_HRA = "LEVEL_UPGRADE_ACCOUNT_CLASS_HRA";

                public const string LOGIN_SUCCESS_MESSAGE = "LOGIN_SUCCESS_MESSAGE";
                public const string LOGIN_SUCCESS_MESSAGE_ENABLED = "LOGIN_SUCCESS_MESSAGE_ENABLED";
                public const string LAST_PASSWORD_CHANGE_DAYS = "LAST_PASSWORD_CHANGE_DAYS";
                public const string PASSWORD_RECOVER = "PASSWORD_RECOVER";
                public const string NEW_USER_CREATED = "NEW_USER_CREATED";
                public const string ACTIVE_AGENT = "1";
                public const string NEW_USER_MPIN = "NEW_USER_MPIN";
                public const string PASSWORD_CHANGE = "PASSWORD_CHANGE";
                public const string MAX_DATE_SELECT_RANGE = "MAX_DATE_SELECT_RANGE";
                public const string MAX_DATE_RANGE_ERROR = "MAX_DATE_RANGE_ERROR";
                public const string BIOMETRIC_PRODUCT_IDS = "BIOMETRIC_PRODUCT_IDS";
                public const string DUKAN_LOCATOR_URL = "DUKAN_LOCATOR_URL";

                public const string IS_CARD_ISSUE = "IS_CARD_ISSUE";

                public const string CNIC_EXPIRING_NDAYS_MSG = "CNIC_EXPIRING_NDAYS_MSG";
                public const string CNIC_EXPIRED_MSG = "CNIC_EXPIRED_MSG";
                public const string CNIC_EXPIRING_DAYS = "CNIC_EXPIRING_DAYS";
                public const string IS_DELETED = "0";


            }
        }

        public class WebConfiguration
        {
            public const string BulkBillMaxLength = "BulkBillMaxLength";
            private static WebConfiguration m_WebConfiguration;
            string m_HbpsConnectionString;
            string m_AGConnectionString;
            string m_MISConnectionString;
            string m_DAEConnectionString;
            string m_PRICINGConnectionString;
            string m_ALERTING_Connection;
            private static object m_padlock = new object();
            private static ManualResetEvent m_LoadingSignal = new ManualResetEvent(true);





            public string PRICINGConnectionString
            {
                get { return m_PRICINGConnectionString; }
                set { m_PRICINGConnectionString = value; }
            }

            public string ALERTING_Connection
            {
                get { return m_ALERTING_Connection; }
                set { m_ALERTING_Connection = value; }
            }




            public string DAEConnectionString
            {
                get { return m_DAEConnectionString; }
                set { m_DAEConnectionString = value; }
            }


            public string MISConnectionString
            {
                get { return m_MISConnectionString; }
                set { m_MISConnectionString = value; }
            }
            public string HbpsConnectionString
            {
                get { return m_HbpsConnectionString; }
                set { m_HbpsConnectionString = value; }
            }

            public string AGConnectionString
            {
                get { return m_AGConnectionString; }
                set { m_AGConnectionString = value; }
            }
            string m_CoreConnectionString;

            public string CoreConnectionString
            {
                get { return m_CoreConnectionString; }
                set { m_CoreConnectionString = value; }
            }
            string m_MobileConnectionString;
            public string MobileConnectionString
            {
                get { return m_MobileConnectionString; }
                set { m_MobileConnectionString = value; }
            }
            private WebConfiguration()
            {

            }



            public static WebConfiguration Instance
            {
                get
                {
                    m_LoadingSignal.WaitOne();
                    if (m_WebConfiguration == null)
                    {
                        lock (m_padlock)
                        {
                            m_LoadingSignal.Reset();
                            if (m_WebConfiguration == null)
                            {
                                m_WebConfiguration = new WebConfiguration();
                                m_WebConfiguration.Load();
                            }
                            m_LoadingSignal.Set();

                        }
                    }
                    return m_WebConfiguration;
                }



            }

            private void Load()
            {
                Cipher c = new Cipher();
                m_ALERTING_Connection = new Cipher().Decrypt(ConfigurationManager.ConnectionStrings["ALERTING_Connection"].ConnectionString);
            }

            public string Get(string r_ConfigKey)
            {
                return ConfigurationManager.AppSettings[r_ConfigKey];
            }
        }

        public class TransactionStatus
        {
            public const string PENDING = "PENDING";
            public const string PROCESSING = "PROCESSING";
            public const string PROCESSED = "PROCESSED";
            public const string FAILED = "FAILED";
            public const string TIMEOUT = "TIMEOUT";
        }

        public class SubSystem
        {
            public const string TPE = "TPE";
        }

        public class TransactionTypes
        {
            public const int NO_PERMISSION_REQUIRED = -1;
            public const int CASH = 1;
            public const int Cheque = 2;
            public const int DR_SEND = 8;
            public const int DR_RECEIVE = 9;
            public const int BILL_PAYMENT = 10;
            public const int BULK_BILL_PAYMENT = 83;
            public const int BALANCE = 11;
            public const int DR_CANCEL = 12;
            public const int TRANSFER_IN = 13;
            public const int TRANSFER_OUT = 14;
            public const int CASH_DEPOSIT = 15;
            public const int DR_SEND_BIOMETRIC = 16;
            public const int DR_UPDATE = 138;
            public const int DEPOSIT_TO_CORE = 17;
            public const int REMITTANCE_SEARCH = 18;
            public const int AGENT_TRANSFER = 19;
            public const int CASH_WITHDRAW = 20;
            public const int ACCOUNT_OPEN = 22;
            public const int INVENTORY_RECEIVE = 23;
            public const int INVENTORY_ASSIGN = 24;
            public const int RETAIL_PURCHASE = 25;
            public const int MPIN_VALIDATE = 26;
            public const int IBFT = 27;
            public const int IBFT_BIOMETRIC = 36;
            public const int MPIN_CHANGE = 28;
            public const int ACCOUNT_OPEN_BIOMETRIC = 29;
            public const int TRANSACTION_LOGS = 30;
            public const int DR_RECEIVE_BIOMETRIC = 35;
            public const int DR_CANCEL_RECEIVE_BIOMETRIC = 143;
            public const int ACCOUNT_UPGRADE = 37;
            public const int ADD_AGENT_USER = 43;
            public const int LIQUIDITY_SUPPORT = 45;
            public const int CARD_ISSUANCE = 76;
            public const int CASH_WITHDRAW_MYSIS = 81;
            public const int MIS_REPORTS = 82;
            public const int DEBIT_CARD_REQUEST = 102;
            public const int ACCOUNT_STATEMENT = 98;
            public const int QR_TRANSACTION_LOGS = 100;
            public const int QR_TRANSACTION_REFUND = 103;
            public const int QR_GENERATE = 110;
            public const int ACCOUNT_OPEN_BISP = 109;
            public const int CASH_WITHDRAW_BISP = 107;
            public const int BALANCE_INQUIRY_BISP = 106;
            public const int HRA_ACCOUNT_UPGRADE = 112;
            public const int CASH_WITHDRAW_BIOMETRIC = 130;
            public const int DORMANCY_REMOVE = 124;

            public const int ADD_TILL = 116;
            public const int EDIT_TILL = 117;
            public const int DELETE_TILL = 118;
            public const int MANAGE_TILLS = 170;
            // public const int DR_CANCEL_BIOMETRIC = 143;
            public const int MOBILE_OTP = 151;
            public const int LEAD_GENERATION = 160;
            public const int BUY_BUNDLE = 163;

        }

        public class AccountTypes
        {
            public const string BB = "BB";
            public const string CORE = "CB";
            public const string IBFT = "IBFT";
            public const string IBAN = "IBAN";
            public const string BISP = "BISP";
        }

        public class AgentType
        {
            public const int ANM = 1;
            public const int CHILD = 2;
            public const int SUPER = 3;
            public const int SUB = 4;
            public const int DIRECT = 5;
            public const int MERCHANT = 6;
        }


        public class TPEInquiryType
        {
            public const string INQUIRY = "INQUIRY";
            public const string VALIDATE = "VALIDATE";
        }

        public class AES
        {//We have hard-coded it after discussion 
            public const string AES_KEY = "asdrcsiort85sdjr5963asejks2698sw";
            public const string AES_IV = "asjircnhtrwsg56s";
        }

        public class Channels
        {
            public const string USSD = "USSD";
            public const string MOBILE_ANDROID = "MOBILE_ANDROID";
            public const string SMS = "SMS";
            public const string INTERNET = "INTERNET";
        }

        public class ChannelIds
        {
            public const int USSD = 2;
            public const int MOBILE_ANDROID = 3;
            public const int SMS = 4;
            public const int INTERNET = 1;
        }

        public class EMAILALERT
        {
            public const string CHANGE_PASSWORD = "PASSWORD_CHANGE";
            public const string RETRIEVE_PASSWORD = "RETRIEVE_PASSWORD";
        }

        public class BILL_AMOUNT_TYPE
        {
            public const string Any = "1";
            public const string Multiples = "2";
            public const string Denomination = "3";
            public const string NoAmount = "4";
        }

        public enum AGENTSTATUS
        {
            Active = 1,
            Inactive = 2,
            Blocked = 3,
            Terminate = 4,
        }

        public enum AgentBlockAction
        {
            Block = 1,
            Unblock = 2,
            Terminate = 3,
            AddTxn = 4,
        }

        public class AGENT_USER_STATUS
        {
            public const string Active = "1";
            public const string InActive = "2";
            public const string Terminate = "3";
            public const string Block = "4";
        }

        public class AGENT_USER_OPERTIONS
        {
            public const string AddTransType = "AddTransType";
            public const string AddTxnLimit = "AddTxnLimit";
            public const string CreateUser = "CreateUser";
            public const string PASSWORD_LENGTH = "8";
            public const string BLOCK_USER = "BlockUser";
            public const string UNBLOCK_USER = "UnblockUser";
            public const string UnAssignTransaction = "UnAssignTransaction";
        }

        public class BLOCKING_TYPE
        {
            public const string AgentBlock = "AgBlock";
        }

        public class ResponseMessage
        {
            public const string INVALID_CONSUMER_NO = "All Consumer numbers are incorrect";
        }

        public class AccessKeyForOTP
        {
            public const string Mobile_OTP = "MPin Reset";
        }

    }
}
