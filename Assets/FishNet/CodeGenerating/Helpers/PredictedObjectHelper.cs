using System;
using System.Reflection;

using FishNet.Component.Prediction;

using MonoFN.Cecil;

namespace FishNet.CodeGenerating.Helping
{
    internal class PredictedObjectHelper : CodegenBase
    {
        public override bool ImportReferences()
        {
            return true;
        }
    }
}
