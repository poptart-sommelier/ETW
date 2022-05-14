// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// TODO: save process rows to sqlite db
using System;
using SQLiteHelper;

namespace ManagedExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment in/out the particular example you'd like to run.
            // String cmdline = ProcessUtilities.GetCommandLine(12896);
            //Console.WriteLine(cmdline);
            //Console.WriteLine("");
            SQLiteHelper.SQLiteHelper.DoSQLStuff();
            //KernelTrace001.Start();
            //KernelTrace002.Start();
            //UserTrace001.Start();
            //UserTrace002.Start();
            //UserTrace003.Start();
            //UserTrace004.Start();
            //UserTrace005.Start();
            //UserTrace006_Rundown.Start();
            //FakingEvents001.Start();
            //WppTrace001.Start();
        }
    }
}
