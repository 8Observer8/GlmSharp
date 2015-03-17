﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GlmSharpGenerator.Types
{
    abstract class AbstractType
    {
        /// <summary>
        /// All known types
        /// </summary>
        public static readonly Dictionary<string, AbstractType> Types = new Dictionary<string, AbstractType>();

        /// <summary>
        /// Base name (e.g. vec, mat, quat)
        /// </summary>
        public string BaseName { get; set; } = "vec";
        /// <summary>
        /// Name of the base type
        /// </summary>
        public string BaseTypeName => BaseType.Name;
        /// <summary>
        /// Actual name of the type (e.g. the C# class name)
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// Name used for parameter types (for generics has T)
        /// </summary>
        public string NameThat => Name + GenericSuffix;
        /// <summary>
        /// Suffix for generic types
        /// </summary>
        public string GenericSuffix => BaseType.Generic ? "<T>" : "";
        /// <summary>
        /// Reference to base type
        /// </summary>
        public BuiltinType BaseType { get; set; }

        /// <summary>
        /// Namespace of this type
        /// </summary>
        public virtual string Namespace { get; } = "GlmSharp";

        /// <summary>
        /// Folder for this type
        /// </summary>
        public virtual string Folder { get; } = "";
        /// <summary>
        /// Folder with trailing /
        /// </summary>
        public string PathOf(string basePath) => string.IsNullOrEmpty(Folder) ? Path.Combine(basePath, Name + ".cs") : Path.Combine(basePath, Folder, Name + ".cs");

        /// <summary>
        /// Comment of this type
        /// </summary>
        public abstract string TypeComment { get; }

        /// <summary>
        /// List of C# base classes (mostly interfaces)
        /// </summary>
        public virtual IEnumerable<string> BaseClasses { get { yield break; } }

        public IEnumerable<string> CSharpFile
        {
            get
            {
                var baseclasses = BaseClasses.ToArray();
                yield return "using System;";
                yield return "using System.Collections;";
                yield return "using System.Collections.Generic;";
                yield return "using System.Globalization;";
                yield return "using System.Numerics;";
                yield return "using System.Runtime.InteropServices;";
                yield return "using System.Runtime.Serialization;";
                yield return "using System.Linq;";
                yield return "using GlmSharp.Swizzle;";
                yield return "";
                yield return "// ReSharper disable InconsistentNaming";
                yield return "";
                yield return "namespace " + Namespace;
                yield return "{";
                foreach (var line in TypeComment.AsComment()) yield return line.Indent();
                yield return "    [Serializable]";
                yield return "    [DataContract]";
                yield return "    [StructLayout(LayoutKind.Sequential)]";
                yield return "    public struct " + Name + GenericSuffix + (baseclasses.Length == 0 ? "" : " : " + baseclasses.CommaSeparated());
                yield return "    {";
                foreach (var line in Body)
                    yield return line.Indent(2);
                yield return "    }";
                yield return "}";
            }
        }

        protected abstract IEnumerable<string> Body { get; }

        public string Comparer(string val) => BaseType.Generic ?
            string.Format("EqualityComparer<T>.Default.Equals({0}, rhs.{0})", val) :
            string.Format("{0}.Equals(rhs.{0})", val);

        public virtual string ZeroValue => BaseType.ZeroValue;
        public virtual string OneValue => BaseType.OneValue;

        public string HashCodeOf(string val) => BaseType.Generic ? string.Format("EqualityComparer<T>.Default.GetHashCode({0})", val) : string.Format("{0}.GetHashCode()", val);


        public string SqrOf(string s) => BaseType.IsComplex ? s + ".LengthSqr()" : s + "*" + s;
        public string SqrOf(char s) => SqrOf(s.ToString());

        public string SqrtOf(string s) => BaseType.Decimal ? s + ".Sqrt()" : string.Format("Math.Sqrt({0})", s);
        public string SqrtOf(char s) => SqrOf(s.ToString());


        public string AbsString(string s) => BaseType.IsSigned ? (BaseType.IsComplex ? s + ".Magnitude" : string.Format("Math.Abs({0})", s)) : s;
        public string AbsString(char s) => BaseType.IsSigned ? (BaseType.IsComplex ? s + ".Magnitude" : string.Format("Math.Abs({0})", s)) : s.ToString();

        public string ConstantSuffixFor(string s)
        {
            if (BaseType == BuiltinType.TypeFloat)
                return s + "f";

            if (BaseType == BuiltinType.TypeDouble)
                return s + "d";

            if (BaseType == BuiltinType.TypeDecimal)
                return s + "m";

            throw new InvalidOperationException("unknown type");
        }

        public static void InitTypes()
        {
            // vectors
            foreach (var type in BuiltinType.BaseTypes)
                for (var comp = 2; comp <= 4; ++comp)
                {
                    var vect = new VectorType
                    {
                        BaseName = type.Prefix + "vec",
                        Components = comp,
                        BaseType = type
                    };
                    var swizzler = vect.SwizzleType;
                    Types.Add(vect.Name, vect);
                    Types.Add(swizzler.Name, swizzler);
                }

            // matrices
            foreach (var type in BuiltinType.BaseTypes)
                for (var rows = 2; rows <= 4; ++rows)
                    for (var cols = 2; cols <= 4; ++cols)
                    {
                        var matt = new MatrixType
                        {
                            BaseName = type.Prefix + "mat",
                            Columns = cols,
                            Rows = rows,
                            BaseType = type
                        };
                        Types.Add(matt.Name, matt);
                    }
        }

    }
}