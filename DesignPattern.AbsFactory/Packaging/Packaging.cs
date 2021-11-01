using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbsFactory.Packaging
{
    public abstract class Package {
        public abstract string GetDetails();
    }
    public class NormalPackaging : Package
    {
        public override string GetDetails()
        {
            return "This is normal package";
        }
    }
    public class StandardPackaging : Package
    {
        public override string GetDetails()
        {
            return "This is standard package.";
        }
    }
}
