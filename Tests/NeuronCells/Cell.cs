﻿using System;
using Zene.NeuralNetworking;
using Zene.Structs;

namespace NeuralNetworkingTest
{
    public struct Cell : INeuronCell
    {
        public int GetOrder => throw new NotSupportedException();
        public int SetOrder => throw new NotSupportedException();

        public double GetValue(Lifeform lifeform)
        {
            throw new NotSupportedException();
        }

        public void SetValue(Lifeform lifeform, double value)
        {
            throw new NotSupportedException();
        }

        public void Activate(Lifeform lifeform)
        {
            throw new NotSupportedException();
        }
    }
}