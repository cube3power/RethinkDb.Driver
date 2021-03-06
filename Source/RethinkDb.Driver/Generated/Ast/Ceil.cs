














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Ceil : ReqlExpr {

    
    
    
/// <summary>
/// <para>Rounds the given value up, returning the smallest integer value greater than or equal to the given value (the value's ceiling).</para>
/// </summary>
/// <example><para>Example: Return the ceiling of 12.345.</para>
/// <code>&gt; r.ceil(12.345).run(conn, callback);
/// 
/// 13.0
/// </code></example>
        public Ceil (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Rounds the given value up, returning the smallest integer value greater than or equal to the given value (the value's ceiling).</para>
/// </summary>
/// <example><para>Example: Return the ceiling of 12.345.</para>
/// <code>&gt; r.ceil(12.345).run(conn, callback);
/// 
/// 13.0
/// </code></example>
        public Ceil (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Rounds the given value up, returning the smallest integer value greater than or equal to the given value (the value's ceiling).</para>
/// </summary>
/// <example><para>Example: Return the ceiling of 12.345.</para>
/// <code>&gt; r.ceil(12.345).run(conn, callback);
/// 
/// 13.0
/// </code></example>
        public Ceil (Arguments args, OptArgs optargs)
         : base(TermType.CEIL, args, optargs) {
        }


    



    


    

    
        /// <summary>
        /// Get a single field from an object. If called on a sequence, gets that field from every object in the sequence, skipping objects that lack it.
        /// </summary>
        /// <param name="bracket"></param>
        public new Bracket this[string bracket] => base[bracket];
        
        /// <summary>
        /// Get the nth element of a sequence, counting from zero. If the argument is negative, count from the last element.
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public new Bracket this[int bracket] => base[bracket];


    

    


    
    }
}
