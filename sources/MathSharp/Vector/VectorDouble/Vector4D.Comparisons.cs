﻿using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using MathSharp.Attributes;
using static MathSharp.SoftwareFallbacks;

namespace MathSharp
{
    using Vector4D = Vector256<double>;
    using Vector4DParam1_3 = Vector256<double>;

    public static partial class Vector
    {
#warning TODO check Unordered/Ordered
        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4D Equality(in Vector4DParam1_3 left, in Vector4DParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.Compare(left, right, FloatComparisonMode.OrderedEqualNonSignaling);
            }

            return Equality_Software(left, right);
        }
        
        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4D Inequality(in Vector4DParam1_3 left, in Vector4DParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.Compare(left, right, FloatComparisonMode.OrderedNotEqualNonSignaling);
            }

            return Inequality_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4D GreaterThan(in Vector4DParam1_3 left, in Vector4DParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanNonSignaling);
            }

            return GreaterThan_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4D LessThan(in Vector4DParam1_3 left, in Vector4DParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanNonSignaling);
            }

            return LessThan_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4D GreaterThanOrEqual(in Vector4DParam1_3 left, in Vector4DParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.Compare(left, right, FloatComparisonMode.OrderedGreaterThanOrEqualNonSignaling);
            }

            return GreaterThanOrEqual_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4D LessThanOrEqual(in Vector4DParam1_3 left, in Vector4DParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.Compare(left, right, FloatComparisonMode.OrderedLessThanOrEqualNonSignaling);
            }

            return LessThanOrEqual_Software(left, right);
        }
    }
}