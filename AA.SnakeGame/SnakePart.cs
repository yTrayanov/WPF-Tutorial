﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace AA.SnakeGame
{
    public class SnakePart
    {
        public UIElement UiElement { get; set; }
        public Point Position { get; set; }
        public bool IsHead { get; set; }
    }
}
