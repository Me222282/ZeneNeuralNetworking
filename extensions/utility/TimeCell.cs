﻿using System;
using Zene.NeuralNetworking;

namespace utility
{
    public struct TimeCell : INeuronCell
    {
        public string Name => "TIM";

        public int GetOrder => 0;
        public int SetOrder => throw new NotSupportedException();

        public double GetValue(Lifeform lifeform) => (double)lifeform.CurrentWorld.CurrentIteration / (lifeform.CurrentWorld.GenerationLength - 1);

        public void SetValue(Lifeform lifeform, double value) => throw new NotSupportedException();
        public void Activate(Lifeform lifeform) => throw new NotSupportedException();

        public static void Add()
        {
            NeuralNetwork.PosibleGetCells.Add(new TimeCell());
        }
    }
}