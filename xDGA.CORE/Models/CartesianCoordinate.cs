﻿// The MIT License (MIT)
//
// Copyright (c) 2017-2018 Carlos Gamez
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;

namespace xDGA.CORE.Models
{
    public class CartesianCoordinate
    {
        public double X { get; set; } = 0.0;
        public double Y { get; set; } = 0.0;

        public CartesianCoordinate(double x, double y) { X = x; Y = y; }

        public Vector ToVector()
        {
            var magnitude = Math.Sqrt(Math.Pow(X,2.0) + Math.Pow(Y,2.0));
            var angle = Math.Atan(Y / X);
            return new Vector(magnitude, angle);
        }
    }
}
