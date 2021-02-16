﻿using System;

namespace DesignPatterns.Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(headingNode:this);
        }
    }
}