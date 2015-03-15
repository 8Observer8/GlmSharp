using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_gvec3<T>
    {
        public readonly T x;
        public readonly T y;
        public readonly T z;
        
        public swizzle_gvec3(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        public gvec2<T> xx => new gvec2<T>(x, x);
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        public gvec4<T> xxxx => new gvec4<T>(x, x, x, x);
        public gvec4<T> xxxy => new gvec4<T>(x, x, x, y);
        public gvec4<T> xxxz => new gvec4<T>(x, x, x, z);
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        public gvec4<T> xxyx => new gvec4<T>(x, x, y, x);
        public gvec4<T> xxyy => new gvec4<T>(x, x, y, y);
        public gvec4<T> xxyz => new gvec4<T>(x, x, y, z);
        public gvec3<T> xxz => new gvec3<T>(x, x, z);
        public gvec4<T> xxzx => new gvec4<T>(x, x, z, x);
        public gvec4<T> xxzy => new gvec4<T>(x, x, z, y);
        public gvec4<T> xxzz => new gvec4<T>(x, x, z, z);
        public gvec2<T> xy => new gvec2<T>(x, y);
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        public gvec4<T> xyxx => new gvec4<T>(x, y, x, x);
        public gvec4<T> xyxy => new gvec4<T>(x, y, x, y);
        public gvec4<T> xyxz => new gvec4<T>(x, y, x, z);
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        public gvec4<T> xyyx => new gvec4<T>(x, y, y, x);
        public gvec4<T> xyyy => new gvec4<T>(x, y, y, y);
        public gvec4<T> xyyz => new gvec4<T>(x, y, y, z);
        public gvec3<T> xyz => new gvec3<T>(x, y, z);
        public gvec4<T> xyzx => new gvec4<T>(x, y, z, x);
        public gvec4<T> xyzy => new gvec4<T>(x, y, z, y);
        public gvec4<T> xyzz => new gvec4<T>(x, y, z, z);
        public gvec2<T> xz => new gvec2<T>(x, z);
        public gvec3<T> xzx => new gvec3<T>(x, z, x);
        public gvec4<T> xzxx => new gvec4<T>(x, z, x, x);
        public gvec4<T> xzxy => new gvec4<T>(x, z, x, y);
        public gvec4<T> xzxz => new gvec4<T>(x, z, x, z);
        public gvec3<T> xzy => new gvec3<T>(x, z, y);
        public gvec4<T> xzyx => new gvec4<T>(x, z, y, x);
        public gvec4<T> xzyy => new gvec4<T>(x, z, y, y);
        public gvec4<T> xzyz => new gvec4<T>(x, z, y, z);
        public gvec3<T> xzz => new gvec3<T>(x, z, z);
        public gvec4<T> xzzx => new gvec4<T>(x, z, z, x);
        public gvec4<T> xzzy => new gvec4<T>(x, z, z, y);
        public gvec4<T> xzzz => new gvec4<T>(x, z, z, z);
        public gvec2<T> yx => new gvec2<T>(y, x);
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        public gvec4<T> yxxx => new gvec4<T>(y, x, x, x);
        public gvec4<T> yxxy => new gvec4<T>(y, x, x, y);
        public gvec4<T> yxxz => new gvec4<T>(y, x, x, z);
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        public gvec4<T> yxyx => new gvec4<T>(y, x, y, x);
        public gvec4<T> yxyy => new gvec4<T>(y, x, y, y);
        public gvec4<T> yxyz => new gvec4<T>(y, x, y, z);
        public gvec3<T> yxz => new gvec3<T>(y, x, z);
        public gvec4<T> yxzx => new gvec4<T>(y, x, z, x);
        public gvec4<T> yxzy => new gvec4<T>(y, x, z, y);
        public gvec4<T> yxzz => new gvec4<T>(y, x, z, z);
        public gvec2<T> yy => new gvec2<T>(y, y);
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        public gvec4<T> yyxx => new gvec4<T>(y, y, x, x);
        public gvec4<T> yyxy => new gvec4<T>(y, y, x, y);
        public gvec4<T> yyxz => new gvec4<T>(y, y, x, z);
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        public gvec4<T> yyyx => new gvec4<T>(y, y, y, x);
        public gvec4<T> yyyy => new gvec4<T>(y, y, y, y);
        public gvec4<T> yyyz => new gvec4<T>(y, y, y, z);
        public gvec3<T> yyz => new gvec3<T>(y, y, z);
        public gvec4<T> yyzx => new gvec4<T>(y, y, z, x);
        public gvec4<T> yyzy => new gvec4<T>(y, y, z, y);
        public gvec4<T> yyzz => new gvec4<T>(y, y, z, z);
        public gvec2<T> yz => new gvec2<T>(y, z);
        public gvec3<T> yzx => new gvec3<T>(y, z, x);
        public gvec4<T> yzxx => new gvec4<T>(y, z, x, x);
        public gvec4<T> yzxy => new gvec4<T>(y, z, x, y);
        public gvec4<T> yzxz => new gvec4<T>(y, z, x, z);
        public gvec3<T> yzy => new gvec3<T>(y, z, y);
        public gvec4<T> yzyx => new gvec4<T>(y, z, y, x);
        public gvec4<T> yzyy => new gvec4<T>(y, z, y, y);
        public gvec4<T> yzyz => new gvec4<T>(y, z, y, z);
        public gvec3<T> yzz => new gvec3<T>(y, z, z);
        public gvec4<T> yzzx => new gvec4<T>(y, z, z, x);
        public gvec4<T> yzzy => new gvec4<T>(y, z, z, y);
        public gvec4<T> yzzz => new gvec4<T>(y, z, z, z);
        public gvec2<T> zx => new gvec2<T>(z, x);
        public gvec3<T> zxx => new gvec3<T>(z, x, x);
        public gvec4<T> zxxx => new gvec4<T>(z, x, x, x);
        public gvec4<T> zxxy => new gvec4<T>(z, x, x, y);
        public gvec4<T> zxxz => new gvec4<T>(z, x, x, z);
        public gvec3<T> zxy => new gvec3<T>(z, x, y);
        public gvec4<T> zxyx => new gvec4<T>(z, x, y, x);
        public gvec4<T> zxyy => new gvec4<T>(z, x, y, y);
        public gvec4<T> zxyz => new gvec4<T>(z, x, y, z);
        public gvec3<T> zxz => new gvec3<T>(z, x, z);
        public gvec4<T> zxzx => new gvec4<T>(z, x, z, x);
        public gvec4<T> zxzy => new gvec4<T>(z, x, z, y);
        public gvec4<T> zxzz => new gvec4<T>(z, x, z, z);
        public gvec2<T> zy => new gvec2<T>(z, y);
        public gvec3<T> zyx => new gvec3<T>(z, y, x);
        public gvec4<T> zyxx => new gvec4<T>(z, y, x, x);
        public gvec4<T> zyxy => new gvec4<T>(z, y, x, y);
        public gvec4<T> zyxz => new gvec4<T>(z, y, x, z);
        public gvec3<T> zyy => new gvec3<T>(z, y, y);
        public gvec4<T> zyyx => new gvec4<T>(z, y, y, x);
        public gvec4<T> zyyy => new gvec4<T>(z, y, y, y);
        public gvec4<T> zyyz => new gvec4<T>(z, y, y, z);
        public gvec3<T> zyz => new gvec3<T>(z, y, z);
        public gvec4<T> zyzx => new gvec4<T>(z, y, z, x);
        public gvec4<T> zyzy => new gvec4<T>(z, y, z, y);
        public gvec4<T> zyzz => new gvec4<T>(z, y, z, z);
        public gvec2<T> zz => new gvec2<T>(z, z);
        public gvec3<T> zzx => new gvec3<T>(z, z, x);
        public gvec4<T> zzxx => new gvec4<T>(z, z, x, x);
        public gvec4<T> zzxy => new gvec4<T>(z, z, x, y);
        public gvec4<T> zzxz => new gvec4<T>(z, z, x, z);
        public gvec3<T> zzy => new gvec3<T>(z, z, y);
        public gvec4<T> zzyx => new gvec4<T>(z, z, y, x);
        public gvec4<T> zzyy => new gvec4<T>(z, z, y, y);
        public gvec4<T> zzyz => new gvec4<T>(z, z, y, z);
        public gvec3<T> zzz => new gvec3<T>(z, z, z);
        public gvec4<T> zzzx => new gvec4<T>(z, z, z, x);
        public gvec4<T> zzzy => new gvec4<T>(z, z, z, y);
        public gvec4<T> zzzz => new gvec4<T>(z, z, z, z);
        
        // RGBA Versions
        public gvec2<T> rr => new gvec2<T>(x, x);
        public gvec3<T> rrr => new gvec3<T>(x, x, x);
        public gvec4<T> rrrr => new gvec4<T>(x, x, x, x);
        public gvec4<T> rrrg => new gvec4<T>(x, x, x, y);
        public gvec4<T> rrrb => new gvec4<T>(x, x, x, z);
        public gvec3<T> rrg => new gvec3<T>(x, x, y);
        public gvec4<T> rrgr => new gvec4<T>(x, x, y, x);
        public gvec4<T> rrgg => new gvec4<T>(x, x, y, y);
        public gvec4<T> rrgb => new gvec4<T>(x, x, y, z);
        public gvec3<T> rrb => new gvec3<T>(x, x, z);
        public gvec4<T> rrbr => new gvec4<T>(x, x, z, x);
        public gvec4<T> rrbg => new gvec4<T>(x, x, z, y);
        public gvec4<T> rrbb => new gvec4<T>(x, x, z, z);
        public gvec2<T> rg => new gvec2<T>(x, y);
        public gvec3<T> rgr => new gvec3<T>(x, y, x);
        public gvec4<T> rgrr => new gvec4<T>(x, y, x, x);
        public gvec4<T> rgrg => new gvec4<T>(x, y, x, y);
        public gvec4<T> rgrb => new gvec4<T>(x, y, x, z);
        public gvec3<T> rgg => new gvec3<T>(x, y, y);
        public gvec4<T> rggr => new gvec4<T>(x, y, y, x);
        public gvec4<T> rggg => new gvec4<T>(x, y, y, y);
        public gvec4<T> rggb => new gvec4<T>(x, y, y, z);
        public gvec3<T> rgb => new gvec3<T>(x, y, z);
        public gvec4<T> rgbr => new gvec4<T>(x, y, z, x);
        public gvec4<T> rgbg => new gvec4<T>(x, y, z, y);
        public gvec4<T> rgbb => new gvec4<T>(x, y, z, z);
        public gvec2<T> rb => new gvec2<T>(x, z);
        public gvec3<T> rbr => new gvec3<T>(x, z, x);
        public gvec4<T> rbrr => new gvec4<T>(x, z, x, x);
        public gvec4<T> rbrg => new gvec4<T>(x, z, x, y);
        public gvec4<T> rbrb => new gvec4<T>(x, z, x, z);
        public gvec3<T> rbg => new gvec3<T>(x, z, y);
        public gvec4<T> rbgr => new gvec4<T>(x, z, y, x);
        public gvec4<T> rbgg => new gvec4<T>(x, z, y, y);
        public gvec4<T> rbgb => new gvec4<T>(x, z, y, z);
        public gvec3<T> rbb => new gvec3<T>(x, z, z);
        public gvec4<T> rbbr => new gvec4<T>(x, z, z, x);
        public gvec4<T> rbbg => new gvec4<T>(x, z, z, y);
        public gvec4<T> rbbb => new gvec4<T>(x, z, z, z);
        public gvec2<T> gr => new gvec2<T>(y, x);
        public gvec3<T> grr => new gvec3<T>(y, x, x);
        public gvec4<T> grrr => new gvec4<T>(y, x, x, x);
        public gvec4<T> grrg => new gvec4<T>(y, x, x, y);
        public gvec4<T> grrb => new gvec4<T>(y, x, x, z);
        public gvec3<T> grg => new gvec3<T>(y, x, y);
        public gvec4<T> grgr => new gvec4<T>(y, x, y, x);
        public gvec4<T> grgg => new gvec4<T>(y, x, y, y);
        public gvec4<T> grgb => new gvec4<T>(y, x, y, z);
        public gvec3<T> grb => new gvec3<T>(y, x, z);
        public gvec4<T> grbr => new gvec4<T>(y, x, z, x);
        public gvec4<T> grbg => new gvec4<T>(y, x, z, y);
        public gvec4<T> grbb => new gvec4<T>(y, x, z, z);
        public gvec2<T> gg => new gvec2<T>(y, y);
        public gvec3<T> ggr => new gvec3<T>(y, y, x);
        public gvec4<T> ggrr => new gvec4<T>(y, y, x, x);
        public gvec4<T> ggrg => new gvec4<T>(y, y, x, y);
        public gvec4<T> ggrb => new gvec4<T>(y, y, x, z);
        public gvec3<T> ggg => new gvec3<T>(y, y, y);
        public gvec4<T> gggr => new gvec4<T>(y, y, y, x);
        public gvec4<T> gggg => new gvec4<T>(y, y, y, y);
        public gvec4<T> gggb => new gvec4<T>(y, y, y, z);
        public gvec3<T> ggb => new gvec3<T>(y, y, z);
        public gvec4<T> ggbr => new gvec4<T>(y, y, z, x);
        public gvec4<T> ggbg => new gvec4<T>(y, y, z, y);
        public gvec4<T> ggbb => new gvec4<T>(y, y, z, z);
        public gvec2<T> gb => new gvec2<T>(y, z);
        public gvec3<T> gbr => new gvec3<T>(y, z, x);
        public gvec4<T> gbrr => new gvec4<T>(y, z, x, x);
        public gvec4<T> gbrg => new gvec4<T>(y, z, x, y);
        public gvec4<T> gbrb => new gvec4<T>(y, z, x, z);
        public gvec3<T> gbg => new gvec3<T>(y, z, y);
        public gvec4<T> gbgr => new gvec4<T>(y, z, y, x);
        public gvec4<T> gbgg => new gvec4<T>(y, z, y, y);
        public gvec4<T> gbgb => new gvec4<T>(y, z, y, z);
        public gvec3<T> gbb => new gvec3<T>(y, z, z);
        public gvec4<T> gbbr => new gvec4<T>(y, z, z, x);
        public gvec4<T> gbbg => new gvec4<T>(y, z, z, y);
        public gvec4<T> gbbb => new gvec4<T>(y, z, z, z);
        public gvec2<T> br => new gvec2<T>(z, x);
        public gvec3<T> brr => new gvec3<T>(z, x, x);
        public gvec4<T> brrr => new gvec4<T>(z, x, x, x);
        public gvec4<T> brrg => new gvec4<T>(z, x, x, y);
        public gvec4<T> brrb => new gvec4<T>(z, x, x, z);
        public gvec3<T> brg => new gvec3<T>(z, x, y);
        public gvec4<T> brgr => new gvec4<T>(z, x, y, x);
        public gvec4<T> brgg => new gvec4<T>(z, x, y, y);
        public gvec4<T> brgb => new gvec4<T>(z, x, y, z);
        public gvec3<T> brb => new gvec3<T>(z, x, z);
        public gvec4<T> brbr => new gvec4<T>(z, x, z, x);
        public gvec4<T> brbg => new gvec4<T>(z, x, z, y);
        public gvec4<T> brbb => new gvec4<T>(z, x, z, z);
        public gvec2<T> bg => new gvec2<T>(z, y);
        public gvec3<T> bgr => new gvec3<T>(z, y, x);
        public gvec4<T> bgrr => new gvec4<T>(z, y, x, x);
        public gvec4<T> bgrg => new gvec4<T>(z, y, x, y);
        public gvec4<T> bgrb => new gvec4<T>(z, y, x, z);
        public gvec3<T> bgg => new gvec3<T>(z, y, y);
        public gvec4<T> bggr => new gvec4<T>(z, y, y, x);
        public gvec4<T> bggg => new gvec4<T>(z, y, y, y);
        public gvec4<T> bggb => new gvec4<T>(z, y, y, z);
        public gvec3<T> bgb => new gvec3<T>(z, y, z);
        public gvec4<T> bgbr => new gvec4<T>(z, y, z, x);
        public gvec4<T> bgbg => new gvec4<T>(z, y, z, y);
        public gvec4<T> bgbb => new gvec4<T>(z, y, z, z);
        public gvec2<T> bb => new gvec2<T>(z, z);
        public gvec3<T> bbr => new gvec3<T>(z, z, x);
        public gvec4<T> bbrr => new gvec4<T>(z, z, x, x);
        public gvec4<T> bbrg => new gvec4<T>(z, z, x, y);
        public gvec4<T> bbrb => new gvec4<T>(z, z, x, z);
        public gvec3<T> bbg => new gvec3<T>(z, z, y);
        public gvec4<T> bbgr => new gvec4<T>(z, z, y, x);
        public gvec4<T> bbgg => new gvec4<T>(z, z, y, y);
        public gvec4<T> bbgb => new gvec4<T>(z, z, y, z);
        public gvec3<T> bbb => new gvec3<T>(z, z, z);
        public gvec4<T> bbbr => new gvec4<T>(z, z, z, x);
        public gvec4<T> bbbg => new gvec4<T>(z, z, z, y);
        public gvec4<T> bbbb => new gvec4<T>(z, z, z, z);
    }
}
