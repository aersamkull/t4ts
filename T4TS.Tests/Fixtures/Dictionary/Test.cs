﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4TS.Tests.Fixtures.Basic;
using T4TS.Tests.Utils;

namespace T4TS.Tests.Fixtures.Dictionary
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void DictionaryModelHasExpectedOutput()
        {
            // Expect
            new OutputFor(
                typeof(BasicModel),
                typeof(DictionaryModel)
            ).ToEqual(ExpectedOutput);
        }

const string ExpectedOutput = @"
/****************************************************************************
  Generated by T4TS.tt - don't make any changes in this file
****************************************************************************/

declare module T4TS {
    /** Generated from T4TS.Tests.Fixtures.Basic.BasicModel **/
    export interface BasicModel {
        MyProperty: number;
        SomeDateTime: string;
    }
    /** Generated from T4TS.Tests.Fixtures.Dictionary.DictionaryModel **/
    export interface DictionaryModel {
        IntKey: { [name: number]: T4TS.BasicModel};
        StringKey: { [name: string]: T4TS.BasicModel};
        [index: number]: T4TS.BasicModel;
    }
}
";
    }
}