// ***********************************************************************
// Copyright (c) 2009 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

// ****************************************************************
//              Generated by the NUnit Syntax Generator
//
// Command Line: GenSyntax.exe -syntax:SyntaxElements.txt Shared/Framework/Is.cs Shared/Framework/Has.cs NUnit/Framework/Text.cs Shared/Framework/Throws.cs Shared/Framework/Constraints/ConstraintFactory.cs Shared/Framework/Constraints/ConstraintExpression.cs Shared/Framework/Assert.cs
// 
//                  DO NOT MODIFY THIS FILE DIRECTLY
// ****************************************************************

using System;
using System.Collections;
using NUnit.Framework.Constraints;

namespace NUnit.Framework
{
    /// <summary>
    /// Helper class with properties and methods that supply
    /// constraints that operate on exceptions.
    /// </summary>
    public class Throws
    {
        #region Exception

        /// <summary>
        /// Creates a constraint specifying an expected exception
        /// </summary>
public static ResolvableConstraintExpression Exception
        {
            get { return new ConstraintExpression().Append(new ThrowsOperator()); }
        }

        #endregion

        #region InnerException

#if !NUNITLITE
        /// <summary>
        /// Creates a constraint specifying an exception with a given InnerException
        /// </summary>
public static ResolvableConstraintExpression InnerException
        {
            get { return Exception.InnerException; }
        }
#endif

        #endregion

        #region TargetInvocationException

#if !NUNITLITE
        /// <summary>
        /// Creates a constraint specifying an expected TargetInvocationException
        /// </summary>
public static ExactTypeConstraint TargetInvocationException
        {
            get { return TypeOf(typeof(System.Reflection.TargetInvocationException)); }
        }
#endif

        #endregion

        #region ArgumentException

#if !NUNITLITE
        /// <summary>
        /// Creates a constraint specifying an expected TargetInvocationException
        /// </summary>
public static ExactTypeConstraint ArgumentException
        {
            get { return TypeOf(typeof(System.ArgumentException)); }
        }
#endif

        #endregion

        #region InvalidOperationException

#if !NUNITLITE
        /// <summary>
        /// Creates a constraint specifying an expected TargetInvocationException
        /// </summary>
public static ExactTypeConstraint InvalidOperationException
        {
            get { return TypeOf(typeof(System.InvalidOperationException)); }
        }
#endif

        #endregion

        #region Nothing

        /// <summary>
        /// Creates a constraint specifying that no exception is thrown
        /// </summary>
public static ThrowsNothingConstraint Nothing
        {
            get { return new ThrowsNothingConstraint(); }
        }

        #endregion

        #region TypeOf

        /// <summary>
        /// Creates a constraint specifying the exact type of exception expected
        /// </summary>
public static ExactTypeConstraint TypeOf(Type expectedType)
        {
            return Exception.TypeOf(expectedType);
        }

#if CLR_2_0
        /// <summary>
        /// Creates a constraint specifying the exact type of exception expected
        /// </summary>
public static ExactTypeConstraint TypeOf<T>()
        {
            return TypeOf(typeof(T));
        }
#endif

        #endregion

        #region InstanceOf

        /// <summary>
        /// Creates a constraint specifying the type of exception expected
        /// </summary>
public static InstanceOfTypeConstraint InstanceOf(Type expectedType)
        {
            return Exception.InstanceOf(expectedType);
        }

#if CLR_2_0
        /// <summary>
        /// Creates a constraint specifying the type of exception expected
        /// </summary>
public static InstanceOfTypeConstraint InstanceOf<T>()
        {
            return InstanceOf(typeof(T));
        }
#endif

        #endregion

    }
}
