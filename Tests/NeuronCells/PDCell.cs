﻿using System;
using Zene.NeuralNetworking;
using Zene.Structs;

namespace NeuralNetworkingTest
{
    public struct PDCell : INeuronCell
    {
        public int GetOrder => 0;
        public int SetOrder => throw new NotSupportedException();

        public double GetValue(Lifeform lifeform)
        {
            return (double)(lifeform.CurrentWorld.Height - lifeform.Location.Y) / lifeform.CurrentWorld.Height;
        }

        public void SetValue(Lifeform lifeform, double value) => throw new NotSupportedException();
        public void Activate(Lifeform lifeform) => throw new NotSupportedException();
    }
}