//--------------------------------------------------------------------------
// 
//  Copyright (c) Microsoft Corporation.  All rights reserved. 
// 
//  File: Ray.cs
//
//--------------------------------------------------------------------------

namespace Samples
{
    struct Ray
    {
        public Vector Start;
        public Vector Dir;

        public Ray(Vector start, Vector dir) { Start = start; Dir = dir; }
    }
}
