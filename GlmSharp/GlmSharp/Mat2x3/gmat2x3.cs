using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    
    /// <summary>
    /// A matrix of type T with 2 columns and 3 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct gmat2x3<T> : IReadOnlyList<T>, IEquatable<gmat2x3<T>>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public T m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public T m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public T m02;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public T m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public T m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public T m12;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gmat2x3(T m00, T m01, T m02, T m10, T m11, T m12)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat3x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat4x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat2x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat4x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat2x4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat3x4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gmat4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gvec2<T> c0, gvec2<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x3(gvec3<T> c0, gvec3<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public T[,] Values => new[,] { { m00, m01, m02 }, { m10, m11, m12 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public T[] Values1D => new[] { m00, m01, m02, m10, m11, m12 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public gvec3<T> Column0 => new gvec3<T>(m00, m01, m02);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public gvec3<T> Column1 => new gvec3<T>(m10, m11, m12);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public gvec2<T> Row0 => new gvec2<T>(m00, m10);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public gvec2<T> Row1 => new gvec2<T>(m01, m11);
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public gvec2<T> Row2 => new gvec2<T>(m02, m12);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static gmat2x3<T> Zero { get; } = new gmat2x3<T>(default(T), default(T), default(T), default(T), default(T), default(T));

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m10;
            yield return m11;
            yield return m12;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (2 x 3 = 6).
        /// </summary>
        public int Count => 6;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public T this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m02;
                    case 3: return m10;
                    case 4: return m11;
                    case 5: return m12;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
            set
            {
                switch (fieldIndex)
                {
                    case 0: this.m00 = value; break;
                    case 1: this.m01 = value; break;
                    case 2: this.m02 = value; break;
                    case 3: this.m10 = value; break;
                    case 4: this.m11 = value; break;
                    case 5: this.m12 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public T this[int col, int row]
        {
            get
            {
                return this[col * 3 + row];
            }
            set
            {
                this[col * 3 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(gmat2x3<T> rhs) => (((EqualityComparer<T>.Default.Equals(m00, rhs.m00) && EqualityComparer<T>.Default.Equals(m01, rhs.m01)) && EqualityComparer<T>.Default.Equals(m02, rhs.m02)) && ((EqualityComparer<T>.Default.Equals(m10, rhs.m10) && EqualityComparer<T>.Default.Equals(m11, rhs.m11)) && EqualityComparer<T>.Default.Equals(m12, rhs.m12)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gmat2x3<T> && Equals((gmat2x3<T>) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(gmat2x3<T> lhs, gmat2x3<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(gmat2x3<T> lhs, gmat2x3<T> rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((EqualityComparer<T>.Default.GetHashCode(m00)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m01)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m02)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m10)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m11)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m12);
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public gmat3x2<T> Transposed => new gmat3x2<T>(m00, m10, m01, m11, m02, m12);
    }
}
