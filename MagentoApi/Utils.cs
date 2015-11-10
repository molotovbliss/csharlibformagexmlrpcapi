/* 
MagentoApi CSharp Library
Copyright (c) 2009 ez.newsletter, LLC <ezmagento@ez-llc.com>
ez.newsletter - Advanced Targeted Email Marketing for Magento Store Owners
http://www.ez-llc.com/studio/site/eznewsletter/email-marketing-info-magento-customer-management.aspx
Contributions By:
	Keith Smyth keith@kkl.com.au

XML-RPC.NET library
Copyright (c) 2001-2006, Charles Cook <charlescook@cookcomputing.com>

Permission is hereby granted, free of charge, to any person 
obtaining a copy of this software and associated documentation 
files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, 
publish, distribute, sublicense, and/or sell copies of the Software, 
and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be 
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CookComputing.XmlRpc;

namespace Ez.Newsletter.MagentoApi
{
    public class Utils
    {
        #region Private Member Variables

        #endregion

        #region Private Properties

        #endregion

        #region Public Properties

        #endregion

        #region Constructor

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods
        // utility for xml-rpc request handler
        public static void RequestEventHandler(object sender, XmlRpcRequestEventArgs args)
        {
            StreamReader reader = new StreamReader(args.RequestStream, Encoding.UTF8);
            Console.WriteLine("\nXML-RPC REQUEST\n" + reader.ReadToEnd());
        }

        // utility for xml-rpc response handler
        public static void ResponseEventHandler(object sender, XmlRpcResponseEventArgs args)
        {
            StreamReader reader = new StreamReader(args.ResponseStream, Encoding.UTF8);
            Console.WriteLine("\nXML-RPC RESPONSE\n" + reader.ReadToEnd());
        }

        // utility that uncovers the keys and values of the xml-rpc struct for figuring out and creating your own structs/classes
        public static void StructDiscovery(object[] bar)
        {
            //used to discover the items returned
            foreach (object foo in bar)
            {
                XmlRpcStruct duh = (XmlRpcStruct)foo;
                foreach (string ugh in duh.Keys)
                {
                    // writes the key value pairs
                    Console.WriteLine(ugh + "=" + duh[ugh]);
                }
            }
        }

        // utility to build the class properties
        public static void ClassPropertyBuilder(object[] bar)
        {
            string filePath = @"C:\temp\orderinfo.cs";
            StringBuilder fileData = new StringBuilder();

            //build the private properties
            foreach (object foo in bar)
            {
                XmlRpcStruct duh = (XmlRpcStruct)foo;
                foreach (string ugh in duh.Keys)
                {
                    fileData.AppendLine("private string _" + ugh + ";");
                }
            }

            // add space between properties
            fileData.AppendLine();

            //build the public properties
            foreach (object foo in bar)
            {
                XmlRpcStruct duh = (XmlRpcStruct)foo;
                foreach (string ugh in duh.Keys)
                {
                    // writes the key value pairs
                    fileData.AppendLine("public string " + ugh);
                    fileData.AppendLine("{");
                    fileData.AppendLine("\tget { return _" + ugh + "; }");
                    fileData.AppendLine("\tset { _" + ugh + " = value; }");
                    fileData.AppendLine("}");
                }
            }

            // write the file
            File.WriteAllText(filePath, fileData.ToString());
        }
        #endregion
    }
}
