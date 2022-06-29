﻿using System;
using System.Diagnostics;
using System.Text;
using NHapi.Base.Parser;
using NHapiTools.Base.Net;

namespace TBD
{
    public class HapiSendMessageSimpleExample
    {
        private static int PORT_NUMBER = 1234;// change this to whatever your port number is

        public void startsending()
        {
            try
            {
                // create the HL7 message
                // this AdtMessageFactory class is not from NHAPI but my own wrapper
                // check my GitHub page or see my earlier article for reference
                var adtMessage = AdtMessageFactory.CreateMessage("A01");

                // create a new MLLP client over the specified port (note this class is from NHAPI Tools)
                //Note that using higher level encodings such as UTF-16 is not recommended due to conflict with
                //MLLP wrapping characters

                var connection = new SimpleMLLPClient("localhost", PORT_NUMBER, Encoding.UTF8);

                // send the previously created HL7 message over the connection established
                var parser = new PipeParser();
                LogToDebugConsole("Sending message:" + "\n" + parser.Encode(adtMessage));
                var response = connection.SendHL7Message(adtMessage);

                // display the message response received from the remote party
                var responseString = parser.Encode(response);
                LogToDebugConsole("Received response:\n" + responseString);

            }
            catch (Exception e)
            {
                LogToDebugConsole($"Error occured while creating HL7 message {e.Message}");
            }

        }

        private static void LogToDebugConsole(string informationToLog)
        {
            Debug.WriteLine(informationToLog);
        }


    }
}