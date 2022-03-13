//
//

using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        SentSMS();
    }

    static void SentSMS()
    {
        // Craig's test account
        string accountSid = "AC599760bfd6358c0ad81683ad3b299a7d";
        string authToken = "9adb63225f044b0019590e3d9b741951";
        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "A Saudi prince want's to send you money!",
            from: new Twilio.Types.PhoneNumber("+17624755550"),
            to: new Twilio.Types.PhoneNumber("+13525142743")
        );
        Console.WriteLine(message.Sid);
    }
}
