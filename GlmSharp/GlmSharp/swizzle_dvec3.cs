using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_dvec3
    {
        public readonly double x;
        public readonly double y;
        public readonly double z;
        
        public swizzle_dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        public dvec2 xx => new dvec2(x, x);
        public dvec3 xxx => new dvec3(x, x, x);
        public dvec4 xxxx => new dvec4(x, x, x, x);
        public dvec4 xxxy => new dvec4(x, x, x, y);
        public dvec4 xxxz => new dvec4(x, x, x, z);
        public dvec3 xxy => new dvec3(x, x, y);
        public dvec4 xxyx => new dvec4(x, x, y, x);
        public dvec4 xxyy => new dvec4(x, x, y, y);
        public dvec4 xxyz => new dvec4(x, x, y, z);
        public dvec3 xxz => new dvec3(x, x, z);
        public dvec4 xxzx => new dvec4(x, x, z, x);
        public dvec4 xxzy => new dvec4(x, x, z, y);
        public dvec4 xxzz => new dvec4(x, x, z, z);
        public dvec2 xy => new dvec2(x, y);
        public dvec3 xyx => new dvec3(x, y, x);
        public dvec4 xyxx => new dvec4(x, y, x, x);
        public dvec4 xyxy => new dvec4(x, y, x, y);
        public dvec4 xyxz => new dvec4(x, y, x, z);
        public dvec3 xyy => new dvec3(x, y, y);
        public dvec4 xyyx => new dvec4(x, y, y, x);
        public dvec4 xyyy => new dvec4(x, y, y, y);
        public dvec4 xyyz => new dvec4(x, y, y, z);
        public dvec3 xyz => new dvec3(x, y, z);
        public dvec4 xyzx => new dvec4(x, y, z, x);
        public dvec4 xyzy => new dvec4(x, y, z, y);
        public dvec4 xyzz => new dvec4(x, y, z, z);
        public dvec2 xz => new dvec2(x, z);
        public dvec3 xzx => new dvec3(x, z, x);
        public dvec4 xzxx => new dvec4(x, z, x, x);
        public dvec4 xzxy => new dvec4(x, z, x, y);
        public dvec4 xzxz => new dvec4(x, z, x, z);
        public dvec3 xzy => new dvec3(x, z, y);
        public dvec4 xzyx => new dvec4(x, z, y, x);
        public dvec4 xzyy => new dvec4(x, z, y, y);
        public dvec4 xzyz => new dvec4(x, z, y, z);
        public dvec3 xzz => new dvec3(x, z, z);
        public dvec4 xzzx => new dvec4(x, z, z, x);
        public dvec4 xzzy => new dvec4(x, z, z, y);
        public dvec4 xzzz => new dvec4(x, z, z, z);
        public dvec2 yx => new dvec2(y, x);
        public dvec3 yxx => new dvec3(y, x, x);
        public dvec4 yxxx => new dvec4(y, x, x, x);
        public dvec4 yxxy => new dvec4(y, x, x, y);
        public dvec4 yxxz => new dvec4(y, x, x, z);
        public dvec3 yxy => new dvec3(y, x, y);
        public dvec4 yxyx => new dvec4(y, x, y, x);
        public dvec4 yxyy => new dvec4(y, x, y, y);
        public dvec4 yxyz => new dvec4(y, x, y, z);
        public dvec3 yxz => new dvec3(y, x, z);
        public dvec4 yxzx => new dvec4(y, x, z, x);
        public dvec4 yxzy => new dvec4(y, x, z, y);
        public dvec4 yxzz => new dvec4(y, x, z, z);
        public dvec2 yy => new dvec2(y, y);
        public dvec3 yyx => new dvec3(y, y, x);
        public dvec4 yyxx => new dvec4(y, y, x, x);
        public dvec4 yyxy => new dvec4(y, y, x, y);
        public dvec4 yyxz => new dvec4(y, y, x, z);
        public dvec3 yyy => new dvec3(y, y, y);
        public dvec4 yyyx => new dvec4(y, y, y, x);
        public dvec4 yyyy => new dvec4(y, y, y, y);
        public dvec4 yyyz => new dvec4(y, y, y, z);
        public dvec3 yyz => new dvec3(y, y, z);
        public dvec4 yyzx => new dvec4(y, y, z, x);
        public dvec4 yyzy => new dvec4(y, y, z, y);
        public dvec4 yyzz => new dvec4(y, y, z, z);
        public dvec2 yz => new dvec2(y, z);
        public dvec3 yzx => new dvec3(y, z, x);
        public dvec4 yzxx => new dvec4(y, z, x, x);
        public dvec4 yzxy => new dvec4(y, z, x, y);
        public dvec4 yzxz => new dvec4(y, z, x, z);
        public dvec3 yzy => new dvec3(y, z, y);
        public dvec4 yzyx => new dvec4(y, z, y, x);
        public dvec4 yzyy => new dvec4(y, z, y, y);
        public dvec4 yzyz => new dvec4(y, z, y, z);
        public dvec3 yzz => new dvec3(y, z, z);
        public dvec4 yzzx => new dvec4(y, z, z, x);
        public dvec4 yzzy => new dvec4(y, z, z, y);
        public dvec4 yzzz => new dvec4(y, z, z, z);
        public dvec2 zx => new dvec2(z, x);
        public dvec3 zxx => new dvec3(z, x, x);
        public dvec4 zxxx => new dvec4(z, x, x, x);
        public dvec4 zxxy => new dvec4(z, x, x, y);
        public dvec4 zxxz => new dvec4(z, x, x, z);
        public dvec3 zxy => new dvec3(z, x, y);
        public dvec4 zxyx => new dvec4(z, x, y, x);
        public dvec4 zxyy => new dvec4(z, x, y, y);
        public dvec4 zxyz => new dvec4(z, x, y, z);
        public dvec3 zxz => new dvec3(z, x, z);
        public dvec4 zxzx => new dvec4(z, x, z, x);
        public dvec4 zxzy => new dvec4(z, x, z, y);
        public dvec4 zxzz => new dvec4(z, x, z, z);
        public dvec2 zy => new dvec2(z, y);
        public dvec3 zyx => new dvec3(z, y, x);
        public dvec4 zyxx => new dvec4(z, y, x, x);
        public dvec4 zyxy => new dvec4(z, y, x, y);
        public dvec4 zyxz => new dvec4(z, y, x, z);
        public dvec3 zyy => new dvec3(z, y, y);
        public dvec4 zyyx => new dvec4(z, y, y, x);
        public dvec4 zyyy => new dvec4(z, y, y, y);
        public dvec4 zyyz => new dvec4(z, y, y, z);
        public dvec3 zyz => new dvec3(z, y, z);
        public dvec4 zyzx => new dvec4(z, y, z, x);
        public dvec4 zyzy => new dvec4(z, y, z, y);
        public dvec4 zyzz => new dvec4(z, y, z, z);
        public dvec2 zz => new dvec2(z, z);
        public dvec3 zzx => new dvec3(z, z, x);
        public dvec4 zzxx => new dvec4(z, z, x, x);
        public dvec4 zzxy => new dvec4(z, z, x, y);
        public dvec4 zzxz => new dvec4(z, z, x, z);
        public dvec3 zzy => new dvec3(z, z, y);
        public dvec4 zzyx => new dvec4(z, z, y, x);
        public dvec4 zzyy => new dvec4(z, z, y, y);
        public dvec4 zzyz => new dvec4(z, z, y, z);
        public dvec3 zzz => new dvec3(z, z, z);
        public dvec4 zzzx => new dvec4(z, z, z, x);
        public dvec4 zzzy => new dvec4(z, z, z, y);
        public dvec4 zzzz => new dvec4(z, z, z, z);
        
        // RGBA Versions
        public dvec2 rr => new dvec2(x, x);
        public dvec3 rrr => new dvec3(x, x, x);
        public dvec4 rrrr => new dvec4(x, x, x, x);
        public dvec4 rrrg => new dvec4(x, x, x, y);
        public dvec4 rrrb => new dvec4(x, x, x, z);
        public dvec3 rrg => new dvec3(x, x, y);
        public dvec4 rrgr => new dvec4(x, x, y, x);
        public dvec4 rrgg => new dvec4(x, x, y, y);
        public dvec4 rrgb => new dvec4(x, x, y, z);
        public dvec3 rrb => new dvec3(x, x, z);
        public dvec4 rrbr => new dvec4(x, x, z, x);
        public dvec4 rrbg => new dvec4(x, x, z, y);
        public dvec4 rrbb => new dvec4(x, x, z, z);
        public dvec2 rg => new dvec2(x, y);
        public dvec3 rgr => new dvec3(x, y, x);
        public dvec4 rgrr => new dvec4(x, y, x, x);
        public dvec4 rgrg => new dvec4(x, y, x, y);
        public dvec4 rgrb => new dvec4(x, y, x, z);
        public dvec3 rgg => new dvec3(x, y, y);
        public dvec4 rggr => new dvec4(x, y, y, x);
        public dvec4 rggg => new dvec4(x, y, y, y);
        public dvec4 rggb => new dvec4(x, y, y, z);
        public dvec3 rgb => new dvec3(x, y, z);
        public dvec4 rgbr => new dvec4(x, y, z, x);
        public dvec4 rgbg => new dvec4(x, y, z, y);
        public dvec4 rgbb => new dvec4(x, y, z, z);
        public dvec2 rb => new dvec2(x, z);
        public dvec3 rbr => new dvec3(x, z, x);
        public dvec4 rbrr => new dvec4(x, z, x, x);
        public dvec4 rbrg => new dvec4(x, z, x, y);
        public dvec4 rbrb => new dvec4(x, z, x, z);
        public dvec3 rbg => new dvec3(x, z, y);
        public dvec4 rbgr => new dvec4(x, z, y, x);
        public dvec4 rbgg => new dvec4(x, z, y, y);
        public dvec4 rbgb => new dvec4(x, z, y, z);
        public dvec3 rbb => new dvec3(x, z, z);
        public dvec4 rbbr => new dvec4(x, z, z, x);
        public dvec4 rbbg => new dvec4(x, z, z, y);
        public dvec4 rbbb => new dvec4(x, z, z, z);
        public dvec2 gr => new dvec2(y, x);
        public dvec3 grr => new dvec3(y, x, x);
        public dvec4 grrr => new dvec4(y, x, x, x);
        public dvec4 grrg => new dvec4(y, x, x, y);
        public dvec4 grrb => new dvec4(y, x, x, z);
        public dvec3 grg => new dvec3(y, x, y);
        public dvec4 grgr => new dvec4(y, x, y, x);
        public dvec4 grgg => new dvec4(y, x, y, y);
        public dvec4 grgb => new dvec4(y, x, y, z);
        public dvec3 grb => new dvec3(y, x, z);
        public dvec4 grbr => new dvec4(y, x, z, x);
        public dvec4 grbg => new dvec4(y, x, z, y);
        public dvec4 grbb => new dvec4(y, x, z, z);
        public dvec2 gg => new dvec2(y, y);
        public dvec3 ggr => new dvec3(y, y, x);
        public dvec4 ggrr => new dvec4(y, y, x, x);
        public dvec4 ggrg => new dvec4(y, y, x, y);
        public dvec4 ggrb => new dvec4(y, y, x, z);
        public dvec3 ggg => new dvec3(y, y, y);
        public dvec4 gggr => new dvec4(y, y, y, x);
        public dvec4 gggg => new dvec4(y, y, y, y);
        public dvec4 gggb => new dvec4(y, y, y, z);
        public dvec3 ggb => new dvec3(y, y, z);
        public dvec4 ggbr => new dvec4(y, y, z, x);
        public dvec4 ggbg => new dvec4(y, y, z, y);
        public dvec4 ggbb => new dvec4(y, y, z, z);
        public dvec2 gb => new dvec2(y, z);
        public dvec3 gbr => new dvec3(y, z, x);
        public dvec4 gbrr => new dvec4(y, z, x, x);
        public dvec4 gbrg => new dvec4(y, z, x, y);
        public dvec4 gbrb => new dvec4(y, z, x, z);
        public dvec3 gbg => new dvec3(y, z, y);
        public dvec4 gbgr => new dvec4(y, z, y, x);
        public dvec4 gbgg => new dvec4(y, z, y, y);
        public dvec4 gbgb => new dvec4(y, z, y, z);
        public dvec3 gbb => new dvec3(y, z, z);
        public dvec4 gbbr => new dvec4(y, z, z, x);
        public dvec4 gbbg => new dvec4(y, z, z, y);
        public dvec4 gbbb => new dvec4(y, z, z, z);
        public dvec2 br => new dvec2(z, x);
        public dvec3 brr => new dvec3(z, x, x);
        public dvec4 brrr => new dvec4(z, x, x, x);
        public dvec4 brrg => new dvec4(z, x, x, y);
        public dvec4 brrb => new dvec4(z, x, x, z);
        public dvec3 brg => new dvec3(z, x, y);
        public dvec4 brgr => new dvec4(z, x, y, x);
        public dvec4 brgg => new dvec4(z, x, y, y);
        public dvec4 brgb => new dvec4(z, x, y, z);
        public dvec3 brb => new dvec3(z, x, z);
        public dvec4 brbr => new dvec4(z, x, z, x);
        public dvec4 brbg => new dvec4(z, x, z, y);
        public dvec4 brbb => new dvec4(z, x, z, z);
        public dvec2 bg => new dvec2(z, y);
        public dvec3 bgr => new dvec3(z, y, x);
        public dvec4 bgrr => new dvec4(z, y, x, x);
        public dvec4 bgrg => new dvec4(z, y, x, y);
        public dvec4 bgrb => new dvec4(z, y, x, z);
        public dvec3 bgg => new dvec3(z, y, y);
        public dvec4 bggr => new dvec4(z, y, y, x);
        public dvec4 bggg => new dvec4(z, y, y, y);
        public dvec4 bggb => new dvec4(z, y, y, z);
        public dvec3 bgb => new dvec3(z, y, z);
        public dvec4 bgbr => new dvec4(z, y, z, x);
        public dvec4 bgbg => new dvec4(z, y, z, y);
        public dvec4 bgbb => new dvec4(z, y, z, z);
        public dvec2 bb => new dvec2(z, z);
        public dvec3 bbr => new dvec3(z, z, x);
        public dvec4 bbrr => new dvec4(z, z, x, x);
        public dvec4 bbrg => new dvec4(z, z, x, y);
        public dvec4 bbrb => new dvec4(z, z, x, z);
        public dvec3 bbg => new dvec3(z, z, y);
        public dvec4 bbgr => new dvec4(z, z, y, x);
        public dvec4 bbgg => new dvec4(z, z, y, y);
        public dvec4 bbgb => new dvec4(z, z, y, z);
        public dvec3 bbb => new dvec3(z, z, z);
        public dvec4 bbbr => new dvec4(z, z, z, x);
        public dvec4 bbbg => new dvec4(z, z, z, y);
        public dvec4 bbbb => new dvec4(z, z, z, z);
    }
}
