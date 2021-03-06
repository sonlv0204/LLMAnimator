﻿#region License
//   Copyright 2015 Brook Shi
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLM
{
    public enum AnimationType
    {
        Bounce,
        Flash,
        Pulse,
        RubberBand,
        Shake,
        StandUp,
        Swing,
        Tada,
        Wave,
        Wobble,

        BounceIn,
        BounceInDown,
        BounceInUp,
        BounceInLeft,
        BounceInRight,

        FadeIn,
        FadeInDown,
        FadeInUp,
        FadeInLeft,
        FadeInRight,

        FadeOut,
        FadeOutDown,
        FadeOutUp,
        FadeOutLeft,
        FadeOutRight,

        FlipInX,
        FlipInY,

        FlipOutX,
        FlipOutY,

        RotateIn,
        RotateInDownLeft,
        RotateInDownRight,
        RotateInUpLeft,
        RotateInUpRight,

        RotateOut,
        RotateOutDownLeft,
        RotateOutDownRight,
        RotateOutUpLeft,
        RotateOutUpRight,

        SlideInDown,
        SlideInUp,
        SlideInLeft,
        SlideInRight,

        SlideOutDown,
        SlideOutUp,
        SlideOutLeft,
        SlideOutRight,

        ZoomIn,
        ZoomInDown,
        ZoomInUp,
        ZoomInLeft,
        ZoomInRight,

        ZoomOut,
        ZoomOutDown,
        ZoomOutUp,
        ZoomOutLeft,
        ZoomOutRight,

        Hinge,
        RollIn,
        RollOut,
        DropOut,
        Landing,
        TakingOff,
    }
}
