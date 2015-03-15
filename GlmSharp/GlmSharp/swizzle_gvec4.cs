using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_gvec4<T>
    {
        public readonly T x;
        public readonly T y;
        public readonly T z;
        public readonly T w;
        
        public swizzle_gvec4(T x, T y, T z, T w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        // XYZW Versions
        public gvec2<T> xx => new gvec2<T>(x, x);
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        public gvec4<T> xxxx => new gvec4<T>(x, x, x, x);
        public gvec4<T> xxxy => new gvec4<T>(x, x, x, y);
        public gvec4<T> xxxz => new gvec4<T>(x, x, x, z);
        public gvec4<T> xxxw => new gvec4<T>(x, x, x, w);
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        public gvec4<T> xxyx => new gvec4<T>(x, x, y, x);
        public gvec4<T> xxyy => new gvec4<T>(x, x, y, y);
        public gvec4<T> xxyz => new gvec4<T>(x, x, y, z);
        public gvec4<T> xxyw => new gvec4<T>(x, x, y, w);
        public gvec3<T> xxz => new gvec3<T>(x, x, z);
        public gvec4<T> xxzx => new gvec4<T>(x, x, z, x);
        public gvec4<T> xxzy => new gvec4<T>(x, x, z, y);
        public gvec4<T> xxzz => new gvec4<T>(x, x, z, z);
        public gvec4<T> xxzw => new gvec4<T>(x, x, z, w);
        public gvec3<T> xxw => new gvec3<T>(x, x, w);
        public gvec4<T> xxwx => new gvec4<T>(x, x, w, x);
        public gvec4<T> xxwy => new gvec4<T>(x, x, w, y);
        public gvec4<T> xxwz => new gvec4<T>(x, x, w, z);
        public gvec4<T> xxww => new gvec4<T>(x, x, w, w);
        public gvec2<T> xy => new gvec2<T>(x, y);
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        public gvec4<T> xyxx => new gvec4<T>(x, y, x, x);
        public gvec4<T> xyxy => new gvec4<T>(x, y, x, y);
        public gvec4<T> xyxz => new gvec4<T>(x, y, x, z);
        public gvec4<T> xyxw => new gvec4<T>(x, y, x, w);
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        public gvec4<T> xyyx => new gvec4<T>(x, y, y, x);
        public gvec4<T> xyyy => new gvec4<T>(x, y, y, y);
        public gvec4<T> xyyz => new gvec4<T>(x, y, y, z);
        public gvec4<T> xyyw => new gvec4<T>(x, y, y, w);
        public gvec3<T> xyz => new gvec3<T>(x, y, z);
        public gvec4<T> xyzx => new gvec4<T>(x, y, z, x);
        public gvec4<T> xyzy => new gvec4<T>(x, y, z, y);
        public gvec4<T> xyzz => new gvec4<T>(x, y, z, z);
        public gvec4<T> xyzw => new gvec4<T>(x, y, z, w);
        public gvec3<T> xyw => new gvec3<T>(x, y, w);
        public gvec4<T> xywx => new gvec4<T>(x, y, w, x);
        public gvec4<T> xywy => new gvec4<T>(x, y, w, y);
        public gvec4<T> xywz => new gvec4<T>(x, y, w, z);
        public gvec4<T> xyww => new gvec4<T>(x, y, w, w);
        public gvec2<T> xz => new gvec2<T>(x, z);
        public gvec3<T> xzx => new gvec3<T>(x, z, x);
        public gvec4<T> xzxx => new gvec4<T>(x, z, x, x);
        public gvec4<T> xzxy => new gvec4<T>(x, z, x, y);
        public gvec4<T> xzxz => new gvec4<T>(x, z, x, z);
        public gvec4<T> xzxw => new gvec4<T>(x, z, x, w);
        public gvec3<T> xzy => new gvec3<T>(x, z, y);
        public gvec4<T> xzyx => new gvec4<T>(x, z, y, x);
        public gvec4<T> xzyy => new gvec4<T>(x, z, y, y);
        public gvec4<T> xzyz => new gvec4<T>(x, z, y, z);
        public gvec4<T> xzyw => new gvec4<T>(x, z, y, w);
        public gvec3<T> xzz => new gvec3<T>(x, z, z);
        public gvec4<T> xzzx => new gvec4<T>(x, z, z, x);
        public gvec4<T> xzzy => new gvec4<T>(x, z, z, y);
        public gvec4<T> xzzz => new gvec4<T>(x, z, z, z);
        public gvec4<T> xzzw => new gvec4<T>(x, z, z, w);
        public gvec3<T> xzw => new gvec3<T>(x, z, w);
        public gvec4<T> xzwx => new gvec4<T>(x, z, w, x);
        public gvec4<T> xzwy => new gvec4<T>(x, z, w, y);
        public gvec4<T> xzwz => new gvec4<T>(x, z, w, z);
        public gvec4<T> xzww => new gvec4<T>(x, z, w, w);
        public gvec2<T> xw => new gvec2<T>(x, w);
        public gvec3<T> xwx => new gvec3<T>(x, w, x);
        public gvec4<T> xwxx => new gvec4<T>(x, w, x, x);
        public gvec4<T> xwxy => new gvec4<T>(x, w, x, y);
        public gvec4<T> xwxz => new gvec4<T>(x, w, x, z);
        public gvec4<T> xwxw => new gvec4<T>(x, w, x, w);
        public gvec3<T> xwy => new gvec3<T>(x, w, y);
        public gvec4<T> xwyx => new gvec4<T>(x, w, y, x);
        public gvec4<T> xwyy => new gvec4<T>(x, w, y, y);
        public gvec4<T> xwyz => new gvec4<T>(x, w, y, z);
        public gvec4<T> xwyw => new gvec4<T>(x, w, y, w);
        public gvec3<T> xwz => new gvec3<T>(x, w, z);
        public gvec4<T> xwzx => new gvec4<T>(x, w, z, x);
        public gvec4<T> xwzy => new gvec4<T>(x, w, z, y);
        public gvec4<T> xwzz => new gvec4<T>(x, w, z, z);
        public gvec4<T> xwzw => new gvec4<T>(x, w, z, w);
        public gvec3<T> xww => new gvec3<T>(x, w, w);
        public gvec4<T> xwwx => new gvec4<T>(x, w, w, x);
        public gvec4<T> xwwy => new gvec4<T>(x, w, w, y);
        public gvec4<T> xwwz => new gvec4<T>(x, w, w, z);
        public gvec4<T> xwww => new gvec4<T>(x, w, w, w);
        public gvec2<T> yx => new gvec2<T>(y, x);
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        public gvec4<T> yxxx => new gvec4<T>(y, x, x, x);
        public gvec4<T> yxxy => new gvec4<T>(y, x, x, y);
        public gvec4<T> yxxz => new gvec4<T>(y, x, x, z);
        public gvec4<T> yxxw => new gvec4<T>(y, x, x, w);
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        public gvec4<T> yxyx => new gvec4<T>(y, x, y, x);
        public gvec4<T> yxyy => new gvec4<T>(y, x, y, y);
        public gvec4<T> yxyz => new gvec4<T>(y, x, y, z);
        public gvec4<T> yxyw => new gvec4<T>(y, x, y, w);
        public gvec3<T> yxz => new gvec3<T>(y, x, z);
        public gvec4<T> yxzx => new gvec4<T>(y, x, z, x);
        public gvec4<T> yxzy => new gvec4<T>(y, x, z, y);
        public gvec4<T> yxzz => new gvec4<T>(y, x, z, z);
        public gvec4<T> yxzw => new gvec4<T>(y, x, z, w);
        public gvec3<T> yxw => new gvec3<T>(y, x, w);
        public gvec4<T> yxwx => new gvec4<T>(y, x, w, x);
        public gvec4<T> yxwy => new gvec4<T>(y, x, w, y);
        public gvec4<T> yxwz => new gvec4<T>(y, x, w, z);
        public gvec4<T> yxww => new gvec4<T>(y, x, w, w);
        public gvec2<T> yy => new gvec2<T>(y, y);
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        public gvec4<T> yyxx => new gvec4<T>(y, y, x, x);
        public gvec4<T> yyxy => new gvec4<T>(y, y, x, y);
        public gvec4<T> yyxz => new gvec4<T>(y, y, x, z);
        public gvec4<T> yyxw => new gvec4<T>(y, y, x, w);
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        public gvec4<T> yyyx => new gvec4<T>(y, y, y, x);
        public gvec4<T> yyyy => new gvec4<T>(y, y, y, y);
        public gvec4<T> yyyz => new gvec4<T>(y, y, y, z);
        public gvec4<T> yyyw => new gvec4<T>(y, y, y, w);
        public gvec3<T> yyz => new gvec3<T>(y, y, z);
        public gvec4<T> yyzx => new gvec4<T>(y, y, z, x);
        public gvec4<T> yyzy => new gvec4<T>(y, y, z, y);
        public gvec4<T> yyzz => new gvec4<T>(y, y, z, z);
        public gvec4<T> yyzw => new gvec4<T>(y, y, z, w);
        public gvec3<T> yyw => new gvec3<T>(y, y, w);
        public gvec4<T> yywx => new gvec4<T>(y, y, w, x);
        public gvec4<T> yywy => new gvec4<T>(y, y, w, y);
        public gvec4<T> yywz => new gvec4<T>(y, y, w, z);
        public gvec4<T> yyww => new gvec4<T>(y, y, w, w);
        public gvec2<T> yz => new gvec2<T>(y, z);
        public gvec3<T> yzx => new gvec3<T>(y, z, x);
        public gvec4<T> yzxx => new gvec4<T>(y, z, x, x);
        public gvec4<T> yzxy => new gvec4<T>(y, z, x, y);
        public gvec4<T> yzxz => new gvec4<T>(y, z, x, z);
        public gvec4<T> yzxw => new gvec4<T>(y, z, x, w);
        public gvec3<T> yzy => new gvec3<T>(y, z, y);
        public gvec4<T> yzyx => new gvec4<T>(y, z, y, x);
        public gvec4<T> yzyy => new gvec4<T>(y, z, y, y);
        public gvec4<T> yzyz => new gvec4<T>(y, z, y, z);
        public gvec4<T> yzyw => new gvec4<T>(y, z, y, w);
        public gvec3<T> yzz => new gvec3<T>(y, z, z);
        public gvec4<T> yzzx => new gvec4<T>(y, z, z, x);
        public gvec4<T> yzzy => new gvec4<T>(y, z, z, y);
        public gvec4<T> yzzz => new gvec4<T>(y, z, z, z);
        public gvec4<T> yzzw => new gvec4<T>(y, z, z, w);
        public gvec3<T> yzw => new gvec3<T>(y, z, w);
        public gvec4<T> yzwx => new gvec4<T>(y, z, w, x);
        public gvec4<T> yzwy => new gvec4<T>(y, z, w, y);
        public gvec4<T> yzwz => new gvec4<T>(y, z, w, z);
        public gvec4<T> yzww => new gvec4<T>(y, z, w, w);
        public gvec2<T> yw => new gvec2<T>(y, w);
        public gvec3<T> ywx => new gvec3<T>(y, w, x);
        public gvec4<T> ywxx => new gvec4<T>(y, w, x, x);
        public gvec4<T> ywxy => new gvec4<T>(y, w, x, y);
        public gvec4<T> ywxz => new gvec4<T>(y, w, x, z);
        public gvec4<T> ywxw => new gvec4<T>(y, w, x, w);
        public gvec3<T> ywy => new gvec3<T>(y, w, y);
        public gvec4<T> ywyx => new gvec4<T>(y, w, y, x);
        public gvec4<T> ywyy => new gvec4<T>(y, w, y, y);
        public gvec4<T> ywyz => new gvec4<T>(y, w, y, z);
        public gvec4<T> ywyw => new gvec4<T>(y, w, y, w);
        public gvec3<T> ywz => new gvec3<T>(y, w, z);
        public gvec4<T> ywzx => new gvec4<T>(y, w, z, x);
        public gvec4<T> ywzy => new gvec4<T>(y, w, z, y);
        public gvec4<T> ywzz => new gvec4<T>(y, w, z, z);
        public gvec4<T> ywzw => new gvec4<T>(y, w, z, w);
        public gvec3<T> yww => new gvec3<T>(y, w, w);
        public gvec4<T> ywwx => new gvec4<T>(y, w, w, x);
        public gvec4<T> ywwy => new gvec4<T>(y, w, w, y);
        public gvec4<T> ywwz => new gvec4<T>(y, w, w, z);
        public gvec4<T> ywww => new gvec4<T>(y, w, w, w);
        public gvec2<T> zx => new gvec2<T>(z, x);
        public gvec3<T> zxx => new gvec3<T>(z, x, x);
        public gvec4<T> zxxx => new gvec4<T>(z, x, x, x);
        public gvec4<T> zxxy => new gvec4<T>(z, x, x, y);
        public gvec4<T> zxxz => new gvec4<T>(z, x, x, z);
        public gvec4<T> zxxw => new gvec4<T>(z, x, x, w);
        public gvec3<T> zxy => new gvec3<T>(z, x, y);
        public gvec4<T> zxyx => new gvec4<T>(z, x, y, x);
        public gvec4<T> zxyy => new gvec4<T>(z, x, y, y);
        public gvec4<T> zxyz => new gvec4<T>(z, x, y, z);
        public gvec4<T> zxyw => new gvec4<T>(z, x, y, w);
        public gvec3<T> zxz => new gvec3<T>(z, x, z);
        public gvec4<T> zxzx => new gvec4<T>(z, x, z, x);
        public gvec4<T> zxzy => new gvec4<T>(z, x, z, y);
        public gvec4<T> zxzz => new gvec4<T>(z, x, z, z);
        public gvec4<T> zxzw => new gvec4<T>(z, x, z, w);
        public gvec3<T> zxw => new gvec3<T>(z, x, w);
        public gvec4<T> zxwx => new gvec4<T>(z, x, w, x);
        public gvec4<T> zxwy => new gvec4<T>(z, x, w, y);
        public gvec4<T> zxwz => new gvec4<T>(z, x, w, z);
        public gvec4<T> zxww => new gvec4<T>(z, x, w, w);
        public gvec2<T> zy => new gvec2<T>(z, y);
        public gvec3<T> zyx => new gvec3<T>(z, y, x);
        public gvec4<T> zyxx => new gvec4<T>(z, y, x, x);
        public gvec4<T> zyxy => new gvec4<T>(z, y, x, y);
        public gvec4<T> zyxz => new gvec4<T>(z, y, x, z);
        public gvec4<T> zyxw => new gvec4<T>(z, y, x, w);
        public gvec3<T> zyy => new gvec3<T>(z, y, y);
        public gvec4<T> zyyx => new gvec4<T>(z, y, y, x);
        public gvec4<T> zyyy => new gvec4<T>(z, y, y, y);
        public gvec4<T> zyyz => new gvec4<T>(z, y, y, z);
        public gvec4<T> zyyw => new gvec4<T>(z, y, y, w);
        public gvec3<T> zyz => new gvec3<T>(z, y, z);
        public gvec4<T> zyzx => new gvec4<T>(z, y, z, x);
        public gvec4<T> zyzy => new gvec4<T>(z, y, z, y);
        public gvec4<T> zyzz => new gvec4<T>(z, y, z, z);
        public gvec4<T> zyzw => new gvec4<T>(z, y, z, w);
        public gvec3<T> zyw => new gvec3<T>(z, y, w);
        public gvec4<T> zywx => new gvec4<T>(z, y, w, x);
        public gvec4<T> zywy => new gvec4<T>(z, y, w, y);
        public gvec4<T> zywz => new gvec4<T>(z, y, w, z);
        public gvec4<T> zyww => new gvec4<T>(z, y, w, w);
        public gvec2<T> zz => new gvec2<T>(z, z);
        public gvec3<T> zzx => new gvec3<T>(z, z, x);
        public gvec4<T> zzxx => new gvec4<T>(z, z, x, x);
        public gvec4<T> zzxy => new gvec4<T>(z, z, x, y);
        public gvec4<T> zzxz => new gvec4<T>(z, z, x, z);
        public gvec4<T> zzxw => new gvec4<T>(z, z, x, w);
        public gvec3<T> zzy => new gvec3<T>(z, z, y);
        public gvec4<T> zzyx => new gvec4<T>(z, z, y, x);
        public gvec4<T> zzyy => new gvec4<T>(z, z, y, y);
        public gvec4<T> zzyz => new gvec4<T>(z, z, y, z);
        public gvec4<T> zzyw => new gvec4<T>(z, z, y, w);
        public gvec3<T> zzz => new gvec3<T>(z, z, z);
        public gvec4<T> zzzx => new gvec4<T>(z, z, z, x);
        public gvec4<T> zzzy => new gvec4<T>(z, z, z, y);
        public gvec4<T> zzzz => new gvec4<T>(z, z, z, z);
        public gvec4<T> zzzw => new gvec4<T>(z, z, z, w);
        public gvec3<T> zzw => new gvec3<T>(z, z, w);
        public gvec4<T> zzwx => new gvec4<T>(z, z, w, x);
        public gvec4<T> zzwy => new gvec4<T>(z, z, w, y);
        public gvec4<T> zzwz => new gvec4<T>(z, z, w, z);
        public gvec4<T> zzww => new gvec4<T>(z, z, w, w);
        public gvec2<T> zw => new gvec2<T>(z, w);
        public gvec3<T> zwx => new gvec3<T>(z, w, x);
        public gvec4<T> zwxx => new gvec4<T>(z, w, x, x);
        public gvec4<T> zwxy => new gvec4<T>(z, w, x, y);
        public gvec4<T> zwxz => new gvec4<T>(z, w, x, z);
        public gvec4<T> zwxw => new gvec4<T>(z, w, x, w);
        public gvec3<T> zwy => new gvec3<T>(z, w, y);
        public gvec4<T> zwyx => new gvec4<T>(z, w, y, x);
        public gvec4<T> zwyy => new gvec4<T>(z, w, y, y);
        public gvec4<T> zwyz => new gvec4<T>(z, w, y, z);
        public gvec4<T> zwyw => new gvec4<T>(z, w, y, w);
        public gvec3<T> zwz => new gvec3<T>(z, w, z);
        public gvec4<T> zwzx => new gvec4<T>(z, w, z, x);
        public gvec4<T> zwzy => new gvec4<T>(z, w, z, y);
        public gvec4<T> zwzz => new gvec4<T>(z, w, z, z);
        public gvec4<T> zwzw => new gvec4<T>(z, w, z, w);
        public gvec3<T> zww => new gvec3<T>(z, w, w);
        public gvec4<T> zwwx => new gvec4<T>(z, w, w, x);
        public gvec4<T> zwwy => new gvec4<T>(z, w, w, y);
        public gvec4<T> zwwz => new gvec4<T>(z, w, w, z);
        public gvec4<T> zwww => new gvec4<T>(z, w, w, w);
        public gvec2<T> wx => new gvec2<T>(w, x);
        public gvec3<T> wxx => new gvec3<T>(w, x, x);
        public gvec4<T> wxxx => new gvec4<T>(w, x, x, x);
        public gvec4<T> wxxy => new gvec4<T>(w, x, x, y);
        public gvec4<T> wxxz => new gvec4<T>(w, x, x, z);
        public gvec4<T> wxxw => new gvec4<T>(w, x, x, w);
        public gvec3<T> wxy => new gvec3<T>(w, x, y);
        public gvec4<T> wxyx => new gvec4<T>(w, x, y, x);
        public gvec4<T> wxyy => new gvec4<T>(w, x, y, y);
        public gvec4<T> wxyz => new gvec4<T>(w, x, y, z);
        public gvec4<T> wxyw => new gvec4<T>(w, x, y, w);
        public gvec3<T> wxz => new gvec3<T>(w, x, z);
        public gvec4<T> wxzx => new gvec4<T>(w, x, z, x);
        public gvec4<T> wxzy => new gvec4<T>(w, x, z, y);
        public gvec4<T> wxzz => new gvec4<T>(w, x, z, z);
        public gvec4<T> wxzw => new gvec4<T>(w, x, z, w);
        public gvec3<T> wxw => new gvec3<T>(w, x, w);
        public gvec4<T> wxwx => new gvec4<T>(w, x, w, x);
        public gvec4<T> wxwy => new gvec4<T>(w, x, w, y);
        public gvec4<T> wxwz => new gvec4<T>(w, x, w, z);
        public gvec4<T> wxww => new gvec4<T>(w, x, w, w);
        public gvec2<T> wy => new gvec2<T>(w, y);
        public gvec3<T> wyx => new gvec3<T>(w, y, x);
        public gvec4<T> wyxx => new gvec4<T>(w, y, x, x);
        public gvec4<T> wyxy => new gvec4<T>(w, y, x, y);
        public gvec4<T> wyxz => new gvec4<T>(w, y, x, z);
        public gvec4<T> wyxw => new gvec4<T>(w, y, x, w);
        public gvec3<T> wyy => new gvec3<T>(w, y, y);
        public gvec4<T> wyyx => new gvec4<T>(w, y, y, x);
        public gvec4<T> wyyy => new gvec4<T>(w, y, y, y);
        public gvec4<T> wyyz => new gvec4<T>(w, y, y, z);
        public gvec4<T> wyyw => new gvec4<T>(w, y, y, w);
        public gvec3<T> wyz => new gvec3<T>(w, y, z);
        public gvec4<T> wyzx => new gvec4<T>(w, y, z, x);
        public gvec4<T> wyzy => new gvec4<T>(w, y, z, y);
        public gvec4<T> wyzz => new gvec4<T>(w, y, z, z);
        public gvec4<T> wyzw => new gvec4<T>(w, y, z, w);
        public gvec3<T> wyw => new gvec3<T>(w, y, w);
        public gvec4<T> wywx => new gvec4<T>(w, y, w, x);
        public gvec4<T> wywy => new gvec4<T>(w, y, w, y);
        public gvec4<T> wywz => new gvec4<T>(w, y, w, z);
        public gvec4<T> wyww => new gvec4<T>(w, y, w, w);
        public gvec2<T> wz => new gvec2<T>(w, z);
        public gvec3<T> wzx => new gvec3<T>(w, z, x);
        public gvec4<T> wzxx => new gvec4<T>(w, z, x, x);
        public gvec4<T> wzxy => new gvec4<T>(w, z, x, y);
        public gvec4<T> wzxz => new gvec4<T>(w, z, x, z);
        public gvec4<T> wzxw => new gvec4<T>(w, z, x, w);
        public gvec3<T> wzy => new gvec3<T>(w, z, y);
        public gvec4<T> wzyx => new gvec4<T>(w, z, y, x);
        public gvec4<T> wzyy => new gvec4<T>(w, z, y, y);
        public gvec4<T> wzyz => new gvec4<T>(w, z, y, z);
        public gvec4<T> wzyw => new gvec4<T>(w, z, y, w);
        public gvec3<T> wzz => new gvec3<T>(w, z, z);
        public gvec4<T> wzzx => new gvec4<T>(w, z, z, x);
        public gvec4<T> wzzy => new gvec4<T>(w, z, z, y);
        public gvec4<T> wzzz => new gvec4<T>(w, z, z, z);
        public gvec4<T> wzzw => new gvec4<T>(w, z, z, w);
        public gvec3<T> wzw => new gvec3<T>(w, z, w);
        public gvec4<T> wzwx => new gvec4<T>(w, z, w, x);
        public gvec4<T> wzwy => new gvec4<T>(w, z, w, y);
        public gvec4<T> wzwz => new gvec4<T>(w, z, w, z);
        public gvec4<T> wzww => new gvec4<T>(w, z, w, w);
        public gvec2<T> ww => new gvec2<T>(w, w);
        public gvec3<T> wwx => new gvec3<T>(w, w, x);
        public gvec4<T> wwxx => new gvec4<T>(w, w, x, x);
        public gvec4<T> wwxy => new gvec4<T>(w, w, x, y);
        public gvec4<T> wwxz => new gvec4<T>(w, w, x, z);
        public gvec4<T> wwxw => new gvec4<T>(w, w, x, w);
        public gvec3<T> wwy => new gvec3<T>(w, w, y);
        public gvec4<T> wwyx => new gvec4<T>(w, w, y, x);
        public gvec4<T> wwyy => new gvec4<T>(w, w, y, y);
        public gvec4<T> wwyz => new gvec4<T>(w, w, y, z);
        public gvec4<T> wwyw => new gvec4<T>(w, w, y, w);
        public gvec3<T> wwz => new gvec3<T>(w, w, z);
        public gvec4<T> wwzx => new gvec4<T>(w, w, z, x);
        public gvec4<T> wwzy => new gvec4<T>(w, w, z, y);
        public gvec4<T> wwzz => new gvec4<T>(w, w, z, z);
        public gvec4<T> wwzw => new gvec4<T>(w, w, z, w);
        public gvec3<T> www => new gvec3<T>(w, w, w);
        public gvec4<T> wwwx => new gvec4<T>(w, w, w, x);
        public gvec4<T> wwwy => new gvec4<T>(w, w, w, y);
        public gvec4<T> wwwz => new gvec4<T>(w, w, w, z);
        public gvec4<T> wwww => new gvec4<T>(w, w, w, w);
        
        // RGBA Versions
        public gvec2<T> rr => new gvec2<T>(x, x);
        public gvec3<T> rrr => new gvec3<T>(x, x, x);
        public gvec4<T> rrrr => new gvec4<T>(x, x, x, x);
        public gvec4<T> rrrg => new gvec4<T>(x, x, x, y);
        public gvec4<T> rrrb => new gvec4<T>(x, x, x, z);
        public gvec4<T> rrra => new gvec4<T>(x, x, x, w);
        public gvec3<T> rrg => new gvec3<T>(x, x, y);
        public gvec4<T> rrgr => new gvec4<T>(x, x, y, x);
        public gvec4<T> rrgg => new gvec4<T>(x, x, y, y);
        public gvec4<T> rrgb => new gvec4<T>(x, x, y, z);
        public gvec4<T> rrga => new gvec4<T>(x, x, y, w);
        public gvec3<T> rrb => new gvec3<T>(x, x, z);
        public gvec4<T> rrbr => new gvec4<T>(x, x, z, x);
        public gvec4<T> rrbg => new gvec4<T>(x, x, z, y);
        public gvec4<T> rrbb => new gvec4<T>(x, x, z, z);
        public gvec4<T> rrba => new gvec4<T>(x, x, z, w);
        public gvec3<T> rra => new gvec3<T>(x, x, w);
        public gvec4<T> rrar => new gvec4<T>(x, x, w, x);
        public gvec4<T> rrag => new gvec4<T>(x, x, w, y);
        public gvec4<T> rrab => new gvec4<T>(x, x, w, z);
        public gvec4<T> rraa => new gvec4<T>(x, x, w, w);
        public gvec2<T> rg => new gvec2<T>(x, y);
        public gvec3<T> rgr => new gvec3<T>(x, y, x);
        public gvec4<T> rgrr => new gvec4<T>(x, y, x, x);
        public gvec4<T> rgrg => new gvec4<T>(x, y, x, y);
        public gvec4<T> rgrb => new gvec4<T>(x, y, x, z);
        public gvec4<T> rgra => new gvec4<T>(x, y, x, w);
        public gvec3<T> rgg => new gvec3<T>(x, y, y);
        public gvec4<T> rggr => new gvec4<T>(x, y, y, x);
        public gvec4<T> rggg => new gvec4<T>(x, y, y, y);
        public gvec4<T> rggb => new gvec4<T>(x, y, y, z);
        public gvec4<T> rgga => new gvec4<T>(x, y, y, w);
        public gvec3<T> rgb => new gvec3<T>(x, y, z);
        public gvec4<T> rgbr => new gvec4<T>(x, y, z, x);
        public gvec4<T> rgbg => new gvec4<T>(x, y, z, y);
        public gvec4<T> rgbb => new gvec4<T>(x, y, z, z);
        public gvec4<T> rgba => new gvec4<T>(x, y, z, w);
        public gvec3<T> rga => new gvec3<T>(x, y, w);
        public gvec4<T> rgar => new gvec4<T>(x, y, w, x);
        public gvec4<T> rgag => new gvec4<T>(x, y, w, y);
        public gvec4<T> rgab => new gvec4<T>(x, y, w, z);
        public gvec4<T> rgaa => new gvec4<T>(x, y, w, w);
        public gvec2<T> rb => new gvec2<T>(x, z);
        public gvec3<T> rbr => new gvec3<T>(x, z, x);
        public gvec4<T> rbrr => new gvec4<T>(x, z, x, x);
        public gvec4<T> rbrg => new gvec4<T>(x, z, x, y);
        public gvec4<T> rbrb => new gvec4<T>(x, z, x, z);
        public gvec4<T> rbra => new gvec4<T>(x, z, x, w);
        public gvec3<T> rbg => new gvec3<T>(x, z, y);
        public gvec4<T> rbgr => new gvec4<T>(x, z, y, x);
        public gvec4<T> rbgg => new gvec4<T>(x, z, y, y);
        public gvec4<T> rbgb => new gvec4<T>(x, z, y, z);
        public gvec4<T> rbga => new gvec4<T>(x, z, y, w);
        public gvec3<T> rbb => new gvec3<T>(x, z, z);
        public gvec4<T> rbbr => new gvec4<T>(x, z, z, x);
        public gvec4<T> rbbg => new gvec4<T>(x, z, z, y);
        public gvec4<T> rbbb => new gvec4<T>(x, z, z, z);
        public gvec4<T> rbba => new gvec4<T>(x, z, z, w);
        public gvec3<T> rba => new gvec3<T>(x, z, w);
        public gvec4<T> rbar => new gvec4<T>(x, z, w, x);
        public gvec4<T> rbag => new gvec4<T>(x, z, w, y);
        public gvec4<T> rbab => new gvec4<T>(x, z, w, z);
        public gvec4<T> rbaa => new gvec4<T>(x, z, w, w);
        public gvec2<T> ra => new gvec2<T>(x, w);
        public gvec3<T> rar => new gvec3<T>(x, w, x);
        public gvec4<T> rarr => new gvec4<T>(x, w, x, x);
        public gvec4<T> rarg => new gvec4<T>(x, w, x, y);
        public gvec4<T> rarb => new gvec4<T>(x, w, x, z);
        public gvec4<T> rara => new gvec4<T>(x, w, x, w);
        public gvec3<T> rag => new gvec3<T>(x, w, y);
        public gvec4<T> ragr => new gvec4<T>(x, w, y, x);
        public gvec4<T> ragg => new gvec4<T>(x, w, y, y);
        public gvec4<T> ragb => new gvec4<T>(x, w, y, z);
        public gvec4<T> raga => new gvec4<T>(x, w, y, w);
        public gvec3<T> rab => new gvec3<T>(x, w, z);
        public gvec4<T> rabr => new gvec4<T>(x, w, z, x);
        public gvec4<T> rabg => new gvec4<T>(x, w, z, y);
        public gvec4<T> rabb => new gvec4<T>(x, w, z, z);
        public gvec4<T> raba => new gvec4<T>(x, w, z, w);
        public gvec3<T> raa => new gvec3<T>(x, w, w);
        public gvec4<T> raar => new gvec4<T>(x, w, w, x);
        public gvec4<T> raag => new gvec4<T>(x, w, w, y);
        public gvec4<T> raab => new gvec4<T>(x, w, w, z);
        public gvec4<T> raaa => new gvec4<T>(x, w, w, w);
        public gvec2<T> gr => new gvec2<T>(y, x);
        public gvec3<T> grr => new gvec3<T>(y, x, x);
        public gvec4<T> grrr => new gvec4<T>(y, x, x, x);
        public gvec4<T> grrg => new gvec4<T>(y, x, x, y);
        public gvec4<T> grrb => new gvec4<T>(y, x, x, z);
        public gvec4<T> grra => new gvec4<T>(y, x, x, w);
        public gvec3<T> grg => new gvec3<T>(y, x, y);
        public gvec4<T> grgr => new gvec4<T>(y, x, y, x);
        public gvec4<T> grgg => new gvec4<T>(y, x, y, y);
        public gvec4<T> grgb => new gvec4<T>(y, x, y, z);
        public gvec4<T> grga => new gvec4<T>(y, x, y, w);
        public gvec3<T> grb => new gvec3<T>(y, x, z);
        public gvec4<T> grbr => new gvec4<T>(y, x, z, x);
        public gvec4<T> grbg => new gvec4<T>(y, x, z, y);
        public gvec4<T> grbb => new gvec4<T>(y, x, z, z);
        public gvec4<T> grba => new gvec4<T>(y, x, z, w);
        public gvec3<T> gra => new gvec3<T>(y, x, w);
        public gvec4<T> grar => new gvec4<T>(y, x, w, x);
        public gvec4<T> grag => new gvec4<T>(y, x, w, y);
        public gvec4<T> grab => new gvec4<T>(y, x, w, z);
        public gvec4<T> graa => new gvec4<T>(y, x, w, w);
        public gvec2<T> gg => new gvec2<T>(y, y);
        public gvec3<T> ggr => new gvec3<T>(y, y, x);
        public gvec4<T> ggrr => new gvec4<T>(y, y, x, x);
        public gvec4<T> ggrg => new gvec4<T>(y, y, x, y);
        public gvec4<T> ggrb => new gvec4<T>(y, y, x, z);
        public gvec4<T> ggra => new gvec4<T>(y, y, x, w);
        public gvec3<T> ggg => new gvec3<T>(y, y, y);
        public gvec4<T> gggr => new gvec4<T>(y, y, y, x);
        public gvec4<T> gggg => new gvec4<T>(y, y, y, y);
        public gvec4<T> gggb => new gvec4<T>(y, y, y, z);
        public gvec4<T> ggga => new gvec4<T>(y, y, y, w);
        public gvec3<T> ggb => new gvec3<T>(y, y, z);
        public gvec4<T> ggbr => new gvec4<T>(y, y, z, x);
        public gvec4<T> ggbg => new gvec4<T>(y, y, z, y);
        public gvec4<T> ggbb => new gvec4<T>(y, y, z, z);
        public gvec4<T> ggba => new gvec4<T>(y, y, z, w);
        public gvec3<T> gga => new gvec3<T>(y, y, w);
        public gvec4<T> ggar => new gvec4<T>(y, y, w, x);
        public gvec4<T> ggag => new gvec4<T>(y, y, w, y);
        public gvec4<T> ggab => new gvec4<T>(y, y, w, z);
        public gvec4<T> ggaa => new gvec4<T>(y, y, w, w);
        public gvec2<T> gb => new gvec2<T>(y, z);
        public gvec3<T> gbr => new gvec3<T>(y, z, x);
        public gvec4<T> gbrr => new gvec4<T>(y, z, x, x);
        public gvec4<T> gbrg => new gvec4<T>(y, z, x, y);
        public gvec4<T> gbrb => new gvec4<T>(y, z, x, z);
        public gvec4<T> gbra => new gvec4<T>(y, z, x, w);
        public gvec3<T> gbg => new gvec3<T>(y, z, y);
        public gvec4<T> gbgr => new gvec4<T>(y, z, y, x);
        public gvec4<T> gbgg => new gvec4<T>(y, z, y, y);
        public gvec4<T> gbgb => new gvec4<T>(y, z, y, z);
        public gvec4<T> gbga => new gvec4<T>(y, z, y, w);
        public gvec3<T> gbb => new gvec3<T>(y, z, z);
        public gvec4<T> gbbr => new gvec4<T>(y, z, z, x);
        public gvec4<T> gbbg => new gvec4<T>(y, z, z, y);
        public gvec4<T> gbbb => new gvec4<T>(y, z, z, z);
        public gvec4<T> gbba => new gvec4<T>(y, z, z, w);
        public gvec3<T> gba => new gvec3<T>(y, z, w);
        public gvec4<T> gbar => new gvec4<T>(y, z, w, x);
        public gvec4<T> gbag => new gvec4<T>(y, z, w, y);
        public gvec4<T> gbab => new gvec4<T>(y, z, w, z);
        public gvec4<T> gbaa => new gvec4<T>(y, z, w, w);
        public gvec2<T> ga => new gvec2<T>(y, w);
        public gvec3<T> gar => new gvec3<T>(y, w, x);
        public gvec4<T> garr => new gvec4<T>(y, w, x, x);
        public gvec4<T> garg => new gvec4<T>(y, w, x, y);
        public gvec4<T> garb => new gvec4<T>(y, w, x, z);
        public gvec4<T> gara => new gvec4<T>(y, w, x, w);
        public gvec3<T> gag => new gvec3<T>(y, w, y);
        public gvec4<T> gagr => new gvec4<T>(y, w, y, x);
        public gvec4<T> gagg => new gvec4<T>(y, w, y, y);
        public gvec4<T> gagb => new gvec4<T>(y, w, y, z);
        public gvec4<T> gaga => new gvec4<T>(y, w, y, w);
        public gvec3<T> gab => new gvec3<T>(y, w, z);
        public gvec4<T> gabr => new gvec4<T>(y, w, z, x);
        public gvec4<T> gabg => new gvec4<T>(y, w, z, y);
        public gvec4<T> gabb => new gvec4<T>(y, w, z, z);
        public gvec4<T> gaba => new gvec4<T>(y, w, z, w);
        public gvec3<T> gaa => new gvec3<T>(y, w, w);
        public gvec4<T> gaar => new gvec4<T>(y, w, w, x);
        public gvec4<T> gaag => new gvec4<T>(y, w, w, y);
        public gvec4<T> gaab => new gvec4<T>(y, w, w, z);
        public gvec4<T> gaaa => new gvec4<T>(y, w, w, w);
        public gvec2<T> br => new gvec2<T>(z, x);
        public gvec3<T> brr => new gvec3<T>(z, x, x);
        public gvec4<T> brrr => new gvec4<T>(z, x, x, x);
        public gvec4<T> brrg => new gvec4<T>(z, x, x, y);
        public gvec4<T> brrb => new gvec4<T>(z, x, x, z);
        public gvec4<T> brra => new gvec4<T>(z, x, x, w);
        public gvec3<T> brg => new gvec3<T>(z, x, y);
        public gvec4<T> brgr => new gvec4<T>(z, x, y, x);
        public gvec4<T> brgg => new gvec4<T>(z, x, y, y);
        public gvec4<T> brgb => new gvec4<T>(z, x, y, z);
        public gvec4<T> brga => new gvec4<T>(z, x, y, w);
        public gvec3<T> brb => new gvec3<T>(z, x, z);
        public gvec4<T> brbr => new gvec4<T>(z, x, z, x);
        public gvec4<T> brbg => new gvec4<T>(z, x, z, y);
        public gvec4<T> brbb => new gvec4<T>(z, x, z, z);
        public gvec4<T> brba => new gvec4<T>(z, x, z, w);
        public gvec3<T> bra => new gvec3<T>(z, x, w);
        public gvec4<T> brar => new gvec4<T>(z, x, w, x);
        public gvec4<T> brag => new gvec4<T>(z, x, w, y);
        public gvec4<T> brab => new gvec4<T>(z, x, w, z);
        public gvec4<T> braa => new gvec4<T>(z, x, w, w);
        public gvec2<T> bg => new gvec2<T>(z, y);
        public gvec3<T> bgr => new gvec3<T>(z, y, x);
        public gvec4<T> bgrr => new gvec4<T>(z, y, x, x);
        public gvec4<T> bgrg => new gvec4<T>(z, y, x, y);
        public gvec4<T> bgrb => new gvec4<T>(z, y, x, z);
        public gvec4<T> bgra => new gvec4<T>(z, y, x, w);
        public gvec3<T> bgg => new gvec3<T>(z, y, y);
        public gvec4<T> bggr => new gvec4<T>(z, y, y, x);
        public gvec4<T> bggg => new gvec4<T>(z, y, y, y);
        public gvec4<T> bggb => new gvec4<T>(z, y, y, z);
        public gvec4<T> bgga => new gvec4<T>(z, y, y, w);
        public gvec3<T> bgb => new gvec3<T>(z, y, z);
        public gvec4<T> bgbr => new gvec4<T>(z, y, z, x);
        public gvec4<T> bgbg => new gvec4<T>(z, y, z, y);
        public gvec4<T> bgbb => new gvec4<T>(z, y, z, z);
        public gvec4<T> bgba => new gvec4<T>(z, y, z, w);
        public gvec3<T> bga => new gvec3<T>(z, y, w);
        public gvec4<T> bgar => new gvec4<T>(z, y, w, x);
        public gvec4<T> bgag => new gvec4<T>(z, y, w, y);
        public gvec4<T> bgab => new gvec4<T>(z, y, w, z);
        public gvec4<T> bgaa => new gvec4<T>(z, y, w, w);
        public gvec2<T> bb => new gvec2<T>(z, z);
        public gvec3<T> bbr => new gvec3<T>(z, z, x);
        public gvec4<T> bbrr => new gvec4<T>(z, z, x, x);
        public gvec4<T> bbrg => new gvec4<T>(z, z, x, y);
        public gvec4<T> bbrb => new gvec4<T>(z, z, x, z);
        public gvec4<T> bbra => new gvec4<T>(z, z, x, w);
        public gvec3<T> bbg => new gvec3<T>(z, z, y);
        public gvec4<T> bbgr => new gvec4<T>(z, z, y, x);
        public gvec4<T> bbgg => new gvec4<T>(z, z, y, y);
        public gvec4<T> bbgb => new gvec4<T>(z, z, y, z);
        public gvec4<T> bbga => new gvec4<T>(z, z, y, w);
        public gvec3<T> bbb => new gvec3<T>(z, z, z);
        public gvec4<T> bbbr => new gvec4<T>(z, z, z, x);
        public gvec4<T> bbbg => new gvec4<T>(z, z, z, y);
        public gvec4<T> bbbb => new gvec4<T>(z, z, z, z);
        public gvec4<T> bbba => new gvec4<T>(z, z, z, w);
        public gvec3<T> bba => new gvec3<T>(z, z, w);
        public gvec4<T> bbar => new gvec4<T>(z, z, w, x);
        public gvec4<T> bbag => new gvec4<T>(z, z, w, y);
        public gvec4<T> bbab => new gvec4<T>(z, z, w, z);
        public gvec4<T> bbaa => new gvec4<T>(z, z, w, w);
        public gvec2<T> ba => new gvec2<T>(z, w);
        public gvec3<T> bar => new gvec3<T>(z, w, x);
        public gvec4<T> barr => new gvec4<T>(z, w, x, x);
        public gvec4<T> barg => new gvec4<T>(z, w, x, y);
        public gvec4<T> barb => new gvec4<T>(z, w, x, z);
        public gvec4<T> bara => new gvec4<T>(z, w, x, w);
        public gvec3<T> bag => new gvec3<T>(z, w, y);
        public gvec4<T> bagr => new gvec4<T>(z, w, y, x);
        public gvec4<T> bagg => new gvec4<T>(z, w, y, y);
        public gvec4<T> bagb => new gvec4<T>(z, w, y, z);
        public gvec4<T> baga => new gvec4<T>(z, w, y, w);
        public gvec3<T> bab => new gvec3<T>(z, w, z);
        public gvec4<T> babr => new gvec4<T>(z, w, z, x);
        public gvec4<T> babg => new gvec4<T>(z, w, z, y);
        public gvec4<T> babb => new gvec4<T>(z, w, z, z);
        public gvec4<T> baba => new gvec4<T>(z, w, z, w);
        public gvec3<T> baa => new gvec3<T>(z, w, w);
        public gvec4<T> baar => new gvec4<T>(z, w, w, x);
        public gvec4<T> baag => new gvec4<T>(z, w, w, y);
        public gvec4<T> baab => new gvec4<T>(z, w, w, z);
        public gvec4<T> baaa => new gvec4<T>(z, w, w, w);
        public gvec2<T> ar => new gvec2<T>(w, x);
        public gvec3<T> arr => new gvec3<T>(w, x, x);
        public gvec4<T> arrr => new gvec4<T>(w, x, x, x);
        public gvec4<T> arrg => new gvec4<T>(w, x, x, y);
        public gvec4<T> arrb => new gvec4<T>(w, x, x, z);
        public gvec4<T> arra => new gvec4<T>(w, x, x, w);
        public gvec3<T> arg => new gvec3<T>(w, x, y);
        public gvec4<T> argr => new gvec4<T>(w, x, y, x);
        public gvec4<T> argg => new gvec4<T>(w, x, y, y);
        public gvec4<T> argb => new gvec4<T>(w, x, y, z);
        public gvec4<T> arga => new gvec4<T>(w, x, y, w);
        public gvec3<T> arb => new gvec3<T>(w, x, z);
        public gvec4<T> arbr => new gvec4<T>(w, x, z, x);
        public gvec4<T> arbg => new gvec4<T>(w, x, z, y);
        public gvec4<T> arbb => new gvec4<T>(w, x, z, z);
        public gvec4<T> arba => new gvec4<T>(w, x, z, w);
        public gvec3<T> ara => new gvec3<T>(w, x, w);
        public gvec4<T> arar => new gvec4<T>(w, x, w, x);
        public gvec4<T> arag => new gvec4<T>(w, x, w, y);
        public gvec4<T> arab => new gvec4<T>(w, x, w, z);
        public gvec4<T> araa => new gvec4<T>(w, x, w, w);
        public gvec2<T> ag => new gvec2<T>(w, y);
        public gvec3<T> agr => new gvec3<T>(w, y, x);
        public gvec4<T> agrr => new gvec4<T>(w, y, x, x);
        public gvec4<T> agrg => new gvec4<T>(w, y, x, y);
        public gvec4<T> agrb => new gvec4<T>(w, y, x, z);
        public gvec4<T> agra => new gvec4<T>(w, y, x, w);
        public gvec3<T> agg => new gvec3<T>(w, y, y);
        public gvec4<T> aggr => new gvec4<T>(w, y, y, x);
        public gvec4<T> aggg => new gvec4<T>(w, y, y, y);
        public gvec4<T> aggb => new gvec4<T>(w, y, y, z);
        public gvec4<T> agga => new gvec4<T>(w, y, y, w);
        public gvec3<T> agb => new gvec3<T>(w, y, z);
        public gvec4<T> agbr => new gvec4<T>(w, y, z, x);
        public gvec4<T> agbg => new gvec4<T>(w, y, z, y);
        public gvec4<T> agbb => new gvec4<T>(w, y, z, z);
        public gvec4<T> agba => new gvec4<T>(w, y, z, w);
        public gvec3<T> aga => new gvec3<T>(w, y, w);
        public gvec4<T> agar => new gvec4<T>(w, y, w, x);
        public gvec4<T> agag => new gvec4<T>(w, y, w, y);
        public gvec4<T> agab => new gvec4<T>(w, y, w, z);
        public gvec4<T> agaa => new gvec4<T>(w, y, w, w);
        public gvec2<T> ab => new gvec2<T>(w, z);
        public gvec3<T> abr => new gvec3<T>(w, z, x);
        public gvec4<T> abrr => new gvec4<T>(w, z, x, x);
        public gvec4<T> abrg => new gvec4<T>(w, z, x, y);
        public gvec4<T> abrb => new gvec4<T>(w, z, x, z);
        public gvec4<T> abra => new gvec4<T>(w, z, x, w);
        public gvec3<T> abg => new gvec3<T>(w, z, y);
        public gvec4<T> abgr => new gvec4<T>(w, z, y, x);
        public gvec4<T> abgg => new gvec4<T>(w, z, y, y);
        public gvec4<T> abgb => new gvec4<T>(w, z, y, z);
        public gvec4<T> abga => new gvec4<T>(w, z, y, w);
        public gvec3<T> abb => new gvec3<T>(w, z, z);
        public gvec4<T> abbr => new gvec4<T>(w, z, z, x);
        public gvec4<T> abbg => new gvec4<T>(w, z, z, y);
        public gvec4<T> abbb => new gvec4<T>(w, z, z, z);
        public gvec4<T> abba => new gvec4<T>(w, z, z, w);
        public gvec3<T> aba => new gvec3<T>(w, z, w);
        public gvec4<T> abar => new gvec4<T>(w, z, w, x);
        public gvec4<T> abag => new gvec4<T>(w, z, w, y);
        public gvec4<T> abab => new gvec4<T>(w, z, w, z);
        public gvec4<T> abaa => new gvec4<T>(w, z, w, w);
        public gvec2<T> aa => new gvec2<T>(w, w);
        public gvec3<T> aar => new gvec3<T>(w, w, x);
        public gvec4<T> aarr => new gvec4<T>(w, w, x, x);
        public gvec4<T> aarg => new gvec4<T>(w, w, x, y);
        public gvec4<T> aarb => new gvec4<T>(w, w, x, z);
        public gvec4<T> aara => new gvec4<T>(w, w, x, w);
        public gvec3<T> aag => new gvec3<T>(w, w, y);
        public gvec4<T> aagr => new gvec4<T>(w, w, y, x);
        public gvec4<T> aagg => new gvec4<T>(w, w, y, y);
        public gvec4<T> aagb => new gvec4<T>(w, w, y, z);
        public gvec4<T> aaga => new gvec4<T>(w, w, y, w);
        public gvec3<T> aab => new gvec3<T>(w, w, z);
        public gvec4<T> aabr => new gvec4<T>(w, w, z, x);
        public gvec4<T> aabg => new gvec4<T>(w, w, z, y);
        public gvec4<T> aabb => new gvec4<T>(w, w, z, z);
        public gvec4<T> aaba => new gvec4<T>(w, w, z, w);
        public gvec3<T> aaa => new gvec3<T>(w, w, w);
        public gvec4<T> aaar => new gvec4<T>(w, w, w, x);
        public gvec4<T> aaag => new gvec4<T>(w, w, w, y);
        public gvec4<T> aaab => new gvec4<T>(w, w, w, z);
        public gvec4<T> aaaa => new gvec4<T>(w, w, w, w);
    }
}
