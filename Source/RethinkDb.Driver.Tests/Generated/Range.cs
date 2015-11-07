




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Tests RQL range generation

    [TestFixture]
    public class Range : YamlTestFixture {

        public Range (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIzIiwiT3JpZ2luYWwiOiJyLnJhbmdlKCkudHlwZV9vZigpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5yYW5nZSgpLnR5cGVPZigpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlNUUkVBTSIsIkV4cGVjdGVkVHlwZSI6IlN0cmluZyIsIkV4cGVjdGVkSmF2YSI6IlwiU1RSRUFNXCIiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, range.yaml, #3
                 /* ExpectedOriginal: STREAM */
                 var expected_ = "STREAM";
                 
                 /* Original: r.range().type_of() */
                 var obtained = runOrCatch( r.range().typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiI2IiwiT3JpZ2luYWwiOiJyLnJhbmdlKCkubGltaXQoNCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnJhbmdlKCkubGltaXQoNEwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlswLCAxLCAyLCAzXSIsIkV4cGVjdGVkVHlwZSI6Ikxpc3QiLCJFeHBlY3RlZEphdmEiOiJyLmFycmF5KDBMLCAxTCwgMkwsIDNMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, range.yaml, #6
                 /* ExpectedOriginal: [0, 1, 2, 3] */
                 var expected_ = r.array(0L, 1L, 2L, 3L);
                 
                 /* Original: r.range().limit(4) */
                 var obtained = runOrCatch( r.range().limit(4L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiI5IiwiT3JpZ2luYWwiOiJyLnJhbmdlKDQpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5yYW5nZSg0TCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiWzAsIDEsIDIsIDNdIiwiRXhwZWN0ZWRUeXBlIjoiTGlzdCIsIkV4cGVjdGVkSmF2YSI6InIuYXJyYXkoMEwsIDFMLCAyTCwgM0wpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, range.yaml, #9
                 /* ExpectedOriginal: [0, 1, 2, 3] */
                 var expected_ = r.array(0L, 1L, 2L, 3L);
                 
                 /* Original: r.range(4) */
                 var obtained = runOrCatch( r.range(4L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIxMiIsIk9yaWdpbmFsIjoici5yYW5nZSgyLCA1KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucmFuZ2UoMkwsIDVMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJbMiwgMywgNF0iLCJFeHBlY3RlZFR5cGUiOiJMaXN0IiwiRXhwZWN0ZWRKYXZhIjoici5hcnJheSgyTCwgM0wsIDRMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, range.yaml, #12
                 /* ExpectedOriginal: [2, 3, 4] */
                 var expected_ = r.array(2L, 3L, 4L);
                 
                 /* Original: r.range(2, 5) */
                 var obtained = runOrCatch( r.range(2L, 5L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIxNSIsIk9yaWdpbmFsIjoici5yYW5nZSgwKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucmFuZ2UoMEwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IltdIiwiRXhwZWN0ZWRUeXBlIjoiTGlzdCIsIkV4cGVjdGVkSmF2YSI6InIuYXJyYXkoKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, range.yaml, #15
                 /* ExpectedOriginal: [] */
                 var expected_ = r.array();
                 
                 /* Original: r.range(0) */
                 var obtained = runOrCatch( r.range(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIxOCIsIk9yaWdpbmFsIjoici5yYW5nZSg1LCAyKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucmFuZ2UoNUwsIDJMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJbXSIsIkV4cGVjdGVkVHlwZSI6Ikxpc3QiLCJFeHBlY3RlZEphdmEiOiJyLmFycmF5KCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, range.yaml, #18
                 /* ExpectedOriginal: [] */
                 var expected_ = r.array();
                 
                 /* Original: r.range(5, 2) */
                 var obtained = runOrCatch( r.range(5L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIyMSIsIk9yaWdpbmFsIjoici5yYW5nZSgtNSwgLTIpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5yYW5nZSgtNUwsIC0yTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiWy01LCAtNCwgLTNdIiwiRXhwZWN0ZWRUeXBlIjoiTGlzdCIsIkV4cGVjdGVkSmF2YSI6InIuYXJyYXkoLTVMLCAtNEwsIC0zTCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, range.yaml, #21
                 /* ExpectedOriginal: [-5, -4, -3] */
                 var expected_ = r.array(-5L, -4L, -3L);
                 
                 /* Original: r.range(-5, -2) */
                 var obtained = runOrCatch( r.range(-5L, -2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIyNCIsIk9yaWdpbmFsIjoici5yYW5nZSgtNSwgMikiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnJhbmdlKC01TCwgMkwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlstNSwgLTQsIC0zLCAtMiwgLTEsIDAsIDFdIiwiRXhwZWN0ZWRUeXBlIjoiTGlzdCIsIkV4cGVjdGVkSmF2YSI6InIuYXJyYXkoLTVMLCAtNEwsIC0zTCwgLTJMLCAtMUwsIDBMLCAxTCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, range.yaml, #24
                 /* ExpectedOriginal: [-5, -4, -3, -2, -1, 0, 1] */
                 var expected_ = r.array(-5L, -4L, -3L, -2L, -1L, 0L, 1L);
                 
                 /* Original: r.range(-5, 2) */
                 var obtained = runOrCatch( r.range(-5L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIzMCIsIk9yaWdpbmFsIjoici5yYW5nZShcImZvb1wiKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucmFuZ2UoXCJmb29cIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIkV4cGVjdGVkIHR5cGUgTlVNQkVSIGJ1dCBmb3VuZCBTVFJJTkcuXCIsIFtdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCB0eXBlIE5VTUJFUiBidXQgZm91bmQgU1RSSU5HLlwiLCByLmFycmF5KCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, range.yaml, #30
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array());
                 
                 /* Original: r.range("foo") */
                 var obtained = runOrCatch( r.range("foo") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIzNCIsIk9yaWdpbmFsIjoici5yYW5nZSg5MDA3MTk5MjU0NzQwOTk0KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucmFuZ2UoOTAwNzE5OTI1NDc0MDk5NEwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycl9yZWdleChcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJOdW1iZXIgbm90IGFuIGludGVnZXIgXFxcXCg+MlxcXFxeNTNcXFxcKS4gOTAwNzE5OTI1NDc0MDk5NFwiLCBbXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnJSZWdleCIsIkV4cGVjdGVkSmF2YSI6ImVycl9yZWdleChcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJOdW1iZXIgbm90IGFuIGludGVnZXIgXFxcXCg+MlxcXFxeNTNcXFxcKS4gOTAwNzE5OTI1NDc0MDk5NFwiLCByLmFycmF5KCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, range.yaml, #34
                 /* ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer \\(>2\\^53\\). 9007199254740994", []) */
                 var expected_ = err_regex("ReqlQueryLogicError", "Number not an integer \\(>2\\^53\\). 9007199254740994", r.array());
                 
                 /* Original: r.range(9007199254740994) */
                 var obtained = runOrCatch( r.range(9007199254740994L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiIzNyIsIk9yaWdpbmFsIjoici5yYW5nZSgtOTAwNzE5OTI1NDc0MDk5NCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnJhbmdlKC05MDA3MTk5MjU0NzQwOTk0TCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyX3JlZ2V4KFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIk51bWJlciBub3QgYW4gaW50ZWdlciBcXFxcKDwtMlxcXFxeNTNcXFxcKS4gLTkwMDcxOTkyNTQ3NDA5OTRcIiwgW10pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyUmVnZXgiLCJFeHBlY3RlZEphdmEiOiJlcnJfcmVnZXgoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiTnVtYmVyIG5vdCBhbiBpbnRlZ2VyIFxcXFwoPC0yXFxcXF41M1xcXFwpLiAtOTAwNzE5OTI1NDc0MDk5NFwiLCByLmFycmF5KCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, range.yaml, #37
                 /* ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer \\(<-2\\^53\\). -9007199254740994", []) */
                 var expected_ = err_regex("ReqlQueryLogicError", "Number not an integer \\(<-2\\^53\\). -9007199254740994", r.array());
                 
                 /* Original: r.range(-9007199254740994) */
                 var obtained = runOrCatch( r.range(-9007199254740994L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiI0MCIsIk9yaWdpbmFsIjoici5yYW5nZSgwLjUpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5yYW5nZSgwLjUpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycl9yZWdleChcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJOdW1iZXIgbm90IGFuIGludGVnZXIuIDBcXFxcLjVcIiwgW10pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyUmVnZXgiLCJFeHBlY3RlZEphdmEiOiJlcnJfcmVnZXgoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiTnVtYmVyIG5vdCBhbiBpbnRlZ2VyLiAwXFxcXC41XCIsIHIuYXJyYXkoKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, range.yaml, #40
                 /* ExpectedOriginal: err_regex("ReqlQueryLogicError", "Number not an integer. 0\\.5", []) */
                 var expected_ = err_regex("ReqlQueryLogicError", "Number not an integer. 0\\.5", r.array());
                 
                 /* Original: r.range(0.5) */
                 var obtained = runOrCatch( r.range(0.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiI0MyIsIk9yaWdpbmFsIjoici5yYW5nZSgpLmNvdW50KCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLnJhbmdlKCkuY291bnQoKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiQ2Fubm90IHVzZSBhbiBpbmZpbml0ZSBzdHJlYW0gd2l0aCBhbiBhZ2dyZWdhdGlvbiBmdW5jdGlvbiAoYHJlZHVjZWAsIGBjb3VudGAsIGV0Yy4pIG9yIGNvZXJjZSBpdCB0byBhbiBhcnJheS5cIiwgW10pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyIiwiRXhwZWN0ZWRKYXZhIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIkNhbm5vdCB1c2UgYW4gaW5maW5pdGUgc3RyZWFtIHdpdGggYW4gYWdncmVnYXRpb24gZnVuY3Rpb24gKGByZWR1Y2VgLCBgY291bnRgLCBldGMuKSBvciBjb2VyY2UgaXQgdG8gYW4gYXJyYXkuXCIsIHIuYXJyYXkoKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, range.yaml, #43
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", r.array());
                 
                 /* Original: r.range().count() */
                 var obtained = runOrCatch( r.range().count() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiI0NiIsIk9yaWdpbmFsIjoici5yYW5nZSgpLmNvZXJjZV90byhcIkFSUkFZXCIpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5yYW5nZSgpLmNvZXJjZVRvKFwiQVJSQVlcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIkNhbm5vdCB1c2UgYW4gaW5maW5pdGUgc3RyZWFtIHdpdGggYW4gYWdncmVnYXRpb24gZnVuY3Rpb24gKGByZWR1Y2VgLCBgY291bnRgLCBldGMuKSBvciBjb2VyY2UgaXQgdG8gYW4gYXJyYXkuXCIsIFtdKSIsIkV4cGVjdGVkVHlwZSI6IkVyciIsIkV4cGVjdGVkSmF2YSI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJDYW5ub3QgdXNlIGFuIGluZmluaXRlIHN0cmVhbSB3aXRoIGFuIGFnZ3JlZ2F0aW9uIGZ1bmN0aW9uIChgcmVkdWNlYCwgYGNvdW50YCwgZXRjLikgb3IgY29lcmNlIGl0IHRvIGFuIGFycmF5LlwiLCByLmFycmF5KCkpIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, range.yaml, #46
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", r.array());
                 
                 /* Original: r.range().coerce_to("ARRAY") */
                 var obtained = runOrCatch( r.range().coerceTo("ARRAY") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiI0OSIsIk9yaWdpbmFsIjoici5yYW5nZSgpLmNvZXJjZV90byhcIk9CSkVDVFwiKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIucmFuZ2UoKS5jb2VyY2VUbyhcIk9CSkVDVFwiKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiQ2Fubm90IHVzZSBhbiBpbmZpbml0ZSBzdHJlYW0gd2l0aCBhbiBhZ2dyZWdhdGlvbiBmdW5jdGlvbiAoYHJlZHVjZWAsIGBjb3VudGAsIGV0Yy4pIG9yIGNvZXJjZSBpdCB0byBhbiBhcnJheS5cIiwgW10pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyIiwiRXhwZWN0ZWRKYXZhIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIkNhbm5vdCB1c2UgYW4gaW5maW5pdGUgc3RyZWFtIHdpdGggYW4gYWdncmVnYXRpb24gZnVuY3Rpb24gKGByZWR1Y2VgLCBgY291bnRgLCBldGMuKSBvciBjb2VyY2UgaXQgdG8gYW4gYXJyYXkuXCIsIHIuYXJyYXkoKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, range.yaml, #49
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot use an infinite stream with an aggregation function (`reduce`, `count`, etc.) or coerce it to an array.", r.array());
                 
                 /* Original: r.range().coerce_to("OBJECT") */
                 var obtained = runOrCatch( r.range().coerceTo("OBJECT") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoicmFuZ2UueWFtbCIsIkxpbmVOdW0iOiI1MiIsIk9yaWdpbmFsIjoici5yYW5nZSg0KS5jb3VudCgpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5yYW5nZSg0TCkuY291bnQoKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiI0IiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjRMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, range.yaml, #52
                 /* ExpectedOriginal: 4 */
                 var expected_ = 4L;
                 
                 /* Original: r.range(4).count() */
                 var obtained = runOrCatch( r.range(4L).count() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
