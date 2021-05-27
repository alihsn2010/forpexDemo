using System;
using System.Collections.Generic;
using System.Text;

namespace Fopex.DAL.Common
{
    public static class SafeConvert
    {

        public static string ToString(object value)
        {
            try
            {
                return (value == DBNull.Value || value == null) ? null : value.ToString();
            }
            catch
            {
                return null;
            }
        }
        public static string NullToString(object value)
        {
            try
            {
                return (value == DBNull.Value || value == null) ? string.Empty : value.ToString();
            }
            catch
            {
                return null;
            }
        }

        public static int ToInt32(object value)
        {
            try
            {
                if (value == null || value.ToString().Equals(string.Empty))
                    return default(int);

                return Convert.ToInt32(value);
            } // Remove general catch
            catch (ArgumentException)
            {
                return default(int);
            }
            catch (OverflowException)
            {
                return default(int);
            }
            catch (FormatException)
            {
                return default(int);
            }
        }

        public static long ToInt64(object value)
        {
            try
            {
                if (value == null || value.ToString().Equals(string.Empty))
                    return default(long);

                return Convert.ToInt64(value);
            }
            catch (ArgumentException)
            {
                return default(long);
            }
            catch (OverflowException)
            {
                return default(long);
            }
            catch (FormatException)
            {
                return default(long);
            }
        }

        public static bool ToBoolean(object value)
        {
            try
            {
                if (value == null || value.ToString().Equals(string.Empty))
                    return default(bool);

                return Convert.ToBoolean(value);
            }
            catch (InvalidCastException)
            {
                return default(bool);
            }
        }


        public static bool ToBoolean(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return default(bool);

                return Convert.ToBoolean(value);
            }
            catch
            {
                return value == "1";
            }
        }

        public static byte[] ToByteArray(object value)
        {
            try
            {
                if (value == DBNull.Value || value == null || value.ToString().Equals(string.Empty))
                    return null;

                return (byte[])(value);
            }
            catch (InvalidCastException)
            {
                return new byte[0];
            }
        }

        public static decimal ToDecimal(object value)
        {
            try
            {
                if (value == null || value.ToString().Equals(string.Empty))
                    return default(decimal);

                return Convert.ToDecimal(value);
            }
            catch
            {
                return default(decimal);
            }
        }

        public static DateTime ToDateTime(object value, DateTime defValue)
        {
            try
            {
                if (value == null || value.ToString() == null || value.ToString().Equals(string.Empty))
                    return defValue;

                return Convert.ToDateTime(value);
            }
            catch (InvalidCastException)
            {
                return defValue;
            }
        }

        public static T? ToNullable<T>(object value) where T : struct
        {
            if (value is T)
                return new Nullable<T>((T)value);

            if (value == null || value is DBNull)
                return new Nullable<T>();

            try
            {
                if (value is System.Decimal)
                {
                    int strValue = Convert.ToInt32(value);
                    object TempValue = strValue;
                    return new Nullable<T>((T)TempValue);
                }
                else if (value is System.String)
                {
                    string strTemp = ToString(value);
                    if (strTemp != null)
                    {
                        int strValue = Convert.ToInt32(value);
                        object TempValue = strValue;
                        return new Nullable<T>((T)TempValue);
                    }
                }
                return new Nullable<T>((T)value);
            }
            catch (Exception ex)
            {

                return new Nullable<T>();
            }
        }

        public static DateTime ToDateTime(object value)
        {
            return ToDateTime(value, default(DateTime));
        }

        public static string ConvertDateTimeToString(object value)
        {
            try
            {
                if (value == null || value.ToString() == null || value.ToString().Equals(string.Empty))
                {
                    return string.Empty;
                }
                else
                {
                    return Convert.ToDateTime(value).ToShortDateString();
                }
            }
            catch (InvalidCastException)
            {
                return ToDateTime(value, default(DateTime)).ToShortDateString();
            }

        }

        public static T ToEnum<T>(object value, T defVal)
            where T : struct
        {
            try { return ToEnum<T>(value); }
            catch { }

            return defVal;
        }

        public static T ToEnum<T>(object value)
            where T : struct
        {
            string strValue = value + "";
            return (T)Enum.Parse(typeof(T), strValue, true);
        }

        public static object DbValue<T>(T? value) where T : struct
        {
            return value.HasValue ? (object)value.Value : (object)DBNull.Value;
        }

        /// <summary>
        /// Return DBNull if value is null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>value or of DBNull</returns>
        /// <remarks>This function will also work with Nullable&ltT&gt</remarks>
        public static object DbValue(object value)
        {
            return (value == null) ? DBNull.Value : value;
        }
    }
}


