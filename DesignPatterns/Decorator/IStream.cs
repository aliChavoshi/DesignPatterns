﻿using System.Data.SqlTypes;

namespace DesignPatterns.Decorator
{
    public interface IStream
    {
        void Write(string data);
    }
}