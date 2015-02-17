﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public static class Constants
    {
        public static readonly int Rows = 12;
        public static readonly int Columns = 8;
        public static readonly float AnimationDuration = 0.3f;

        public static readonly float MoveAnimationMinDuration = 0.05f;

        public static readonly float ExplosionDuration = 0.3f;

        public static readonly float WaitBeforePotentialMatchesCheck = 2f;
        public static readonly float OpacityAnimationFrameDelay = 0.05f;

        public static readonly int MinimumMatches = 3;
        public static readonly int MinimumMatchesForBooster = 4;
    }

    public enum GameState
    {
        None,
        SelectionStarted,
        Animating
    }

