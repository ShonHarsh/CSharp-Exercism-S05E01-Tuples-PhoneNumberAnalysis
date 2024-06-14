using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

/// <summary>
/// Phone numbers passed to the routines are guaranteed to be in the form NNN-NNN-NNNN e.g. 212-515-9876 and non-null.
/// </summary>
public static class PhoneNumber
{
    /// <summary>
    /// An indication of whether the number has a New York dialing code ie. 212 as the first 3 digits
    /// An indication of whether the number is fake having 555 as a prefix code in positions 5 to 7 (numbering from 1)
    /// The last 4 digits of the number.
    /// </summary>
    /// <param name="phoneNumber">The phone number in the form of NNN-NNN-NNNN.</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException">NotImplementedException</exception>
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        //Split the phone number into segments in an array
        string[] phoneSegments = phoneNumber.Split('-');
        //set the phone area code
        string phoneAreaCode = phoneSegments[0];
        //set the phone prefix
        string phonePrefix = phoneSegments[1];
        //set the phone line number
        string phoneLineNumber = phoneSegments[2];

        //set return values
        bool isNewYork = (phoneAreaCode == "212");
        bool isFake = (phonePrefix == "555");
        string localNumber = phoneLineNumber;

        return (isNewYork, isFake, localNumber);

        throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    /// <summary>
    /// An indication of whether the number is fake having 555 as a prefix code in positions 5 to 7 (numbering from 1)
    /// </summary>
    /// <param name="phoneNumberInfo">The phone number information as a tuple.</param>
    /// <returns>A boolean value representing if the phone number is fake.</returns>
    /// <exception cref="NotImplementedException">NotImplementedException</exception>
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;

        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
